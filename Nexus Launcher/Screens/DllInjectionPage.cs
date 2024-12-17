using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Nexus_Launcher.Screens
{
    public partial class DllInjectionPage : UserControl
    {
        public DllInjectionPage()
        {
            InitializeComponent();
            HelpLabel.Visible = false; // Hide the label
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DllInjectionPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Open the GitHub link in the default browser
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/max8447/Eon-Launcher",
                    UseShellExecute = true // Required for URLs
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the link: " + ex.Message);
            }
        }

        private void Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check the current visibility and toggle it
            if (HelpLabel.Visible)
            {
                HelpLabel.Visible = false; // Hide the label
            }
            else
            {
                HelpLabel.Visible = true; // Show the label
            }
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Path to the config.json file
            string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Injector", "config.json");

            // Get the DLL URL from textBox1
            string DLLDownload = textBox1.Text;

            try
            {
                // Read the existing JSON content from the file
                string jsonContent = File.ReadAllText(configFilePath);

                // Deserialize the JSON to a C# object
                var config = JsonConvert.DeserializeObject<Config>(jsonContent);

                // If the config is null, initialize it
                if (config == null)
                {
                    config = new Config
                    {
                        Download = new Download()
                    };
                }

                // Update the DLLUrl value in the config object
                if (config.Download != null)
                {
                    config.Download.DLLUrl = DLLDownload; // Set the DLL URL from textBox1
                }

                // Serialize the object back to JSON
                string updatedJsonContent = JsonConvert.SerializeObject(config, Formatting.Indented);

                // Write the updated JSON content back to the file
                File.WriteAllText(configFilePath, updatedJsonContent);

                MessageBox.Show("config.json updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating config.json: " + ex.Message);
            }

            // Start the Injector EXE (this line remains unchanged)
            Process.Start("Injector\\Project Nexus GUI DLL INJECTOR.exe");
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string DLLDownload = textBox1.Text;
        }

        // Define a C# class to map the JSON structure
        public class Config
        {
            public Download Download { get; set; }
        }

        public class Download
        {
            public string DLLUrl { get; set; }
        }
    }
}
