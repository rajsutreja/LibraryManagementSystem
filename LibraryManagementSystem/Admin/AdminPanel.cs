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
    public partial class AdminPanel : Form
    {
        private string adminUsername;

        public AdminPanel()
        {
            InitializeComponent();
        }

        public AdminPanel(string username)
        {
            this.adminUsername = username;
            InitializeComponent();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(0, 122, 204), 5);
            e.Graphics.DrawLine(pen, 18, 200, 900, 200);

            Panel rightLine = new Panel();
            rightLine.BackColor = Color.FromArgb(0, 122, 204);
            rightLine.Width = 2; // thickness of line
            rightLine.Dock = DockStyle.Left; // stick to right side

            panel1.Controls.Add(rightLine);
            this.Controls.Add(panel1);
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            label1.Text +=adminUsername+"!";
           
            
            lblOverview.Text = "As an administrator, you hold the keys to the kingdom of knowledge within our online library system.\n" +
                           "This dashboard serves as your command center, providing you with comprehensive insights and\n" +
                           "control over the vast repository of resources at your disposal.\n" +
                           "With a few clicks, you can manage user accounts, as well as book shelf storages.";
           
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            mainForm main = new mainForm();
            main.Show();
            this.Hide();
        }

        private void Stud_Sec_Click(object sender, EventArgs e)
        {
            AdminIssueBookForm AD_studSec = new AdminIssueBookForm(adminUsername);
            AD_studSec.Show();
            this.Hide();
        }

        private void Book_Shelve_Click(object sender, EventArgs e)
        {
            AdminBookShelveForm bookShelveForm = new AdminBookShelveForm(adminUsername);
            bookShelveForm.Show();
            this.Hide();
        }

        private void Issue_Book_Click(object sender, EventArgs e)
        {
            AdminIssueBook issueBookForm = new AdminIssueBook(adminUsername);
            issueBookForm.Show();
            this.Hide();
        }
    }
}

