using System;
using System.IO;
using System.Windows.Forms;

namespace Nexus_Launcher.Screens
{
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            textBox2.Text = Properties.Settings.Default.UserInput1;
            textBox1.Text = Properties.Settings.Default.UserInput2;
            useDCname.Checked = Properties.Settings.Default.UseDCnameChecked;

            if (useDCname.Checked)
            {
                LoadDiscordUsername();
            }

            if (!useDCname.Checked || !File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User", "discord_username.txt")))
            {
                textBox2.Text = Properties.Settings.Default.UserInput1;
            }

            textBox1.Text = Properties.Settings.Default.UserInput2;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            // Use appropriate properties to fetch the text
            string userInput1 = textBox2.Text; // Replace with correct property if needed
            string userInput2 = textBox1.Text; // Replace with correct property if needed

            // Update application settings
            Properties.Settings.Default.UserInput1 = userInput1;
            Properties.Settings.Default.UserInput2 = userInput2;
            Properties.Settings.Default.UseDCnameChecked = useDCname.Checked;
            Properties.Settings.Default.Save();

            // Write to JSON config
            WriteJsonConfig(userInput1, userInput2);
        }


        private void WriteJsonConfig(string userInput1, string userInput2)
        {
            try
            {
                string escapedPath = userInput2.Replace("\\", "\\\\");
                string jsonData = $"{{\"name\":\"{userInput1}\",\"path\":\"{escapedPath}\"}}";

                string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Project Carbon");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, "Carbon.config");
                File.WriteAllText(filePath, jsonData);

                MessageBox.Show($"Settings saved to {filePath} successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the configuration: {ex.Message}");
            }
        }


        private void LoadDiscordUsername()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User", "discord_username.txt");

            if (File.Exists(filePath) && useDCname.Checked)
            {
                try
                {
                    string discordUsername = File.ReadAllText(filePath).Trim();
                    textBox2.Text = discordUsername;

                    Properties.Settings.Default.UserInput1 = discordUsername;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading Discord username: {ex.Message}");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_Click(object sender, EventArgs e) { }
        private void SettingsPage_Load(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void useDCname_CheckedChanged_1(object sender, EventArgs e) { }
        private void textBox1_ContentChanged(object sender, EventArgs e) { }
        private void useDCname_Click(object sender, EventArgs e) { }
        private void eee(object sender, EventArgs e) { }
        private void useDCname_CheckedChanged(object sender, EventArgs e)
        {
            if (useDCname.Checked)
            {
                LoadDiscordUsername();
            }
            else
            {
                textBox2.Text = Properties.Settings.Default.UserInput1;
            }
        }
        private void textBox2_ContentChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}