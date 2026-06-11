using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSysterm
{
    public partial class AdminUpdateBook : Form
    {   private int bid;
        private byte[] imageBytes;
        private String adminUsername;
        public AdminUpdateBook(int b_id, string b_title, string b_author, string b_isbn, string b_category, int b_qty, string adminUsername)
        {
            InitializeComponent();
            this.bid=b_id;
            this.adminUsername = adminUsername;
            id.Text = b_id.ToString();
            title.Text = b_title;
            author.Text = b_author;
            isbn.Text = b_isbn;
            category.Text = b_category;
            qty.Text = b_qty.ToString();
        }

        private void Update_data_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrWhiteSpace(title.Text) ||
               string.IsNullOrWhiteSpace(author.Text) ||
               string.IsNullOrWhiteSpace(isbn.Text) ||
               string.IsNullOrWhiteSpace(category.Text) ||
               string.IsNullOrWhiteSpace(qty.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            DATABASE db = new DATABASE();

            string query;
            int result;

            if (imageBytes != null) 
            {
                query = @"UPDATE Books 
                  SET b_title=@t, b_author=@a, b_isbn=@i, b_category=@c, b_qty=@q, Book_Image=@img 
                  WHERE b_id=@id";

                result = db.ExecuteQuery(query,
                    ("@t", title.Text),
                    ("@a", author.Text),
                    ("@i", isbn.Text),
                    ("@c", category.Text),
                    ("@q", int.Parse(qty.Text)),
                    ("@id", bid),
                    ("@img", imageBytes)
                );
            }
            else //  no new image → don’t update image column
            {
                query = @"UPDATE Books 
                  SET b_title=@t, b_author=@a, b_isbn=@i, b_category=@c, b_qty=@q 
                  WHERE b_id=@id";

                result = db.ExecuteQuery(query,
                    ("@t", title.Text),
                    ("@a", author.Text),
                    ("@i", isbn.Text),
                    ("@c", category.Text),
                    ("@q", int.Parse(qty.Text)),
                    ("@id", bid)
                );
            }

            if (result !=-1 )
            {
                MessageBox.Show("Book updated successfully!");
            }
        }

        private void AdminUpdateBook_Load(object sender, EventArgs e)
        {
            DATABASE db = new DATABASE();

            string query = $"SELECT Book_Image FROM Books WHERE b_id = {bid}";

            DataTable dt = db.LoadBooks(query);

            if (dt.Rows.Count > 0 && dt.Rows[0]["Book_Image"] != DBNull.Value)
            {
                byte[] img = (byte[])dt.Rows[0]["Book_Image"];

                using (MemoryStream ms = new MemoryStream(img))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null; // no image
            }
        }
        

        private void previous_Click(object sender, EventArgs e)
        {
            AdminManageBooks adm_mng_book=new AdminManageBooks(adminUsername);
            adm_mng_book.Show();
            this.Hide();
        }
           // store image for DB
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Book Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Show image in PictureBox
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Convert image to byte[] (for database)
                imageBytes = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
}
