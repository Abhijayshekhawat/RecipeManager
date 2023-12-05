using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Account
    {
        private int accountID;
        private string firstName;
        private string lastName;
        private string userName;
        private string password;  // Note: In a real-world application, store passwords securely, not as plain text.
        public Account(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
        public string UserName
        {
            get { 
                return userName; 
                }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("UserName cannot be null or whitespace.");
                }
                userName = value;
            }
        }

        public string Password
        {
            get { 
                return password; 
                }
            set
            {
                if (value.Length < 8)
                {
                    throw new ArgumentException("Password must be at least 8 characters long.");
                }
                password = value;
            }
        }
    }

}
