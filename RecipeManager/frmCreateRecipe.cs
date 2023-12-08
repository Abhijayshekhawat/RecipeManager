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
        private List<Ingredients> ingredients = new List<Ingredients>();
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
            string selectedIngredientName = cmbAdd.SelectedItem.ToString();
            int quantity = Convert.ToInt32(txtQuantity.Text);
            IngredientManagement ingMgmt = new IngredientManagement();
            Ingredients ingredient = ingMgmt.GetIngredientByName(selectedIngredientName);
            ingredient.IngredientQuantity = quantity;
            ingredients.Add(ingredient);
            var listViewItem = new ListViewItem(ingredient.IngredientName);
            listViewItem.SubItems.Add(ingredient.IngredientQuantity.ToString());
            lvIngredients.Items.Add(listViewItem);
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            RecipeManagement rm = new RecipeManagement();
            int servingSize = Convert.ToInt32(txtServingSize.Text);
            Recipe r = new Recipe(txtName.Text, txtDescription.Text, txtImageString.Text, txtDirections.Text, servingSize, ingredients);
            rm.AddRecipe(r);
        }

        private void frmCreateRecipe_Load(object sender, EventArgs e)
        {
            IngredientManagement ingMgmt = new IngredientManagement();
            List<string> ingredientNames = ingMgmt.GetIngredientList();
            cmbAdd.DataSource = ingredientNames;
        }
    }
}
