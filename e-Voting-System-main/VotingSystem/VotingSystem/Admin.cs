using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace VotingSystem
{
    public partial class Admin : KryptonForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        // Candidate form
        private void loginButton_Click(object sender, EventArgs e)
        {
            Candidates candidates = new Candidates();
            this.Hide();
            candidates.Show();
        }

        // Voter form
        private void voterButton_Click(object sender, EventArgs e)
        {
            Voter voter = new Voter();
            this.Hide();
            voter.Show();
        }

        // EXIT
        private void logoutButton_Click(object sender, EventArgs e)
        {
            var confirmDel = MessageBox.Show("Exit now?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmDel == DialogResult.Yes)
            {
                Close();
                Login login = new Login();
                login.Show();


            }
            else
            {
                MessageBox.Show("Error exiting.", "Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // METHOD DISPLAYING VOTERS
        public void displayVoters()
        {
            string mySqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
            using (MySqlConnection conn = new MySqlConnection(mySqlCon))
            {
                try
                {
                    conn.Open();
                    string selectQuery = " SELECT * FROM voter";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // gets the data from the database to the datagridview
                    voterGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // METHOD DISPLAYING CANDIDATES
        public void displayCandidate()
        {
            string mySqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
            using (MySqlConnection conn = new MySqlConnection(mySqlCon))
            {
                try
                {
                    conn.Open();
                    string selectQuery = " SELECT * FROM candidate";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // gets the data from the database to the datagridview
                    candidateGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            displayCandidate();
            displayVoters();
        }
    }
}
