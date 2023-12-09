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
    public partial class frmMealPlan : Form
    {
        private string authenticatedUser;
        public frmMealPlan(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }
        private void frmMealPlan_Load(object sender, EventArgs e)
        {
            AccountManagement am = new AccountManagement();
            Account a = am.GetAccountByUsername(authenticatedUser);
            Dictionary<string, int> mealPlan = a.MealPlan;
            foreach (var entry in mealPlan)
            {
            }
        }
    }
}
