namespace LibraryManagementSysterm
{
    partial class StudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yourAC = new System.Windows.Forms.Button();
            this.booksshelve = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.issuedbooks = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(270, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the Students Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(269, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hello, ";
            // 
            // yourAC
            // 
            this.yourAC.BackColor = System.Drawing.SystemColors.Highlight;
            this.yourAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yourAC.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yourAC.Location = new System.Drawing.Point(43, 375);
            this.yourAC.Name = "yourAC";
            this.yourAC.Size = new System.Drawing.Size(168, 123);
            this.yourAC.TabIndex = 7;
            this.yourAC.Text = "Your Account";
            this.yourAC.UseVisualStyleBackColor = false;
            this.yourAC.Click += new System.EventHandler(this.yourAC_Click);
            // 
            // booksshelve
            // 
            this.booksshelve.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.booksshelve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.booksshelve.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksshelve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.booksshelve.Location = new System.Drawing.Point(324, 375);
            this.booksshelve.Name = "booksshelve";
            this.booksshelve.Size = new System.Drawing.Size(168, 123);
            this.booksshelve.TabIndex = 8;
            this.booksshelve.Text = "Books Shelve";
            this.booksshelve.UseVisualStyleBackColor = false;
            this.booksshelve.Click += new System.EventHandler(this.booksshelve_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.IndianRed;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout.Location = new System.Drawing.Point(920, 375);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(168, 123);
            this.logout.TabIndex = 9;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // issuedbooks
            // 
            this.issuedbooks.BackColor = System.Drawing.Color.ForestGreen;
            this.issuedbooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuedbooks.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedbooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.issuedbooks.Location = new System.Drawing.Point(628, 375);
            this.issuedbooks.Name = "issuedbooks";
            this.issuedbooks.Size = new System.Drawing.Size(168, 123);
            this.issuedbooks.TabIndex = 10;
            this.issuedbooks.Text = "Issued Books";
            this.issuedbooks.UseVisualStyleBackColor = false;
            this.issuedbooks.Click += new System.EventHandler(this.issuedbooks_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.close.FlatAppearance.BorderSize = 2;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.close.Location = new System.Drawing.Point(1108, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 31);
            this.close.TabIndex = 25;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1035, 574);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSysterm.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(906, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "AI Chatbot";
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.issuedbooks);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.booksshelve);
            this.Controls.Add(this.yourAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.Load += new System.EventHandler(this.StudentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yourAC;
        private System.Windows.Forms.Button booksshelve;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button issuedbooks;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}