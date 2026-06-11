namespace LibraryManagementSystem
{
    partial class AdminIssueBookForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet4 = new LibraryManagementSystem.Data.LibraryDataSet4();
            this.studentsTableAdapter = new LibraryManagementSystem.Data.LibraryDataSet4TableAdapters.StudentsTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adm_Add_Stud = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.S_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Location = new System.Drawing.Point(0, 0);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(63, 53);
            this.previous.TabIndex = 4;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(258, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Panel - Student Section";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update,
            this.S_ID,
            this.S_Username,
            this.S_Email,
            this.S_Mobile,
            this.S_Age});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 429);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.libraryDataSet4;
            // 
            // libraryDataSet4
            // 
            this.libraryDataSet4.DataSetName = "LibraryDataSet4";
            this.libraryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSearch.Location = new System.Drawing.Point(331, 177);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(561, 34);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search By Username :";
            // 
            // Adm_Add_Stud
            // 
            this.Adm_Add_Stud.BackColor = System.Drawing.SystemColors.Highlight;
            this.Adm_Add_Stud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Adm_Add_Stud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Adm_Add_Stud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Adm_Add_Stud.ForeColor = System.Drawing.SystemColors.Control;
            this.Adm_Add_Stud.Location = new System.Drawing.Point(947, 171);
            this.Adm_Add_Stud.Name = "Adm_Add_Stud";
            this.Adm_Add_Stud.Size = new System.Drawing.Size(171, 52);
            this.Adm_Add_Stud.TabIndex = 11;
            this.Adm_Add_Stud.Text = "Add Student";
            this.Adm_Add_Stud.UseVisualStyleBackColor = false;
            this.Adm_Add_Stud.Click += new System.EventHandler(this.Adm_Add_Stud_Click);
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "S_ID";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.DataPropertyName = "S_ID";
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Change";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // S_ID
            // 
            this.S_ID.DataPropertyName = "S_ID";
            this.S_ID.HeaderText = "S_ID";
            this.S_ID.MinimumWidth = 6;
            this.S_ID.Name = "S_ID";
            this.S_ID.ReadOnly = true;
            // 
            // S_Username
            // 
            this.S_Username.DataPropertyName = "S_Username";
            this.S_Username.HeaderText = "S_Username";
            this.S_Username.MinimumWidth = 6;
            this.S_Username.Name = "S_Username";
            this.S_Username.ReadOnly = true;
            // 
            // S_Email
            // 
            this.S_Email.DataPropertyName = "S_Email";
            this.S_Email.HeaderText = "S_Email";
            this.S_Email.MinimumWidth = 6;
            this.S_Email.Name = "S_Email";
            this.S_Email.ReadOnly = true;
            // 
            // S_Mobile
            // 
            this.S_Mobile.DataPropertyName = "S_Mobile";
            this.S_Mobile.HeaderText = "S_Mobile";
            this.S_Mobile.MinimumWidth = 6;
            this.S_Mobile.Name = "S_Mobile";
            this.S_Mobile.ReadOnly = true;
            // 
            // S_Age
            // 
            this.S_Age.DataPropertyName = "S_Age";
            this.S_Age.HeaderText = "S_Age";
            this.S_Age.MinimumWidth = 6;
            this.S_Age.Name = "S_Age";
            this.S_Age.ReadOnly = true;
            // 
            // Ad_P_Stud_Sec1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 686);
            this.Controls.Add(this.Adm_Add_Stud);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previous);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ad_P_Stud_Sec1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ad_P_Stud_Sec1";
            this.Load += new System.EventHandler(this.Ad_P_Stud_Sec1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.LibraryDataSet4 libraryDataSet4;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Data.LibraryDataSet4TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Adm_Add_Stud;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_Age;
    }
}
