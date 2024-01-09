
namespace PasswordGenerator
{
    partial class frmPasswordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordGenerator));
            fileSystemWatcher1 = new FileSystemWatcher();
            btnGenerate = new Button();
            lblOutput = new Label();
            chkNumerics = new CheckBox();
            lstDeselected = new ListView();
            lblDeselect = new Label();
            cmbDeselectChars = new ComboBox();
            btnDeselectChars = new Button();
            btnReselect = new Button();
            btnReselectAll = new Button();
            nudLength = new NumericUpDown();
            lblLength = new Label();
            panel1 = new Panel();
            chkRandom = new CheckBox();
            pgbStrength = new ProgressBar();
            lblStrength = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(142, 232);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(266, 46);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(43, 21);
            lblOutput.MaximumSize = new Size(300, 50);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 25);
            lblOutput.TabIndex = 1;
            // 
            // chkNumerics
            // 
            chkNumerics.AutoSize = true;
            chkNumerics.Location = new Point(22, 142);
            chkNumerics.Name = "chkNumerics";
            chkNumerics.Size = new Size(154, 29);
            chkNumerics.TabIndex = 2;
            chkNumerics.Text = "Numerics Only";
            chkNumerics.UseVisualStyleBackColor = true;
            chkNumerics.CheckStateChanged += chkNumerics_CheckStateChanged;
            // 
            // lstDeselected
            // 
            lstDeselected.Location = new Point(532, 70);
            lstDeselected.Name = "lstDeselected";
            lstDeselected.Size = new Size(246, 332);
            lstDeselected.TabIndex = 3;
            lstDeselected.UseCompatibleStateImageBehavior = false;
            // 
            // lblDeselect
            // 
            lblDeselect.AutoSize = true;
            lblDeselect.Location = new Point(532, 28);
            lblDeselect.Name = "lblDeselect";
            lblDeselect.Size = new Size(185, 25);
            lblDeselect.TabIndex = 4;
            lblDeselect.Text = "Deselected Characters";
            // 
            // cmbDeselectChars
            // 
            cmbDeselectChars.FormattingEnabled = true;
            cmbDeselectChars.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "+", "{", "}", "[", "]", "|", "\\", "/", ";", ":", "<", ">", ".", "," });
            cmbDeselectChars.Location = new Point(22, 21);
            cmbDeselectChars.Name = "cmbDeselectChars";
            cmbDeselectChars.Size = new Size(256, 33);
            cmbDeselectChars.TabIndex = 5;
            cmbDeselectChars.Text = "Select Characters to Deselect";
            // 
            // btnDeselectChars
            // 
            btnDeselectChars.Location = new Point(296, 19);
            btnDeselectChars.Name = "btnDeselectChars";
            btnDeselectChars.Size = new Size(112, 34);
            btnDeselectChars.TabIndex = 6;
            btnDeselectChars.Text = "Deselect";
            btnDeselectChars.UseVisualStyleBackColor = true;
            btnDeselectChars.Click += btnDeselectChars_Click;
            // 
            // btnReselect
            // 
            btnReselect.Location = new Point(532, 423);
            btnReselect.Name = "btnReselect";
            btnReselect.Size = new Size(112, 34);
            btnReselect.TabIndex = 7;
            btnReselect.Text = "Reselect";
            btnReselect.UseVisualStyleBackColor = true;
            btnReselect.Click += btnReselect_Click;
            // 
            // btnReselectAll
            // 
            btnReselectAll.Location = new Point(650, 423);
            btnReselectAll.Name = "btnReselectAll";
            btnReselectAll.Size = new Size(128, 34);
            btnReselectAll.TabIndex = 8;
            btnReselectAll.Text = "Reselect All";
            btnReselectAll.UseVisualStyleBackColor = true;
            btnReselectAll.Click += btnReselectAll_Click;
            // 
            // nudLength
            // 
            nudLength.Location = new Point(296, 82);
            nudLength.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nudLength.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            nudLength.Name = "nudLength";
            nudLength.Size = new Size(112, 31);
            nudLength.TabIndex = 9;
            nudLength.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(22, 84);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(256, 25);
            lblLength.TabIndex = 10;
            lblLength.Text = "Enter Desired Password Length";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(chkRandom);
            panel1.Controls.Add(nudLength);
            panel1.Controls.Add(chkNumerics);
            panel1.Controls.Add(lblLength);
            panel1.Controls.Add(btnDeselectChars);
            panel1.Controls.Add(cmbDeselectChars);
            panel1.Location = new Point(64, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 187);
            panel1.TabIndex = 11;
            // 
            // chkRandom
            // 
            chkRandom.AutoSize = true;
            chkRandom.Checked = true;
            chkRandom.CheckState = CheckState.Checked;
            chkRandom.Enabled = false;
            chkRandom.Location = new Point(182, 142);
            chkRandom.Name = "chkRandom";
            chkRandom.Size = new Size(106, 29);
            chkRandom.TabIndex = 11;
            chkRandom.Text = "Random";
            chkRandom.UseVisualStyleBackColor = true;
            // 
            // pgbStrength
            // 
            pgbStrength.Location = new Point(286, 423);
            pgbStrength.Name = "pgbStrength";
            pgbStrength.Size = new Size(187, 34);
            pgbStrength.TabIndex = 12;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Location = new Point(82, 432);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(159, 25);
            lblStrength.TabIndex = 13;
            lblStrength.Text = "Password Strength";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblOutput);
            panel2.Location = new Point(64, 298);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 104);
            panel2.TabIndex = 14;
            // 
            // frmPasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(panel2);
            Controls.Add(lblStrength);
            Controls.Add(pgbStrength);
            Controls.Add(panel1);
            Controls.Add(btnReselectAll);
            Controls.Add(btnReselect);
            Controls.Add(lblDeselect);
            Controls.Add(lstDeselected);
            Controls.Add(btnGenerate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPasswordGenerator";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label lblOutput;
        private Button btnGenerate;
        private ListView lstDeselected;
        private CheckBox chkNumerics;
        private Button btnDeselectChars;
        private ComboBox cmbDeselectChars;
        private Label lblDeselect;
        private Label lblLength;
        private NumericUpDown nudLength;
        private Button btnReselectAll;
        private Button btnReselect;
        private Panel panel1;
        private Label lblStrength;
        private ProgressBar pgbStrength;
        private Panel panel2;
        private CheckBox chkRandom;
    }
}
