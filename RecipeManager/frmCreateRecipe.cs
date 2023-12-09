using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            MessageBox.Show("Item Saved!");
        }

        private void frmCreateRecipe_Load(object sender, EventArgs e)
        {
            IngredientManagement ingMgmt = new IngredientManagement();
            List<string> ingredientNames = ingMgmt.GetIngredientList();
            cmbAdd.DataSource = ingredientNames;
            cmbAdd.SelectedIndex = -1;
        }

        private void txtImageString_TextChanged(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(txtImageString.Text, UriKind.Absolute))
            {
                pbxImage.Load(txtImageString.Text);
            }
            else
            {
                pbxImage.Image = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtDirections.Text = "";
            txtServingSize.Text = "";
            txtImageString.Text = "";
            txtQuantity.Text = "";
            cmbAdd.SelectedIndex = -1;
            lvIngredients.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
