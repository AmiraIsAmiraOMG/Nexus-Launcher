namespace Nexus_Launcher.Screens
{
    partial class SettingsPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useDCname = new CuoreUI.Controls.cuiCheckbox();
            this.saveButton = new CuoreUI.Controls.cuiButton();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 127);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(506, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path To Fortnite Install";
            // 
            // useDCname
            // 
            this.useDCname.BackColor = System.Drawing.Color.Black;
            this.useDCname.Checked = false;
            this.useDCname.CheckedBackground = System.Drawing.Color.Black;
            this.useDCname.CheckedForeground = System.Drawing.Color.Black;
            this.useDCname.CheckedOutlineColor = System.Drawing.Color.Black;
            this.useDCname.CheckedSymbolColor = System.Drawing.Color.White;
            this.useDCname.Content = "cuiCheckbox";
            this.useDCname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.useDCname.Location = new System.Drawing.Point(394, 225);
            this.useDCname.MinimumSize = new System.Drawing.Size(24, 24);
            this.useDCname.Name = "useDCname";
            this.useDCname.OutlineStyle = true;
            this.useDCname.OutlineThickness = 0F;
            this.useDCname.Rounding = 8;
            this.useDCname.ShowSymbols = true;
            this.useDCname.Size = new System.Drawing.Size(31, 27);
            this.useDCname.TabIndex = 17;
            this.useDCname.ThumbSizeModifier = new System.Drawing.Size(0, 0);
            this.useDCname.UncheckedBackground = System.Drawing.Color.Black;
            this.useDCname.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.useDCname.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.useDCname.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.useDCname.CheckedChanged += new System.EventHandler(this.useDCname_CheckedChanged);
            this.useDCname.Click += new System.EventHandler(this.useDCname_Click);
            // 
            // saveButton
            // 
            this.saveButton.CheckButton = false;
            this.saveButton.Checked = false;
            this.saveButton.CheckedBackground = System.Drawing.Color.White;
            this.saveButton.CheckedForeColor = System.Drawing.Color.White;
            this.saveButton.CheckedImageTint = System.Drawing.Color.White;
            this.saveButton.CheckedOutline = System.Drawing.Color.White;
            this.saveButton.Content = "SAVE";
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveButton.HoveredImageTint = System.Drawing.Color.White;
            this.saveButton.HoverForeColor = System.Drawing.Color.White;
            this.saveButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveButton.Image = null;
            this.saveButton.ImageAutoCenter = true;
            this.saveButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.saveButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.saveButton.ImageTint = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(328, 293);
            this.saveButton.Name = "saveButton";
            this.saveButton.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))), ((int)(((byte)(249)))));
            this.saveButton.OutlineThickness = 2.5F;
            this.saveButton.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.saveButton.PressedForeColor = System.Drawing.Color.White;
            this.saveButton.PressedImageTint = System.Drawing.Color.White;
            this.saveButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.saveButton.Rounding = new System.Windows.Forms.Padding(20);
            this.saveButton.Size = new System.Drawing.Size(320, 61);
            this.saveButton.TabIndex = 22;
            this.saveButton.TextOffset = new System.Drawing.Point(0, 0);
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // cuiButton1
            // 
            this.cuiButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.White;
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.White;
            this.cuiButton1.Content = "";
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Enabled = false;
            this.cuiButton1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Empty;
            this.cuiButton1.HoveredImageTint = System.Drawing.SystemColors.Window;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(34, 220);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Black;
            this.cuiButton1.NormalOutline = System.Drawing.Color.Black;
            this.cuiButton1.OutlineThickness = 2.5F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cuiButton1.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiButton1.Size = new System.Drawing.Size(394, 38);
            this.cuiButton1.TabIndex = 23;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(45, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 24);
            this.textBox2.TabIndex = 26;
            // 
            // cuiButton3
            // 
            this.cuiButton3.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.White;
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.White;
            this.cuiButton3.Content = "";
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Enabled = false;
            this.cuiButton3.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton3.ForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverBackground = System.Drawing.Color.Empty;
            this.cuiButton3.HoveredImageTint = System.Drawing.SystemColors.Window;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiButton3.Image = null;
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageTint = System.Drawing.Color.White;
            this.cuiButton3.Location = new System.Drawing.Point(27, 211);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))), ((int)(((byte)(249)))));
            this.cuiButton3.OutlineThickness = 2.5F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cuiButton3.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton3.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiButton3.Size = new System.Drawing.Size(409, 55);
            this.cuiButton3.TabIndex = 28;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(461, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 24);
            this.textBox1.TabIndex = 30;
            // 
            // cuiButton2
            // 
            this.cuiButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.White;
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.White;
            this.cuiButton2.Content = "";
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Enabled = false;
            this.cuiButton2.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton2.ForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverBackground = System.Drawing.Color.Empty;
            this.cuiButton2.HoveredImageTint = System.Drawing.SystemColors.Window;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiButton2.Image = null;
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageTint = System.Drawing.Color.White;
            this.cuiButton2.Location = new System.Drawing.Point(453, 220);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.Black;
            this.cuiButton2.NormalOutline = System.Drawing.Color.Black;
            this.cuiButton2.OutlineThickness = 2.5F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cuiButton2.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(15);
            this.cuiButton2.Size = new System.Drawing.Size(499, 38);
            this.cuiButton2.TabIndex = 29;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton4
            // 
            this.cuiButton4.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.White;
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.White;
            this.cuiButton4.Content = "";
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Enabled = false;
            this.cuiButton4.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton4.ForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverBackground = System.Drawing.Color.Empty;
            this.cuiButton4.HoveredImageTint = System.Drawing.SystemColors.Window;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiButton4.Image = null;
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageTint = System.Drawing.Color.White;
            this.cuiButton4.Location = new System.Drawing.Point(446, 211);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))), ((int)(((byte)(249)))));
            this.cuiButton4.OutlineThickness = 2.5F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cuiButton4.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton4.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiButton4.Size = new System.Drawing.Size(514, 55);
            this.cuiButton4.TabIndex = 31;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "NEXUS GUI BETA CB O1.01.13";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.useDCname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton4);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.cuiButton3);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(985, 558);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CuoreUI.Controls.cuiCheckbox useDCname;
        private CuoreUI.Controls.cuiButton saveButton;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private System.Windows.Forms.TextBox textBox1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private System.Windows.Forms.Label label4;
    }
}
