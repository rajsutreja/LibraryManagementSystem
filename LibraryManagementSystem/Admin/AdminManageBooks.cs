using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminManageBooks : Form
    {
        private String adminUsername;
        DataTable dt;
        public AdminManageBooks(String adusrnm)
        {
            InitializeComponent();
            this.adminUsername = adusrnm;
        }
       
        private void Adm_pnl_mng_book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
        }
           
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                int b_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["b_id"].Value);
                int s_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);

                DATABASE db = new DATABASE();
                string checkQuery = @"SELECT COUNT(*) FROM Book_Issues 
                      WHERE book_id = @id AND return_date IS NULL";

                int count = db.ExecuteScalar(checkQuery, ("@id", b_id));

                if (count > 0)
                {
                    MessageBox.Show("Cannot delete. Book is currently issued.");
                    return;
                }



                // delete history (optional)
                string delIssues = "DELETE FROM Book_Issues WHERE book_id = @id";
                db.ExecuteQuery(delIssues, ("@id", b_id));

                // delete book
                string delBook = "DELETE FROM Books WHERE b_id = @id";
                int result = db.ExecuteQuery(delBook, ("@id", b_id));

                if (result != -1)
                {
                    MessageBox.Show("Book deleted successfully");      
                    this.booksTableAdapter.Fill(this.libraryDataSet.Books);

                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {

                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                        int b_id = Convert.ToInt32(row.Cells["b_id"].Value);
                        String b_title = row.Cells["b_title"].Value?.ToString();
                        String b_author = row.Cells["b_author"].Value?.ToString();
                        String b_isbn = row.Cells["b_isbn"].Value?.ToString();
                        String b_category = row.Cells["b_category"].Value?.ToString();
                        int b_qty = Convert.ToInt32(row.Cells["b_qty"].Value);
                        AdminUpdateBook adm_p_UP = new AdminUpdateBook(b_id, b_title, b_author, b_isbn, b_category, b_qty, adminUsername);
                        adm_p_UP.Show();
                        this.Hide();
                    }
                
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminBookShelveForm adm_Book_ShelveForm = new AdminBookShelveForm(adminUsername);
            adm_Book_ShelveForm.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
           
            string search = txtSearch.Text.Replace("'", "''");
            booksBindingSource.Filter = $"b_title LIKE '%{search}%'";
        }
    }
}

