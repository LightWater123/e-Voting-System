﻿using System;
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
    public partial class Voter : KryptonForm
    {
        // initialize database
        private string sqlCon = "server=127.0.0.1; user=root; database=votingdata; password=";
        public Voter()
        {
            InitializeComponent();
        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ADD 
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userTxtBox.Text;
            string password = passTxtbox.Text;
            string studentName = studNameTxt.Text;
            string section = secTxtbox.Text;
            string level = levelTxtbox.Text;
            string program = progTxtbox.Text;

            // check empty values
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(section) ||
                string.IsNullOrWhiteSpace(level) || string.IsNullOrWhiteSpace(program))
            {
                MessageBox.Show("Do not leave the values blank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // add voter data to database
                using (MySqlConnection conn = new MySqlConnection(sqlCon))
                {
                    try
                    {
                        conn.Open();
                        // insert command
                        string insertQuery = "INSERT INTO voter(nameStudent, Section, Program, Level, username, password) " +
                                             "VALUES (@studentName, @section, @program, @level, @username, @password)";
                        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@studentName", studentName);
                        cmd.Parameters.AddWithValue("@section", section);
                        cmd.Parameters.AddWithValue("@program", program);
                        cmd.Parameters.AddWithValue("@level", level);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();

                        // candidate added message
                        MessageBox.Show("Voter added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // refresh the datagridview to show updated data
                        displayVoters();
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
                // get v_ID of the voter
                int v_ID = Convert.ToInt32(kryptonDataGridView1.SelectedRows[0].Cells["v_ID"].Value);

                // confirm deletion
                var confirmDel = MessageBox.Show("Delete Voter?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmDel == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(sqlCon))
                    {
                        try
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM voter WHERE v_ID = @v_ID";
                            MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                            cmd.Parameters.AddWithValue("@v_ID", v_ID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Voter deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayVoters();
                            }
                            else
                            {
                                MessageBox.Show("Error: Voter could not be deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a voter to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // UPDATE
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {

                if (kryptonDataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a voter to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // select user by ID
                string v_ID = kryptonDataGridView1.SelectedRows[0].Cells["v_ID"].Value.ToString();

                // get updated values
                string nUsername = userTxtBox.Text;
                string nPassword = passTxtbox.Text;
                string nStudName = studNameTxt.Text;
                string nSection = secTxtbox.Text;
                string nLevel = levelTxtbox.Text;

                // check empty values
                if (string.IsNullOrWhiteSpace(nUsername) || string.IsNullOrWhiteSpace(nPassword) ||
                   string.IsNullOrEmpty(nStudName) || string.IsNullOrEmpty(nSection) ||
                   string.IsNullOrWhiteSpace(nLevel))
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
                        string updateQuery = @"UPDATE voter
                                               SET username = @nUsername,
                                                   password = @nPassword,
                                                   nameStudent = @nStudName,
                                                   Section = @nSection,
                                                   Level = @nLevel
                                                   WHERE v_ID = @v_ID";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@nUsername", nUsername);
                        cmd.Parameters.AddWithValue("@nPassword", nPassword);
                        cmd.Parameters.AddWithValue("@nStudName", nStudName);
                        cmd.Parameters.AddWithValue("@nSection", nSection);
                        cmd.Parameters.AddWithValue("@nLevel", nLevel);
                        cmd.Parameters.AddWithValue("@v_ID", v_ID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Voter updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayVoters(); // updated voter list
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Voter not found.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // RETURN
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        // METHOD to display voters in the datagridview
        public void displayVoters()
        {
            using (MySqlConnection conn = new MySqlConnection(sqlCon))
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
                    kryptonDataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Voter_Load(object sender, EventArgs e)
        {
            displayVoters();
        }
    }
}
