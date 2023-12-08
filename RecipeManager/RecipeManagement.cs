using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    class RecipeManagement
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
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            recConnection = new OleDbConnection(recConnectString);

            queryString = "SELECT * FROM AccountInformation";
            // Create a new OleDbCommand with the specified query and connection
            recCommand = new OleDbCommand(queryString, recConnection);
            recDataAdapter = new OleDbDataAdapter(recCommand);
            // Create a new DataSet named "RecipesTable" and fill it with data from the database
            recDataSet = new DataSet("RecipesTable");
            //load data into the DataTable of a DataSet.
            recDataAdapter.Fill(recDataSet, "RecipesTable");
            recTable = recDataSet.Tables["RecipesTable"];
            recipes.Clear();
            foreach (DataRow row in recTable.Rows)
            {
                recipes.Add(new Recipe(
                    row["RecipeName"].ToString(),
                    row["RecipeDescription"].ToString(),
                    row["RecipeImageUrl"].ToString(),
                    row["RecipeDirections"].ToString(),
                    row["ServingSize"].ToString());
            }
        }
        //public void AddAccount(Recipe account)
        //{
        //    recConnection = new OleDbConnection(recConnectString);
        //    queryString = "INSERT INTO AccountInformation (FirstName, LastName, UserName, [Password]) VALUES ('" + account.FirstName + "', '" + account.LastName + "', '" + account.UserName + "', '" + account.Password + "')";
        //    recCommand = new OleDbCommand(queryString, recConnection);
        //    recDataAdapter = new OleDbDataAdapter(recCommand);
        //    //opening a database connection
        //    recConnection.Open();
        //    //used for executing SQL statements that do not return data, such as INSERT, UPDATE, DELETE
        //    recCommand.ExecuteNonQuery();
        //    recConnection.Close();
        //}
        //public void DeleteAccount(string userName)
        //{
        //    recConnection = new OleDbConnection(recConnectString);
        //    queryString = "DELETE FROM AccountInformation WHERE UserName = '" + userName + "'";
        //    recCommand = new OleDbCommand(queryString, recConnection);
        //    recConnection.Open();
        //    recCommand.ExecuteNonQuery();
        //    recConnection.Close();
        //    LoadAccounts();
        //}
        //public void UpdateAccount(Recipe account)
        //{
        //    recConnection = new OleDbConnection(recConnectString);
        //    queryString = "UPDATE AccountInformation SET FirstName = '" + account.FirstName + "', LastName = '" + account.LastName + "', [Password] = '" + account.Password + "' WHERE UserName = '" + account.UserName + "'";
        //    recCommand = new OleDbCommand(queryString, recConnection);
        //    recConnection.Open();
        //    recCommand.ExecuteNonQuery();
        //    recConnection.Close();
        //    LoadAccounts();
        //}
        //public Recipe GetAccountByUsername(string userName)
        //{
        //    recConnection = new OleDbConnection(recConnectString);
        //    queryString = "SELECT * FROM AccountInformation WHERE UserName = '" + userName + "'";
        //    recCommand = new OleDbCommand(queryString, recConnection);
        //    recConnection.Open();
        //    recDataReader = recCommand.ExecuteReader();
        //    Recipe searchedAccount = null;
        //    if (recDataReader.Read())
        //    {
        //        searchedAccount = new Recipe(
        //            recDataReader["FirstName"].ToString(),
        //            recDataReader["LastName"].ToString(),
        //            recDataReader["UserName"].ToString(),
        //            recDataReader["Password"].ToString());
        //    }

        //    recDataReader.Close();
        //    recConnection.Close();

        //    return searchedAccount;
        //}
        //public bool Authenticate(string username, string password)
        //{
        //    Recipe accountToCheck = GetAccountByUsername(username);
        //    if (accountToCheck.Password == password)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
    }
}
