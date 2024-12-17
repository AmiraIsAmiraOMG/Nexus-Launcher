// #   #  ###  #   #  #  #  ###    #####  #  #  #####
// ##  #  #     # #   #  #  #      #      #  #    #
// # # #  ##     #    #  #  ###    # ###  #  #    #
// #  ##  #     # #   #  #    #    #   #  #  #    #
// #   #  ###  #   #  ####  ###    #####  ####  #####

// By SamIsSamOMG
// https://discord.gg/gZZtysUAp3

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

            // Load previously saved values
            textBox1.Text = Properties.Settings.Default.UserInput1;
            textBox2.Text = Properties.Settings.Default.UserInput2;
            comboBox1.Text = Properties.Settings.Default.GameVersion;

            // Load the saved checkbox state
            useDCname.Checked = Properties.Settings.Default.UseDCnameChecked;

            // Attach event handler for the checkbox
            useDCname.CheckedChanged += useDCname_CheckedChanged;

            // Load Discord username if the checkbox is checked
            if (useDCname.Checked)
            {
                LoadDiscordUsername();
            }
        }

        // Button click handler to save user inputs
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            // Access the input from the textboxes and comboBox
            string userInput1 = textBox1.Text;
            string userInput2 = textBox2.Text;
            string userInput3 = comboBox1.Text;

            // Save the values to Application Settings
            Properties.Settings.Default.UserInput1 = userInput1;
            Properties.Settings.Default.UserInput2 = userInput2;
            Properties.Settings.Default.GameVersion = userInput3;
            Properties.Settings.Default.UseDCnameChecked = useDCname.Checked;

            // Save the settings
            Properties.Settings.Default.Save();

            // Escape backslashes in the path
            string escapedPath = userInput2.Replace("\\", "\\\\");

            // Create the JSON data in the required format
            string jsonData = $"{{\"name\":\"{userInput1}\",\"path\":\"{escapedPath}\"}}";

            // Specify the folder path
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Project Carbon");

            try
            {
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

        // Event handler for the useDCname checkbox
        private void useDCname_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Method to load Discord username from a text file
        private void LoadDiscordUsername()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "User", "discord_username.txt");

            if (File.Exists(filePath))
            {
                try
                {
                    string discordUsername = File.ReadAllText(filePath).Trim();

                    textBox1.Text = discordUsername;
                    Properties.Settings.Default.UserInput1 = discordUsername;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading Discord username: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("discord_username.txt not found.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional logic for textBox1 changes
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            // Optional logic for comboBox1 click
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
