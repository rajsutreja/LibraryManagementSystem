namespace LibraryManagementSystem
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.StudentRegistration = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.StudentLogin);
            this.panel1.Controls.Add(this.StudentRegistration);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 662);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(167, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(754, 52);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lakshya Library Management System";
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.HotTrack;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.help.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.help.Location = new System.Drawing.Point(710, 555);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(283, 66);
            this.help.TabIndex = 11;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(92, 555);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 66);
            this.button3.TabIndex = 10;
            this.button3.Text = "Admin Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentLogin
            // 
            this.StudentLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StudentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentLogin.Location = new System.Drawing.Point(710, 424);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(283, 66);
            this.StudentLogin.TabIndex = 9;
            this.StudentLogin.Text = "Student Login";
            this.StudentLogin.UseVisualStyleBackColor = false;
            this.StudentLogin.Click += new System.EventHandler(this.StudentLogin_Click);
            // 
            // StudentRegistration
            // 
            this.StudentRegistration.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StudentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StudentRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentRegistration.Location = new System.Drawing.Point(92, 424);
            this.StudentRegistration.Name = "StudentRegistration";
            this.StudentRegistration.Size = new System.Drawing.Size(270, 66);
            this.StudentRegistration.TabIndex = 8;
            this.StudentRegistration.Text = "Student Registration";
            this.StudentRegistration.UseVisualStyleBackColor = false;
            this.StudentRegistration.Click += new System.EventHandler(this.StudentRegistration_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementSystem.Properties.Resources.Lakshya;
            this.pictureBox2.Location = new System.Drawing.Point(385, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.close.FlatAppearance.BorderSize = 2;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.close.Location = new System.Drawing.Point(1105, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 31);
            this.close.TabIndex = 24;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.minimize.FlatAppearance.BorderSize = 2;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minimize.Location = new System.Drawing.Point(1009, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(46, 31);
            this.minimize.TabIndex = 26;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button8.Location = new System.Drawing.Point(1061, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 31);
            this.button8.TabIndex = 25;
            this.button8.Text = "☐   ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button StudentLogin;
        private System.Windows.Forms.Button StudentRegistration;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button button8;
    }
}
