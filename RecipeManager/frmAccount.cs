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
    public partial class frmAccount : Form
    {
        private string authenticatedUser;
        public frmAccount(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string fN = txtFirstName.Text;
            string lN = txtLastName.Text;
            string uN = txtUserName.Text;
            string pwd = txtPassword.Text;
            string confirmPwd = txtRePassword.Text;

            if (string.IsNullOrWhiteSpace(fN) || string.IsNullOrWhiteSpace(lN) ||
                string.IsNullOrWhiteSpace(uN))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (pwd != confirmPwd)
            {
                MessageBox.Show("Please ensure the passwords are the same.");
                return;
            }
            try
            {
                Account account = new Account(fN, lN, uN, pwd);
                AccountManagement am = new AccountManagement();
                am.UpdateAccount(account);
                MessageBox.Show("Account Updated");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            AccountManagement am = new AccountManagement();
            Account account = am.GetAccountByUsername(authenticatedUser);
            txtFirstName.Text = account.FirstName;
            txtLastName.Text = account.LastName;
            txtUserName.Text = account.UserName;
        }
    }
}
