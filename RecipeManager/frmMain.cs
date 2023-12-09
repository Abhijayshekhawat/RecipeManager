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
        public frmMain(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            AccountManagement userManagement = new AccountManagement();
            string account = userManagement.GetAccountByUsername(authenticatedUser).FirstName.ToString();
            lblAccountInformation.Text = "Welcome " + account;
        }
        private void pBoxCreateRecipe_Click(object sender, EventArgs e)
        {
            frmCreateRecipe createRecipeForm = new frmCreateRecipe(authenticatedUser);
            this.Hide();
            createRecipeForm.ShowDialog();
            this.Show();
        }
        private void pBoxAccount_Click(object sender, EventArgs e)
        {
            frmAccount accountForm = new frmAccount(authenticatedUser);
            this.Hide();
            accountForm.ShowDialog();
            this.Show();
        }
        private void lblAccountInformation_Click(object sender, EventArgs e)
        {
            frmAccount accountForm = new frmAccount(authenticatedUser);
            this.Hide();
            accountForm.ShowDialog();
            this.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch(authenticatedUser);
            this.Hide();
            searchForm.ShowDialog();
            this.Show();
        }
        private void pBoxSavedRecipe_Click(object sender, EventArgs e)
        {
            frmSavedRecipes savedForm = new frmSavedRecipes(authenticatedUser);
            this.Hide();
            savedForm.ShowDialog();
            this.Show();
        }
        private void pBoxMealPlan_Click(object sender, EventArgs e)
        {
            frmMealPlan mealForm = new frmMealPlan(authenticatedUser);
            this.Hide();
            mealForm.ShowDialog();
            this.Show();
        }
    }
}
