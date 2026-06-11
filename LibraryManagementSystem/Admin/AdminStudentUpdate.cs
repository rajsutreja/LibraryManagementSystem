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
    public partial class AdminStudentUpdate : Form
    {   private string adminUsername;
        public AdminStudentUpdate(int s_id, string s_username, string s_email, String s_phone, int s_age,String adminnm)
        {
            InitializeComponent();
            // You can use the parameters to initialize the form controls
            id_txt.Text = s_id.ToString();
            username.Text = s_username;
            Email.Text = s_email;
            Mobile.Text = s_phone;
            Age.Text = s_age.ToString();

            this.adminUsername = adminnm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_pannel_Stud_Add_Load(object sender, EventArgs e)
        {

        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminIssueBookForm ad_P_Stud_Sec1 = new AdminIssueBookForm(adminUsername);
            ad_P_Stud_Sec1.Show();
            this.Hide();
        }

    

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
               string.IsNullOrWhiteSpace(Email.Text) ||
               string.IsNullOrWhiteSpace(Mobile.Text) ||
               string.IsNullOrWhiteSpace(Age.Text) 
               )
            {
                MessageBox.Show("Fill all the fields ,Avoid Password field if You Can change to Fill", "Error");
                return;
            }
            if (!string.IsNullOrWhiteSpace(password.Text))
            {
                DialogResult d1=MessageBox.Show("You Can Change the User Password !", "Error",MessageBoxButtons.YesNo);
                if (d1 == DialogResult.No)
                {
                    password.Text = "";
                    return;
                }
            }                             
            String query = "UPDATE Students SET S_Username=@username, S_Email=@Email, S_Password=@Password, S_Mobile=@Mobile, S_Age=@Age WHERE S_ID=@id";
            DATABASE db = new DATABASE();
            string hashedPassword = DATABASE.HashPassword(password.Text);
            int result = db.ExecuteQuery(query, ("@username", username.Text), ("@Email", Email.Text), ("@Password", hashedPassword), ("@Mobile", Mobile.Text), ("@Age", Age.Text), ("@id", id_txt.Text));
            if (result >= 0)
            {
                MessageBox.Show("Student information updated successfully.");
                AdminIssueBookForm ad_P_Stud_Sec1 = new AdminIssueBookForm(adminUsername);
                ad_P_Stud_Sec1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to update student information. Please try again.");
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

