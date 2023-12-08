using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager
{
    public class Ingredients
    {
        private string ingredientName;
        private int ingredientQuantity;
        private bool isAllergen;
        private double ingredientCaloriesPerUnit;
        private double ingredientFatPerUnit;
        private double ingredientCarbsPerUnit;
        private double ingredientProteinPerUnit;
        private double ingredientCholesterolPerUnit;   

        public Ingredients(string name, bool allergen, double caloriesPerUnit, double fatPerUnit, double carbsPerUnit, double proteinPerUnit, double cholesterolPerUnit)
        {
            ingredientName = name;
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
        public double IngredientCaloriesPerUnit { get { return ingredientCaloriesPerUnit; } set { ingredientCaloriesPerUnit = value; } }
        public double IngredientFatPerUnit { get { return ingredientFatPerUnit; } set { ingredientFatPerUnit = value; } }
        public double IngredientCarbsPerUnit { get { return ingredientCarbsPerUnit; } set { ingredientCarbsPerUnit = value; } }
        public double IngredientProteinPerUnit { get { return ingredientProteinPerUnit; } set { ingredientProteinPerUnit = value; } }
        public double IngredientCholesterolPerUnit { get { return ingredientCholesterolPerUnit; } set { ingredientCholesterolPerUnit = value; } }
    }
}

