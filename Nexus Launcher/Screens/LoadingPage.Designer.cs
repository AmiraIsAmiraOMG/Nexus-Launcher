namespace Nexus_Launcher.Screens
{
    partial class LoadingPage
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
            this.cuiSpinner1 = new CuoreUI.Controls.cuiSpinner();
            this.SuspendLayout();
            // 
            // cuiSpinner1
            // 
            this.cuiSpinner1.ArcColor = System.Drawing.Color.White;
            this.cuiSpinner1.Location = new System.Drawing.Point(386, 185);
            this.cuiSpinner1.Name = "cuiSpinner1";
            this.cuiSpinner1.RingColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cuiSpinner1.RotateSpeed = 20F;
            this.cuiSpinner1.Rotation = 143.1569F;
            this.cuiSpinner1.Size = new System.Drawing.Size(197, 197);
            this.cuiSpinner1.TabIndex = 0;
            this.cuiSpinner1.Thickness = 10F;
            this.cuiSpinner1.Load += new System.EventHandler(this.cuiSpinner1_Load);
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cuiSpinner1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "LoadingPage";
            this.Size = new System.Drawing.Size(985, 558);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiSpinner cuiSpinner1;
    }
}
