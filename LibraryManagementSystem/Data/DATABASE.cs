using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //account details form used
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public String Mobile { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
    }



    internal class DATABASE
    {
        public SqlConnection con;
        public DATABASE()
        {
            string cs = ConfigurationManager
               .ConnectionStrings["LibraryDB"]
               .ConnectionString;

            con = new SqlConnection(cs);
        }
        public int ExecuteQuery(string query, params (string, object)[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
               
                    foreach (var p in parameters)
                    {
                        cmd.Parameters.AddWithValue(p.Item1, p.Item2 ?? DBNull.Value);
                    }
                
                int rows = cmd.ExecuteNonQuery();

                //if (rows == 0)
                //{
                //    MessageBox.Show("Insert failed!", "Error");
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return -1;
            }
            finally
            {
                con.Close();

            }
            return 0;
        }
        //login form stud
        public Boolean validstudent(string username, string password)
        {
            try
            {
                con.Open();

                string query = "SELECT S_Password FROM Students WHERE S_Username=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", username);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string storedHash = result.ToString();

                    if (VerifyPassword(password, storedHash))
                    {
                        MessageBox.Show("Login successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid password!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not found!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        //  Hash password
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        //  Verify password
        public static bool VerifyPassword(string inputPassword, string storedHash)
        {
            string inputHash = HashPassword(inputPassword);
            return inputHash == storedHash;
        }


        //account details form used
        public Student oneuserdata(string username)
        {
            Student s = null;

            try
            {
                con.Open();

                string query = "SELECT * FROM Students WHERE S_Username=@user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    s = new Student()
                    {
                        Id = Convert.ToInt32(reader["S_ID"]),
                        Username = reader["S_Username"].ToString(),
                        Email = reader["S_Email"].ToString(),
                        Mobile =reader["S_Mobile"].ToString(),
                        Age = Convert.ToInt32(reader["S_Age"]),
                        Password = reader["S_Password"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
            }
            finally
            {
                con.Close();
            }

            return s;
        }

        //update data
        public int UpdateStudent(String query, params (string, object)[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                foreach (var p in parameters)
                {
                    cmd.Parameters.AddWithValue(p.Item1, p.Item2 ?? DBNull.Value);
                }
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("Update failed!", "Error");
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }


        //Bookshelve form used to show all the books
        public DataTable LoadBooks(String query)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                //string query = "SELECT b_id, b_title, b_author, b_isbn, b_category, b_qty FROM Books";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        //BookShelve form used to return a stud_id value
        public int GetStud_id(String query) {
                   int stud_id = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    stud_id = Convert.ToInt32(reader["S_ID"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally
            {
                con.Close();
            }
            return stud_id;
        }
        public Boolean validAdmin(String username,String password)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Admin WHERE A_Username=@user AND A_Password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Admin login successful!", "Success");
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            finally 
            { con.Close(); }
            return false;
        }

        
        
        //Ad_p_Stud_S delete button used
        public int ExecuteScalar(string query, params (string, object)[] parameters)
        {
            int result = 0;

            
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Item1, param.Item2);
                    }

                    con.Open();
                    object value = cmd.ExecuteScalar();

                    if (value != null)
                    {
                        result = Convert.ToInt32(value);
                    }
                }
            
            con.Close();
            return result;
        }   
    }
}
