namespace Nexus_Launcher.Screens
{
    partial class Key
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getKeybtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 62F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(-2, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEXUS GUI KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please input a key\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "YOU ARE NOT VERIFIED\r\n";
            // 
            // getKeybtn
            // 
            this.getKeybtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.getKeybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getKeybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getKeybtn.FlatAppearance.BorderSize = 0;
            this.getKeybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getKeybtn.Font = new System.Drawing.Font("Cascadia Code", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.getKeybtn.Location = new System.Drawing.Point(539, 485);
            this.getKeybtn.Name = "getKeybtn";
            this.getKeybtn.Size = new System.Drawing.Size(326, 54);
            this.getKeybtn.TabIndex = 3;
            this.getKeybtn.Text = "GET KEY";
            this.getKeybtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 100F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(68, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(707, 354);
            this.label4.TabIndex = 4;
            this.label4.Text = "WORK IN \r\nPROGRESS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getKeybtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Key";
            this.Size = new System.Drawing.Size(877, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getKeybtn;
        private System.Windows.Forms.Label label4;
    }
}
