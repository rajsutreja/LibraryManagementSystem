namespace LibraryManagementSystem
{
    partial class AdminBookShelveForm
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
            this.Add_Book = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prev_book = new System.Windows.Forms.Button();
            this.next_book = new System.Windows.Forms.Button();
            this.first_book = new System.Windows.Forms.Button();
            this.last_book = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.view_manage_book = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Panel -Book Section";
            // 
            // Add_Book
            // 
            this.Add_Book.BackColor = System.Drawing.Color.IndianRed;
            this.Add_Book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Book.Location = new System.Drawing.Point(904, 207);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(196, 113);
            this.Add_Book.TabIndex = 8;
            this.Add_Book.Text = "Add Book";
            this.Add_Book.UseVisualStyleBackColor = false;
            this.Add_Book.Click += new System.EventHandler(this.Add_Book_Click);
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.Location = new System.Drawing.Point(416, 553);
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Size = new System.Drawing.Size(339, 30);
            this.qty.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(411, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Book Qty :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.category.Location = new System.Drawing.Point(416, 461);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(339, 30);
            this.category.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(411, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Book Category :";
            // 
            // isbn
            // 
            this.isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.isbn.Location = new System.Drawing.Point(416, 368);
            this.isbn.MaxLength = 20;
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Size = new System.Drawing.Size(339, 30);
            this.isbn.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(411, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Book ISBN :";
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.author.Location = new System.Drawing.Point(416, 290);
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Size = new System.Drawing.Size(339, 30);
            this.author.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(411, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Book Author :";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title.Location = new System.Drawing.Point(416, 207);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Size = new System.Drawing.Size(339, 30);
            this.title.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(411, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Book Title :";
            // 
            // prev_book
            // 
            this.prev_book.BackColor = System.Drawing.SystemColors.Highlight;
            this.prev_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prev_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prev_book.Location = new System.Drawing.Point(41, 612);
            this.prev_book.Name = "prev_book";
            this.prev_book.Size = new System.Drawing.Size(148, 42);
            this.prev_book.TabIndex = 32;
            this.prev_book.Text = "Previous";
            this.prev_book.UseVisualStyleBackColor = false;
            this.prev_book.Click += new System.EventHandler(this.prev_book_Click);
            // 
            // next_book
            // 
            this.next_book.BackColor = System.Drawing.SystemColors.Highlight;
            this.next_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.next_book.Location = new System.Drawing.Point(239, 612);
            this.next_book.Name = "next_book";
            this.next_book.Size = new System.Drawing.Size(148, 42);
            this.next_book.TabIndex = 33;
            this.next_book.Text = "Next";
            this.next_book.UseVisualStyleBackColor = false;
            this.next_book.Click += new System.EventHandler(this.next_book_Click);
            // 
            // first_book
            // 
            this.first_book.BackColor = System.Drawing.SystemColors.Highlight;
            this.first_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.first_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.first_book.Location = new System.Drawing.Point(435, 612);
            this.first_book.Name = "first_book";
            this.first_book.Size = new System.Drawing.Size(148, 42);
            this.first_book.TabIndex = 34;
            this.first_book.Text = "First";
            this.first_book.UseVisualStyleBackColor = false;
            this.first_book.Click += new System.EventHandler(this.first_book_Click);
            // 
            // last_book
            // 
            this.last_book.BackColor = System.Drawing.SystemColors.Highlight;
            this.last_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.last_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.last_book.Location = new System.Drawing.Point(641, 612);
            this.last_book.Name = "last_book";
            this.last_book.Size = new System.Drawing.Size(148, 42);
            this.last_book.TabIndex = 35;
            this.last_book.Text = "Last";
            this.last_book.UseVisualStyleBackColor = false;
            this.last_book.Click += new System.EventHandler(this.last_book_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id.Location = new System.Drawing.Point(416, 126);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(339, 30);
            this.id.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(411, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Book ID :";
            // 
            // view_manage_book
            // 
            this.view_manage_book.BackColor = System.Drawing.Color.Teal;
            this.view_manage_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_manage_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_manage_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.view_manage_book.Location = new System.Drawing.Point(904, 404);
            this.view_manage_book.Name = "view_manage_book";
            this.view_manage_book.Size = new System.Drawing.Size(196, 113);
            this.view_manage_book.TabIndex = 38;
            this.view_manage_book.Text = "View / Manage Book";
            this.view_manage_book.UseVisualStyleBackColor = false;
            this.view_manage_book.Click += new System.EventHandler(this.view_manage_book_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(0, -1);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(63, 53);
            this.previous.TabIndex = 7;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Adm_Book_ShelveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.view_manage_book);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.last_book);
            this.Controls.Add(this.first_book);
            this.Controls.Add(this.next_book);
            this.Controls.Add(this.prev_book);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.Add_Book);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adm_Book_ShelveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_ShelveForm";
            this.Load += new System.EventHandler(this.Book_ShelveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button Add_Book;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prev_book;
        private System.Windows.Forms.Button next_book;
        private System.Windows.Forms.Button first_book;
        private System.Windows.Forms.Button last_book;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button view_manage_book;
    }
}
