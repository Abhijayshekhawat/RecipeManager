using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecipeManager
{
    public class AccountManagement
    {
        private List<Account> accounts;
        private List<int> savedRecipes = new List<int>();
        private string accConnectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../Data/Accounts.accdb;";
        OleDbConnection accConecction;
        OleDbDataAdapter accDataAdapter;
        OleDbCommand accCommand;
        OleDbDataReader accDataReader;
        DataSet accDataSet;
        DataTable accTable;
        string queryString;

        public AccountManagement()
        {
            accounts = new List<Account>();
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            accConecction = new OleDbConnection(accConnectString);
            queryString = "SELECT * FROM AccountInformation";
            accCommand = new OleDbCommand(queryString, accConecction);
            accDataAdapter = new OleDbDataAdapter(accCommand);
            accDataSet = new DataSet("AccountsTable");
            accDataAdapter.Fill(accDataSet, "AccountsTable");
            accTable = accDataSet.Tables["AccountsTable"];
            accounts.Clear();
            foreach (DataRow row in accTable.Rows)
            {
                accounts.Add(new Account(
                    row["FirstName"].ToString(),
                    row["LastName"].ToString(),
                    row["UserName"].ToString(),
                    row["Password"].ToString()));
            }
        }
        public bool AddAccount(Account account)
        {
            if (uniqueUsername(account.UserName))
            {
                accConecction = new OleDbConnection(accConnectString);
                queryString = "INSERT INTO AccountInformation (FirstName, LastName, UserName, [Password]) VALUES ('" + account.FirstName + "', '" + account.LastName + "', '" + account.UserName + "', '" + account.Password + "')";
                accCommand = new OleDbCommand(queryString, accConecction);
                accDataAdapter = new OleDbDataAdapter(accCommand);
                accConecction.Open();
                accCommand.ExecuteNonQuery();
                accConecction.Close();
                return true;
            } else
            {
                return false;
            }
        }
        public bool uniqueUsername(string userName)
        {
            accConecction = new OleDbConnection(accConnectString);
            queryString = "SELECT * FROM AccountInformation WHERE UserName = '" + userName + "'";
            accCommand = new OleDbCommand(queryString, accConecction);
            accConecction.Open();
            accDataReader = accCommand.ExecuteReader();
            if (accDataReader.HasRows)
            {
                accDataReader.Close();
                accConecction.Close();
                return false;
            } else
            {
                accDataReader.Close();
                accConecction.Close();
                return true;
            }
        }
        public void DeleteAccount(string userName)
        {
            accConecction = new OleDbConnection(accConnectString);
            queryString = "DELETE FROM AccountInformation WHERE UserName = '" + userName + "'";
            accCommand = new OleDbCommand(queryString, accConecction);
            accConecction.Open();
            accCommand.ExecuteNonQuery();
            accConecction.Close();
            LoadAccounts();
        }
        public void UpdateAccount(Account account)
        {
            accConecction = new OleDbConnection(accConnectString);
            queryString = "UPDATE AccountInformation SET FirstName = '" + account.FirstName + "', LastName = '" + account.LastName + "', [Password] = '" + account.Password + "' WHERE UserName = '" + account.UserName + "'";
            accCommand = new OleDbCommand(queryString, accConecction);
            accConecction.Open();
            accCommand.ExecuteNonQuery();
            accConecction.Close();
            LoadAccounts();
        }
        public Account GetAccountByUsername(string userName)
        {
            accConecction = new OleDbConnection(accConnectString);
            queryString = "SELECT *, SavedRecipes FROM AccountInformation WHERE UserName = '" + userName + "'";
            accCommand = new OleDbCommand(queryString, accConecction);
            accConecction.Open();
            accDataReader = accCommand.ExecuteReader();
            Account searchedAccount = null;
            if (accDataReader.Read())
            {
                searchedAccount = new Account(
                    accDataReader["FirstName"].ToString(),
                    accDataReader["LastName"].ToString(),
                    accDataReader["UserName"].ToString(),
                    accDataReader["Password"].ToString());
                var savedRecipes = accDataReader["SavedRecipes"].ToString();
                searchedAccount.SavedRecipeIds = string.IsNullOrWhiteSpace(savedRecipes) ? new List<int>() : savedRecipes.Split(',').Select(int.Parse).ToList();
            }
            accDataReader.Close();
            accConecction.Close();
            return searchedAccount;
        }
        public bool Authenticate(string username, string password)
        {
            Account accountToCheck = GetAccountByUsername(username);
            if (accountToCheck.Password == password) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SaveRecipe(int recipeID, string userName)
        {
            var account = GetAccountByUsername(userName);
            if (account.SavedRecipeIds == null)
            {
                account.SavedRecipeIds = new List<int>();
            }
            if (!account.SavedRecipeIds.Contains(recipeID))
            {
                account.SavedRecipeIds.Add(recipeID);
                string savedRecipesString = string.Join(",", account.SavedRecipeIds);
                accConecction = new OleDbConnection(accConnectString);
                queryString = "UPDATE AccountInformation SET SavedRecipes = '" + savedRecipesString + "' WHERE UserName = '" + userName + "'";
                accCommand = new OleDbCommand(queryString, accConecction);
                accConecction.Open();
                accCommand.ExecuteNonQuery();
                accConecction.Close();
                LoadAccounts();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SaveMeal(string userName, string dayMealKey, int recipeID)
        {
            var account = GetAccountByUsername(userName);
            if (account.MealPlan == null)
            {
                account.MealPlan = new Dictionary<string, int>();
            }
            account.SavedRecipeIds.Add(recipeID);
                string mealPlanString = string.Join("|", account.MealPlan);
                accConecction = new OleDbConnection(accConnectString);
                queryString = "UPDATE AccountInformation SET MealPlan = '" + mealPlanString + "' WHERE UserName = '" + userName + "'";
                accCommand = new OleDbCommand(queryString, accConecction);
                accConecction.Open();
                accCommand.ExecuteNonQuery();
                accConecction.Close();
                LoadAccounts();
        }
    }
}
