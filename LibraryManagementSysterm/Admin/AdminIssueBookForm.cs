using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LibraryManagementSysterm
{
    public partial class AdminIssueBookForm : Form
    {
        private string adminUsername;
        public AdminIssueBookForm(String Admin)
        {
            InitializeComponent();
            this.adminUsername = Admin;
        }
        public String query;

        private void Ad_P_Stud_Sec1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet4.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.libraryDataSet4.Students);
            query = "select * from Students";

        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(adminUsername);
            adminPanel.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Replace("'", "''");
            studentsBindingSource.Filter = $"S_Username LIKE '%{search}%'";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DATABASE db = new DATABASE();

                    int s_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);


                    string checkQuery = @"SELECT COUNT(*) FROM Book_Issues  WHERE student_id = @S_ID  AND return_date IS NULL";

                    int count = db.ExecuteScalar(checkQuery, ("@S_ID", s_id));

                    if (count > 0)
                    {
                        MessageBox.Show("Cannot delete. Student has unreturned books.");
                        return;
                    }


                    string deleteBI = @"DELETE FROM Book_Issues  WHERE student_id = @S_ID AND return_date IS NOT NULL";

                    db.ExecuteQuery(deleteBI, ("@S_ID", s_id));




                    string deleteStudent = "DELETE FROM Students WHERE S_ID = @S_ID";

                    int result = db.ExecuteQuery(deleteStudent, ("@S_ID", s_id));

                    if (result >= 0)
                    {
                        MessageBox.Show("Student deleted successfully!");
                        dataGridView1.DataSource = db.LoadBooks(query);

                    }
                    else
                    {
                        MessageBox.Show("Delete failed.");
                    }
                }
            }


            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    int s_id = Convert.ToInt32(row.Cells["S_ID"].Value);
                    String s_username = row.Cells["S_Username"].Value?.ToString();
                    String s_email = row.Cells["S_Email"].Value?.ToString();
                    String s_phone = row.Cells["S_Mobile"].Value?.ToString();
                    int s_age = Convert.ToInt32(row.Cells["S_Age"].Value);

                    AdminStudentUpdate updateStud=new AdminStudentUpdate(s_id, s_username, s_email, s_phone, s_age, adminUsername);
                    updateStud.Show();
                    this.Hide();

                }
            }
        }

        private void Adm_Add_Stud_Click(object sender, EventArgs e)
        {
            AdminStudentAdd addStud = new AdminStudentAdd(adminUsername);
            addStud.Show();
            this.Hide();
        }
    }
}
