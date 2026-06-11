using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
   
    public partial class AdminIssueBook : Form
    {
        private String adnusernm;
        public AdminIssueBook(String adnusernm)
        {
            InitializeComponent();
            this.adnusernm = adnusernm;
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
        private void Adm_pnl_issue_book_Load(object sender, EventArgs e)//_1AF_Load
        {
            // TODO: This line of code loads data into the 'libraryDataSet8.Book_Issues' table. You can move, or remove it, as needed.
            this.book_IssuesTableAdapter.Fill(this.libraryDataSet8.Book_Issues);
            Panelty_book_redline();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevent header click error
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
                
                    this.book_IssuesTableAdapter.Fill(this.libraryDataSet8.Book_Issues);
                    Panelty_book_redline();
                }
            }
        }

        private void Issue_btn_Click(object sender, EventArgs e)
        {

            if (Stud_txt_Search.Text == "" || Book_id_Search.Text == "")
            {
                MessageBox.Show("Enter Student ID and Book ID");
                return;
            }
          

            label7.Visible = true;
            cmb.Visible = true;
            cmb.Focus();
            cmb.DroppedDown = true; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stud_txt_Search.Clear();
            Book_id_Search.Clear();

            name.Text = "No Data";
            mobile.Text = "No Data";
            age.Text = "No Data";

            title.Text = "No Data";
            author.Text = "No Data";
            qty.Text = "No Data";
        }

        private void Stud_txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Stud_txt_Search.Text == "") return;

            string query = $"SELECT S_Username, S_Mobile, S_Age FROM Students WHERE S_ID = '{Stud_txt_Search.Text}'";

            DATABASE db = new DATABASE();
            DataTable dt = db.LoadBooks(query);

            if (dt.Rows.Count > 0)
            {
                name.Text = dt.Rows[0]["S_Username"].ToString();
                mobile.Text = dt.Rows[0]["S_Mobile"].ToString();
                age.Text = dt.Rows[0]["S_Age"].ToString();
            }
            else
            {
                name.Text = "No Data";
                mobile.Text = "No Data";
                age.Text = "No Data";
            }
        }

        private void Book_id_Search_TextChanged(object sender, EventArgs e)
        {
            if (Book_id_Search.Text == "") return;

            string query = $"SELECT b_title, b_author, b_qty FROM Books WHERE b_id = '{Book_id_Search.Text}'";

            DATABASE db = new DATABASE();
            DataTable dt = db.LoadBooks(query);

            if (dt.Rows.Count > 0)
            {
                title.Text = dt.Rows[0]["b_title"].ToString();
                author.Text = dt.Rows[0]["b_author"].ToString();
                qty.Text = dt.Rows[0]["b_qty"].ToString();
            }
            else
            {
                title.Text = "No Data";
                author.Text = "No Data";
                qty.Text = "No Data";
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            string selected_days = cmb.SelectedItem?.ToString();


            int b_qty = qty.Text != "No Data" ? Convert.ToInt32(qty.Text) : 0;
            if (b_qty <= 0)
            {
                MessageBox.Show("This book is currently unavailable. Please Wait Some Time");
                return;
            }

            //user already same book issue to not again issue
            DATABASE dbCheck = new DATABASE();
            int s_id_check = Convert.ToInt32(Stud_txt_Search.Text);
            int b_id_check = Convert.ToInt32(Book_id_Search.Text);
            string checkQuery = $"select count(*) from Book_Issues where student_id = @S_ID and book_id = @B_ID and return_date is null";
            int count = Convert.ToInt32(dbCheck.ExecuteScalar(checkQuery, ("@S_ID", s_id_check), ("@B_ID", b_id_check)));
            if (count > 0)
            {
                MessageBox.Show("You have already issued this book. Please return it before issuing again.");
                label7.Visible = false;
                cmb.Visible = false;
                return;
            }

            if (string.IsNullOrEmpty(selected_days))
            {
                MessageBox.Show("Please select duration");
                return;
            }

            if (!int.TryParse(selected_days.Split(' ')[0], out int days))
            {
                MessageBox.Show("Invalid duration format");
                return;
            }

            if (Stud_txt_Search.Text == "" || Book_id_Search.Text == "")
            {
                MessageBox.Show("Enter Student ID and Book ID");
                return;
            }

            int b_id = Convert.ToInt32(Book_id_Search.Text);
            int s_id = Convert.ToInt32(Stud_txt_Search.Text);

            DATABASE db = new DATABASE();

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
                MessageBox.Show("Book issued for " + days + " days!");
                cmb.Visible=false;
                label7.Visible=false;
            }

            String updateQuery = "update Books set b_qty = b_qty - 1 where b_id = @B_ID";
            db.ExecuteQuery(updateQuery, ("@B_ID", b_id));

            this.book_IssuesTableAdapter.Fill(this.libraryDataSet8.Book_Issues);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminPanel Adp = new AdminPanel(adnusernm);
            Adp.Show();
            this.Hide();
        }

        private void clear_recoard_Click(object sender, EventArgs e)
        {
            DialogResult d1 = MessageBox.Show("Are you sure you want to Returned Book records Delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d1 == DialogResult.Yes)
            {
                String query = "DELETE FROM Book_Issues where return_date is not null";
                DATABASE db = new DATABASE();
                int result = db.ExecuteQuery(query);
                if (result != -1)
                {
                    MessageBox.Show("Returned Book records deleted successfully!");
                    this.book_IssuesTableAdapter.Fill(this.libraryDataSet8.Book_Issues);

                }

            }
        }
    }
}

