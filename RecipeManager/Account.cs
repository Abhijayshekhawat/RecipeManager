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
        private string password;
        private List<int> savedRecipeIds = new List<int>();
        Dictionary<string, int> mealPlan;
        public Account(string firstName, string lastName, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Password = password;
            mealPlan = new Dictionary<string, int>
            {
                {"Monday-Breakfast", -1 },
                {"Monday-Lunch", -1 },
                {"Monday-Dinner", -1 },
                {"Tuesday-Breakfast", -1 },
                {"Tuesday-Lunch", -1 },
                {"Tuesday-Dinner", -1 },
                {"Wednesday-Breakfast", -1 },
                {"Wednesday-Lunch", -1 },
                {"Wednesday-Dinner", -1 },
                {"Thursday-Breakfast", -1 },
                {"Thursday-Lunch", -1 },
                {"Thursday-Dinner", -1 },
                {"Friday-Breakfast", -1 },
                {"Friday-Lunch", -1 },
                {"Friday-Dinner", -1 },
                {"Saturday-Breakfast", -1 },
                {"Saturday-Lunch", -1 },
                {"Saturday-Dinner", -1 },
                {"Sunday-Breakfast", -1 },
                {"Sunday-Lunch", -1 },
                {"Sunday-Dinner", -1 }
            };
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
        public List<int> SavedRecipeIds{
            get
            {
                return savedRecipeIds;
            }
            set
            {
                savedRecipeIds = value;
            }
        }
        public Dictionary<string, int> MealPlan
        {
            get
            {
                return mealPlan;
            }
            set
            {
                mealPlan = value;
            }
        }
    }

}
