namespace Nexus_Launcher.Screens
{
    partial class ScreenJSONMaker
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VersionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReleasetypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Link1Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Link2Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AboutBox = new System.Windows.Forms.TextBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.NameBox.Location = new System.Drawing.Point(27, 56);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(478, 35);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Authour";
            // 
            // AuthourBox
            // 
            this.AuthourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.AuthourBox.Location = new System.Drawing.Point(21, 137);
            this.AuthourBox.Name = "AuthourBox";
            this.AuthourBox.Size = new System.Drawing.Size(484, 35);
            this.AuthourBox.TabIndex = 3;
            this.AuthourBox.TextChanged += new System.EventHandler(this.AuthourBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Version";
            // 
            // VersionBox
            // 
            this.VersionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.VersionBox.Location = new System.Drawing.Point(21, 228);
            this.VersionBox.Name = "VersionBox";
            this.VersionBox.Size = new System.Drawing.Size(484, 35);
            this.VersionBox.TabIndex = 5;
            this.VersionBox.TextChanged += new System.EventHandler(this.VersionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(10, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release Type";
            // 
            // ReleasetypeBox
            // 
            this.ReleasetypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ReleasetypeBox.FormattingEnabled = true;
            this.ReleasetypeBox.Items.AddRange(new object[] {
            "TESTING",
            "ALPHA",
            "BETA",
            "RELEASE",
            "BUGFIX"});
            this.ReleasetypeBox.Location = new System.Drawing.Point(21, 319);
            this.ReleasetypeBox.Name = "ReleasetypeBox";
            this.ReleasetypeBox.Size = new System.Drawing.Size(484, 37);
            this.ReleasetypeBox.TabIndex = 7;
            this.ReleasetypeBox.Text = "Unselected";
            this.ReleasetypeBox.SelectedIndexChanged += new System.EventHandler(this.ReleasetypeBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(10, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Link 1";
            // 
            // Link1Box
            // 
            this.Link1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Link1Box.Location = new System.Drawing.Point(21, 414);
            this.Link1Box.Name = "Link1Box";
            this.Link1Box.Size = new System.Drawing.Size(484, 35);
            this.Link1Box.TabIndex = 9;
            this.Link1Box.TextChanged += new System.EventHandler(this.Link1Box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(10, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Link 2";
            // 
            // Link2Box
            // 
            this.Link2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Link2Box.Location = new System.Drawing.Point(21, 500);
            this.Link2Box.Name = "Link2Box";
            this.Link2Box.Size = new System.Drawing.Size(484, 35);
            this.Link2Box.TabIndex = 11;
            this.Link2Box.TextChanged += new System.EventHandler(this.Link2Box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(533, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "About";
            // 
            // AboutBox
            // 
            this.AboutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.AboutBox.Location = new System.Drawing.Point(550, 56);
            this.AboutBox.Multiline = true;
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.Size = new System.Drawing.Size(408, 393);
            this.AboutBox.TabIndex = 13;
            this.AboutBox.TextChanged += new System.EventHandler(this.AboutBox_TextChanged);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.CreateBtn.Location = new System.Drawing.Point(758, 468);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(200, 69);
            this.CreateBtn.TabIndex = 14;
            this.CreateBtn.Text = "Create Module.Config";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ReadBtn.Location = new System.Drawing.Point(550, 468);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(192, 69);
            this.ReadBtn.TabIndex = 15;
            this.ReadBtn.Text = "Read Module.Config";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // ScreenJSONMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.AboutBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Link2Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Link1Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReleasetypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VersionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthourBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Name = "ScreenJSONMaker";
            this.Size = new System.Drawing.Size(985, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VersionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ReleasetypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Link1Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Link2Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AboutBox;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button ReadBtn;
    }
}
