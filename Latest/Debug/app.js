const sails = require('sails');
const NeoLog = require('./structs/NeoLog');
const { default: axios } = require('axios');
const fs = require("fs").promises;
const path = require("path");
const https = require('https');

async function compareAndUpdateKeychain() {
  try {
    const response = await axios.get('https://fortnitecentral.genxgames.gg/api/v1/aes');
    if (response.status === 200) {
      const data = response.data;
      const keychain = JSON.parse(await fs.readFile('./responses/keychain.json', 'utf8'));
      let count = 0;
      const newEntries = [];

      for (const entry of data.dynamicKeys) {
        if (!keychain.includes(entry.keychain)) {
          count++;
          newEntries.push(entry.keychain);
        }
      }

      keychain.push(...newEntries);
      await fs.writeFile('./responses/keychain.json', JSON.stringify(keychain, null, 2));
      NeoLog.Debug(`Fetched ${count} New Keychains From Fortnite Central`);
    } else if (response.status === 503 || response.status === 403) {
      NeoLog.Error("Fortnite Central is down, falling back to Nitestats for the keychain");
      const fallbackResponse = await axios.get('https://api.nitestats.com/v1/epic/keychain');
      const data = fallbackResponse.data;
      const localData = JSON.parse(await fs.readFile('./responses/keychain.json', 'utf8'));
      let count = 0;

      for (const entry of data) {
        if (!localData.includes(entry)) {
          count++;
          localData.push(entry);
        }
      }

      await fs.writeFile('./responses/keychain.json', JSON.stringify(localData, null, 2));
      NeoLog.Debug(`Fetched ${count} New Keychains From Nitestats`);
    }
  } catch (error) {
    NeoLog.Error(`Error updating keychain: ${error.message}`);
  }
}

function fetchContent(url) {
  return new Promise((resolve, reject) => {
    https.get(url, (response) => {
      let rawData = '';
      response.on('data', (chunk) => (rawData += chunk));
      response.on('end', () => resolve(rawData));
    }).on('error', (error) => reject(error));
  });
}

async function updateBackend() {
	const baseGitHubRawUrl = 'https://raw.githubusercontent.com/HybridFNBR/Neonite/main';
  
	const filesDirs = [
    { source: 'discovery', destination: 'discovery' },
	  { source: 'api/controllers', destination: 'api/controllers' },
	  { source: 'config', destination: 'config' },
	  { source: 'hotfixes', destination: 'hotfixes' },
	];
	await Promise.all(filesDirs.map(async (task) => {
	  const sourcePath = path.join(__dirname, task.source);
	  const destinationPath = path.join(__dirname, task.destination);
  
	  try {
		const files = await fs.readdir(sourcePath);
  
		await Promise.all(files.map(async (file) => {
		  const rawUrl = `${baseGitHubRawUrl}/${task.source}/${file}`;
		  const rawContent = await fetchContent(rawUrl);
		  await fs.writeFile(path.join(destinationPath, file), rawContent);
		}));
  
		NeoLog.Debug(`Updated files in ${task.destination}`);
	  } catch (error) {
		NeoLog.Debug(`Error updating files in ${task.destination}: ${error.message}`);
	  }
	}));
}
async function startBackend() {
  sails.lift({
    port: 5595,
    environment: "production",
    hooks: {
      session: false,
    },
    log: {
      level: 'silent',
    },
  }, (err) => {
    if (err) {
      console.log(err);
    }
  });
}

async function runFunctions() {
    await updateBackend();
    await compareAndUpdateKeychain();
    await startBackend();
}
runFunctions();
