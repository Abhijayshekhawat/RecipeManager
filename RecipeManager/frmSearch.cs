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
    public partial class frmSearch : Form
    {
        private string authenticatedUser;
        public frmSearch(string username)
        {
            InitializeComponent();
            authenticatedUser = username;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var isAllergyFree = chkAllergy.Checked;
            var isLowCholesterol = chkCholesterol.Checked;
            var isHighProtein = chkProtein.Checked;
            var isLowFat = chkFat.Checked;
            var searchName = txtSearch.Text;
            RecipeManagement rm = new RecipeManagement();
            var filteredRecipes = rm.FilterRecipes(searchName, isAllergyFree, isLowCholesterol, isHighProtein, isLowFat);
            pnlRecipes.Controls.Clear();
            Label lblResults = new Label();
            lblResults.Text = "Results: " + filteredRecipes.Count;
            lblResults.AutoSize = true;
            lblResults.Location = new Point(10, 10);
            pnlRecipes.Controls.Add(lblResults);
            foreach (var recipe in filteredRecipes)
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
                Button btnAdd = new Button();
                btnAdd.Text = "Add";
                btnAdd.AutoSize = true;
                btnAdd.Tag = recipe.RecipeName;
                btnAdd.Click += new EventHandler(this.btnAdd_Click);
                recipePanel.Controls.Add(pictureBox);
                recipePanel.Controls.Add(lblName);
                recipePanel.Controls.Add(lblDescription);
                recipePanel.Controls.Add(lblAllergens);
                recipePanel.Controls.Add(lblCalories);
                recipePanel.Controls.Add(btnAdd);
                lblName.Location = new Point(pictureBox.Width + 5, 10);
                lblDescription.Location = new Point(pictureBox.Width + 5, 30);
                lblAllergens.Location = new Point(pictureBox.Width + 5, 50);
                lblCalories.Location = new Point(pictureBox.Width + 5, 70);
                btnAdd.Location = new Point(pictureBox.Width + 500, 35);
                pnlRecipes.Controls.Add(recipePanel);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string recipeName = (string)btn.Tag;
            RecipeManagement rm = new RecipeManagement();
            int recipeId = rm.RecipeId(recipeName);
            AccountManagement am = new AccountManagement();
            if (am.SaveRecipe(recipeId, authenticatedUser))
            {
                MessageBox.Show("Recipe: " + recipeName + " Saved");
            }
            else {
                MessageBox.Show("Recipe Already Saved!");
            }
        }
        private void frmSearch_Load(object sender, EventArgs e)
        {
            RecipeManagement rm = new RecipeManagement();
            var allRec = rm.AllRecipes();
            pnlRecipes.Controls.Clear();
            Label lblResults = new Label();
            lblResults.Text = "Results: " + allRec.Count;
            lblResults.AutoSize = true;
            lblResults.Location = new Point(10, 10);
            pnlRecipes.Controls.Add(lblResults);
            foreach (var recipe in allRec)
            {
                Panel recipePanel = new Panel();
                recipePanel.Width = pnlRecipes.Width-30;
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
                Button btnAdd = new Button();
                btnAdd.Text = "Add";
                btnAdd.AutoSize = true;
                btnAdd.Tag = recipe.RecipeName;
                btnAdd.Click += new EventHandler(this.btnAdd_Click);
                recipePanel.Controls.Add(pictureBox);
                recipePanel.Controls.Add(lblName);
                recipePanel.Controls.Add(lblDescription);
                recipePanel.Controls.Add(lblAllergens);
                recipePanel.Controls.Add(lblCalories);
                recipePanel.Controls.Add(btnAdd);
                lblName.Location = new Point(pictureBox.Width + 5, 10);
                lblDescription.Location = new Point(pictureBox.Width + 5, 30);
                lblAllergens.Location = new Point(pictureBox.Width + 5, 50);
                lblCalories.Location = new Point(pictureBox.Width + 5, 70);
                btnAdd.Location = new Point(pictureBox.Width + 500, 35);
                pnlRecipes.Controls.Add(recipePanel);
            }
        }
    }
    
}
