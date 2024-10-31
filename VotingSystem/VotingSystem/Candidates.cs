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


namespace VotingSystem
{
    public partial class Candidates : Form
    {
        // initialize database
        private string sqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
        public Candidates()
        {            
        InitializeComponent();
        }

        
        // ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string studName = studNameTxt.Text;
            string position = posTxt.Text;
            string partylist = partytxt.Text;
            string section = secTxt.Text;
            string program = progTxt.Text;
            string level = levelTxt.Text;
            // check for whitespaces
            if(string.IsNullOrWhiteSpace(studName) || string.IsNullOrWhiteSpace(position)||
               string.IsNullOrWhiteSpace(partylist) || string.IsNullOrWhiteSpace(section)||
               string.IsNullOrWhiteSpace(program)|| string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Do not leave the values blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // add candidate to database

                using(MySqlConnection conn = new MySqlConnection(sqlCon))
                {
                    try
                    {
                        // variables with @ belong to this file
                        conn.Open();
                        string insertQuery = "INSERT INTO candidate(position, partylist, studentName, section, program, level)" +
                                             "VALUES(@position,@partylist, @studName, @section, @program, @level)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                        // adding values to each variable
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@partylist", partylist);
                        cmd.Parameters.AddWithValue("@studName", studName);
                        cmd.Parameters.AddWithValue("@section", section);
                        cmd.Parameters.AddWithValue("@program", program);
                        cmd.Parameters.AddWithValue("@level", level);
                        cmd.ExecuteNonQuery();

                        // candidate added message
                        MessageBox.Show("Candidate added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayCandidate();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        // DELETE
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // get candidate ID
                int candidateId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // confirm delete
                var confirmDel = MessageBox.Show("Delete candidate?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmDel == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(sqlCon))
                    {
                        try
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM candidate WHERE ID = @candidateId";
                            MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                            cmd.Parameters.AddWithValue("@candidateId", candidateId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Candidate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayCandidate(); // Refresh DataGridView to reflect changes
                            }
                            else
                            {
                                MessageBox.Show("Error: Candidate could not be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a candidate to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // UPDATE
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a candidate to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // select user by ID
            string ID = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

            // update values
            string nPosition = posTxt.Text;
            string nStudName = studNameTxt.Text;
            string nPartylist = partytxt.Text;
            string nSection = secTxt.Text;
            string nProgram = progTxt.Text;
            string nLevel = levelTxt.Text;

            // check empty values
            if (string.IsNullOrWhiteSpace(nPosition) || string.IsNullOrWhiteSpace(nStudName) ||
                string.IsNullOrWhiteSpace(nPartylist) || string.IsNullOrWhiteSpace(nSection) ||
                string.IsNullOrWhiteSpace(nProgram) || string.IsNullOrWhiteSpace(nLevel))
            {
                MessageBox.Show("Do not leave the values blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // update voter values in the database
            using (MySqlConnection conn = new MySqlConnection(sqlCon))
            {
                try
                {
                    conn.Open();
                    string updateQuery = @"UPDATE candidate
                                   SET position = @nPosition,
                                       studentName = @nStudName,
                                       partylist = @nPartylist,
                                       section = @nSection,
                                       program = @nProgram,
                                       level = @nLevel
                                   WHERE ID = @ID";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@nPosition", nPosition);
                    cmd.Parameters.AddWithValue("@nStudName", nStudName);
                    cmd.Parameters.AddWithValue("@nPartylist", nPartylist);
                    cmd.Parameters.AddWithValue("@nSection", nSection);
                    cmd.Parameters.AddWithValue("@nProgram", nProgram);
                    cmd.Parameters.AddWithValue("@nLevel", nLevel);
                    cmd.Parameters.AddWithValue("@ID", ID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Candidate updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        displayCandidate(); // display updated list
                    }
                    else
                    {
                        MessageBox.Show("Error: Candidate could not be updated.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            using (MySqlConnection conn = new MySqlConnection(sqlCon))
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
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // RETURN
        private void button5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        // etc
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void studNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void posTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void partytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void secTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Candidates_Load(object sender, EventArgs e)
        {
            displayCandidate();
        }

        
    }
}
