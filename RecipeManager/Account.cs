using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Account
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string password;  // Note: In a real-world application, store passwords securely, not as plain text.
        public Account(string firstName, string lastName, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
        }
        public string FirstName {  
            get { 
                return firstName; 
            } 
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
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
