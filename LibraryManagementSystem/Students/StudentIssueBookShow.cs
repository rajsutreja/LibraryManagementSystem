using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class StudentIssueBookShow : Form
    {
        private string usrnm;
        public StudentIssueBookShow(String usrnm)
        {
            InitializeComponent();
            this.usrnm = usrnm;
        }
        private void Panelty_book_redline()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["due_date"].Value != DBNull.Value &&
                    row.Cells["return_date"].Value == DBNull.Value)
                {
                    DateTime due = Convert.ToDateTime(row.Cells["due_date"].Value);

                    if (DateTime.Now > due)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }
        private string query;
        private void Stud_issue_book_disp_Load(object sender, EventArgs e)//_3_Load
        {
            // TODO: This line of code loads data into the 'libraryDataSet8.Book_Issues' table. You can move, or remove it, as needed.
            this.book_IssuesTableAdapter.Fill(this.libraryDataSet8.Book_Issues);
            
            DATABASE db = new DATABASE();
            query = $"SELECT issue_id, student_id, book_id, issue_date, return_date,due_date FROM Book_Issues WHERE student_id = (SELECT S_ID FROM Students WHERE S_Username = '{usrnm}')";
            dataGridView1.DataSource = db.LoadBooks(query);
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Sego UI", 13, FontStyle.Bold);
            Panelty_book_redline();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //  Make sure Return button column index = 0 (change if needed)
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                //  Get IDs safely using column names
                int issue_id = Convert.ToInt32(row.Cells["issue_id"].Value);
                int book_id = Convert.ToInt32(row.Cells["book_id"].Value);

                // Check already returned
                DATABASE dbCheck = new DATABASE();
                string checkQuery = "SELECT COUNT(*) FROM Book_Issues WHERE issue_id = @issue_id AND return_date IS NOT NULL";

                int count = Convert.ToInt32(
                    dbCheck.ExecuteScalar(checkQuery, ("@issue_id", issue_id))
                );

                if (count > 0)
                {
                    MessageBox.Show("You have already returned this book!");
                    return;
                }

                //  Due Date + Fine Calculation
                if (row.Cells["due_date"].Value != DBNull.Value)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells["due_date"].Value);
                    DateTime today = DateTime.Now;

                    if (today > dueDate)
                    {
                        int lateDays = (today - dueDate).Days;
                        int fine = lateDays * 5; // ₹5 per day

                        MessageBox.Show(
                            "Late Return!\nDays: " + lateDays + "\nFine: ₹" + fine
                        );
                    }
                }

                //  Return Book
                DATABASE db = new DATABASE();

                string returnQuery = "UPDATE Book_Issues SET return_date = GETDATE() WHERE issue_id = @issue_id";
                int result = db.ExecuteQuery(returnQuery, ("@issue_id", issue_id));

                if (result != -1)
                {
                    //  Increase book quantity
                    string updateBook = "UPDATE Books SET b_qty = b_qty + 1 WHERE b_id = @book_id";
                    db.ExecuteQuery(updateBook, ("@book_id", book_id));

                    MessageBox.Show("Book returned successfully!");
                   



                    dataGridView1.DataSource = db.LoadBooks(query);

                    Panelty_book_redline();
                }
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            StudentPanel sp = new StudentPanel(usrnm);
            sp.Show();
            this.Hide();
        }
    }
}

