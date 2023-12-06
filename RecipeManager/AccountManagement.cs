using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace RecipeManager
{
    class AccountManagement
    {
        private List<Account> accounts;
        private string strConnection;
        const string filePath = @"..\..\Data\Accounts.accdb";
        public AccountManagement()
        {
            strConnection = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath}";
            accounts = new List<Account>();
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            OleDbConnection connection = new OleDbConnection(strConnection);
            string query = "SELECT * FROM AccountInformation";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds, "AccountInformation");
                foreach (DataRow row in ds.Tables["AccountInformation"].Rows)
                {
                    accounts.Add(new Account(row["FirstName"].ToString(), row["LastName"].ToString(),
                                             row["UserName"].ToString(), row["Password"].ToString()));
                }
            }
            catch (OleDbException ex)
            {
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddAccount(Account account)
        {
            string cmdText = "INSERT INTO AccountInformation (FirstName, LastName, UserName, [Password]) VALUES ('" + account.FirstName + account.LastName + "','" + account.UserName + "','" + account.Password + "')";
            OleDbConnection connection = new OleDbConnection(strConnection);
            OleDbCommand cmd = new OleDbCommand(cmdText, connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                accounts.Add(account);
            }
            catch (OleDbException ex) { }
            catch (SystemException ex) { }
            finally { 
                connection.Close(); 
            } 
        }
        //public void DeleteAccount(string userName)
        //{
        //    OleDbConnection connection = new OleDbConnection(strConnection);
        //    string cmdText = "DELETE FROM AccountInformation WHERE UserName = ?";
        //    OleDbCommand cmd = new OleDbCommand(cmdText, connection);
        //    cmd.Parameters.AddWithValue("@UserName", userName);

        //    try
        //    {
        //        connection.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (OleDbException ex){}
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    accounts.RemoveAll(a => a.UserName == userName);
        //}
        //public void UpdateAccount(Account account)
        //{
        //    OleDbConnection connection = new OleDbConnection(strConnection);
        //    string cmdText = "UPDATE AccountInformation SET FirstName = ?, LastName = ?, [Password] = ? WHERE UserName = ?";
        //    OleDbCommand cmd = new OleDbCommand(cmdText, connection);
        //    cmd.Parameters.AddWithValue("@FirstName", account.FirstName);
        //    cmd.Parameters.AddWithValue("@LastName", account.LastName);
        //    cmd.Parameters.AddWithValue("@Password", account.Password);
        //    cmd.Parameters.AddWithValue("@UserName", account.UserName);

        //    try
        //    {
        //        connection.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (OleDbException ex){}
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    var existingAccount = accounts.Find(a => a.UserName == account.UserName);
        //    if (existingAccount != null)
        //    {
        //        existingAccount.FirstName = account.FirstName;
        //        existingAccount.LastName = account.LastName;
        //        existingAccount.Password = account.Password;
        //    }
        //}
        public Account GetAccountByUsername(string userName)
        {
            OleDbConnection connection = new OleDbConnection(strConnection);
            string query = "SELECT * FROM AccountInformation WHERE UserName = ?";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@UserName", userName);

            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds, "AccountInformation");
                if (ds.Tables["AccountInformation"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["AccountInformation"].Rows[0];
                    return new Account(row["FirstName"].ToString(), row["LastName"].ToString(),
                                       row["UserName"].ToString(), row["Password"].ToString());
                }
            }
            catch (OleDbException ex){}
            finally
            {
                connection.Close();
            }
            return null;
        }


    }
}
