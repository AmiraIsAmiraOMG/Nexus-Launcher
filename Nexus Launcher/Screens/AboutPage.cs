using System;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Nexus_Launcher.Screens
{
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // You can add any logic here if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the method to show system information when the button is clicked
            ShowDebugInfo();
        }

        // Method to show system information in a single popup message box
        private void ShowDebugInfo()
        {
            // Collect all system information into one string
            StringBuilder debugInfo = new StringBuilder();

            // Get OS version information using WMI (for accurate version detection)
            debugInfo.AppendLine($"Operating System: {GetWindowsVersion()}");

            // Get User Information
            debugInfo.AppendLine($"User: {Environment.UserName}");
            debugInfo.AppendLine($"Domain: {Environment.UserDomainName}");

            // Get User's Documents Folder
            debugInfo.AppendLine($"Documents Folder: {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");

            // Get System Architecture (x86, x64)
            debugInfo.AppendLine($"Architecture: {Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")}");

            // Get CPU Information
            string cpuInfo = GetCPUInfo();
            debugInfo.AppendLine(cpuInfo);

            // Get Memory (RAM) Information
            string ramInfo = GetRAMInfo();
            debugInfo.AppendLine(ramInfo);

            // Dump all stored variables (Settings)
            DumpStoredVariables(debugInfo);

            // Show all collected system information in one message box
            MessageBox.Show(debugInfo.ToString(), "System Information");
        }

        // Get accurate Windows version using WMI
        private string GetWindowsVersion()
        {
            string osVersion = "Windows: Not Available";

            try
            {
                // Connect to the WMI namespace
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (ManagementObject os in searcher.Get())
                {
                    osVersion = $"Windows: {os["Caption"]} {os["Version"]}";
                }
            }
            catch (Exception ex)
            {
                osVersion = $"Error fetching Windows version: {ex.Message}";
            }

            return osVersion;
        }

        // Get CPU information using WMI (Windows Management Instrumentation)
        private string GetCPUInfo()
        {
            string cpuInfo = "CPU: Not Available";

            try
            {
                // Connect to the WMI namespace
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuInfo = $"CPU: {obj["Name"]}";
                }
            }
            catch (Exception ex)
            {
                cpuInfo = $"Error fetching CPU info: {ex.Message}";
            }

            return cpuInfo;
        }

        // Get RAM (Memory) information using WMI
        private string GetRAMInfo()
        {
            string ramInfo = "RAM: Not Available";

            try
            {
                // Connect to the WMI namespace
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
                foreach (ManagementObject obj in searcher.Get())
                {
                    ramInfo = $"RAM: {(Convert.ToInt64(obj["TotalPhysicalMemory"]) / (1024 * 1024 * 1024))} GB";
                }
            }
            catch (Exception ex)
            {
                ramInfo = $"Error fetching RAM info: {ex.Message}";
            }

            return ramInfo;
        }

        // Dump all stored settings (Variables) into the debug information
        private void DumpStoredVariables(StringBuilder debugInfo)
        {
            try
            {
                // Add stored variables (settings) to debug output
                debugInfo.AppendLine("\nStored Application Settings:");

                debugInfo.AppendLine($"UserInput1: {Properties.Settings.Default.UserInput1}");
                debugInfo.AppendLine($"UserInput2: {Properties.Settings.Default.UserInput2}");
                debugInfo.AppendLine($"GameVersion: {Properties.Settings.Default.GameVersion}");

                // Add any other settings you have in your settings file
                // For example, if you have other settings like 'UserPreference', 'LaunchPath', etc., you can add them here:
                // debugInfo.AppendLine($"UserPreference: {Properties.Settings.Default.UserPreference}");
            }
            catch (Exception ex)
            {
                debugInfo.AppendLine($"Error fetching stored settings: {ex.Message}");
            }
        }
    }
}
