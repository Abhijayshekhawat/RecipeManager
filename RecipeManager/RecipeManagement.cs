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
        private double CholesterolThreshold = 10;
        private double ProteinThreshold = 10;
        private double FatThreshold = 20;
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
        public List<Recipe> AllRecipes()
        {
            return recipes;
        }
        private string ConvertIngredientsListToString(List<Ingredients> ingredientsList)
        {
            var ingredientsString = new StringBuilder();
            foreach (var ingredient in ingredientsList)
            {
                ingredientsString.Append($"Ingredient={ingredient.IngredientName},");
                ingredientsString.Append($"Calories={ingredient.IngredientCaloriesPerUnit},");
                ingredientsString.Append($"Fat={ingredient.IngredientFatPerUnit},");
                ingredientsString.Append($"Carbs={ingredient.IngredientCarbsPerUnit},");
                ingredientsString.Append($"Protein={ingredient.IngredientProteinPerUnit},");
                ingredientsString.Append($"Cholesterol={ingredient.IngredientCholesterolPerUnit},");
                ingredientsString.Append($"Allergen={ingredient.IsAllergen}|");
            }
            return ingredientsString.ToString().TrimEnd('|');
        }
        private List<Ingredients> ParseIngredientsFromString(string ingsString)
        {
            var ingredientsList = new List<Ingredients>();
            string[] ingredientsArray = ingsString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var ingredientStr in ingredientsArray)
            {
                string[] details = ingredientStr.Split(',');
                if (details.Length < 7)
                {
                    Console.WriteLine($"Invalid ingredient format: {ingredientStr}");
                    continue;
                }
                string name = GetValueFromDetail(details[0]);
                double calories = Convert.ToDouble(GetValueFromDetail(details[1]));
                double fat = Convert.ToDouble(GetValueFromDetail(details[2]));
                double carbs = Convert.ToDouble(GetValueFromDetail(details[3]));
                double protein = Convert.ToDouble(GetValueFromDetail(details[4]));
                double cholesterol = Convert.ToDouble(GetValueFromDetail(details[5]));
                bool isAllergen = Convert.ToBoolean(GetValueFromDetail(details[6]));

                ingredientsList.Add(new Ingredients(name, isAllergen, calories, fat, carbs, protein, cholesterol));
            }
            return ingredientsList;
        }

        private string GetValueFromDetail(string detail)
        {
            return detail.Split('=')[1].Trim();
        }
        public void AddRecipe(Recipe recipe)
        {
            recConnection = new OleDbConnection(recConnectString);
            queryString = "INSERT INTO Recipes (RecipeName, RecipeDescription, RecipeImageUrl, RecipeDirections, ServingSize, CaloriesPerServing, " +
                "FatPerServing, CarbsPerServing, ProteinPerServing, CholesterolPerServing, Ingredients) VALUES ('" 
                + recipe.RecipeName+ "', '" + recipe.RecipeDescription + "', '" + recipe.RecipeImageUrl + "', '" + recipe.RecipeDirections + "', '" + 
                recipe.ServingSize + "', '" + recipe.CaloriesPerServing + "', '" + recipe.FatPerServing + "', '" + recipe.CarbsPerServing + "', '" + 
                recipe.ProteinPerServing + "', '" + recipe.CholesterolPerServing + "', '" + ConvertIngredientsListToString(recipe.Ingredients) + "')";
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
        public List<Recipe> FilterRecipes(string searchName, bool isAllergyFree, bool isLowCholesterol, bool isHighProtein, bool isLowFat)
        {
            List<Recipe> filteredRecipes = new List<Recipe>();
            searchName = searchName?.ToLower();
            foreach (var recipe in recipes)
            {
                bool nameMatches = string.IsNullOrEmpty(searchName) || recipe.RecipeName.ToLower().Contains(searchName);
                bool allergyConditionMet = !isAllergyFree || !recipe.Allergens.Any();
                bool cholesterolConditionMet = !isLowCholesterol || recipe.CholesterolPerServing <= CholesterolThreshold;
                bool proteinConditionMet = !isHighProtein || recipe.ProteinPerServing >= ProteinThreshold;
                bool fatConditionMet = !isLowFat || recipe.FatPerServing <= FatThreshold;
                if (nameMatches && allergyConditionMet && cholesterolConditionMet && proteinConditionMet && fatConditionMet)
                {
                    filteredRecipes.Add(recipe);
                }
            }
            return filteredRecipes;
        }
        public int RecipeId(string recipeName)
        {
            int recipeId = -1;
            recConnection = new OleDbConnection(recConnectString);
            queryString = "SELECT RecipeID FROM Recipes WHERE RecipeName = '" + recipeName + "'";
            recCommand = new OleDbCommand(queryString, recConnection);
            recConnection.Open();
            recDataReader = recCommand.ExecuteReader();
            if (recDataReader.Read())
            {
                recipeId = recDataReader.GetInt32(0);
            }
            recDataReader.Close();
            recConnection.Close();
            return recipeId;
        }
        public Recipe GetRecipeById(int recipeId)
        {
            recConnection = new OleDbConnection(recConnectString);
            queryString = "SELECT * FROM Recipes WHERE RecipeID = " + recipeId;
            recCommand = new OleDbCommand(queryString, recConnection);
            recConnection.Open();
            recDataReader = recCommand.ExecuteReader();
            Recipe recipe = null;
            if (recDataReader.Read())
            {
                recipe = new Recipe(
                    recDataReader["RecipeName"].ToString(),
                    recDataReader["RecipeDescription"].ToString(),
                    recDataReader["RecipeImageUrl"].ToString(),
                    recDataReader["RecipeDirections"].ToString(),
                    Convert.ToInt32(recDataReader["ServingSize"]),
                    ParseIngredientsFromString(recDataReader["Ingredients"].ToString())
                );
            }
            recDataReader.Close();
            recConnection.Close();
            return recipe;
        }

    }
}
