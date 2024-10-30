using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VotingSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {

            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        // show voter form
        private void button5_Click(object sender, EventArgs e)
        {
            Voter voter = new Voter();
            this.Hide();
            voter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candidates candidates = new Candidates();
            this.Hide();
            candidates.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            displayVoters();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

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
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
