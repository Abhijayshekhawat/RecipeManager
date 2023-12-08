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
    public partial class frmCreateAccount : Form
    {
        private frmLogin formOwner;

        public frmCreateAccount()
        {
            InitializeComponent();
        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            formOwner = (frmLogin)this.Owner;
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
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
                am.AddAccount(account);
                string message = $"Account Created: \nUsername: {account.UserName}\nFirst Name: {account.FirstName}\nLast Name: {account.LastName}";
                MessageBox.Show(message);
                this.Close();


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
