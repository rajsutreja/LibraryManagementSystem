using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class AdminAddBook : Form
    {
        private String adminUsername;
        public AdminAddBook(String admusrnm)
        {
            InitializeComponent();
            this.adminUsername = admusrnm;
        }
        private byte[] imageBytes;   // store image for DB
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

        private void Add_data_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text) ||
                string.IsNullOrWhiteSpace(author.Text) ||
                string.IsNullOrWhiteSpace(isbn.Text) ||
                string.IsNullOrWhiteSpace(category.Text) ||
                string.IsNullOrWhiteSpace(qty.Text) ||
                imageBytes == null) 
            {
                MessageBox.Show("Please fill in all fields and select an image.");
                return;
            }
            String Query = "INSERT INTO Books (b_title, b_author, b_isbn, b_category, b_qty,Book_Image) VALUES (@title, @author, @isbn, @category,@qty, @image)";
            DATABASE db = new DATABASE();
            int result=db.ExecuteQuery(Query,
                ("@title", title.Text),
                ("@author", author.Text),
                ("@isbn", isbn.Text),
                ("@category", category.Text),
                ("@qty", qty.Text),
                ("@image", imageBytes)
                );
            if (result != -1)
            {
                MessageBox.Show("Book added successfully!");
                title.Text = "";
                author.Text = "";
                isbn.Text = "";
                category.Text = "";
                qty.Text = "";
                pictureBox1.Image = null;
                imageBytes = null;

            }
            else
            {
                MessageBox.Show("Failed to add book. Please try again.");
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            AdminBookShelveForm bookShelveForm = new AdminBookShelveForm(adminUsername);
            bookShelveForm.Show();
            this.Hide();
        }
    }
}

