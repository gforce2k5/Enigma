namespace EnigmaMachine
{
    partial class MainFrm
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
            this.cmbRotor1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlugboard = new System.Windows.Forms.TextBox();
            this.cmdApply = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRightSetting = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMiddleSetting = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRightOffset = new System.Windows.Forms.ComboBox();
            this.cmbLeftSetting = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLeftOffset = new System.Windows.Forms.ComboBox();
            this.cmbRotor3 = new System.Windows.Forms.ComboBox();
            this.cmbMiddleOffset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRotor2 = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.cmdEncode = new System.Windows.Forms.Button();
            this.txtCypher = new System.Windows.Forms.TextBox();
            this.cmdProfiling = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRotor1
            // 
            this.cmbRotor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotor1.FormattingEnabled = true;
            this.cmbRotor1.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbRotor1.Location = new System.Drawing.Point(3, 27);
            this.cmbRotor1.Name = "cmbRotor1";
            this.cmbRotor1.Size = new System.Drawing.Size(121, 21);
            this.cmbRotor1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Left Rotor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdLoad);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdReset);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPlugboard);
            this.panel1.Controls.Add(this.cmdApply);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbRightSetting);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbMiddleSetting);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbRightOffset);
            this.panel1.Controls.Add(this.cmbLeftSetting);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbLeftOffset);
            this.panel1.Controls.Add(this.cmbRotor3);
            this.panel1.Controls.Add(this.cmbMiddleOffset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbRotor2);
            this.panel1.Controls.Add(this.cmbRotor1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 289);
            this.panel1.TabIndex = 2;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Location = new System.Drawing.Point(234, 263);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(75, 23);
            this.cmdLoad.TabIndex = 23;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(153, 263);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 22;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(315, 263);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(75, 23);
            this.cmdReset.TabIndex = 21;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Plugboard";
            // 
            // txtPlugboard
            // 
            this.txtPlugboard.Location = new System.Drawing.Point(211, 238);
            this.txtPlugboard.MaxLength = 26;
            this.txtPlugboard.Name = "txtPlugboard";
            this.txtPlugboard.Size = new System.Drawing.Size(241, 20);
            this.txtPlugboard.TabIndex = 19;
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(396, 263);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(75, 23);
            this.cmdApply.TabIndex = 18;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Setting";
            // 
            // cmbRightSetting
            // 
            this.cmbRightSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRightSetting.FormattingEnabled = true;
            this.cmbRightSetting.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbRightSetting.Location = new System.Drawing.Point(435, 121);
            this.cmbRightSetting.Name = "cmbRightSetting";
            this.cmbRightSetting.Size = new System.Drawing.Size(121, 21);
            this.cmbRightSetting.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Setting";
            // 
            // cmbMiddleSetting
            // 
            this.cmbMiddleSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMiddleSetting.FormattingEnabled = true;
            this.cmbMiddleSetting.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbMiddleSetting.Location = new System.Drawing.Point(208, 121);
            this.cmbMiddleSetting.Name = "cmbMiddleSetting";
            this.cmbMiddleSetting.Size = new System.Drawing.Size(121, 21);
            this.cmbMiddleSetting.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Setting";
            // 
            // cmbRightOffset
            // 
            this.cmbRightOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRightOffset.FormattingEnabled = true;
            this.cmbRightOffset.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbRightOffset.Location = new System.Drawing.Point(435, 211);
            this.cmbRightOffset.Name = "cmbRightOffset";
            this.cmbRightOffset.Size = new System.Drawing.Size(121, 21);
            this.cmbRightOffset.TabIndex = 12;
            // 
            // cmbLeftSetting
            // 
            this.cmbLeftSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeftSetting.FormattingEnabled = true;
            this.cmbLeftSetting.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbLeftSetting.Location = new System.Drawing.Point(3, 121);
            this.cmbLeftSetting.Name = "cmbLeftSetting";
            this.cmbLeftSetting.Size = new System.Drawing.Size(121, 21);
            this.cmbLeftSetting.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Offset";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Offset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Right Rotor";
            // 
            // cmbLeftOffset
            // 
            this.cmbLeftOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeftOffset.FormattingEnabled = true;
            this.cmbLeftOffset.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbLeftOffset.Location = new System.Drawing.Point(3, 211);
            this.cmbLeftOffset.Name = "cmbLeftOffset";
            this.cmbLeftOffset.Size = new System.Drawing.Size(121, 21);
            this.cmbLeftOffset.TabIndex = 7;
            // 
            // cmbRotor3
            // 
            this.cmbRotor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotor3.FormattingEnabled = true;
            this.cmbRotor3.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbRotor3.Location = new System.Drawing.Point(435, 27);
            this.cmbRotor3.Name = "cmbRotor3";
            this.cmbRotor3.Size = new System.Drawing.Size(121, 21);
            this.cmbRotor3.TabIndex = 4;
            // 
            // cmbMiddleOffset
            // 
            this.cmbMiddleOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMiddleOffset.FormattingEnabled = true;
            this.cmbMiddleOffset.Items.AddRange(new object[] {
            "1 A",
            "2 B",
            "3 C",
            "4 D",
            "5 E",
            "6 F",
            "7 G",
            "8 H",
            "9 I",
            "10 J",
            "11 K",
            "12 L",
            "13 M",
            "14 N",
            "15 O",
            "16 P",
            "17 Q",
            "18 R",
            "19 S",
            "20 T",
            "21 U",
            "22 V",
            "23 W",
            "24 X",
            "25 Y",
            "26 Z"});
            this.cmbMiddleOffset.Location = new System.Drawing.Point(208, 211);
            this.cmbMiddleOffset.Name = "cmbMiddleOffset";
            this.cmbMiddleOffset.Size = new System.Drawing.Size(121, 21);
            this.cmbMiddleOffset.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Middle Rotor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Offset";
            // 
            // cmbRotor2
            // 
            this.cmbRotor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotor2.FormattingEnabled = true;
            this.cmbRotor2.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V"});
            this.cmbRotor2.Location = new System.Drawing.Point(208, 27);
            this.cmbRotor2.Name = "cmbRotor2";
            this.cmbRotor2.Size = new System.Drawing.Size(121, 21);
            this.cmbRotor2.TabIndex = 2;
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(28, 318);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(562, 125);
            this.txtText.TabIndex = 3;
            // 
            // cmdEncode
            // 
            this.cmdEncode.Enabled = false;
            this.cmdEncode.Location = new System.Drawing.Point(258, 449);
            this.cmdEncode.Name = "cmdEncode";
            this.cmdEncode.Size = new System.Drawing.Size(75, 23);
            this.cmdEncode.TabIndex = 19;
            this.cmdEncode.Text = "Encode";
            this.cmdEncode.UseVisualStyleBackColor = true;
            this.cmdEncode.Click += new System.EventHandler(this.cmdEncode_Click);
            // 
            // txtCypher
            // 
            this.txtCypher.Location = new System.Drawing.Point(28, 478);
            this.txtCypher.Multiline = true;
            this.txtCypher.Name = "txtCypher";
            this.txtCypher.ReadOnly = true;
            this.txtCypher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCypher.Size = new System.Drawing.Size(562, 125);
            this.txtCypher.TabIndex = 20;
            // 
            // cmdProfiling
            // 
            this.cmdProfiling.Location = new System.Drawing.Point(31, 623);
            this.cmdProfiling.Name = "cmdProfiling";
            this.cmdProfiling.Size = new System.Drawing.Size(75, 23);
            this.cmdProfiling.TabIndex = 21;
            this.cmdProfiling.Text = "Profiling";
            this.cmdProfiling.UseVisualStyleBackColor = true;
            this.cmdProfiling.Click += new System.EventHandler(this.cmdProfiling_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 669);
            this.Controls.Add(this.cmdProfiling);
            this.Controls.Add(this.txtCypher);
            this.Controls.Add(this.cmdEncode);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrm";
            this.Text = "Enigma";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRotor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRotor3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRotor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRightSetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMiddleSetting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRightOffset;
        private System.Windows.Forms.ComboBox cmbLeftSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLeftOffset;
        private System.Windows.Forms.ComboBox cmbMiddleOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button cmdEncode;
        private System.Windows.Forms.TextBox txtCypher;
        private System.Windows.Forms.TextBox txtPlugboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdProfiling;
    }
}