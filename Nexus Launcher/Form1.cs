using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nexus_Launcher.Screens;
using PluginSystem;

namespace Nexus_Launcher
{
    public partial class NexusMainWindow : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public NexusMainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true;

            TitleBar.MouseDown += TitleBar_MouseDown;
            TitleBar.MouseMove += TitleBar_MouseMove;
            TitleBar.MouseUp += TitleBar_MouseUp;
;
            LoadDefaultPage(new UpdatesPage());
        }

        private void LoadDefaultPage(UserControl page)
        {
            ShowLoadingPage();

            Task.Delay(250).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    panelContent.Controls.Clear();
                    page.Dock = DockStyle.Fill;
                    panelContent.Controls.Add(page);
                }));
            });
        }

        private void ShowLoadingPage()
        {
            var loadingPage = new LoadingPage
            {
                Dock = DockStyle.Fill
            };

            panelContent.Controls.Clear();
            panelContent.Controls.Add(loadingPage);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check for specific key presses
            if (keyData == Keys.Escape)
            {
                TriggerOption3();
                return true; // Indicate the key event was handled
            }
            else if (keyData == Keys.Enter)
            {
                // Check if DebugForm is already open
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is DebugForm)
                    {
                        openForm.BringToFront(); // Bring existing DebugForm to front
                        return true; // Key event handled
                    }
                }

                // Open DebugForm if not already open
                DebugForm form = new DebugForm();
                form.ShowDialog();
                return true; // Key event handled
            }

            // Allow the base implementation to handle other keys
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TriggerOption3()
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void LoadAllPlugins()
        {
            string pluginFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");

            foreach (string pluginFilePath in Directory.GetFiles(pluginFolderPath, "*.dll"))
            {
                try
                {
                    Assembly pluginAssembly = Assembly.LoadFrom(pluginFilePath);

                    foreach (Type type in pluginAssembly.GetTypes())
                    {
                        if (typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface)
                        {
                            // Create an instance of the plugin
                            IPlugin pluginInstance = (IPlugin)Activator.CreateInstance(type);

                            // Execute the plugin's functionality
                            pluginInstance.Execute();
                        }
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    string loaderExceptions = string.Join(Environment.NewLine, ex.LoaderExceptions.Select(e => e.Message));
                    MessageBox.Show($"Error loading plugin from {pluginFilePath}: {ex.Message}\nDetails:\n{loaderExceptions}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading plugin from {pluginFilePath}: {ex.Message}");
                }
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new LaunchPage());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new SettingsPage());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new LoginPage());
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoadDefaultPage(new LaunchPage());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadAllPlugins();
        }
    }
}