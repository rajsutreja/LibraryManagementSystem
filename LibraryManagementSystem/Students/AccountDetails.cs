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
    public partial class AccountDetails : Form
    {
        private string accountName;

        public AccountDetails(String accountName)
        {
            InitializeComponent();
            this.accountName = accountName;
        }
        

        private void AccountDetails_Load(object sender, EventArgs e)
        {
           DATABASE db = new DATABASE();

            string username = accountName; 
           
            Student s = db.oneuserdata(username);

            if (s != null)
            {
                id.Text = s.Id.ToString();
                usrnm.Text = s.Username;
                email.Text = s.Email;
                mobile.Text = s.Mobile.ToString();
                age.Text = s.Age.ToString();
                password.Text = s.Password;
            }
        }

        private void StudentRegistration_Click(object sender, EventArgs e)
        {
            EditAccountdetails edit = new EditAccountdetails();
            edit.DataShow(accountName);
            edit.Show();
            this.Hide();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            StudentPanel sp = new StudentPanel(accountName);
            sp.ShowDialog();
            this.Hide();
        }
    }
}
