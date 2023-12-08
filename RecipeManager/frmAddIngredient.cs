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
    public partial class frmAddIngredient : Form
    {
        private frmCreateRecipe formOwner;

        public frmAddIngredient()
        {
            InitializeComponent();
        }

        private void frmAddIngredient_Load(object sender, EventArgs e)
        {
            formOwner = (frmCreateRecipe)this.Owner;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
