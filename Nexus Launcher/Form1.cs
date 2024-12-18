using System;
using System.Drawing;
using System.Windows.Forms;
using Nexus_Launcher.Screens; // Reference the namespace where UpdatesPage is defined

namespace Nexus_Launcher
{
    public partial class NexusMainWindow : Form
    {
        // Variables for dragging functionality
        private bool dragging = false;     // Flag to track dragging status
        private Point dragCursorPoint;     // Point where the mouse cursor is during drag
        private Point dragFormPoint;       // Initial point of the form's location

        public NexusMainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;  // Hide the title bar and borders
            this.KeyPreview = true; // Ensures the form captures key presses before controls do

            // Load the default page when the form loads
            LoadDefaultPage(new UpdatesPage()); // Here, you can load UpdatesPage or any other page dynamically

            // Attach mouse events to the TitleBar for dragging functionality
            TitleBar.MouseDown += TitleBar_MouseDown;
            TitleBar.MouseMove += TitleBar_MouseMove;
            TitleBar.MouseUp += TitleBar_MouseUp;
        }

        // Generalized method to load any UserControl into the panelContent
        private void LoadDefaultPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;            // Make the page fill the parent container (panelContent)
            panelContent.Controls.Clear();         // Clear any existing controls in the panel
            panelContent.Controls.Add(page);      // Add the new page control to the panel
        }

        // Override ProcessCmdKey to handle Enter and Escape keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // You can add logic here for the Enter key, for now we just show a message
                MessageBox.Show("Enter key was pressed!");
                return true; // Mark the key event as handled
            }
            else if (keyData == Keys.Escape)
            {
                TriggerOption3(); // Call Option 3 functionality when Escape is pressed
                return true; // Mark the key event as handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Option 3 functionality triggered by Escape key
        private void TriggerOption3()
        {
            this.Close();  // Close the form when Escape key is pressed
        }

        // Handle the custom close button click
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form
        }

        // Paint event for the panel (can be used for custom drawing)
        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            // You can add custom drawing code here if needed
        }

        // Mouse down event for dragging the window using the TitleBar
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  // Only drag on left mouse button press
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;  // Get the position of the mouse
                dragFormPoint = this.Location;      // Get the current location of the form
            }
        }

        // While the mouse is moved, move the form accordingly
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // Calculate the difference between the cursor's current position and the original position
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));  // Update the form's location
            }
        }

        // When the mouse button is released, stop dragging
        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;  // Stop dragging when mouse button is released
        }

        // Example of label click handler (you must add a label with this event in the Designer)
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form when Escape key is pressed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new LaunchPage());
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panelContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            LoadDefaultPage(new LaunchPage());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadDefaultPage(new SettingsPage());
        }
    }
}
