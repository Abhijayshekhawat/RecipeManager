using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager;
using System;
using System.Collections.Generic;

namespace RecipeUnitTests
{
    [TestClass]
    public class RecipeTest
    {
        private TestContext testContextInstance;
        Recipe recipe1, recipe2, recipe3;
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
            recipe1 = null;
            recipe2 = null;
            recipe3 = null;
        }

        [TestMethod]
        public void RecipeConstructorTest()
        {
            string rn1 = "Tomato", rn2 = "23131#$", rn3 = null;
            string rd1 = "Tomato", rd2 = "23131#$", rd3 = null;
            string riu1 = "Tomato", riu2 = "23131#$", riu3 = null;
            string rdi1 = "Tomato", rdi2 = "23131#$", rdi3 = null;
            int ss1 = 0, ss2 = 20, ss3 = 100;
            List <Ingredients> i1 = new List <Ingredients>();
            List<Ingredients> i2 = new List<Ingredients>();
            List<Ingredients> i3 = new List<Ingredients>();
            Assert.AreEqual(null, recipe1);
            Assert.AreEqual(null, recipe2);
            Assert.AreEqual(null, recipe3);

            recipe1 = new Recipe(rn1, rd1, riu1, rdi1, ss1, i1);
            Assert.AreNotEqual(null, recipe1);
            Assert.AreEqual(rn1, recipe1.RecipeName);
            Assert.AreEqual(rd1, recipe1.RecipeDescription);
            Assert.AreEqual(riu1, recipe1.RecipeImageUrl);
            Assert.AreEqual(rdi1, recipe1.RecipeDirections);
            Assert.AreEqual(ss1, recipe1.ServingSize);
            for (int i = 0; i < i1.Count; i++)
            {
                Assert.AreEqual(i1[i], recipe1.Allergens[i]);
            }
            Assert.IsNotNull(recipe1.Ingredients);
            Assert.AreEqual(0, recipe1.Ingredients.Count);

            recipe2 = new Recipe(rn2, rd2, riu2, rdi2, ss2, i2);
            Assert.AreNotEqual(null, recipe2);
            Assert.AreEqual(rn2, recipe2.RecipeName);
            Assert.AreEqual(rd2, recipe2.RecipeDescription);
            Assert.AreEqual(riu2, recipe2.RecipeImageUrl);
            Assert.AreEqual(rdi2, recipe2.RecipeDirections);
            Assert.AreEqual(ss2, recipe2.ServingSize);
            for (int i = 0; i < i2.Count; i++)
            {
                Assert.AreEqual(i2[i], recipe2.Allergens[i]);
            }
            Assert.IsNotNull(recipe2.Ingredients);
            Assert.AreEqual(0, recipe2.Ingredients.Count);

            recipe3 = new Recipe(rn3, rd3, riu3, rdi3, ss3, i3);
            Assert.AreNotEqual(null, recipe3);
            Assert.AreEqual(rn3, recipe3.RecipeName);
            Assert.AreEqual(rd3, recipe3.RecipeDescription);
            Assert.AreEqual(riu3, recipe3.RecipeImageUrl);
            Assert.AreEqual(rdi3, recipe3.RecipeDirections);
            Assert.AreEqual(ss3, recipe3.ServingSize);
            for (int i = 0; i < i3.Count; i++)
            {
                Assert.AreEqual(i3[i], recipe3.Allergens[i]);
            }
            Assert.IsNotNull(recipe3.Ingredients);
            Assert.AreEqual(0, recipe3.Ingredients.Count);

        }
        [TestMethod()]
        public void RecipeNameTest()
        {
            List<Ingredients> li1 = new List<Ingredients>();
            recipe1 = new Recipe("@#$%", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0,li1);
            recipe2 = new Recipe("asd2134", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0,li1);
            recipe3 = new Recipe("My ID 3", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0,li1);
            Assert.AreEqual("@#$%", recipe1.RecipeName);
            Assert.AreEqual("asd2134", recipe2.RecipeName);
            Assert.AreEqual("My ID 3", recipe3.RecipeName);
            recipe2 = new Recipe("@#$%", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0, li1);
            Assert.AreEqual(recipe1.RecipeName, recipe2.RecipeName);
        }
        [TestMethod()]
        public void RecipeDescriptionTest()
        {
            List<Ingredients> li1 = new List<Ingredients>();
            recipe1 = new Recipe("RecipeName", "@#$%", "RecipeImageUrl", "RecipeDirections", 0, li1);
            recipe2 = new Recipe("RecipeName", "asd2134", "RecipeImageUrl", "RecipeDirections", 0, li1);
            recipe3 = new Recipe("RecipeName", "My ID 3", "RecipeImageUrl", "RecipeDirections", 0, li1);
            Assert.AreEqual("@#$%", recipe1.RecipeDescription);
            Assert.AreEqual("asd2134", recipe2.RecipeDescription);
            Assert.AreEqual("My ID 3", recipe3.RecipeDescription);
            recipe2 = new Recipe("RecipeName", "@#$%", "RecipeImageUrl", "RecipeDirections", 0, li1);
            Assert.AreEqual(recipe1.RecipeDescription, recipe2.RecipeDescription);
        }
        [TestMethod()]
        public void RecipeImageUrlTest()
        {
            List<Ingredients> li1 = new List<Ingredients>();
            recipe1 = new Recipe("RecipeName", "RecipeDescription", "@#$%", "RecipeDirections", 0, li1);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "asd2134", "RecipeDirections", 0, li1);
            recipe3 = new Recipe("RecipeName", "RecipeDescription", "My ID 3", "RecipeDirections", 0, li1);
            Assert.AreEqual("@#$%", recipe1.RecipeImageUrl);
            Assert.AreEqual("asd2134", recipe2.RecipeImageUrl);
            Assert.AreEqual("My ID 3", recipe3.RecipeImageUrl);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "@#$%", "RecipeDirections", 0, li1);
            Assert.AreEqual(recipe1.RecipeImageUrl, recipe2.RecipeImageUrl);
        }
        [TestMethod()]
        public void RecipeDirectionsTest()
        {
            List<Ingredients> li1 = new List<Ingredients>();
            recipe1 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "@#$%", 0, li1);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "asd2134", 0, li1);
            recipe3 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "My ID 3", 0, li1);
            Assert.AreEqual("@#$%", recipe1.RecipeDirections);
            Assert.AreEqual("asd2134", recipe2.RecipeDirections);
            Assert.AreEqual("My ID 3", recipe3.RecipeDirections);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "@#$%", 0, li1);
            Assert.AreEqual(recipe1.RecipeDirections, recipe2.RecipeDirections);
        }
        [TestMethod()]
        public void ServingSizeTest()
        {
            List<Ingredients> li1 = new List<Ingredients>();
            recipe1 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0, li1);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 10, li1);
            recipe3 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 100, li1);
            Assert.AreEqual(0, recipe1.ServingSize);
            Assert.AreEqual(10, recipe2.ServingSize);
            Assert.AreEqual(100, recipe3.ServingSize);
            recipe2 = new Recipe("RecipeName", "RecipeDescription", "RecipeImageUrl", "RecipeDirections", 0, li1);
            Assert.AreEqual(recipe1.ServingSize, recipe2.ServingSize);
        }
    }
}
