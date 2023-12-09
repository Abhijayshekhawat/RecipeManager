using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager;
using System;
using System.Collections.Generic;

namespace RecipeUnitTests
{
    [TestClass]
    public class IngredientsTest
    {
        private TestContext testContextInstance;
        Ingredients ingredient1, ingredient2, ingredient3;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            ingredient1 = null;
            ingredient2 = null;
            ingredient3 = null;
        }

        [TestMethod]
        public void IngredientConstructorTest()
        {
            string in1 = "Tomato", in2 = "23131#$", in3=null;
            bool al1 = true, al2 = false, al3 = true;
            double calPU1 = 0.0, calPU2 = 100.0, calPU3 = 10.10;
            double fatPU1 = 10.0, fatPU2 = 10.10, fatPU3 = 0.0;
            double carbPU1 = 110.0, carbPU2 = 0.0, carbPU3 = 10.10;
            double proPU1 = 0.10, proPU2 = 100.10, proPU3 = 10.10;
            double cholPU1 = 10.0, cholPU2 = 100.0, cholPU3 = 10.10;
            Assert.AreEqual(null, ingredient1);
            Assert.AreEqual(null, ingredient2);
            Assert.AreEqual(null, ingredient3);

            ingredient1 = new Ingredients(in1, al1, calPU1, fatPU1, carbPU1, proPU1, cholPU1);
            Assert.AreNotEqual(null, ingredient1);
            Assert.AreEqual(in1, ingredient1.IngredientName);
            Assert.AreEqual(al1, ingredient1.IsAllergen);
            Assert.AreEqual(calPU1, ingredient1.IngredientCaloriesPerUnit);
            Assert.AreEqual(fatPU1, ingredient1.IngredientFatPerUnit);
            Assert.AreEqual(carbPU1, ingredient1.IngredientCarbsPerUnit);
            Assert.AreEqual(proPU1, ingredient1.IngredientProteinPerUnit);
            Assert.AreEqual(cholPU1, ingredient1.IngredientCholesterolPerUnit);
            Assert.AreEqual(0,ingredient1.IngredientQuantity);

            ingredient2 = new Ingredients(in2, al2, calPU2, fatPU2, carbPU2, proPU2, cholPU2);
            Assert.AreNotEqual(null, ingredient2);
            Assert.AreEqual(in2, ingredient2.IngredientName);
            Assert.AreEqual(al2, ingredient2.IsAllergen);
            Assert.AreEqual(calPU2, ingredient2.IngredientCaloriesPerUnit);
            Assert.AreEqual(fatPU2, ingredient2.IngredientFatPerUnit);
            Assert.AreEqual(carbPU2, ingredient2.IngredientCarbsPerUnit);
            Assert.AreEqual(proPU2, ingredient2.IngredientProteinPerUnit);
            Assert.AreEqual(cholPU2, ingredient2.IngredientCholesterolPerUnit);
            Assert.AreEqual(0, ingredient2.IngredientQuantity);

            ingredient3 = new Ingredients(in3, al3, calPU3, fatPU3, carbPU3, proPU3, cholPU3);
            Assert.AreNotEqual(null, ingredient3);
            Assert.AreEqual(in3, ingredient3.IngredientName);
            Assert.AreEqual(al3, ingredient3.IsAllergen);
            Assert.AreEqual(calPU3, ingredient3.IngredientCaloriesPerUnit);
            Assert.AreEqual(fatPU3, ingredient3.IngredientFatPerUnit);
            Assert.AreEqual(carbPU3, ingredient3.IngredientCarbsPerUnit);
            Assert.AreEqual(proPU3, ingredient3.IngredientProteinPerUnit);
            Assert.AreEqual(cholPU3, ingredient3.IngredientCholesterolPerUnit);
            Assert.AreEqual(0, ingredient3.IngredientQuantity);

        }
        [TestMethod()]
        public void IngredientNameTest()
        {
            string in1 = "@#$%", in2 = "asd2134", in3 = "My ID 3";
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientName = in1;
            Assert.AreEqual(in1, ingredient1.IngredientName);
            ingredient1.IngredientName = in2;
            Assert.AreEqual(in2, ingredient1.IngredientName);
            ingredient1.IngredientName = in3;
            Assert.AreEqual(in3, ingredient1.IngredientName);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientName = in1;
            ingredient2.IngredientName = ingredient1.IngredientName;
            Assert.AreEqual(ingredient1.IngredientName, ingredient2.IngredientName);
        }
        [TestMethod()]
        public void IsAllergenTest()
        {
            bool al1 = true, al2 = false, al3 = true;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IsAllergen = al1;
            Assert.AreEqual(al1, ingredient1.IsAllergen);
            ingredient1.IsAllergen = al2;
            Assert.AreEqual(al2, ingredient1.IsAllergen);
            ingredient1.IsAllergen = al3;
            Assert.AreEqual(al3, ingredient1.IsAllergen);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IsAllergen = al1;
            ingredient2.IsAllergen = ingredient1.IsAllergen;
            Assert.AreEqual(ingredient1.IsAllergen, ingredient2.IsAllergen);
        }
        [TestMethod()]
        public void IngredientCaloriesPerUnitTest()
        {
            double calPU1 = 0.0, calPU2 = 100.0, calPU3 = 10.10;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCaloriesPerUnit = calPU1;
            Assert.AreEqual(calPU1, ingredient1.IngredientCaloriesPerUnit);
            ingredient1.IngredientCaloriesPerUnit = calPU2;
            Assert.AreEqual(calPU2, ingredient1.IngredientCaloriesPerUnit);
            ingredient1.IngredientCaloriesPerUnit = calPU3;
            Assert.AreEqual(calPU3, ingredient1.IngredientCaloriesPerUnit);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCaloriesPerUnit = calPU1;
            ingredient2.IngredientCaloriesPerUnit = ingredient1.IngredientCaloriesPerUnit;
            Assert.AreEqual(ingredient1.IngredientCaloriesPerUnit, ingredient2.IngredientCaloriesPerUnit);
        }
        [TestMethod()]
        public void IngredientFatPerUnitTest()
        {
            double fatPU1 = 0.0, fatPU2 = 100.0, fatPU3 = 10.10;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientFatPerUnit = fatPU1;
            Assert.AreEqual(fatPU1, ingredient1.IngredientFatPerUnit);
            ingredient1.IngredientFatPerUnit = fatPU2;
            Assert.AreEqual(fatPU2, ingredient1.IngredientFatPerUnit);
            ingredient1.IngredientFatPerUnit = fatPU3;
            Assert.AreEqual(fatPU3, ingredient1.IngredientFatPerUnit);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientFatPerUnit = fatPU1;
            ingredient2.IngredientFatPerUnit = ingredient1.IngredientFatPerUnit;
            Assert.AreEqual(ingredient1.IngredientFatPerUnit, ingredient2.IngredientFatPerUnit);
        }
        [TestMethod()]
        public void IngredientCarbsPerUnitTest()
        {
            double carbPU1 = 0.0, carbPU2 = 100.0, carbPU3 = 10.10;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCarbsPerUnit = carbPU1;
            Assert.AreEqual(carbPU1, ingredient1.IngredientCarbsPerUnit);
            ingredient1.IngredientCarbsPerUnit = carbPU2;
            Assert.AreEqual(carbPU2, ingredient1.IngredientCarbsPerUnit);
            ingredient1.IngredientCarbsPerUnit = carbPU3;
            Assert.AreEqual(carbPU3, ingredient1.IngredientCarbsPerUnit);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCarbsPerUnit = carbPU1;
            ingredient2.IngredientCarbsPerUnit = ingredient1.IngredientCarbsPerUnit;
            Assert.AreEqual(ingredient1.IngredientCarbsPerUnit, ingredient2.IngredientCarbsPerUnit);
        }
        [TestMethod()]
        public void IngredientProteinPerUnitTest()
        {
            double proPU1 = 0.0, proPU2 = 100.0, proPU3 = 10.10;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientProteinPerUnit = proPU1;
            Assert.AreEqual(proPU1, ingredient1.IngredientProteinPerUnit);
            ingredient1.IngredientProteinPerUnit = proPU2;
            Assert.AreEqual(proPU2, ingredient1.IngredientProteinPerUnit);
            ingredient1.IngredientProteinPerUnit = proPU3;
            Assert.AreEqual(proPU3, ingredient1.IngredientProteinPerUnit);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientProteinPerUnit = proPU1;
            ingredient2.IngredientProteinPerUnit = ingredient1.IngredientProteinPerUnit;
            Assert.AreEqual(ingredient1.IngredientProteinPerUnit, ingredient2.IngredientProteinPerUnit);
        }
        [TestMethod()]
        public void IngredientCholesterolPerUnitTest()
        {
            double cholPU1 = 0.0, cholPU2 = 100.0, cholPU3 = 10.10;
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCholesterolPerUnit = cholPU1;
            Assert.AreEqual(cholPU1, ingredient1.IngredientCholesterolPerUnit);
            ingredient1.IngredientCholesterolPerUnit = cholPU2;
            Assert.AreEqual(cholPU2, ingredient1.IngredientCholesterolPerUnit);
            ingredient1.IngredientCholesterolPerUnit = cholPU3;
            Assert.AreEqual(cholPU3, ingredient1.IngredientCholesterolPerUnit);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientCholesterolPerUnit = cholPU1;
            ingredient2.IngredientCholesterolPerUnit = ingredient1.IngredientCholesterolPerUnit;
            Assert.AreEqual(ingredient1.IngredientCholesterolPerUnit, ingredient2.IngredientCholesterolPerUnit);
        }
        [TestMethod()]
        public void IngredientQuantityTest()
        {
            ingredient1 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            Assert.AreEqual(ingredient1.IngredientQuantity, 0);
            int q1 = 0;
            int q2 = 10;
            ingredient1.IngredientQuantity = q1;
            Assert.AreEqual(q1, ingredient1.IngredientQuantity);
            ingredient1.IngredientQuantity = q2;
            Assert.AreEqual(q2, ingredient1.IngredientQuantity);
            ingredient2 = new Ingredients("RecipeName", true, 0.0, 0.0, 0.0, 0.0, 0.0);
            ingredient1.IngredientQuantity = q1;
            ingredient2.IngredientQuantity = ingredient1.IngredientQuantity;
            Assert.AreEqual(ingredient1.IngredientQuantity, ingredient2.IngredientQuantity);
        }
    }
}
