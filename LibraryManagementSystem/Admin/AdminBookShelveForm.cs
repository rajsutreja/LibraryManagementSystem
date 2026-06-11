using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSysterm
{
   
    public partial class AdminBookShelveForm : Form
    {
        DataTable dt;
        int index = 0;
        private String adminUsername;
        public AdminBookShelveForm(String admusrnm)
        {
            InitializeComponent();
            this.adminUsername = admusrnm;
        }

        private void Add_Book_Click(object sender, EventArgs e)
        {
            AdminAddBook book= new AdminAddBook(adminUsername);
            book.Show();
            this.Hide();
        }

        private void prev_book_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                ShowBook(index);
            }
        }

        private void next_book_Click(object sender, EventArgs e)
        {
            if (index < dt.Rows.Count - 1)
            {
                index++;
                ShowBook(index);
            }
        }

        private void first_book_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowBook(index);
        }

        private void last_book_Click(object sender, EventArgs e)
        {
            index = dt.Rows.Count - 1;
            ShowBook(index);
        }

        private void Book_ShelveForm_Load(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();

            string query = "SELECT * FROM Books";
            dt = db.LoadBooks(query);
            if (dt.Rows.Count > 0)
            {
                index = 0;
                ShowBook(index);
            }
        }
        private void ShowBook(int i)
        {
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[i];
            id.Text = row["b_id"].ToString();
            title.Text = row["b_title"].ToString();
            author.Text = row["b_author"].ToString();
            isbn.Text = row["b_isbn"].ToString();
            category.Text = row["b_category"].ToString();
            qty.Text = row["b_qty"].ToString();

            //Load Image
            if (row["Book_Image"] != DBNull.Value)
            {
                byte[] img = (byte[])row["Book_Image"];
                using (MemoryStream ms = new MemoryStream(img))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void view_manage_book_Click(object sender, EventArgs e)
        {
            AdminManageBooks manageBook = new AdminManageBooks(adminUsername);
            manageBook.Show();
            this.Hide();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel(adminUsername);
            adminPanel.Show();
            this.Hide();

        }
    }
}
