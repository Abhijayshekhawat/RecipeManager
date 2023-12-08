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
    public partial class frmCreateRecipe : Form
    {
        private string authenticatedUser;
        public frmCreateRecipe(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            frmAddIngredient addAnIngredient = new frmAddIngredient();
            addAnIngredient.Owner = this;
            addAnIngredient.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
