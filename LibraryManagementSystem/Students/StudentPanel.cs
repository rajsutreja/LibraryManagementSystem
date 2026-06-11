using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class StudentPanel : Form
    {
        private string usrnm;
      
        public StudentPanel(String username)
        {
            InitializeComponent();
            label2.Text += username + "!";
            this.usrnm = username;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
           
        }

        private void yourAC_Click(object sender, EventArgs e)
        {
            AccountDetails ac= new AccountDetails(usrnm);
            ac.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void booksshelve_Click(object sender, EventArgs e)
        {
           

            StudentBookSectionForm shelve = new StudentBookSectionForm(usrnm);
            shelve.Show();
            this.Hide();
        }

        private void issuedbooks_Click(object sender, EventArgs e)
        {
            //Stud_IssueBooks_Disp IB=new Stud_IssueBooks_Disp(usrnm);
            //IB.Show();
            //this.Hide();
            StudentIssueBookShow issue=new StudentIssueBookShow(usrnm);
            issue.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            chatbot chat = new chatbot(usrnm);
            chat.Show();
            this.Hide();
        }
    }
}

