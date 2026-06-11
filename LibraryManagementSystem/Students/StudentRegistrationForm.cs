using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSysterm
{
    public partial class StudentRegistrationForm : Form
    {
        public StudentRegistrationForm()
        {
            InitializeComponent();
        }

        private void StudentRegistrationForm_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
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

        private void previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm main = new mainForm();
            main.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) ||
               string.IsNullOrWhiteSpace(Email.Text) ||
               string.IsNullOrWhiteSpace(password.Text) ||
               string.IsNullOrWhiteSpace(Mobile.Text) ||
               string.IsNullOrWhiteSpace(Age.Text) ||
               string.IsNullOrWhiteSpace(confirmpassword.Text))
            {
                MessageBox.Show("Fill all the fields", "Error");
                return;
            }
            else if (password.Text != confirmpassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (Mobile.Text.Length != 10 || !Mobile.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid Mobile Number. It should be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else if (!int.TryParse(Age.Text, out int age) || age < 0 || age > 120)
            {
                MessageBox.Show("Invalid Age. Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                DATABASE db = new DATABASE();
                string query = @"INSERT INTO Students 
                (S_Username,S_Email,S_Password,S_Mobile,S_Age) 
                VALUES (@user, @mail, @pass, @mobile, @age)";

                string hashedPassword = DATABASE.HashPassword(password.Text);
                int result=db.ExecuteQuery(query,
                    ("@user", username.Text),
                    ("@mail", Email.Text),
                    ("@pass", hashedPassword),
                    ("@mobile", Mobile.Text),
                    ("@age", Age.Text)
                );
                if (result != -1)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentLoginForm loginForm = new StudentLoginForm();
                    loginForm.Show();
                    this.Hide();
                }
               
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            Email.Text = "";
            password.Text = "";
            Mobile.Text = "";
            Age.Text = "";
            confirmpassword.Text = "";
            username.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (confirmpassword.UseSystemPasswordChar == false)
            {
                confirmpassword.UseSystemPasswordChar = true;
            }
            else
            {
                confirmpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
