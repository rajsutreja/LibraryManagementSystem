namespace LibraryManagementSysterm
{
    partial class AdminStudentAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Add_Stud = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.Mobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(296, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Panel - Add Student";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Add_Stud);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.Mobile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(28, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 369);
            this.panel1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::LibraryManagementSysterm.Properties.Resources.password;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(440, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 34);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Add_Stud
            // 
            this.Add_Stud.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Add_Stud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_Stud.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Stud.Location = new System.Drawing.Point(655, 232);
            this.Add_Stud.Name = "Add_Stud";
            this.Add_Stud.Size = new System.Drawing.Size(338, 47);
            this.Add_Stud.TabIndex = 12;
            this.Add_Stud.Text = "Add Data";
            this.Add_Stud.UseVisualStyleBackColor = false;
            this.Add_Stud.Click += new System.EventHandler(this.Add_Stud_btn_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password.Location = new System.Drawing.Point(76, 232);
            this.password.MaxLength = 20;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(338, 34);
            this.password.TabIndex = 10;
            this.password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Age";
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Age.Location = new System.Drawing.Point(655, 157);
            this.Age.MaxLength = 3;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(338, 34);
            this.Age.TabIndex = 6;
            // 
            // Mobile
            // 
            this.Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Mobile.Location = new System.Drawing.Point(76, 144);
            this.Mobile.MaxLength = 10;
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(338, 34);
            this.Mobile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile No";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Email.Location = new System.Drawing.Point(655, 64);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(338, 34);
            this.Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.username.Location = new System.Drawing.Point(76, 63);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(338, 35);
            this.username.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSysterm.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(-1, -2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(63, 53);
            this.previous.TabIndex = 14;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Admin_Panel_Stud_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Panel_Stud_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel_Stud_add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Add_Stud;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Mobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button previous;
    }
}