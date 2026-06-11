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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

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

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            DATABASE dba=new DATABASE();    
           if( dba.validAdmin(username.Text, password.Text))
            { 
                AdminPanel adminPanel = new AdminPanel(username.Text);
                adminPanel.Show();
                this.Hide();
            
            }
        }
    }
}
