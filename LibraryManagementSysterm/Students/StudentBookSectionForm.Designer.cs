namespace LibraryManagementSysterm
{
    partial class StudentBookSectionForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryManagementSysterm.LibraryDataSet();
            this.booksTableAdapter = new LibraryManagementSysterm.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.previous = new System.Windows.Forms.Button();
            this.libraryDataSet8 = new LibraryManagementSysterm.LibraryDataSet8();
            this.libraryDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bisbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearch.Location = new System.Drawing.Point(329, 157);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(786, 34);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search By Book Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(368, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Book Section";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(964, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Time Duration Book";
            this.label7.Visible = false;
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "7 Day",
            "14 Day",
            "30 Day"});
            this.cmb.Location = new System.Drawing.Point(982, 28);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(146, 33);
            this.cmb.TabIndex = 48;
            this.cmb.Visible = false;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSysterm.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(0, 0);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(62, 53);
            this.previous.TabIndex = 50;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // libraryDataSet8
            // 
            this.libraryDataSet8.DataSetName = "LibraryDataSet8";
            this.libraryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDataSet8BindingSource
            // 
            this.libraryDataSet8BindingSource.DataSource = this.libraryDataSet8;
            this.libraryDataSet8BindingSource.Position = 0;
            // 
            // bqtyDataGridViewTextBoxColumn
            // 
            this.bqtyDataGridViewTextBoxColumn.DataPropertyName = "b_qty";
            this.bqtyDataGridViewTextBoxColumn.HeaderText = "b_qty";
            this.bqtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bqtyDataGridViewTextBoxColumn.Name = "bqtyDataGridViewTextBoxColumn";
            this.bqtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bcategoryDataGridViewTextBoxColumn
            // 
            this.bcategoryDataGridViewTextBoxColumn.DataPropertyName = "b_category";
            this.bcategoryDataGridViewTextBoxColumn.HeaderText = "b_category";
            this.bcategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bcategoryDataGridViewTextBoxColumn.Name = "bcategoryDataGridViewTextBoxColumn";
            this.bcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bisbnDataGridViewTextBoxColumn
            // 
            this.bisbnDataGridViewTextBoxColumn.DataPropertyName = "b_isbn";
            this.bisbnDataGridViewTextBoxColumn.HeaderText = "b_isbn";
            this.bisbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bisbnDataGridViewTextBoxColumn.Name = "bisbnDataGridViewTextBoxColumn";
            this.bisbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bauthorDataGridViewTextBoxColumn
            // 
            this.bauthorDataGridViewTextBoxColumn.DataPropertyName = "b_author";
            this.bauthorDataGridViewTextBoxColumn.HeaderText = "b_author";
            this.bauthorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bauthorDataGridViewTextBoxColumn.Name = "bauthorDataGridViewTextBoxColumn";
            this.bauthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btitleDataGridViewTextBoxColumn
            // 
            this.btitleDataGridViewTextBoxColumn.DataPropertyName = "b_title";
            this.btitleDataGridViewTextBoxColumn.HeaderText = "b_title";
            this.btitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.btitleDataGridViewTextBoxColumn.Name = "btitleDataGridViewTextBoxColumn";
            this.btitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "b_id";
            this.bidDataGridViewTextBoxColumn.HeaderText = "b_id";
            this.bidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Issue
            // 
            this.Issue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Issue.DataPropertyName = "b_id";
            this.Issue.HeaderText = "Issue";
            this.Issue.MinimumWidth = 6;
            this.Issue.Name = "Issue";
            this.Issue.ReadOnly = true;
            this.Issue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Issue.Text = "Issue";
            this.Issue.UseColumnTextForButtonValue = true;
            this.Issue.Width = 120;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Issue,
            this.bidDataGridViewTextBoxColumn,
            this.btitleDataGridViewTextBoxColumn,
            this.bauthorDataGridViewTextBoxColumn,
            this.bisbnDataGridViewTextBoxColumn,
            this.bcategoryDataGridViewTextBoxColumn,
            this.bqtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 435);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // _2SSF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_2SSF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stud_book_sec";
            this.Load += new System.EventHandler(this.Stud_book_sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.BindingSource libraryDataSet8BindingSource;
        private LibraryDataSet8 libraryDataSet8;
        private System.Windows.Forms.DataGridViewTextBoxColumn bqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bisbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Issue;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}