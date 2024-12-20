﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nexus_Launcher.Screens;

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
            if (keyData == Keys.Enter)
            {
                MessageBox.Show("Enter key was pressed!");
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                TriggerOption3();
                return true;
            }

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
    }
}