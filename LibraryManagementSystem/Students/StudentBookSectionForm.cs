using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagementSysterm
{
    public partial class StudentBookSectionForm : Form
    {private String usernm;
        public StudentBookSectionForm(String usrnm)
        {
            InitializeComponent();
            this.usernm = usrnm;
        }

        private void Stud_book_sec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
            //_2SSF_Load
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                label7.Visible = true;
                cmb.Visible = true;
                cmb.Focus();
                cmb.DroppedDown = true;
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string selected_days = cmb.SelectedItem?.ToString();
        
            //check book quantity
            int b_qty = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
            if (b_qty <= 0)
            {
                MessageBox.Show("This book is currently unavailable. Please Wait Some Time");
                return;
            }
            if (!int.TryParse(selected_days.Split(' ')[0], out int days))
            {
                MessageBox.Show("Invalid duration format");
                return;
            }
            //user already same book issue to not again issue
            DATABASE dbCheck = new DATABASE();
            int s_id_check = Convert.ToInt32(dbCheck.GetStud_id($"select S_ID from Students where S_Username='{usernm}'"));
            int b_id_check = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            string checkQuery = $"select count(*) from Book_Issues where student_id = @S_ID and book_id = @B_ID and return_date is null";
            int count = Convert.ToInt32(dbCheck.ExecuteScalar(checkQuery, ("@S_ID", s_id_check), ("@B_ID", b_id_check)));
            if (count > 0)
            {
                MessageBox.Show("You have already issued this book. Please return it before issuing again.");
                label7.Visible = false;
                cmb.Visible = false;
                return;
            }

            //issue book code
            int b_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            DATABASE db = new DATABASE();
            int s_id = Convert.ToInt32(db.GetStud_id($"select S_ID from Students where S_Username='{usernm}'"));
            try
            {
                //String QBI = $"insert into Book_Issues (student_id,book_id,issue_date)values(@S_ID,@B_ID,GETDATE())";
                //int result = db.ExecuteQuery(QBI, ("@S_ID", s_id), ("@B_ID", b_id));
                String QBI = @"INSERT INTO Book_Issues 
    (student_id, book_id, issue_date, due_date)
    VALUES (@S_ID, @B_ID, GETDATE(), DATEADD(DAY, @days, GETDATE()))";

                int result = db.ExecuteQuery(QBI,
                    ("@S_ID", s_id),
                    ("@B_ID", b_id),
                    ("@days", days)
                );
                if (result != -1)
                {
                    MessageBox.Show("Book issued successfully!");
                    label7.Visible = false;
                    cmb.Visible = false;


                }
                String updateQuery = $"update Books set b_qty = b_qty - 1 where b_id = @B_ID";
                db.ExecuteQuery(updateQuery, ("@B_ID", b_id));
                this.booksTableAdapter.Fill(this.libraryDataSet.Books);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book: " + ex.Message);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Replace("'", "''");
            booksBindingSource.Filter = $"b_title LIKE '%{search}%'";
        }

        private void previous_Click(object sender, EventArgs e)
        {
            StudentPanel sp = new StudentPanel(usernm);
            sp.Show();
            this.Hide();
        }
    }
}
