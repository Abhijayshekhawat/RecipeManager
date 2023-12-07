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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            AccountManagement am = new AccountManagement();
            if(am.Authenticate(txtUsername.Text, txtPassword.Text) == true)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Username and or Password. Please try again.");
            }
        }
        private void bttnCreate_Click(object sender, EventArgs e)
        {
            frmCreateAccount createAccount = new frmCreateAccount();
            createAccount.Owner = this;
            createAccount.ShowDialog();
        }
    }
}
