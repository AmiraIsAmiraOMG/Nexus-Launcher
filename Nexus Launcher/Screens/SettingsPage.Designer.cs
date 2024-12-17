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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useDCname = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(16, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(16, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(840, 39);
            this.textBox2.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(479, 456);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(363, 51);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path To Fortnite Install";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "UNKNOWN",
            "OT6.5 (Untested)",
            "Cert (Untested)",
            "1.2- (Untested)",
            "1.7.2 (Needs Lawin Server No In game)",
            "1.8 (Untested)",
            "1.8.1 (Untested)",
            "1.8.2 (Untested)",
            "1.9.2 (Untested)",
            "1.9.1 (Untested)",
            "1.10 (Untested)",
            "1.11 (Untested)",
            "2.1.0 (Untested)",
            "2.2.0 (Untested)",
            "2.3.0 (Untested)",
            "2.4.0 (Untested)",
            "2.4.2 (Untested)",
            "2.5.0 (Untested)",
            "3.0 (Untested)",
            "3.1-CL-3915963 (Untested)",
            "3.1-CL-3917250 (Untested)",
            "3.2-CL-3929794 (Untested)",
            "3.2-CL-3935073 (Untested)",
            "3.3-CL-3942182 (Untested)",
            "3.3-CL-3948073 (Untested)",
            "3.4-CL-3968866 (Untested)",
            "3.4-CL-3973340 (Untested)",
            "3.5-CL-3994867 (Untested)",
            "3.5-CL-4000805 (Untested)",
            "3.5-CL-4008490 (Untested)",
            "3.6 (Untested)",
            "4.0 (Untested)",
            "4.1 (Untested)",
            "4.2 (Untested)",
            "4.3-CL-4095806 (Untested)",
            "4.3-CL-4103483 (Untested)",
            "4.4-CL-4117433 (Untested)",
            "4.4-CL-4127312 (Untested)",
            "4.4.x-CL-4132537 (Untested)",
            "4.5-CL-4159770 (Untested)",
            "4.5-CL-4166199 (Untested)",
            "5.0-CL-4204761 (Untested)",
            "5.0-CL-4214610 (Untested)",
            "5.10-CL-4225813 (Untested)",
            "5.10-CL-4240749 (Untested)",
            "5.20-CL-4259375 (Untested)",
            "5.20-CL-4276938 (Untested)",
            "5.21-CL-4281534 (Working)",
            "5.30-CL-4312945 (Untested)",
            "5.30-CL-4317672 (Untested)",
            "5.40-CL-4351695 (Untested)",
            "5.40-CL-4352937 (Untested)",
            "5.41 (Untested)",
            "6.00-CL-4395664 (Untested)",
            "6.00-CL-4402180 (Untested)",
            "6.01-CL-4417689 (Untested)",
            "6.01-CL-4424678 (Untested)",
            "6.02-CL-4442095 (Untested)",
            "6.02-CL-4461277 (Untested)",
            "6.10-CL-4464155 (Untested)",
            "6.10-CL-4476098 (Untested)",
            "6.10-CL-4480234 (Untested)",
            "6.20-CL-4497486 (Untested)",
            "6.20-CL-4504220 (Untested)",
            "6.21-CL-4526925 (Untested)",
            "6.21-CL-4531851 (Untested)",
            "6.21-CL-4535631 (Untested)",
            "6.22-CL-4541220 (Untested)",
            "6.22-CL-4543176 (Untested)",
            "6.30-CL-4579044 (Untested)",
            "6.31-CL-4573279 (Untested)",
            "7.00-CL-4629139 (Untested)",
            "7.01-CL-4648651 (Untested)",
            "7.10-CL-4667333 (Untested)",
            "7.20-CL-4716934 (Untested)",
            "7.20-CL-4727874 (Untested)",
            "7.30-CL-4821335 (Untested)",
            "7.30-CL-4834550 (Untested)",
            "7.30-CL-4869070 (Untested)",
            "7.40-CL-4980899 (Broken)",
            "7.40-CL-4996168(Broken)",
            "7.40-CL-5012948(Broken)",
            "7.40-CL-5046157(Broken)",
            "8.00-CL-5203069 (Untested)",
            "8.00-CL-5251086 (Untested)",
            "8.00-CL-5274521 (Untested)",
            "8.01-CL-5285981 (Untested)",
            "8.10-CL-5362200 (Untested)",
            "8.10-CL-5372009 (Untested)",
            "8.11-CL-5442615 (Untested)",
            "8.11-CL-5484841 (Untested)",
            "8.20-CL-5547534 (Untested)",
            "8.20-CL-5625478 (Untested)",
            "8.30-CL-5793395 (Untested)",
            "8.30-CL-5822617 (Untested)",
            "8.30-CL-5831510 (Untested)",
            "8.40-CL-5914491 (Untested)",
            "8.40-CL-6005771 (Untested)",
            "8.50-CL-6058028 (Untested)",
            "8.51-CL-6165369 (Working)",
            "9.00-CL-6337466 (Untested)",
            "9.01-CL-6428087 (Untested)",
            "9.10-CL-6573057 (Untested)",
            "9.10-CL-6616201 (Untested)",
            "9.10-CL-6639283 (Untested)",
            "9.20-CL-6822798 (Untested)",
            "9.21-CL-6922310 (Untested)",
            "9.30-CL-7021684 (Untested)",
            "9.30-CL-7095426 (Untested)",
            "9.40-CL-7315705 (Untested)",
            "9.41-CL-7463579 (Untested)",
            "9.41-CL-7609292 (Untested)",
            "10.0-CL-7658179 (Untested)",
            "10.0-CL-7704164 (Untested)",
            "10.10-CL-7955722 (Untested)",
            "10.20-CL-8243923 (Untested)",
            "10.20-CL-8360257 (Untested)",
            "10.20-CL-8456527 (Untested)",
            "10.30-CL-8569414 (Untested)",
            "10.31-CL-8723043 (Untested)",
            "10.40-CL-8970213 (Untested)",
            "10.40-CL-9302865 (Untested)",
            "10.40-CL-9380822 (Untested)",
            "11.00-CL-9562734 (Untested)",
            "11.00-CL-9603448 (Untested)",
            "11.01-CL-9728272 (Untested)",
            "11.10-CL-9844520 (Untested)",
            "11.10-CL-9901083 (Untested)",
            "11.11-CL-10082788 (Untested)",
            "11.20-CL-10297577 (Untested)",
            "11.20-CL-10328358 (Untested)",
            "11.21-CL-10481509 (Untested)",
            "11.30-CL-10639804 (Untested)",
            "11.30-CL-10708866 (Untested)",
            "11.31-CL-10760473 (Untested)",
            "11.31-CL-10795579 (Untested)",
            "11.31-CL-10800459 (Untested)",
            "11.40-CL-10951104 (Untested)",
            "11.40-CL-11039906 (Untested)",
            "11.40-CL-11109625 (Untested)",
            "11.50-CL-11204868 (Untested)",
            "11.50-CL-11265652 (Untested)",
            "12.00-CL-11556442 (Untested)",
            "12.00-CL-11566760 (Untested)",
            "12.00-CL-11586896 (Untested)",
            "12.10-CL-11794982 (Untested)",
            "12.10-CL-11883027 (Untested)",
            "12.20-CL-12170032 (Untested)",
            "12.20-CL-12236980 (Untested)",
            "12.21-CL-12353830 (Untested)",
            "12.30-CL-12493283 (Untested)",
            "12.30-CL-12624643 (Untested)",
            "12.40-CL-12837456 (Untested)",
            "12.41-CL-12905909 (Broken)",
            "12.50-CL-13044369 (Untested)",
            "12.50-CL-131370 (Untested)",
            "12.50-CL-13193885 (Untested)",
            "12.60-CL-13315662 (Untested)",
            "12.60-CL-13477524 (Untested)",
            "12.61-CL-13498980 (Broken)",
            "13.00-CL-13649278 (Untested)",
            "13.00-CL-13696059 (Untested)",
            "13.00-CL-13715544 (Untested)",
            "13.20-CL-13777676 (Untested)",
            "13.30-CL-13884634 (Untested)",
            "13.40-CL-14008768 (Untested)",
            "13.40-CL-14036559 (Untested)",
            "13.40-CL-14113327 (Untested)",
            "14.00-CL-14173417 (Untested)",
            "14.00-CL-14199892 (Untested)",
            "14.00-CL-14211474 (Untested)",
            "14.10-CL-14276912 (Untested)",
            "14.10-CL-14288110 (Untested)",
            "14.10-CL-14312695 (Untested)",
            "14.20-CL-14354056 (Untested)",
            "14.20-CL-14375974 (Untested)",
            "14.20-CL-14384759 (Untested)",
            "14.30-CL-14456520 (Untested)",
            "14.40-CL-14512399 (Untested)",
            "14.40-CL-14550713 (Untested)",
            "14.50-CL-14617811 (Untested)",
            "14.50-CL-14643651 (Untested)",
            "14.60-CL-14756138 (Untested)",
            "14.60-CL-14785135 (Untested)",
            "14.60-CL-14786821 (Untested)",
            "15.00-CL-14826719 (Untested)",
            "15.00-CL-14835335 (Untested)",
            "15.10-CL-14904303 (Untested)",
            "15.10-CL-14937640 (Untested)",
            "15.10-CL-15014719 (Untested)",
            "15.20-CL-15033494 (Untested)",
            "15.20-CL-15070882 (Untested)",
            "15.21-CL-15083856 (Untested)",
            "15.30-CL-15233634 (Untested)",
            "15.30-CL-15316852 (Untested)",
            "15.30-CL-15341163 (Untested)",
            "15.40-CL-15385160 (Untested)",
            "15.40-CL-15419568 (Untested)",
            "15.40-CL-15424013 (Untested)",
            "15.40-CL-15496915 (Untested)",
            "15.50-CL-15526472 (Untested)",
            "15.50-CL-15570449 (Untested)",
            "16.00-CL-15685441 (Untested)",
            "16.00-CL-15713390 (Untested)",
            "16.00-CL-15727376 (Untested)",
            "16.10-CL-15851811 (Untested)",
            "16.10-CL-15862581 (Untested)",
            "16.10-CL-15883297 (Untested)",
            "16.10-CL-15898731 (Untested)",
            "16.10-CL-15913292 (Untested)",
            "16.20-CL-15961073 (Untested)",
            "16.20-CL-15987165 (Untested)",
            "16.20-CL-15998392 (Untested)",
            "16.20-CL-16042441 (Untested)",
            "16.30-CL-16086208 (Untested)",
            "16.30-CL-16163563 (Untested)",
            "16.40-CL-16218553 (Untested)",
            "16.50-CL-16432754 (Untested)",
            "16.50-CL-16469788 (Untested)",
            "17.00-CL-16555138 (Untested)",
            "17.00-CL-16593740 (Untested)",
            "17.10-CL-16701187 (Untested)",
            "17.10-CL-16745144 (Untested)",
            "17.20-CL-16868155 (Untested)",
            "17.21-CL-16949556 (Untested)",
            "17.21-CL-16967001 (Untested)",
            "17.30-CL-17004569 (Untested)",
            "17.40-CL-17162853 (Untested)",
            "17.40-CL-17215766 (Untested)",
            "17.40-CL-17269705 (Untested)",
            "17.50-CL-17328477 (Untested)",
            "17.50-CL-17388565 (Untested)",
            "18.00-CL-17468642 (Untested)",
            "18.00-CL-17519952 (Untested)",
            "18.10-CL-17619277 (Untested)",
            "18.10-CL-17661844 (Untested)",
            "18.20-CL-17745267 (Untested)",
            "18.20-CL-17792290 (Untested)",
            "18.21-CL-17811397 (Untested)",
            "18.30-CL-17882303 (Untested)",
            "18.40-CL-18163738 (Untested)",
            "19.00-CL-18335626 (Untested)",
            "19.00-CL-18380290 (Untested)",
            "19.01-CL-18415863 (Untested)",
            "19.01-CL-18489740 (Untested)",
            "19.10-CL-18581131 (Untested)",
            "19.10-CL-18640491 (Untested)",
            "19.10-CL-18675304 (Untested)",
            "19.20-CL-18775446 (Untested)",
            "19.30-CL-18948597 (Untested)",
            "19.30-CL-19027703 (Untested)",
            "19.40-CL-19167615 (Untested)",
            "19.40-CL-19215531 (Untested)",
            "20.00-CL-19381079 (Untested)",
            "20.00-CL-19458861 (Untested)",
            "20.00-CL-19532288 (Untested)",
            "20.10-CL-19598943 (Untested)",
            "20.20-CL-19751212 (Untested)",
            "20.20-CL-19896998 (Untested)",
            "20.30-CL-19950687 (Untested)",
            "20.30-CL-20037261 (Untested)",
            "20.40-CL-20175294 (Untested)",
            "20.40-CL-20244966 (Untested)",
            "21.00-CL-20463113 (Untested)",
            "21.00-CL-20548557 (Untested)",
            "21.10-CL-20696680 (Untested)",
            "21.10-CL-20756627 (Untested)",
            "21.10-CL-20777648 (Untested)",
            "21.10-CL-20829351 (Untested)",
            "21.20-CL-20890025 (Untested)",
            "21.20-CL-20978394 (Untested)",
            "21.20-CL-21035704 (Untested)",
            "21.30-CL-21102315 (Untested)",
            "21.30-CL-21155462 (Untested)",
            "21.40-CL-21348157 (Untested)",
            "21.50-CL-21657658 (Untested)",
            "21.51-CL-21735703 (Untested)",
            "22.00-CL-22026835 (Untested)",
            "22.00-CL-22072684 (Untested)",
            "22.00-CL-22107157 (Untested)",
            "22.00-CL-22149829 (Untested)",
            "22.10-CL-22240570 (Untested)",
            "22.10-CL-22429549 (Untested)",
            "22.20-CL-22523251 (Untested)",
            "22.20-CL-22600409 (Untested)",
            "22.30-CL-22803135 (Untested)",
            "22.40-CL-23070899 (Untested)",
            "23.00-CL-23344627 (Untested)",
            "23.10-CL-23443094 (Untested)",
            "23.10-CL-23572221 (Untested)",
            "23.20-CL-23659353 (Untested)",
            "23.20-CL-23783097 (Untested)",
            "23.30-CL-23901854 (Untested)",
            "23.30-CL-23986860 (Untested)",
            "23.40-CL-24087481 (Untested)",
            "23.50-CL-24376996 (Untested)",
            "23.50-CL-24441668 (Untested)",
            "24.00-CL-24554913 (Untested)",
            "24.01-CL-24672685 (Untested)",
            "24.01-CL-24757023 (Untested)",
            "24.10-CL-24770548 (Untested)",
            "24.10-CL-24903530 (Untested)",
            "24.20-CL-24939793 (Untested)",
            "24.20-CL-25019967 (Untested)",
            "24.20-CL-25058254 (Untested)",
            "24.20-CL-25156858 (Untested)",
            "24.30-CL-25210886 (Untested)",
            "24.30-CL-25347382 (Untested)",
            "24.40-CL-25420516 (Untested)",
            "24.40-CL-25521145 (Untested)",
            "24.40-CL-25595478 (Untested)",
            "25.00-CL-25784668 (Untested)",
            "25.00-CL-25909622 (Untested)",
            "25.10-CL-26000959 (Untested)",
            "25.11-CL-26171015 (Untested)",
            "25.20-CL-26474516 (Untested)",
            "25.20-CL-26629111 (Untested)",
            "25.30-CL-26867995 (Untested)",
            "26.00-CL-27233190 (Untested)",
            "26.00-CL-27424790 (Untested)",
            "26.10-CL-27681420 (Untested)",
            "26.20-CL-28096793 (Untested)",
            "26.30-CL-28509302(Working Needs Nexus.exe) https://discord.com/channels/131144705" +
                "2206477415/1311449174612643910/1313628849593913456",
            "26.30-CL-28688692(Working Needs Nexus.exe) https://discord.com/channels/131144705" +
                "2206477415/1311449174612643910/1313628849593913456",
            "27.00-CL-29072304 (Untested)",
            "27.10-CL-29552510 (Untested)",
            "27.11-CL-29739262 (Untested)",
            "28.00-CL-29915848 (Untested)",
            "28.01-CL-30106568 (Untested)",
            "28.01-CL-30313795 (Untested)",
            "28.10-CL-30676362 (Untested)",
            "28.10-CL-30835064 (Untested)",
            "28.20-CL-31165234 (Untested)",
            "28.20-CL-31286935 (Untested)",
            "28.30-CL-31511038 (Untested)",
            "29.00-CL-31978752 (Untested)",
            "29.00-CL-32116959 (Untested)",
            "29.01-CL-32291970 (Untested)",
            "29.10-CL-32391220 (Untested)",
            "29.10-CL-32567225 (Untested)",
            "29.20-CL-32716692 (Untested)",
            "29.30-CL-32982357 (Untested)",
            "29.40-CL-33291686 (Untested)",
            "29.40-CL-33502036 (Untested)",
            "29.40-CL-33629566 (Untested)",
            "30.00-CL-33760522 (Untested)",
            "30.00-CL-33962396 (Untested)",
            "30.10-CL-34184790 (Untested)",
            "30.10-CL-34261954 (Untested)",
            "30.10-CL-34399867 (Untested)",
            "30.20-CL-34488544 (Untested)",
            "30.20-CL-34597766 (Untested)",
            "30.30-CL-34891016 (Untested)",
            "30.40-CL-35235494 (Untested)",
            "31.00-CL-35447195 (Untested)",
            "31.10-CL-35815136 (Untested)",
            "31.20-CL-36253989 (Untested)",
            "31.20-CL-36348034 (Untested)",
            "31.30-CL-36600465 (Untested)",
            "31.40-CL-36874825 (Untested)",
            "31.40-CL-37076506 (Untested)",
            "31.41-CL-37324991 (Untested)",
            "32.00-CL-37505882 (Untested)",
            "32.00-CL-37770125 (Untested)",
            "32.10-CL-37958378 (Untested)",
            "32.11-CL-38371047 (Untested)",
            "33.00-CL-38324112 (Untested)",
            "33.00-CL-38504598 (Sometimes Works Depends On Setup)",
            "LATEST (Sometimes Works Depends On Setup Lobby Only)"});
            this.comboBox1.Location = new System.Drawing.Point(16, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(840, 75);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(15, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Version";
            // 
            // useDCname
            // 
            this.useDCname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.useDCname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.useDCname.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.useDCname.FlatAppearance.BorderSize = 10;
            this.useDCname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useDCname.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.useDCname.Location = new System.Drawing.Point(450, 148);
            this.useDCname.Name = "useDCname";
            this.useDCname.Size = new System.Drawing.Size(406, 39);
            this.useDCname.TabIndex = 9;
            this.useDCname.Text = "Use Discord Name As Username *";
            this.useDCname.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(15, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "*TEST FEATURES";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.useDCname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(877, 551);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useDCname;
        private System.Windows.Forms.Label label5;
    }
}
