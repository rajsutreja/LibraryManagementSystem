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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;      
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
               CenterPanel();
        }
        private void mainForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }



    

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StudentRegistration_Click(object sender, EventArgs e)
        {
            StudentRegistrationForm srf = new StudentRegistrationForm();
            srf.Show();
            this.Hide();
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            StudentLoginForm slf = new StudentLoginForm();
            slf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }
    }
}
