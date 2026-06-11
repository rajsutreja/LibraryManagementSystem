namespace LibraryManagementSysterm
{
    partial class StudentIssueBookShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.DataGridViewButtonColumn();
            this.issue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet8 = new LibraryManagementSysterm.LibraryDataSet8();
            this.book_IssuesTableAdapter = new LibraryManagementSysterm.LibraryDataSet8TableAdapters.Book_IssuesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(381, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Issue Book";
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSysterm.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(-2, 0);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(62, 53);
            this.previous.TabIndex = 7;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
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
            this.student_id,
            this.book_id,
            this.issue_date,
            this.return_date,
            this.due_date});
            this.dataGridView1.DataSource = this.bookIssuesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 499);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Return
            // 
            this.Return.DataPropertyName = "Return";
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
            // student_id
            // 
            this.student_id.DataPropertyName = "student_id";
            this.student_id.HeaderText = "student_id";
            this.student_id.MinimumWidth = 6;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "issue_date";
            this.issue_date.HeaderText = "issue_date";
            this.issue_date.MinimumWidth = 6;
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
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
            // _3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stud_issue_book_disp";
            this.Load += new System.EventHandler(this.Stud_issue_book_disp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet8 libraryDataSet8;
        private System.Windows.Forms.BindingSource bookIssuesBindingSource;
        private LibraryDataSet8TableAdapters.Book_IssuesTableAdapter book_IssuesTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
    }
}