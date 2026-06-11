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
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
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
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DATABASE dba = new DATABASE();
            if (dba.validstudent(username.Text, password.Text))
            {
                StudentPanel studPanel = new StudentPanel(username.Text);
                studPanel.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only Admin Can Change Your Password");
        }

        private void StudentLoginForm_Load(object sender, EventArgs e)
        {
            
            label3.Text = "Forggot Password!";
            label3.ForeColor = Color.Blue;
            label3.Cursor = Cursors.Hand;

          
    }
    }
}

