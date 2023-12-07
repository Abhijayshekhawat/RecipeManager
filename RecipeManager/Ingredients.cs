using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    class Ingredients
    {
        private string ingredientName;
        private int ingredientQuantity;
        private bool isAllergen;
        private int ingredientCaloriesPerUnit;
        private int ingredientFatPerUnit;
        private int ingredientCarbsPerUnit;
        private int ingredientProteinPerUnit;
        private int ingredientCholesterolPerUnit;

        public Ingredients(string name, int quantity, bool allergen, int caloriesPerUnit, int fatPerUnit, int carbsPerUnit, int proteinPerUnit, int cholesterolPerUnit)
        {
            ingredientName = name;
            ingredientQuantity = quantity;
            isAllergen = allergen;
            ingredientCaloriesPerUnit = caloriesPerUnit;
            ingredientFatPerUnit = fatPerUnit;
            ingredientCarbsPerUnit = carbsPerUnit;
            ingredientProteinPerUnit = proteinPerUnit;
            ingredientCholesterolPerUnit = cholesterolPerUnit;
        }

        // Properties
        public string IngredientName { get { return ingredientName; } set { ingredientName = value; } }
        public int IngredientQuantity { get { return ingredientQuantity; } set { ingredientQuantity = value; } }
        public bool IsAllergen { get { return isAllergen; } set { isAllergen = value; } }
        public int IngredientCaloriesPerUnit { get { return ingredientCaloriesPerUnit; } set { ingredientCaloriesPerUnit = value; } }
        public int IngredientFatPerUnit { get { return ingredientFatPerUnit; } set { ingredientFatPerUnit = value; } }
        public int IngredientCarbsPerUnit { get { return ingredientCarbsPerUnit; } set { ingredientCarbsPerUnit = value; } }
        public int IngredientProteinPerUnit { get { return ingredientProteinPerUnit; } set { ingredientProteinPerUnit = value; } }
        public int IngredientCholesterolPerUnit { get { return ingredientCholesterolPerUnit; } set { ingredientCholesterolPerUnit = value; } }
    }
}
}
