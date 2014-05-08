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
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.peRadioButton = new System.Windows.Forms.RadioButton();
            this.spRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // axVLCPlugin
            // 
            this.axVLCPlugin.Enabled = true;
            this.axVLCPlugin.Location = new System.Drawing.Point(12, 12);
            this.axVLCPlugin.Name = "axVLCPlugin";
            this.axVLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin.OcxState")));
            this.axVLCPlugin.Size = new System.Drawing.Size(639, 480);
            this.axVLCPlugin.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 504);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "File:";
            // 
            // fileDisplay
            // 
            this.fileDisplay.AutoSize = true;
            this.fileDisplay.Location = new System.Drawing.Point(138, 509);
            this.fileDisplay.Name = "fileDisplay";
            this.fileDisplay.Size = new System.Drawing.Size(27, 13);
            this.fileDisplay.TabIndex = 8;
            this.fileDisplay.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Save Directory:";
            // 
            // saveLocationBox
            // 
            this.saveLocationBox.Location = new System.Drawing.Point(125, 24);
            this.saveLocationBox.Name = "saveLocationBox";
            this.saveLocationBox.Size = new System.Drawing.Size(333, 20);
            this.saveLocationBox.TabIndex = 10;
            this.saveLocationBox.Text = "C:\\my_output_save_location";
            // 
            // splitButton
            // 
            this.splitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.splitButton.ForeColor = System.Drawing.Color.Black;
            this.splitButton.Location = new System.Drawing.Point(383, 108);
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
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Starting Military Time:";
            // 
            // hhBox
            // 
            this.hhBox.Location = new System.Drawing.Point(158, 54);
            this.hhBox.Name = "hhBox";
            this.hhBox.Size = new System.Drawing.Size(33, 20);
            this.hhBox.TabIndex = 13;
            this.hhBox.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "(HH)";
            // 
            // mmBox
            // 
            this.mmBox.Location = new System.Drawing.Point(230, 54);
            this.mmBox.Name = "mmBox";
            this.mmBox.Size = new System.Drawing.Size(33, 20);
            this.mmBox.TabIndex = 15;
            this.mmBox.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "(MM)";
            // 
            // ssBox
            // 
            this.ssBox.Location = new System.Drawing.Point(302, 55);
            this.ssBox.Name = "ssBox";
            this.ssBox.Size = new System.Drawing.Size(33, 20);
            this.ssBox.TabIndex = 17;
            this.ssBox.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 57);
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
            this.groupBox1.Size = new System.Drawing.Size(326, 53);
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.splitButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 641);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 145);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.positionDisplay);
            this.groupBox5.Location = new System.Drawing.Point(258, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 53);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.peRadioButton);
            this.groupBox4.Controls.Add(this.spRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 53);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Split Type";
            // 
            // peRadioButton
            // 
            this.peRadioButton.AutoSize = true;
            this.peRadioButton.Location = new System.Drawing.Point(126, 19);
            this.peRadioButton.Name = "peRadioButton";
            this.peRadioButton.Size = new System.Drawing.Size(96, 17);
            this.peRadioButton.TabIndex = 1;
            this.peRadioButton.TabStop = true;
            this.peRadioButton.Text = "Position to End";
            this.peRadioButton.UseVisualStyleBackColor = true;
            // 
            // spRadioButton
            // 
            this.spRadioButton.AutoSize = true;
            this.spRadioButton.Checked = true;
            this.spRadioButton.Location = new System.Drawing.Point(6, 19);
            this.spRadioButton.Name = "spRadioButton";
            this.spRadioButton.Size = new System.Drawing.Size(99, 17);
            this.spRadioButton.TabIndex = 0;
            this.spRadioButton.TabStop = true;
            this.spRadioButton.Text = "Start to Position";
            this.spRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
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
            this.groupBox6.Size = new System.Drawing.Size(469, 91);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Save Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 802);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.fileDisplay);
            this.Controls.Add(this.label1);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label positionDisplay;
        private System.Windows.Forms.Label label1;
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
    }
}

