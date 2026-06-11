using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSysterm
{
    public partial class AdminStudentAdd : Form
    {   private string adminUsername;
        public AdminStudentAdd(String admusr)
        {
            InitializeComponent();
            this.adminUsername = admusr;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminIssueBookForm ad_P_Stud_Sec1 = new AdminIssueBookForm(adminUsername);
            ad_P_Stud_Sec1.Show();
            this.Hide();
        }

        private void Add_Stud_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
               string.IsNullOrWhiteSpace(Email.Text) ||
               string.IsNullOrWhiteSpace(password.Text) ||
               string.IsNullOrWhiteSpace(Mobile.Text) ||
               string.IsNullOrWhiteSpace(Age.Text)  )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DATABASE db = new DATABASE();
            String query = "INSERT INTO Students (S_Username, S_Email,S_Mobile,S_Age,S_Password) VALUES (@username, @email, @mobile, @age, @password)";
            String HashedPassword = DATABASE.HashPassword(password.Text);
            int result = db.ExecuteQuery(query, ("@username", username.Text), ("@Email", Email.Text), ("@Password", HashedPassword), ("@Mobile", Mobile.Text), ("@Age", Age.Text));
            if (result != -1)
            {
                MessageBox.Show("Student Added Successfully");
                username.Text = "";
                Email.Text = "";
                Mobile.Text = "";
                Age.Text = "";
                password.Text = "";
                username.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (password.UseSystemPasswordChar == false)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }
    }
}
