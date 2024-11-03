using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VotingSystem
{
    public partial class Login : Form
    {
        
        public Login()
        {
            // initialize database 
            string mySqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlCon);
            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please connect to the internet.", "Unable to connect to database.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            finally
            {
                mySqlConnection.Close();
                
            }

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Admin and Voter Login

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.Equals(username, "Admin", StringComparison.OrdinalIgnoreCase) && password == "password1234")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else if (string.Equals(username, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Wrong password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mySqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";

                // Voter login with SQL XAMPP database
                using (MySqlConnection conn = new MySqlConnection(mySqlCon))
                {
                    try
                    {
                        conn.Open();

                        // check if username exists
                        string userExistsQuery = "SELECT COUNT(*) FROM voter WHERE username = @username";
                        MySqlCommand userExistsCmd = new MySqlCommand(userExistsQuery, conn);
                        userExistsCmd.Parameters.AddWithValue("@username", username);

                        int userCount = Convert.ToInt32(userExistsCmd.ExecuteScalar());

                        if (userCount == 0)
                        {
                            // username does not exist in the database
                            MessageBox.Show("User does not exist", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // check password matches with username
                            string loginQuery = "SELECT * FROM voter WHERE username = @username AND password = @password";
                            MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn);
                            loginCmd.Parameters.AddWithValue("@username", username);
                            loginCmd.Parameters.AddWithValue("@password", password);

                            MySqlDataReader reader = loginCmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                // voter logged in, open election form
                                this.Hide();
                                Election election = new Election();
                                election.Show();
                            }
                            else
                            {
                                // check password
                                MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

    }
}
