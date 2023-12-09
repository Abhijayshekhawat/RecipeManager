using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RecipeManager
{
    public class Recipe
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
            allergens = new List<Ingredients>();
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
        public int ServingSize
        {
            get { return servingSize; }
        }
        public List<Ingredients> Ingredients
        {
            get
            {
                return ingredients;
            }
        }
        public List<Ingredients> Allergens
        {
            get
            {
                allergens.Clear();
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
        public double CaloriesPerServing
        {
            get
            {
                double totalCalories =0;
                foreach (var ingredient in ingredients)
                {
                    totalCalories += ingredient.IngredientCaloriesPerUnit;
                }
                return totalCalories / servingSize;
            }
        }
        public double FatPerServing
        {
            get
            {
                double totalFat = 0;
                foreach (var ingredient in ingredients)
                {
                    totalFat += ingredient.IngredientFatPerUnit;
                }
                return totalFat / servingSize;
            }
        }
        public double CarbsPerServing
        {
            get
            {
                double totalCarbs = 0;
                foreach (var ingredient in ingredients)
                {
                    totalCarbs += ingredient.IngredientCarbsPerUnit;
                }
                return totalCarbs / servingSize;
            }
        }
        public double ProteinPerServing
        {
            get
            {
                double totalProtein = 0;
                foreach (var ingredient in ingredients)
                {
                    totalProtein += ingredient.IngredientProteinPerUnit;
                }
                return totalProtein / servingSize;
            }
        }
        public double CholesterolPerServing
        {
            get
            {
                double totalCholesterol = 0;
                foreach (var ingredient in ingredients)
                {
                    totalCholesterol += ingredient.IngredientCholesterolPerUnit;
                }
                return totalCholesterol / servingSize;
            }
        }

    }
}





