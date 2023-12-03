using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        if (IsValidUser(username, password))
            {
                MessageBox.Show("Login Successful");
            }
        else
            {
                MessageBox.Show("Invalid Username and or Password. Please try again.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "user" && password == "pass";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
