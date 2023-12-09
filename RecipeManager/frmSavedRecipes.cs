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
    public partial class frmSavedRecipes : Form
    {
        private string authenticatedUser;
        public frmSavedRecipes(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
    }
        private void frmSavedRecipes_Load(object sender, EventArgs e)
        {
            RecipeManagement rm = new RecipeManagement();
            AccountManagement am = new AccountManagement();
            Account currentAccount = am.GetAccountByUsername(authenticatedUser);
            var savedRecipes = new List<Recipe>();
            foreach (int recipeId in currentAccount.SavedRecipeIds)
            {
                Recipe recipe = rm.GetRecipeById(recipeId);
                if (recipe != null)
                {
                    savedRecipes.Add(recipe);
                }
            }
            
            pnlRecipes.Controls.Clear();
            Label lblResults = new Label();
            lblResults.Text = "Results: " + savedRecipes.Count;
            lblResults.AutoSize = true;
            lblResults.Location = new Point(10, 10);
            pnlRecipes.Controls.Add(lblResults);
            foreach (var recipe in savedRecipes)
            {
                Panel recipePanel = new Panel();
                recipePanel.Width = pnlRecipes.Width - 30;
                recipePanel.Height = 100;
                recipePanel.BorderStyle = BorderStyle.FixedSingle;
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 100; 
                pictureBox.Height = 100; 
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.LoadAsync(recipe.RecipeImageUrl); 
                Label lblName = new Label();
                lblName.Text = "Name: " + recipe.RecipeName;
                lblName.AutoSize = true;
                Label lblDescription = new Label();
                lblDescription.Text = "Description: " + recipe.RecipeDescription;
                lblDescription.AutoSize = true;
                Label lblAllergens = new Label();
                lblAllergens.Text = "Allergens: " + (recipe.Allergens.Any() ? string.Join(", ", recipe.Allergens.Select(a => a.IngredientName)) : "No allergens");
                lblAllergens.AutoSize = true;
                Label lblCalories = new Label();
                lblCalories.Text = "Calories: " + recipe.CaloriesPerServing.ToString("F2");
                lblCalories.AutoSize = true;
                recipePanel.Controls.Add(pictureBox);
                recipePanel.Controls.Add(lblName);
                recipePanel.Controls.Add(lblDescription);
                recipePanel.Controls.Add(lblAllergens);
                recipePanel.Controls.Add(lblCalories);
                lblName.Location = new Point(pictureBox.Width + 5, 10);
                lblDescription.Location = new Point(pictureBox.Width + 5, 30);
                lblAllergens.Location = new Point(pictureBox.Width + 5, 50);
                lblCalories.Location = new Point(pictureBox.Width + 5, 70);
                pnlRecipes.Controls.Add(recipePanel);
            }
        }
    }
}
