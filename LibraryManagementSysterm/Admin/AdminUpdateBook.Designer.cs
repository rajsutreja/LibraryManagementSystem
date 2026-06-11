namespace LibraryManagementSysterm
{
    partial class AdminUpdateBook
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
            this.Update_data = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.previous = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_data
            // 
            this.Update_data.BackColor = System.Drawing.SystemColors.Highlight;
            this.Update_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_data.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_data.Location = new System.Drawing.Point(618, 609);
            this.Update_data.Name = "Update_data";
            this.Update_data.Size = new System.Drawing.Size(196, 52);
            this.Update_data.TabIndex = 35;
            this.Update_data.Text = "Update Data";
            this.Update_data.UseVisualStyleBackColor = false;
            this.Update_data.Click += new System.EventHandler(this.Update_data_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(131, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(99, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 52);
            this.label1.TabIndex = 36;
            this.label1.Text = "Admin Panel -Update Book";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.Location = new System.Drawing.Point(618, 144);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(339, 30);
            this.id.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(613, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 48;
            this.label7.Text = "Book ID :";
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.Location = new System.Drawing.Point(618, 571);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(339, 30);
            this.qty.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(613, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Book Qty :";
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.category.Location = new System.Drawing.Point(618, 479);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(339, 30);
            this.category.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(613, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Book Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(613, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Book ISBN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(613, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Book Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(613, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Book Title :";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title.Location = new System.Drawing.Point(618, 225);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(339, 30);
            this.title.TabIndex = 39;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.author.Location = new System.Drawing.Point(618, 308);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(339, 30);
            this.author.TabIndex = 41;
            // 
            // isbn
            // 
            this.isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbn.Location = new System.Drawing.Point(618, 395);
            this.isbn.MaxLength = 20;
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(339, 30);
            this.isbn.TabIndex = 43;
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSysterm.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(-4, -1);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(63, 53);
            this.previous.TabIndex = 50;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Adm_panel_up_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adm_panel_up_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm_panel_up_book";
            this.Load += new System.EventHandler(this.AdminUpdateBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}