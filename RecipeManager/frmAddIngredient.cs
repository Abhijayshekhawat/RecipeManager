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
            cmbAllergen.Items.Add(true);
            cmbAllergen.Items.Add(false);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {
            IngredientManagement ingMgmt = new IngredientManagement();
            Ingredients ing = new Ingredients(txtIngredientName.Text, Convert.ToBoolean(cmbAllergen.SelectedItem), Convert.ToDouble(txtCalories.Text), Convert.ToDouble(txtFat.Text), Convert.ToDouble(txtCarbs.Text), Convert.ToDouble(txtProtein.Text), Convert.ToDouble(txtCholesterol.Text));
            ingMgmt.AddIngredient(ing);
            MessageBox.Show("Item Saved");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalories.Text = "";
            txtCarbs.Text = "";
            txtCholesterol.Text = "";
            txtFat.Text = "";
            txtIngredientName.Text = "";
            txtProtein.Text = "";
            cmbAllergen.SelectedIndex = 0;
        }
    }
}
