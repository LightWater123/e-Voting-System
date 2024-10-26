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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            // ADMIN
            try
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "password1234")
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else if (textBox1.Text == "Admin" && textBox2.Text != "password1234")
                {
                    MessageBox.Show("Wrong password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox1.Text != "Admin" && textBox2.Text == "password1234")
                {
                    MessageBox.Show("Wrong username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Login Error", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VOTER


        }

    }
}
