using Newtonsoft.Json; // Ensure Newtonsoft.Json is referenced
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;
using System.Linq;

namespace Nexus_Launcher.Screens
{
    public partial class LaunchPage : UserControl
    {
        public LaunchPage()
        {
            InitializeComponent();
            AppendToLabels();
            SetAuthenticationLabel();
        }

        // Button click handler for launching the application
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string currentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string downloadsFolder = Path.Combine(currentDirectory, "downloads");

                // Ensure the 'downloads' folder exists
                if (!Directory.Exists(downloadsFolder))
                {
                    Directory.CreateDirectory(downloadsFolder);
                }

                // Define the path for the downloaded .rar file
                string rarFileUrl = "https://cdn.discordapp.com/attachments/1320481505226657855/1320481540236382352/Carbon.rar?ex=6769c1c4&is=67687044&hm=6faf3e5186ea51f1cc99a0367eb2a99ed37b0259648adfa612dcac683273d155&";
                string rarFilePath = Path.Combine(downloadsFolder, "Carbon_v1.7_Beta_4.rar");

                // Download the .rar file
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(rarFileUrl, rarFilePath);
                }

                // Extract the .rar file to the 'Project Carbon' directory
                if (File.Exists(rarFilePath))
                {
                    string extractPath = Path.Combine(currentDirectory, "Project Carbon");

                    // Ensure the 'Project Carbon' directory exists
                    if (!Directory.Exists(extractPath))
                    {
                        Directory.CreateDirectory(extractPath);
                    }

                    // Extract the contents of the .rar file
                    ExtractRarFile(rarFilePath, extractPath);

                    // Delete the .rar file after extraction
                    File.Delete(rarFilePath);

                    // Check if CarbonLauncher.exe now exists and start it
                    string carbonLauncherPath = Path.Combine(extractPath, "CarbonLauncher.exe");
                    if (File.Exists(carbonLauncherPath))
                    {
                        Process.Start(carbonLauncherPath);
                    }
                    else
                    {
                        MessageBox.Show("CarbonLauncher.exe not found after extraction.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to download the .rar file.");
                }

                // Process for the 'Start Neonite.bat' file
                string neoniteBatPath = Path.Combine(currentDirectory, "Project Carbon", "NeoniteV2", "Start Neonite.bat");

                if (File.Exists(neoniteBatPath))
                {
                    Process.Start("explorer.exe", $"/select, \"{neoniteBatPath}\"");
                    MessageBox.Show("Please start the selected file in the opened folder.");
                    System.Threading.Thread.Sleep(5000); // Sleep to give user time to process
                }
                else
                {
                    MessageBox.Show("Start Neonite.bat not found in the 'Project Carbon\\NeoniteV2' folder.");
                }

                this.FindForm().WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Method to extract the .rar file
        private void ExtractRarFile(string rarFilePath, string extractPath)
        {
            try
            {
                // Define the path to 7z.exe (make sure 7-Zip is installed on the system)
                string sevenZipPath = @"C:\Program Files\7-Zip\7z.exe";

                // Ensure 7-Zip is installed
                if (!File.Exists(sevenZipPath))
                {
                    MessageBox.Show("7-Zip is not installed. Please install it to proceed.");
                    return;
                }

                // Prepare the arguments for extracting the RAR file
                string arguments = $"x \"{rarFilePath}\" -o\"{extractPath}\" -y";

                // Start the extraction process using 7-Zip
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = sevenZipPath,
                    Arguments = arguments,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };

                Process process = Process.Start(startInfo);
                process.WaitForExit();

                // Check if the extraction was successful
                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Extraction successful using 7-Zip.");
                }
                else
                {
                    MessageBox.Show("Extraction failed with exit code " + process.ExitCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error using 7-Zip for extraction: {ex.Message}");
            }
        }

        // Method to append configuration details to labels
        private void AppendToLabels()
        {
            try
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";

                string GameVersion = Properties.Settings.Default.GameVersion;
                label3.Text = GameVersion;

                string currentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string configPath = Path.Combine(currentDirectory, "Project Carbon", "Carbon.config");

                if (File.Exists(configPath))
                {
                    string jsonContent = File.ReadAllText(configPath);
                    var config = JsonConvert.DeserializeObject<Config>(jsonContent);

                    if (config != null && !string.IsNullOrWhiteSpace(config.name))
                    {
                        label1.Text = config.name;
                    }
                    else
                    {
                        MessageBox.Show("Invalid configuration format. 'name' field is missing.");
                    }

                    if (config != null && !string.IsNullOrWhiteSpace(config.path))
                    {
                        label2.Text = config.path;
                    }
                    else
                    {
                        MessageBox.Show("Invalid configuration format. 'path' field is missing.");
                    }
                }
                else
                {
                    MessageBox.Show("Carbon.config not found in the 'Project Carbon' folder.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the configuration: {ex.Message}");
            }
        }

        // Method to set label5 based on UseDCnameChecked setting
        private void SetAuthenticationLabel()
        {
            bool isUsingDiscordAuth = Properties.Settings.Default.UseDCnameChecked;

            if (isUsingDiscordAuth)
            {
                label5.Text = "USING DISCORD AUTHENTICATION";
            }
            else
            {
                label5.Text = "NOT USING DISCORD AUTHENTICATION";
            }
        }

        // Class to deserialize JSON config
        public class Config
        {
            public string name { get; set; }
            public string path { get; set; }
        }

        // Other event handlers (empty unless needed)
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void LaunchPage_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }
}