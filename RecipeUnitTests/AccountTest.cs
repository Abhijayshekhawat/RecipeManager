using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager;
using System;
using System.Collections.Generic;

namespace RecipeUnitTests
{
    [TestClass]
    public class AccountTest
    {
        private TestContext testContextInstance;
        Account account1, account2;
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
            account1 = null;
            account2 = null;
        }

        [TestMethod]
        public void AccountConstructorTest()
        {
            string fn1 = "Jay", fn2 = "Jack";
            string ln1 = "Singh", ln2 = "Reacher";
            string un1 = "JS", un2 = "JR";
            string pwd1 = "12345678", pwd2 = "123456789";
            Assert.AreEqual(null, account1);
            Assert.AreEqual(null, account2);

            account1 = new Account(fn1, ln1, un1, pwd1);
            Assert.AreNotEqual(null, account1);
            Assert.AreEqual(fn1, account1.FirstName);
            Assert.AreEqual(ln1, account1.LastName);
            Assert.AreEqual(un1, account1.UserName);
            Assert.AreEqual(pwd1, account1.Password);
            Assert.IsNotNull(account1.SavedRecipeIds);
            Assert.AreEqual(0, account1.SavedRecipeIds.Count);

            account2 = new Account(fn2, ln2, un2, pwd2);
            Assert.AreNotEqual(null, account2);
            Assert.AreEqual(fn2, account2.FirstName);
            Assert.AreEqual(ln2, account2.LastName);
            Assert.AreEqual(un2, account2.UserName);
            Assert.AreEqual(pwd2, account2.Password);
            Assert.IsNotNull(account2.SavedRecipeIds);
            Assert.AreEqual(0, account2.SavedRecipeIds.Count);
        }
        [TestMethod]
        public void ShortPassword()
        {
            string firstName = "Tom";
            string lastName = "andJerry";
            string userName = "TaJ";
            string password= "1234567";
            try
            {
                Account account = new Account(firstName, lastName, userName, password);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Password must be at least 8 characters long.", ex.Message);
            }
        }
        [TestMethod]
        public void BlankUserName()
        {
            string firstName = "Tom";
            string lastName = "andJerry";
            string userName = " ";
            string password = "1234567";
            try
            {
                Account account = new Account(firstName, lastName, userName, password);
                Assert.Fail("Expected ArgumentException was not thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("UserName cannot be null or whitespace.", ex.Message);
            }
        }
        [TestMethod()]
        public void FirstNameTest()
        {
            string fn1 = "@#$%", fn2 = "asd2134", fn3 = "My ID 3";
            account1 = new Account("firstName","lastName","userName","password");
            account1.FirstName = fn1;
            Assert.AreEqual(fn1, account1.FirstName);
            account1.FirstName = fn2;
            Assert.AreEqual(fn2, account1.FirstName);
            account1.FirstName = fn3;
            Assert.AreEqual(fn3, account1.FirstName);
            account2 = new Account("firstName", "lastName", "userName", "password");
            account1.FirstName = fn1;
            account2.FirstName = account1.FirstName;
            Assert.AreEqual(account1.FirstName, account2.FirstName);
        }
        [TestMethod()]
        public void LastNameTest()
        {
            string ln1 = "@#$%", ln2 = "asd2134", ln3 = "My ID 3";
            account1 = new Account("firstName", "lastName", "userName", "password");
            account1.LastName = ln1;
            Assert.AreEqual(ln1, account1.LastName);
            account1.LastName = ln2;
            Assert.AreEqual(ln2, account1.LastName);
            account1.LastName = ln3;
            Assert.AreEqual(ln3, account1.LastName);
            account2 = new Account("firstName", "lastName", "userName", "password");
            account1.LastName = ln1;
            account2.LastName = account1.LastName;
            Assert.AreEqual(account1.LastName, account2.LastName);
        }
        [TestMethod()]
        public void UserNameTest()
        {
            string un1 = "@#$%", un2 = "asd2134", un3 = "My ID 3";
            account1 = new Account("firstName", "lastName", "userName", "password");
            account1.UserName = un1;
            Assert.AreEqual(un1, account1.UserName);
            account1.UserName = un2;
            Assert.AreEqual(un2, account1.UserName);
            account1.UserName = un3;
            Assert.AreEqual(un3, account1.UserName);
            account2 = new Account("firstName", "lastName", "userName", "password");
            account1.UserName = un1;
            account2.UserName = account1.UserName;
            Assert.AreEqual(account1.UserName, account2.UserName);
        }
        [TestMethod()]
        public void PasswordTest()
        {
            string pwd1 = "@#$%#$#$", pwd2 = "asd2134w", pwd3 = "My ID 3   ";
            account1 = new Account("firstName", "lastName", "userName", "password");
            account1.Password = pwd1;
            Assert.AreEqual(pwd1, account1.Password);
            account1.Password = pwd2;
            Assert.AreEqual(pwd2, account1.Password);
            account1.Password = pwd3;
            Assert.AreEqual(pwd3, account1.Password);
            account2 = new Account("firstName", "lastName", "userName", "password");
            account1.Password = pwd1;
            account2.Password = account1.Password;
            Assert.AreEqual(account1.Password, account2.Password);
        }
        [TestMethod()]
        public void SavedRecipesTest()
        {
            account1 = new Account("firstName", "lastName", "userName", "password");
            Assert.AreNotEqual(account1.SavedRecipeIds, null);
            List<int> tl1 = new List<int> { 1, 2, 3 };
            List<int> tl2 = new List<int> { 4, 5, 6 };
            account1.SavedRecipeIds = tl1;
            Assert.AreEqual(tl1, account1.SavedRecipeIds);
            account1.SavedRecipeIds = tl2;
            Assert.AreEqual(tl2, account1.SavedRecipeIds);
            account2 = new Account("firstName", "lastName", "userName", "password");
            account1.SavedRecipeIds = tl1;
            account2.SavedRecipeIds = account1.SavedRecipeIds;
            Assert.AreEqual(account1.SavedRecipeIds, account2.SavedRecipeIds);
        }
    }
}
