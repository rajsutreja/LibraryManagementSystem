namespace LibraryManagementSystem
{
    partial class AdminIssueBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.issue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet8 = new LibraryManagementSystem.Data.LibraryDataSet8();
            this.book_IssuesTableAdapter = new LibraryManagementSystem.Data.LibraryDataSet8TableAdapters.Book_IssuesTableAdapter();
            this.qty = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Book_id_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Stud_txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Issue_btn = new System.Windows.Forms.Button();
            this.clear_recoard = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Return,
            this.issue_id,
            this.studentidDataGridViewTextBoxColumn,
            this.book_id,
            this.issuedateDataGridViewTextBoxColumn,
            this.return_date,
            this.due_date});
            this.dataGridView1.DataSource = this.bookIssuesBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Return
            // 
            this.Return.DataPropertyName = "issue_id";
            this.Return.HeaderText = "Return";
            this.Return.MinimumWidth = 6;
            this.Return.Name = "Return";
            this.Return.ReadOnly = true;
            this.Return.Text = "Return";
            this.Return.UseColumnTextForButtonValue = true;
            // 
            // issue_id
            // 
            this.issue_id.DataPropertyName = "issue_id";
            this.issue_id.HeaderText = "issue_id";
            this.issue_id.MinimumWidth = 6;
            this.issue_id.Name = "issue_id";
            this.issue_id.ReadOnly = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            // 
            // issuedateDataGridViewTextBoxColumn
            // 
            this.issuedateDataGridViewTextBoxColumn.DataPropertyName = "issue_date";
            this.issuedateDataGridViewTextBoxColumn.HeaderText = "issue_date";
            this.issuedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issuedateDataGridViewTextBoxColumn.Name = "issuedateDataGridViewTextBoxColumn";
            this.issuedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // return_date
            // 
            this.return_date.DataPropertyName = "return_date";
            this.return_date.HeaderText = "return_date";
            this.return_date.MinimumWidth = 6;
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            // 
            // due_date
            // 
            this.due_date.DataPropertyName = "due_date";
            this.due_date.HeaderText = "due_date";
            this.due_date.MinimumWidth = 6;
            this.due_date.Name = "due_date";
            this.due_date.ReadOnly = true;
            // 
            // bookIssuesBindingSource
            // 
            this.bookIssuesBindingSource.DataMember = "Book_Issues";
            this.bookIssuesBindingSource.DataSource = this.libraryDataSet8;
            // 
            // libraryDataSet8
            // 
            this.libraryDataSet8.DataSetName = "LibraryDataSet8";
            this.libraryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_IssuesTableAdapter
            // 
            this.book_IssuesTableAdapter.ClearBeforeFill = true;
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qty.ForeColor = System.Drawing.SystemColors.Highlight;
            this.qty.Location = new System.Drawing.Point(651, 297);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(83, 25);
            this.qty.TabIndex = 38;
            this.qty.Text = "No Data";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.author.ForeColor = System.Drawing.SystemColors.Highlight;
            this.author.Location = new System.Drawing.Point(651, 254);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(83, 25);
            this.author.TabIndex = 37;
            this.author.Text = "No Data";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(651, 206);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(83, 25);
            this.title.TabIndex = 36;
            this.title.Text = "No Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(554, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Qty:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(554, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Author:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(554, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(122, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(122, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mobile:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(122, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(554, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Book ID:";
            // 
            // Book_id_Search
            // 
            this.Book_id_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Book_id_Search.Location = new System.Drawing.Point(559, 138);
            this.Book_id_Search.Name = "Book_id_Search";
            this.Book_id_Search.Size = new System.Drawing.Size(189, 34);
            this.Book_id_Search.TabIndex = 28;
            this.Book_id_Search.TextChanged += new System.EventHandler(this.Book_id_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(134, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Student ID:";
            // 
            // Stud_txt_Search
            // 
            this.Stud_txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Stud_txt_Search.Location = new System.Drawing.Point(129, 138);
            this.Stud_txt_Search.Name = "Stud_txt_Search";
            this.Stud_txt_Search.Size = new System.Drawing.Size(189, 34);
            this.Stud_txt_Search.TabIndex = 26;
            this.Stud_txt_Search.TextChanged += new System.EventHandler(this.Stud_txt_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(233, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "Admin Panel - Issue Book Section";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(935, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 42;
            this.button1.Text = "Clear Filed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Issue_btn
            // 
            this.Issue_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Issue_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Issue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Issue_btn.ForeColor = System.Drawing.Color.White;
            this.Issue_btn.Location = new System.Drawing.Point(935, 132);
            this.Issue_btn.Name = "Issue_btn";
            this.Issue_btn.Size = new System.Drawing.Size(153, 48);
            this.Issue_btn.TabIndex = 41;
            this.Issue_btn.Text = "Issue";
            this.Issue_btn.UseVisualStyleBackColor = false;
            this.Issue_btn.Click += new System.EventHandler(this.Issue_btn_Click);
            // 
            // clear_recoard
            // 
            this.clear_recoard.BackColor = System.Drawing.Color.IndianRed;
            this.clear_recoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_recoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear_recoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clear_recoard.ForeColor = System.Drawing.Color.White;
            this.clear_recoard.Location = new System.Drawing.Point(935, 273);
            this.clear_recoard.Name = "clear_recoard";
            this.clear_recoard.Size = new System.Drawing.Size(153, 56);
            this.clear_recoard.TabIndex = 40;
            this.clear_recoard.Text = "Delete Return Books Records";
            this.clear_recoard.UseVisualStyleBackColor = false;
            this.clear_recoard.Click += new System.EventHandler(this.clear_recoard_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.age.ForeColor = System.Drawing.SystemColors.Highlight;
            this.age.Location = new System.Drawing.Point(213, 297);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(83, 25);
            this.age.TabIndex = 45;
            this.age.Text = "No Data";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mobile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mobile.Location = new System.Drawing.Point(213, 254);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(83, 25);
            this.mobile.TabIndex = 44;
            this.mobile.Text = "No Data";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.name.Location = new System.Drawing.Point(213, 206);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(83, 25);
            this.name.TabIndex = 43;
            this.name.Text = "No Data";
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "7 Day",
            "14 Day",
            "30 Day"});
            this.cmb.Location = new System.Drawing.Point(358, 177);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(146, 33);
            this.cmb.TabIndex = 46;
            this.cmb.Visible = false;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(340, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Time Duration Book";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(1, -1);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(62, 51);
            this.previous.TabIndex = 39;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // AdminIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.age);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Issue_btn);
            this.Controls.Add(this.clear_recoard);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Book_id_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stud_txt_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminIssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adm_pnl_issue_book";
            this.Load += new System.EventHandler(this.Adm_pnl_issue_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.LibraryDataSet8 libraryDataSet8;
        private System.Windows.Forms.BindingSource bookIssuesBindingSource;
        private Data.LibraryDataSet8TableAdapters.Book_IssuesTableAdapter book_IssuesTableAdapter;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Book_id_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Stud_txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Issue_btn;
        private System.Windows.Forms.Button clear_recoard;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridViewButtonColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label7;
    }
}
