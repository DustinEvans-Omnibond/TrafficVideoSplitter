namespace TrafficVideoSplitter
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.openButton = new System.Windows.Forms.Button();
            this.positionDisplay = new System.Windows.Forms.Label();
            this.fileDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveLocationBox = new System.Windows.Forms.TextBox();
            this.splitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hhBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mmBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ssBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fogCheckBox = new System.Windows.Forms.CheckBox();
            this.distortionCheckBox = new System.Windows.Forms.CheckBox();
            this.shakeCheckBox = new System.Windows.Forms.CheckBox();
            this.rainCheckBox = new System.Windows.Forms.CheckBox();
            this.glareCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mpRadioButton = new System.Windows.Forms.RadioButton();
            this.peRadioButton = new System.Windows.Forms.RadioButton();
            this.spRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.viewTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.markButton = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.markedDisplay = new System.Windows.Forms.Label();
            this.formatCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.outputFileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // axVLCPlugin
            // 
            this.axVLCPlugin.Enabled = true;
            this.axVLCPlugin.Location = new System.Drawing.Point(12, 12);
            this.axVLCPlugin.Name = "axVLCPlugin";
            this.axVLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin.OcxState")));
            this.axVLCPlugin.Size = new System.Drawing.Size(640, 480);
            this.axVLCPlugin.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 509);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open Video";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // positionDisplay
            // 
            this.positionDisplay.AutoSize = true;
            this.positionDisplay.Location = new System.Drawing.Point(6, 23);
            this.positionDisplay.Name = "positionDisplay";
            this.positionDisplay.Size = new System.Drawing.Size(27, 13);
            this.positionDisplay.TabIndex = 6;
            this.positionDisplay.Text = "N/A";
            // 
            // fileDisplay
            // 
            this.fileDisplay.AutoSize = true;
            this.fileDisplay.Location = new System.Drawing.Point(6, 16);
            this.fileDisplay.Name = "fileDisplay";
            this.fileDisplay.Size = new System.Drawing.Size(27, 13);
            this.fileDisplay.TabIndex = 8;
            this.fileDisplay.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Save Directory:";
            // 
            // saveLocationBox
            // 
            this.saveLocationBox.Location = new System.Drawing.Point(126, 46);
            this.saveLocationBox.Name = "saveLocationBox";
            this.saveLocationBox.Size = new System.Drawing.Size(333, 20);
            this.saveLocationBox.TabIndex = 10;
            this.saveLocationBox.Text = "C:\\my_output_save_location";
            this.saveLocationBox.TextChanged += new System.EventHandler(this.saveLocationBox_TextChanged);
            // 
            // splitButton
            // 
            this.splitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.splitButton.ForeColor = System.Drawing.Color.Black;
            this.splitButton.Location = new System.Drawing.Point(578, 918);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(75, 23);
            this.splitButton.TabIndex = 11;
            this.splitButton.Text = "Split Video";
            this.splitButton.UseVisualStyleBackColor = false;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Starting Military Time:";
            // 
            // hhBox
            // 
            this.hhBox.Location = new System.Drawing.Point(126, 143);
            this.hhBox.Name = "hhBox";
            this.hhBox.Size = new System.Drawing.Size(50, 20);
            this.hhBox.TabIndex = 13;
            this.hhBox.Text = "00";
            this.hhBox.TextChanged += new System.EventHandler(this.hhBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "(HH)";
            // 
            // mmBox
            // 
            this.mmBox.Location = new System.Drawing.Point(181, 143);
            this.mmBox.Name = "mmBox";
            this.mmBox.Size = new System.Drawing.Size(51, 20);
            this.mmBox.TabIndex = 15;
            this.mmBox.Text = "00";
            this.mmBox.TextChanged += new System.EventHandler(this.mmBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "(MM)";
            // 
            // ssBox
            // 
            this.ssBox.Location = new System.Drawing.Point(239, 143);
            this.ssBox.Name = "ssBox";
            this.ssBox.Size = new System.Drawing.Size(48, 20);
            this.ssBox.TabIndex = 17;
            this.ssBox.Text = "00";
            this.ssBox.TextChanged += new System.EventHandler(this.ssBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "(SS)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.fogCheckBox);
            this.groupBox1.Controls.Add(this.distortionCheckBox);
            this.groupBox1.Controls.Add(this.shakeCheckBox);
            this.groupBox1.Controls.Add(this.rainCheckBox);
            this.groupBox1.Controls.Add(this.glareCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(132, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 53);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // fogCheckBox
            // 
            this.fogCheckBox.AutoSize = true;
            this.fogCheckBox.Location = new System.Drawing.Point(126, 25);
            this.fogCheckBox.Name = "fogCheckBox";
            this.fogCheckBox.Size = new System.Drawing.Size(44, 17);
            this.fogCheckBox.TabIndex = 4;
            this.fogCheckBox.Text = "Fog";
            this.fogCheckBox.UseVisualStyleBackColor = true;
            this.fogCheckBox.CheckedChanged += new System.EventHandler(this.fogCheckBox_CheckedChanged);
            // 
            // distortionCheckBox
            // 
            this.distortionCheckBox.AutoSize = true;
            this.distortionCheckBox.Location = new System.Drawing.Point(244, 25);
            this.distortionCheckBox.Name = "distortionCheckBox";
            this.distortionCheckBox.Size = new System.Drawing.Size(70, 17);
            this.distortionCheckBox.TabIndex = 3;
            this.distortionCheckBox.Text = "Distortion";
            this.distortionCheckBox.UseVisualStyleBackColor = true;
            this.distortionCheckBox.CheckedChanged += new System.EventHandler(this.distortionCheckBox_CheckedChanged);
            // 
            // shakeCheckBox
            // 
            this.shakeCheckBox.AutoSize = true;
            this.shakeCheckBox.Location = new System.Drawing.Point(176, 25);
            this.shakeCheckBox.Name = "shakeCheckBox";
            this.shakeCheckBox.Size = new System.Drawing.Size(65, 17);
            this.shakeCheckBox.TabIndex = 2;
            this.shakeCheckBox.Text = "Shaking";
            this.shakeCheckBox.UseVisualStyleBackColor = true;
            this.shakeCheckBox.CheckedChanged += new System.EventHandler(this.shakeCheckBox_CheckedChanged);
            // 
            // rainCheckBox
            // 
            this.rainCheckBox.AutoSize = true;
            this.rainCheckBox.Location = new System.Drawing.Point(72, 25);
            this.rainCheckBox.Name = "rainCheckBox";
            this.rainCheckBox.Size = new System.Drawing.Size(48, 17);
            this.rainCheckBox.TabIndex = 1;
            this.rainCheckBox.Text = "Rain";
            this.rainCheckBox.UseVisualStyleBackColor = true;
            this.rainCheckBox.CheckedChanged += new System.EventHandler(this.rainCheckBox_CheckedChanged);
            // 
            // glareCheckBox
            // 
            this.glareCheckBox.AutoSize = true;
            this.glareCheckBox.Location = new System.Drawing.Point(15, 25);
            this.glareCheckBox.Name = "glareCheckBox";
            this.glareCheckBox.Size = new System.Drawing.Size(51, 17);
            this.glareCheckBox.TabIndex = 0;
            this.glareCheckBox.Text = "Glare";
            this.glareCheckBox.UseVisualStyleBackColor = true;
            this.glareCheckBox.CheckedChanged += new System.EventHandler(this.glareCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nightRadioButton);
            this.groupBox2.Controls.Add(this.dayRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 53);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Day/Night";
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(56, 19);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(50, 17);
            this.nightRadioButton.TabIndex = 1;
            this.nightRadioButton.TabStop = true;
            this.nightRadioButton.Text = "Night";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            this.nightRadioButton.CheckedChanged += new System.EventHandler(this.nightRadioButton_CheckedChanged);
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Checked = true;
            this.dayRadioButton.Location = new System.Drawing.Point(6, 19);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(44, 17);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Day";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.dayRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 754);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 144);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split Options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mpRadioButton);
            this.groupBox4.Controls.Add(this.peRadioButton);
            this.groupBox4.Controls.Add(this.spRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(482, 53);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Split Type";
            // 
            // mpRadioButton
            // 
            this.mpRadioButton.AutoSize = true;
            this.mpRadioButton.Location = new System.Drawing.Point(287, 19);
            this.mpRadioButton.Name = "mpRadioButton";
            this.mpRadioButton.Size = new System.Drawing.Size(190, 17);
            this.mpRadioButton.TabIndex = 2;
            this.mpRadioButton.TabStop = true;
            this.mpRadioButton.Text = "Marked Position to Current Position";
            this.mpRadioButton.UseVisualStyleBackColor = true;
            this.mpRadioButton.CheckedChanged += new System.EventHandler(this.mpRadioButton_CheckedChanged);
            // 
            // peRadioButton
            // 
            this.peRadioButton.AutoSize = true;
            this.peRadioButton.Location = new System.Drawing.Point(148, 19);
            this.peRadioButton.Name = "peRadioButton";
            this.peRadioButton.Size = new System.Drawing.Size(133, 17);
            this.peRadioButton.TabIndex = 1;
            this.peRadioButton.TabStop = true;
            this.peRadioButton.Text = "Current Position to End";
            this.peRadioButton.UseVisualStyleBackColor = true;
            this.peRadioButton.CheckedChanged += new System.EventHandler(this.peRadioButton_CheckedChanged);
            // 
            // spRadioButton
            // 
            this.spRadioButton.AutoSize = true;
            this.spRadioButton.Checked = true;
            this.spRadioButton.Location = new System.Drawing.Point(6, 19);
            this.spRadioButton.Name = "spRadioButton";
            this.spRadioButton.Size = new System.Drawing.Size(136, 17);
            this.spRadioButton.TabIndex = 0;
            this.spRadioButton.TabStop = true;
            this.spRadioButton.Text = "Start to Current Position";
            this.spRadioButton.UseVisualStyleBackColor = true;
            this.spRadioButton.CheckedChanged += new System.EventHandler(this.spRadioButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.positionDisplay);
            this.groupBox5.Location = new System.Drawing.Point(526, 603);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 53);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Position";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.formatCheckBox);
            this.groupBox6.Controls.Add(this.dayTextBox);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.monthTextBox);
            this.groupBox6.Controls.Add(this.monthLabel);
            this.groupBox6.Controls.Add(this.yearTextBox);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.viewTextBox);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.saveLocationBox);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.ssBox);
            this.groupBox6.Controls.Add(this.hhBox);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.mmBox);
            this.groupBox6.Location = new System.Drawing.Point(12, 544);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(498, 204);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Save Options";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(238, 99);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(50, 20);
            this.dayTextBox.TabIndex = 27;
            this.dayTextBox.TextChanged += new System.EventHandler(this.dayTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "(DD)";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(182, 99);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(50, 20);
            this.monthTextBox.TabIndex = 25;
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(190, 80);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(31, 13);
            this.monthLabel.TabIndex = 24;
            this.monthLabel.Text = "(MM)";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(126, 99);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(50, 20);
            this.yearTextBox.TabIndex = 23;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "(YYYY)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Starting Date:";
            // 
            // viewTextBox
            // 
            this.viewTextBox.Location = new System.Drawing.Point(126, 176);
            this.viewTextBox.Name = "viewTextBox";
            this.viewTextBox.Size = new System.Drawing.Size(162, 20);
            this.viewTextBox.TabIndex = 20;
            this.viewTextBox.TextChanged += new System.EventHandler(this.viewTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "View Indicator:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fileDisplay);
            this.groupBox7.Location = new System.Drawing.Point(93, 498);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(417, 40);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Input File";
            // 
            // markButton
            // 
            this.markButton.Location = new System.Drawing.Point(556, 509);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(96, 23);
            this.markButton.TabIndex = 24;
            this.markButton.Text = "Mark Position";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.markedDisplay);
            this.groupBox8.Location = new System.Drawing.Point(526, 544);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(127, 53);
            this.groupBox8.TabIndex = 23;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Marked Position";
            // 
            // markedDisplay
            // 
            this.markedDisplay.AutoSize = true;
            this.markedDisplay.Location = new System.Drawing.Point(9, 23);
            this.markedDisplay.Name = "markedDisplay";
            this.markedDisplay.Size = new System.Drawing.Size(27, 13);
            this.markedDisplay.TabIndex = 0;
            this.markedDisplay.Text = "N/A";
            // 
            // formatCheckBox
            // 
            this.formatCheckBox.AutoSize = true;
            this.formatCheckBox.Location = new System.Drawing.Point(9, 22);
            this.formatCheckBox.Name = "formatCheckBox";
            this.formatCheckBox.Size = new System.Drawing.Size(228, 17);
            this.formatCheckBox.TabIndex = 28;
            this.formatCheckBox.Text = "Input file in YYYYMMDD_HHMMSS format";
            this.formatCheckBox.UseVisualStyleBackColor = true;
            this.formatCheckBox.CheckedChanged += new System.EventHandler(this.formatCheckBox_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.outputFileLabel);
            this.groupBox9.Location = new System.Drawing.Point(12, 904);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(496, 37);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Output File";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(7, 16);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(27, 13);
            this.outputFileLabel.TabIndex = 0;
            this.outputFileLabel.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 952);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.axVLCPlugin);
            this.Name = "Form1";
            this.Text = "Traffic Video Splitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label positionDisplay;
        private System.Windows.Forms.Label fileDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveLocationBox;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hhBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mmBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ssBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox fogCheckBox;
        private System.Windows.Forms.CheckBox distortionCheckBox;
        private System.Windows.Forms.CheckBox shakeCheckBox;
        private System.Windows.Forms.CheckBox rainCheckBox;
        private System.Windows.Forms.CheckBox glareCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton peRadioButton;
        private System.Windows.Forms.RadioButton spRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button markButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label markedDisplay;
        private System.Windows.Forms.RadioButton mpRadioButton;
        private System.Windows.Forms.TextBox viewTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox formatCheckBox;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label outputFileLabel;
    }
}

