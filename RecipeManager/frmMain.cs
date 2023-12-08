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
    public partial class frmMain : Form
    {
        private string authenticatedUser;
        private Form frmSavedRecipes;
        public frmMain(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
            frmSavedRecipes = new Form();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AccountManagement userManagement = new AccountManagement();
            string account = userManagement.GetAccountByUsername(authenticatedUser).FirstName.ToString() + " " + userManagement.GetAccountByUsername(authenticatedUser).LastName.ToString();
            lblAccountInformation.Text = "Welcome " + account;
        }

        private void btnSavedRecipes_Click(object sender, EventArgs e)
        {
            //SavedRecipesForm frmSavedRecipes = new frmSavedRecipes();
            frmSavedRecipes.Show();
        }
    }
}
