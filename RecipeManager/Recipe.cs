using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RecipeManager
{
    class Recipe
    {
        private string recipeName;
        private string recipeDescription;
        private string recipeImageUrl;
        private string recipeDirections;
        private int servingSize;
        private List<Ingredients> allergens;
        private List<Ingredients> ingredients;
        public Recipe(string name, string description, string imageUrl, string directions, int size, List<Ingredients> items)
        {
            recipeName = name;
            recipeDescription = description;
            recipeImageUrl = imageUrl;
            recipeDirections = directions;
            servingSize = size;
            ingredients = items;
        }
        public string RecipeName
        {
            get { return recipeName; }
        }
        public string RecipeDescription
        {
            get { return recipeDescription; }
        }
        public string RecipeImageUrl
        {
            get { return recipeImageUrl; }
        }
        public string RecipeDirections
        {
            get { return recipeDirections; }
        }
        public int SeringSize
        {
            get { return servingSize; }
        }
        public List<Ingredients> Allergens
        {
            get
            {
                foreach (var ingredient in ingredients)
                {
                    if (ingredient.IsAllergen)
                    {
                        allergens.Add(ingredient);
                    }
                }
                return allergens;
            }
        }
        public int CaloriesPerServing
        {
            get
            {
                int totalCalories=0;
                foreach (var ingredient in ingredients)
                {
                    totalCalories += ingredient.IngredientCaloriesPerUnit;
                }
                return totalCalories / servingSize;
            }
        }
        public int FatPerServing
        {
            get
            {
                int totalFat = 0;
                foreach (var ingredient in ingredients)
                {
                    totalFat += ingredient.IngredientFatPerUnit;
                }
                return totalFat / servingSize;
            }
        }
        public int CarbsPerServing
        {
            get
            {
                int totalCarbs = 0;
                foreach (var ingredient in ingredients)
                {
                    totalCarbs += ingredient.IngredientCarbsPerUnit;
                }
                return totalCarbs / servingSize;
            }
        }
        public int ProteinPerServing
        {
            get
            {
                int totalProtein = 0;
                foreach (var ingredient in ingredients)
                {
                    totalProtein += ingredient.IngredientProteinPerUnit;
                }
                return totalProtein / servingSize;
            }
        }
        public int CholesterolPerServing
        {
            get
            {
                int totalCholesterol = 0;
                foreach (var ingredient in ingredients)
                {
                    totalCholesterol += ingredient.IngredientCholesterolPerUnit;
                }
                return totalCholesterol / servingSize;
            }
        }

    }
}
