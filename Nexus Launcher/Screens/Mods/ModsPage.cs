using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nexus_Launcher.Screens
{
    public partial class ModsPage : UserControl
    {
        public ModsPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModsPage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Modslist_Paint(object sender, PaintEventArgs e)
        {
            // Create a GroupBox to group the controls
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Group of Controls";
            groupBox.Size = new System.Drawing.Size(300, 200);
            groupBox.Location = new System.Drawing.Point(10, 10);

            // Add multiple controls to the GroupBox
            Button button1 = new Button();
            button1.Text = "Button 1";
            button1.Location = new System.Drawing.Point(10, 30);

            Button button2 = new Button();
            button2.Text = "Button 2";
            button2.Location = new System.Drawing.Point(10, 70);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(10, 110);

            // Add controls to the GroupBox
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(button2);
            groupBox.Controls.Add(textBox1);

            // Add the GroupBox to the form
            this.Controls.Add(groupBox);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
