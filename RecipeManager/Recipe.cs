using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Recipe
    {
        private string Name;
        private List<string> Ingredients;
        private string Instructions;
        private string Category;


        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public string instructions
        {
            get { return this.Instructions; }
            set { this.Instructions = value; }
        }

        public string category
        {
            get { return this.Category; }
            set { this.Category = value; }
        }

        public List<string> ingredients
        {
            get { return this.Ingredients; }
            set { this.Ingredients = value; }
        }

    }
}




}
