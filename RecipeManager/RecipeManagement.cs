using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecipeManager
{
    public class RecipeManagement
    {
        private List<Recipe> recipes;
        private string recConnectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../Data/Recipes.accdb;";
        OleDbConnection recConnection;
        OleDbDataAdapter recDataAdapter;
        OleDbCommand recCommand;
        OleDbDataReader recDataReader;
        //The data retrieved from a database and utilized by your program is stored in a DataSet
        DataSet recDataSet;
        //The DataSet contains one or more DataTables
        DataTable recTable;
        string queryString;

        public RecipeManagement()
        {
            recipes = new List<Recipe>();
            LoadRecipes();
        }
        private void LoadRecipes()
        {
            recConnection = new OleDbConnection(recConnectString);
            queryString = "SELECT * FROM Recipes";
            recCommand = new OleDbCommand(queryString, recConnection);
            recDataAdapter = new OleDbDataAdapter(recCommand);
            recDataSet = new DataSet("RecipesTable");
            recDataAdapter.Fill(recDataSet, "RecipesTable");
            recTable = recDataSet.Tables["RecipesTable"];
            recipes.Clear();
            foreach (DataRow recipeRow in recTable.Rows)
            {
                string ingredientsString = recipeRow["Ingredients"].ToString();
                var recipeIngredients = ParseIngredientsFromString(ingredientsString);
                recipes.Add(new Recipe(
                    recipeRow["RecipeName"].ToString(),
                    recipeRow["RecipeDescription"].ToString(),
                    recipeRow["RecipeImageUrl"].ToString(),
                    recipeRow["RecipeDirections"].ToString(),
                    Convert.ToInt32(recipeRow["ServingSize"]),
                    recipeIngredients
                ));
            }
        }
        private List<Ingredients> ParseIngredientsFromString(string ingredientsString)
        {
            var ingredientsList = new List<Ingredients>();
            string[] ingredientsArray = ingredientsString.Split('|');
            foreach (var ingredient in ingredientsArray)
            {
                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    string[] details = ingredient.Trim(new char[] { '(', ')' }).Split(':');
                    string name = details[0].Trim();
                    string[] values = details[1].Trim().Split(',');
                    bool isAllergen = Convert.ToBoolean(values[5].Split('=')[1]);
                    ingredientsList.Add(new Ingredients(name,isAllergen,Convert.ToInt32(values[0].Split('=')[1]),Convert.ToInt32(values[1].Split('=')[1]),
                        Convert.ToInt32(values[2].Split('=')[1]),
                        Convert.ToInt32(values[3].Split('=')[1]),
                        Convert.ToInt32(values[4].Split('=')[1])
                    ));
                }
            }
            return ingredientsList;
        }
        private string ConvertIngredientsListToString(List<Ingredients> ingredientsList)
        {
            var ingredientsString = new StringBuilder();
            foreach (var ingredient in ingredientsList)
            {
                ingredientsString.Append($"(Ingredient: {ingredient.IngredientName}|Calories={ingredient.IngredientCaloriesPerUnit}|Fat={ingredient.IngredientFatPerUnit}|Carbs={ingredient.IngredientCarbsPerUnit}|Protein={ingredient.IngredientProteinPerUnit}|Cholesterol={ingredient.IngredientCholesterolPerUnit}|Allergen={ingredient.IsAllergen}) x {ingredient.IngredientQuantity} | ");
            }
            return ingredientsString.ToString().TrimEnd(' ', '|');
        }
        public void AddRecipe(Recipe recipe)
        {
            recConnection = new OleDbConnection(recConnectString);
            queryString = "INSERT INTO Recipes (RecipeName, RecipeDescription, RecipeImageUrl, RecipeDirections, ServingSize, Ingredients) VALUES ('" + recipe.RecipeName+ "', '" + recipe.RecipeDescription + "', '" + recipe.RecipeImageUrl + "', '" + recipe.RecipeDirections + "', '" + recipe.ServingSize + "', '" + ConvertIngredientsListToString(recipe.Ingredients) + "')";
            recCommand = new OleDbCommand(queryString, recConnection);
            //recDataAdapter = new OleDbDataAdapter(recCommand);
            recConnection.Open();
            recCommand.ExecuteNonQuery();
            recConnection.Close();
        }

        public void DeleteRecipe(int recipeId)
        {
            recConnection = new OleDbConnection(recConnectString);
            // Start with deleting the ingredients for the recipe to maintain referential integrity
            queryString = "DELETE FROM Recipes WHERE RecipeID = '" + recipeId + "'";
            recCommand = new OleDbCommand(queryString, recConnection);
            recConnection.Open();
            recCommand.ExecuteNonQuery();
            recConnection.Close();
            LoadRecipes(); // Reload the recipes list
        }
    }
}
