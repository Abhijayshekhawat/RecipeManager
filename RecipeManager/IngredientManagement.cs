using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecipeManager
{
    class IngredientManagement
    {
        private List<Ingredients> ingredients;
        private string ingConnectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../Data/Recipes.accdb;";
        OleDbConnection ingConnection;
        OleDbDataAdapter ingDataAdapter;
        OleDbCommand ingCommand;
        OleDbDataReader ingDataReader;
        DataSet ingDataSet;
        DataTable ingTable;
        string queryString;
        public IngredientManagement()
        {
            ingredients = new List<Ingredients>();
            LoadIngredients();
        }
        private void LoadIngredients()
        {
            ingConnection = new OleDbConnection(ingConnectString);
            queryString = "SELECT * FROM Ingredients";
            ingCommand = new OleDbCommand(queryString, ingConnection);
            ingDataAdapter = new OleDbDataAdapter(ingCommand);
            ingDataSet = new DataSet("RecipesTable");
            ingDataAdapter.Fill(ingDataSet, "RecipesTable");
            ingTable = ingDataSet.Tables["RecipesTable"];
            ingredients.Clear();
            foreach (DataRow recipeRow in ingTable.Rows)
            {
                ingredients.Add(new Ingredients(
                    recipeRow["IngredientName"].ToString(),
                    Convert.ToBoolean(recipeRow["IsAllergen"]),
                    Convert.ToDouble(recipeRow["IngredientCaloriesPerUnit"]),
                    Convert.ToDouble(recipeRow["IngredientFatPerUnit"]),
                    Convert.ToDouble(recipeRow["IngredientCarbsPerUnit"]),
                    Convert.ToDouble(recipeRow["IngredientProteinPerUnit"]),
                    Convert.ToDouble(recipeRow["IngredientCholesterolPerUnit"])
                ));
            }
        }
        public void AddIngredient(Ingredients ingredient)
        {
            ingConnection = new OleDbConnection(ingConnectString);
            queryString = "INSERT INTO Ingredients (IngredientName, IngredientCaloriesPerUnit, IngredientFatPerUnit, IngredientCarbsPerUnit, IngredientProteinPerUnit, IngredientCholesterolPerUnit, IsAllergen) VALUES ('" + ingredient.IngredientName + "', '" + ingredient.IngredientCaloriesPerUnit + "', '" + ingredient.IngredientFatPerUnit + "', '" + ingredient.IngredientCarbsPerUnit + "', '" + ingredient.IngredientProteinPerUnit + "', '" + ingredient.IngredientCholesterolPerUnit + "', '" + ingredient.IsAllergen + "')";
            ingCommand = new OleDbCommand(queryString, ingConnection);
            ingDataAdapter = new OleDbDataAdapter(ingCommand);
            ingConnection.Open();
            ingCommand.ExecuteNonQuery();
            ingConnection.Close();
        }
        public void DeleteIngredient(string ingName)
        {
            ingConnection = new OleDbConnection(ingConnectString);
            queryString = "DELETE FROM Ingredients WHERE IngredientName = '" + ingName + "'";
            ingCommand = new OleDbCommand(queryString, ingConnection);
            ingConnection.Open();
            ingCommand.ExecuteNonQuery();
            ingConnection.Close();
        }
        private string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../Data/Recipes.accdb;";
        public Ingredients GetIngredientByName(string name)
        {
            ingConnection = new OleDbConnection(ingConnectString);
            queryString = "SELECT * FROM Ingredients WHERE IngredientName = '" + name + "'";
            ingCommand = new OleDbCommand(queryString, ingConnection);
            ingConnection.Open();
            ingDataReader = ingCommand.ExecuteReader();
            Ingredients searchedIngredients = null;
            if (ingDataReader.Read())
            {
                searchedIngredients = new Ingredients(
                    ingDataReader["IngredientName"].ToString(),
                    bool.Parse(ingDataReader["IsAllergen"].ToString()),
                    Convert.ToDouble(ingDataReader["IngredientCaloriesPerUnit"]),
                    Convert.ToDouble(ingDataReader["IngredientFatPerUnit"]),
                    Convert.ToDouble(ingDataReader["IngredientCarbsPerUnit"]),
                    Convert.ToDouble(ingDataReader["IngredientProteinPerUnit"]),
                    Convert.ToDouble(ingDataReader["IngredientCholesterolPerUnit"])
                );

                ingDataReader.Close();
                ingConnection.Close();
            }
            return searchedIngredients;
        }
        public List<string> GetIngredientList()
        {
            ingConnection = new OleDbConnection(ingConnectString);
            queryString = "SELECT IngredientName FROM Ingredients";
            ingCommand = new OleDbCommand(queryString, ingConnection);
            ingConnection.Open();
            ingDataReader = ingCommand.ExecuteReader();
            List<string> ingredientNames = new List<string>();
            while (ingDataReader.Read())
            {
                ingredientNames.Add(ingDataReader["IngredientName"].ToString());
            }
            ingDataReader.Close();
            ingConnection.Close();

            return ingredientNames;
        }
    }
}
