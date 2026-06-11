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
    public partial class chatbot : Form
    {
        private string studentName;
        public chatbot(String studentName)
        {
            InitializeComponent();
            this.studentName = studentName;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            StudentPanel studentPanel = new StudentPanel(studentName);
            studentPanel.Show();
            this.Hide();
        }

        private void chatbot_Load(object sender, EventArgs e)
        {
            richTextBox1.Text="Hello " + studentName + " ! How can i help you .\n";
        }

        private async void Send_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string userMsg = textBox1.Text.Trim();

                AddMessage("You", userMsg);

                // Create AI service object
                aiservies ai = new aiservies();

                // First try local chatbot
                string botReply = GetBotResponse(userMsg);

                //  If not understood → use AI
                if (botReply.Contains("Command not recognized"))
                {
                    botReply = await ai.GetAIResponse(userMsg);
                }

                AddMessage("Bot", botReply);

                textBox1.Clear();
            }
        }
        private void AddMessage(string sender, string message)
        {
            richTextBox1.AppendText($"{sender}: {message}\n");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; 
                Send_btn_Click(sender, e); 
          
            }
        }
        private string GetBotResponse(string message)
        {
            
            string msg = message.ToLower();
            if (msg.Contains("hi") || msg.Contains("hello") || msg.Contains("hey"))
            {
                return "Hello " + studentName + " \nHow can I help you?\n\n" +
                       "-. Issue Book 'title name' for 7/14/30 days .,default 7 day\n" +
                       "-. Return Book 'title name'\n" +
                       "-. My Issued Books show\n" +
                       "-. Categories wise Book Display 'Categories'\n" +
                       "-. All Book Show\n" +
                       "-. Check Fine ";

            }


            else if (msg.Contains("issue book"))
            {
                string bookName = ExtractBookName(message);
                bookName = CleanBookName(bookName);
                int days = ExtractDays(message);

                if (string.IsNullOrWhiteSpace(bookName))
                    return "Use format:\nIssue Book 'C++' for 7 days";

                 string issuemsg = IssueBookFromDB(bookName, days);
                 return issuemsg;
            }

            // RETURN BOOK
            else if (msg.StartsWith("return book"))
            {
                string bookName = ExtractBookName(message);

                if (string.IsNullOrEmpty(bookName))
                    return "Please provide book name.\nExample: Return Book 'BookName'";

               return ReturnBookFromDB(bookName);
            }

            // FINE CHECK
            else if (msg.Contains("fine"))
            {
                return GetFineDetails();
            }

            // ALL BOOKS
            else if (msg.Contains("all book"))
            {
               return GetAllBooks();
            }
            else if (msg.Contains("my issued books") || msg.Contains("my books") ||msg.Contains("books show")||msg.Contains("book show"))
            {
                return GetMyIssuedBooks();
            }
            else if (msg.Contains("categories"))
            {
                string category = ExtractBookName(message);

                if (string.IsNullOrWhiteSpace(category))
                    return "Use format:\nCategories wise Book Display 'Programming'";

                return GetBooksByCategory(category);
            }

            // DEFAULT
            return "Command not recognized.";
        }
        //private string ExtractBookName(string message)
        //{
        //    if (string.IsNullOrWhiteSpace(message))
        //        return "";

        //    // Extract text inside quotes
        //    var match = System.Text.RegularExpressions.Regex.Match(message, @"'([^']*)'");

        //    if (!match.Success)
        //        return "";

        //    string bookName = match.Groups[1].Value;

        //    // 2️ Convert to lowercase
        //    bookName = bookName.ToLower();

        //    // 3️ Remove "for XX days" if user typed inside quotes
        //    bookName = System.Text.RegularExpressions.Regex.Replace(
        //        bookName,
        //        @"for\s*\d+\s*days?",
        //        "",
        //        System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        //    // 4️ Remove extra spaces
        //    bookName = bookName.Trim();

        //    return bookName;
        //}
        private string ExtractBookName(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return "";

            // 1️⃣ Try quoted
            var match = System.Text.RegularExpressions.Regex.Match(message, @"'([^']*)'");
            if (match.Success)
                return match.Groups[1].Value.ToLower().Trim();

            // 2️ Try without quotes (issue/return)
            match = System.Text.RegularExpressions.Regex.Match(
                message.ToLower(),
                @"(issue|return)\s+book\s+(.+?)(\s+for\s+\d+\s*days?)?$"
            );

            if (match.Success)
            {
                string name = match.Groups[2].Value;

                // remove "for XX days"
                name = System.Text.RegularExpressions.Regex.Replace(
                    name,
                    @"for\s*\d+\s*days?",
                    "",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase
                );

                return name.Trim();
            }

            return "";
        }
        private string CleanBookName(string bookName)
        {
            // remove "for XX days" if user typed inside quotes
            return System.Text.RegularExpressions.Regex
                .Replace(bookName, @"for\s*\d+\s*days?", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                .Trim();
        }

        private string IssueBookFromDB(string bookName, int days)
        {
            DATABASE db = new DATABASE();

            try
            {
                // 1️ Get Student ID (SAFE)
                string studentQuery = "SELECT S_ID FROM Students WHERE S_Username = @username";
                object sObj = db.ExecuteScalar(studentQuery, ("@username", studentName));

                if (sObj == null)
                    return "Student not found.";

                int s_id = Convert.ToInt32(sObj);

                //  Get Book ID + Quantity
                string bookQuery = $"SELECT b_id, b_qty FROM Books WHERE b_title = '{bookName}'";
                var dt = db.LoadBooks(bookQuery);

                if (dt.Rows.Count == 0)
                    return " Book not found.";

                int b_id = Convert.ToInt32(dt.Rows[0]["b_id"]);
                int b_qty = Convert.ToInt32(dt.Rows[0]["b_qty"]);

                //  Check Quantity
                if (b_qty <= 0)
                    return "Book is currently unavailable.";

                //  Check Already Issued
                string checkQuery = @"SELECT COUNT(*) FROM Book_Issues 
                              WHERE student_id = @S_ID 
                              AND book_id = @B_ID 
                              AND return_date IS NULL";

                int count = Convert.ToInt32(db.ExecuteScalar(checkQuery,
                                ("@S_ID", s_id),
                                ("@B_ID", b_id)));

                if (count > 0)
                    return "You already issued this book.";


                String QBI = @"INSERT INTO Book_Issues 
                (student_id, book_id, issue_date, due_date)
                VALUES (@S_ID, @B_ID, GETDATE(), DATEADD(DAY, @days, GETDATE()))";

                int result = db.ExecuteQuery(QBI,
                    ("@S_ID", s_id),
                    ("@B_ID", b_id),
                    ("@days", days)
                );

                if (result == -1)
                    return " Failed to issue book.";

                //  Update Quantity
                string updateQuery = "UPDATE Books SET b_qty = b_qty - 1 WHERE b_id = @B_ID";
                db.ExecuteQuery(updateQuery, ("@B_ID", b_id));

                return $"Book issued: {bookName}\n - Days: {days}\n - Due: {DateTime.Now.AddDays(days).ToShortDateString()}";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        private int ExtractDays(string message)
        {
            var match = System.Text.RegularExpressions.Regex.Match(message, @"(\d+)\s*day");
            return match.Success ? int.Parse(match.Groups[1].Value) : 7;
        }

        //return book
        private string ReturnBookFromDB(string bookName)
        {
            DATABASE db = new DATABASE();

            try
            {
                // 1️⃣ Get student ID
                string studentQuery = "SELECT S_ID FROM Students WHERE S_Username = @username";
                object sObj = db.ExecuteScalar(studentQuery, ("@username", studentName));

                if (sObj == null)
                    return "Student not found.";

                int s_id = Convert.ToInt32(sObj);

               
              
                //  Basic safety: escape single quote
                bookName = bookName.Replace("'", "''");

                // 1️ Query (NO parameters)
                string issueQuery = $@"
                SELECT TOP 1 bi.issue_id, bi.book_id, bi.due_date, bi.return_date, b.b_title
                FROM Book_Issues bi
                JOIN Books b ON bi.book_id = b.b_id
                WHERE bi.student_id = {s_id}
                  AND LOWER(b.b_title) LIKE '%{bookName.ToLower()}%'
                ORDER BY bi.issue_id DESC";   // latest record

                DataTable dt = db.LoadBooks(issueQuery);

                if (dt.Rows.Count == 0)
                {
                    return $" No record found for '{bookName}'.";
                }

                // 2️ Extract data
                int issue_id = Convert.ToInt32(dt.Rows[0]["issue_id"]);
                int book_id = Convert.ToInt32(dt.Rows[0]["book_id"]);
                string actualTitle = dt.Rows[0]["b_title"].ToString();

                // 3️ Check already returned
                if (dt.Rows[0]["return_date"] != DBNull.Value)
                {
                    return " You have already returned this book!";
                }

                // 3️ Fine Calculation
                string fineMsg = "";
                if (dt.Rows[0]["due_date"] != DBNull.Value)
                {
                    DateTime dueDate = Convert.ToDateTime(dt.Rows[0]["due_date"]);
                    DateTime today = DateTime.Now;

                    if (today > dueDate)
                    {
                        int lateDays = (today - dueDate).Days;
                        int fine = lateDays * 5;

                        fineMsg = $"\n Late Return!\nDays: {lateDays}\nFine: ₹{fine}";
                    }
                }

                //  Update return_date
                string returnQuery = "UPDATE Book_Issues SET return_date = GETDATE() WHERE issue_id = @issue_id";
                int result = db.ExecuteQuery(returnQuery, ("@issue_id", issue_id));

                if (result == -1)
                    return "Failed to return book.";

                // Increase quantity
                string updateBook = "UPDATE Books SET b_qty = b_qty + 1 WHERE b_id = @book_id";
                db.ExecuteQuery(updateBook, ("@book_id", book_id));

                return $" Book returned: {actualTitle}" + fineMsg;
            }
            catch (Exception ex)
            {
                return " Error  : " + ex.Message;
            }
        }

        //fine
        private string GetFineDetails()
        {
            DATABASE db = new DATABASE();

            try
            {
                // 1️ Get student ID
                string studentQuery = "SELECT S_ID FROM Students WHERE S_Username = @username";
                object sObj = db.ExecuteScalar(studentQuery, ("@username", studentName));

                if (sObj == null)
                    return "❌ Student not found.";

                int s_id = Convert.ToInt32(sObj);

                // 2️ Get all active issued books
                string query = $@"
                SELECT b.b_title AS title, bi.due_date
                FROM Book_Issues bi
                JOIN Books b ON bi.book_id = b.b_id
                WHERE bi.student_id = {s_id}
                  AND bi.return_date IS NULL";

                DataTable dt = db.LoadBooks(query);

                if (dt.Rows.Count == 0)
                    return " No active books. No fine.";

                int totalFine = 0;
                string result = "- Fine Details:\n";

                foreach (DataRow row in dt.Rows)
                {
                    string title = row["title"].ToString();

                    if (row["due_date"] != DBNull.Value)
                    {
                        DateTime dueDate = Convert.ToDateTime(row["due_date"]);
                        DateTime today = DateTime.Now;

                        if (today > dueDate)
                        {
                            int lateDays = (today - dueDate).Days;
                            int fine = lateDays * 5;

                            totalFine += fine;

                            result += $"\n-: {title}\n - Late: {lateDays} days | - ₹{fine}";
                        }
                    }
                }

                if (totalFine == 0)
                    return "No fine. All books are within due date.";

                result += $"\n\n- Total Fine: ₹{totalFine}";
                return result;
            }
            catch (Exception ex)
            {
                return " Error: " + ex.Message;
            }
        }



        //all book show
        private string GetAllBooks()
        {
            DATABASE db = new DATABASE();

            try
            {
                string query = @"
                SELECT b_title AS title, b_author AS author, b_qty AS qty
                FROM Books";

                DataTable dt = db.LoadBooks(query);

                if (dt.Rows.Count == 0)
                    return "-No books available in library.";

                string result = "- Available Books:\n";

                foreach (DataRow row in dt.Rows)
                {
                    string title = row["title"].ToString();
                    string author = row["author"].ToString();
                    int qty = Convert.ToInt32(row["qty"]);

                    string status = qty > 0 ? "- Available" : "- Out of stock";

                    result += $"\n-: {title} - {author}\n-: Qty: {qty} | {status}\n";
                }

                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }


        //category wise book show
        private string GetBooksByCategory(string category)
        {
            DATABASE db = new DATABASE();

            try
            {
                //  basic safety
                category = category.Replace("'", "''").ToLower().Trim();

                string query = $@"
                SELECT b_title AS title, b_author AS author, b_qty AS qty, b_category AS category
                FROM Books
                WHERE LOWER(b_category) LIKE '%{category}%'";

                DataTable dt = db.LoadBooks(query);

                if (dt.Rows.Count == 0)
                    return $"No books found in category '{category}'.";

                string result = $"Books in '{category}' category:\n";

                foreach (DataRow row in dt.Rows)
                {
                    string title = row["title"].ToString();
                    string author = row["author"].ToString();
                    int qty = Convert.ToInt32(row["qty"]);

                    string status = qty > 0 ? " Available" : " Out of stock";

                    result += $"\n-: {title} - {author}\n-: Qty: {qty} | {status}\n";
                }

                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        // My Issued Books show
        private string GetMyIssuedBooks()
        {
            DATABASE db = new DATABASE();

            try
            {
                // 1️⃣ Get student ID
                string studentQuery = "SELECT S_ID FROM Students WHERE S_Username = @username";
                object sObj = db.ExecuteScalar(studentQuery, ("@username", studentName));

                if (sObj == null)
                    return "Student not found.";

                int s_id = Convert.ToInt32(sObj);

                // 2️⃣ Get issued books (NOT returned)
                string query = $@"
                SELECT b.b_title AS title, 
                       bi.issue_date, 
                       bi.due_date
                FROM Book_Issues bi
                JOIN Books b ON bi.book_id = b.b_id
                WHERE bi.student_id = {s_id}
                  AND bi.return_date IS NULL
                ORDER BY bi.issue_date DESC";

                DataTable dt = db.LoadBooks(query);

                if (dt.Rows.Count == 0)
                    return " You have no issued books.";

                string result = " Your Issued Books:\n";

                foreach (DataRow row in dt.Rows)
                {
                    string title = row["title"].ToString();
                    DateTime issueDate = Convert.ToDateTime(row["issue_date"]);

                    string line = $"\n-: {title}\n-: Issued: {issueDate.ToShortDateString()}";

                    // 3️⃣ Due + Remaining / Late
                    if (row["due_date"] != DBNull.Value)
                    {
                        DateTime dueDate = Convert.ToDateTime(row["due_date"]);
                        DateTime today = DateTime.Now;

                        if (today > dueDate)
                        {
                            int lateDays = (today - dueDate).Days;
                            line += $"\n⚠-: Late by {lateDays} days";
                        }
                        else
                        {
                            int remaining = (dueDate - today).Days;
                            line += $"\n-: Due in {remaining} days";
                        }
                    }

                    result += line + "\n";
                }

                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

    }

}
