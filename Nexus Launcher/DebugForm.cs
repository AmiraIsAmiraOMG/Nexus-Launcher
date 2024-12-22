using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Nexus_Launcher.Screens;

namespace Nexus_Launcher
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
            LoadDefaultPage(new UpdatesPage());
        }

        private void LoadDefaultPage(UserControl page)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            LoadDefaultPage(new LaunchPage());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new SettingsPage());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new LoginPage());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new UpdatesPage());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new LoadingPage());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new Key());
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new DownloadingAssets());
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new DllInjectionPage());
        }

        private void label11_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new CredditsPage());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new AboutPage());
        }

        private void label13_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new ScreenJSONMaker());
        }
    }
}
