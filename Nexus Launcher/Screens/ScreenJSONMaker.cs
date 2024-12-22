using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Nexus_Launcher.Screens
{
    public partial class ScreenJSONMaker : UserControl
    {
        public ScreenJSONMaker()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // Create an object to hold the data
            var configData = new
            {
                Name = NameBox.Text,
                Author = AuthourBox.Text,
                Version = VersionBox.Text,
                ReleaseType = ReleasetypeBox.SelectedItem?.ToString(),
                Link1 = Link1Box.Text,
                Link2 = Link2Box.Text,
                About = AboutBox.Text
            };

            // Convert the object to JSON
            string json = JsonConvert.SerializeObject(configData, Formatting.Indented);

            // Save the JSON to a file
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            try
            {
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Configuration saved to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            // Define the file path
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            try
            {
                if (File.Exists(filePath))
                {
                    // Read the JSON from the file
                    string json = File.ReadAllText(filePath);

                    // Define a strongly-typed class for deserialization
                    var configData = JsonConvert.DeserializeObject<ConfigData>(json);

                    if (configData != null)
                    {
                        // Populate the fields with the data
                        NameBox.Text = configData.Name;
                        AuthourBox.Text = configData.Author;
                        VersionBox.Text = configData.Version;
                        ReleasetypeBox.SelectedItem = configData.ReleaseType;
                        Link1Box.Text = configData.Link1;
                        Link2Box.Text = configData.Link2;
                        AboutBox.Text = configData.About;

                        MessageBox.Show("Configuration loaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to parse configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e) { }

        private void AuthourBox_TextChanged(object sender, EventArgs e) { }

        private void VersionBox_TextChanged(object sender, EventArgs e) { }

        private void ReleasetypeBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Link1Box_TextChanged(object sender, EventArgs e) { }

        private void Link2Box_TextChanged(object sender, EventArgs e) { }

        private void AboutBox_TextChanged(object sender, EventArgs e) { }

        // Strongly-typed class for deserialization
        private class ConfigData
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string Version { get; set; }
            public string ReleaseType { get; set; }
            public string Link1 { get; set; }
            public string Link2 { get; set; }
            public string About { get; set; }
        }
    }
}