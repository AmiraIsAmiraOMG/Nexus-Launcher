using Newtonsoft.Json; // Ensure Newtonsoft.Json is referenced
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

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
                string carbonLauncherPath = Path.Combine(currentDirectory, "Project Carbon", "CarbonLauncher.exe");

                if (File.Exists(carbonLauncherPath))
                {
                    Process.Start(carbonLauncherPath);
                }
                else
                {
                    MessageBox.Show("CarbonLauncher.exe not found in the 'Project Carbon' folder.");
                }

                string neoniteBatPath = Path.Combine(currentDirectory, "Project Carbon", "NeoniteV2", "Start Neonite.bat");

                if (File.Exists(neoniteBatPath))
                {
                    Process.Start("explorer.exe", $"/select, \"{neoniteBatPath}\"");
                    MessageBox.Show("Please start the selected file in the opened folder.");
                    System.Threading.Thread.Sleep(5000);
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LaunchPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
