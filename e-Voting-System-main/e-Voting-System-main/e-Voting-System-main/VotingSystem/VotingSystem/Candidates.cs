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
using ComponentFactory.Krypton;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
namespace VotingSystem
{
    public partial class Candidates : KryptonForm
    {
        // initialize database
        private string sqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
        public Candidates()
        {

            InitializeComponent();
            positionCb();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // ADD BUTTON
        private void addButton_Click(object sender, EventArgs e)
        {
            string studName = studentNameBox.Text;
            string position = position_cb.SelectedItem?.ToString();
            string partylist = partyBox.Text;
            string section = sectionBox.Text;
            string level = levelBox.Text;
            string program = programTxtbox.Text;

            // check for whitespaces
            if (string.IsNullOrWhiteSpace(studName) || string.IsNullOrWhiteSpace(position) ||
               string.IsNullOrWhiteSpace(partylist) || string.IsNullOrWhiteSpace(section) ||
               string.IsNullOrWhiteSpace(program) || string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show("Do not leave the values blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // add candidate to database

                using (MySqlConnection conn = new MySqlConnection(sqlCon))
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
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                // get candidate ID
                int candidateId = Convert.ToInt32(kryptonDataGridView1.SelectedRows[0].Cells["ID"].Value);

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
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a candidate to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // select user by ID
            string ID = kryptonDataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

            // update values
            string nPosition = position_cb.SelectedItem?.ToString();
            string nStudName = studentNameBox.Text;
            string nPartylist = partyBox.Text;
            string nSection = sectionBox.Text;
            string nProgram = programTxtbox.Text;
            string nLevel = levelBox.Text;

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
                    kryptonDataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // position cb
        private void positionCb()
        {
            position_cb.Items.AddRange(new string[]
            {
                "President", "Vice-President", "Secretary", "PIO",
                "BSIT REPRESENTATIVE", "BSHM REPRESENTATIVE", "BSCPE REPRESENTATIVE"
            });
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void programTxtbox_TextChanged(object sender, EventArgs e)
        {
            programTxtbox.Text = programTxtbox.Text.ToUpper();
            programTxtbox.SelectionStart = programTxtbox.Text.Length;
        }

        private void sectionBox_TextChanged(object sender, EventArgs e)
        {
            sectionBox.Text = sectionBox.Text.ToUpper();
            sectionBox.SelectionStart = sectionBox.Text.Length;
        }

        private void position_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
