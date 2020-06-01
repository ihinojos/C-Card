using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Card
{
    public partial class LogIn : Form
    {

        private readonly SqlConnection sql;

        public LogIn()
        {
            InitializeComponent();
            sql = new SqlConnection(Data.cn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && maskedTextBox1.Text != "")
            {
                //FirstRun();
                UserLogIn(textBox1.Text, maskedTextBox1.Text);
                this.Hide();
            }
        }

        private void FirstRun()
        {
            string pass = Password.Hash("root");
            string query = "INSERT INTO [USERS] ([UserId], [Name], [Password]) VALUES ('antdr','Isaí Hinojos','"+pass+"')";
            SqlCommand command = new SqlCommand(query, sql);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        private void UserLogIn(string user, string password)
        {
            string queryString = "SELECT * FROM [Users] WHERE [UserId] = '" + user + "'";
            SqlCommand command = new SqlCommand(queryString, sql);
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string hash = reader[2].ToString();
                reader.Close();
                if (Password.Verify(password, hash))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var instance = Controller.GetInstance().mainView;
                    if (instance != null) instance.Dispose();
                    instance = Controller.GetInstance().mainView = new Views.MainView();
                    instance.Show();
                    Cursor.Current = Cursors.Default;
                    Visible = false;
                    maskedTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Wrong password.");
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("User not found!");
            }
            command.Connection.Close();
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
    }
}
