using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSysterm
{
    public partial class EditAccountdetails : Form
    {
        String u1;
        public EditAccountdetails()
        {
            InitializeComponent();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            AccountDetails ad = new AccountDetails(u1);
            ad.ShowDialog();
            this.Hide();
        }
        public void DataShow(string username)
        {        u1 = username;
                
                DATABASE db = new DATABASE();
    
                //string username = this.usrnm.Text; 
    
                Student s = db.oneuserdata(username);
    
                if (s != null)
                {
                    
                    id.Text = s.Id.ToString();
                    usrnm.Text = s.Username;
                    email.Text = s.Email;
                    mobile.Text = s.Mobile;
                    age.Text = s.Age.ToString();
                   
            }
        }
        private void EditAccountdetails_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            usrnm.Text = "";
            email.Text = "";    
            mobile.Text = "";
            age.Text = "";
            password.Text = "";
            usrnm.Focus();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();
            string query;
            int result;

            if (String.IsNullOrWhiteSpace(usrnm.Text) || String.IsNullOrWhiteSpace(email.Text) || String.IsNullOrWhiteSpace(mobile.Text) || String.IsNullOrWhiteSpace(age.Text))
            {
                MessageBox.Show("Please fill in all required fields,Already Your details given to fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(password.Text))
            {
               
                query = "UPDATE Students SET S_Username=@Username, S_Email=@Email, S_Mobile=@Mobile, S_Age=@Age WHERE S_ID=@Id";

                result = db.UpdateStudent(query,
                    ("@Username", usrnm.Text),
                    ("@Email", email.Text),
                    ("@Mobile", mobile.Text),
                    ("@Age", Convert.ToInt32(age.Text)),
                    ("@Id", id.Text)
                );
            }
            else
            {
               
                query = "UPDATE Students SET S_Username=@Username, S_Email=@Email, S_Mobile=@Mobile, S_Age=@Age, S_Password=@Password WHERE S_ID=@Id";

                string hashedPassword = DATABASE.HashPassword(password.Text);

                result = db.UpdateStudent(query,
                    ("@Username", usrnm.Text),
                    ("@Email", email.Text),
                    ("@Mobile", mobile.Text),
                    ("@Age", Convert.ToInt32(age.Text)), 
                    ("@Password", hashedPassword),
                    ("@Id", id.Text)
                );
            }

            if (result > 0)
            {
                MessageBox.Show("updated successfully.", "Success", MessageBoxButtons.OK);
                StudentLoginForm Slf = new StudentLoginForm();
                Slf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to update account details.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
