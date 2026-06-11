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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

            richTextBox1.Text =
             @"- What is Lakshya Library Management System?

              - Lakshya Library Management System is a software application designed to help 
                manage library operations efficiently. It allows librarians to keep track of
                books, students, and book issues/returns.  

              - User Roles in System ?
        
                Mainly two user roles :
                1. Admin / Librarian:
                2. Student

                  -Admin / Librarian:
                        1.Add/remove Students :
                        change student details
                        New student registration
                
                        2.Add/remove Books :
                        change book details
                        New book registration
                
                        3.Search Book:

                        Enter book name or ID
                        View availability status

                        4. Issue Book:

                        Provide your Student ID to admin
                        Book will be issued if available

                        5. Return Book:

                        Return book before due date
                        Contact admin for return process

                        6. Rules:

                        Keep books in good condition
                        Do not damage or lose books
                        Late return may result in fine

                        7. Notes:

                        Each student can issue limited books
                        Book availability depends on stock

                        8. Contact:
                        Library Staff / Admin
                        Phone: 123-456-7890


                -Student:
                        1.Register:
                        Registration process with personal details
        
                        2.Login:
                        Access account with username and password

                        3.Update Profile:
                        Change personal details

                        4.Search Book:
                        Enter book name or ID
                        View availability status

                        5.request Book Issue:
                        Request book issue to admin

                        6. Return Book:
                        Return book before due date
                        Late return per day fine may apply 

                        7. Rules:
                        Keep books in good condition
                       
                        8. Notes:
                        If User Forget the password then contact admin for new password
                 ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


