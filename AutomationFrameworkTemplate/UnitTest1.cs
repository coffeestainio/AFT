using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using OpenQA.Selenium;
using Utilities.Helpers;

namespace AutomationFrameworkTemplate
{
    [TestClass]
    public class UnitTest1 : TestBaseClass
    {

      
        [TestMethod]
        public void UnSuccesfulLogin()
        {
            var testUser = new User("marquito", "juanito");

            LoginPage.LoginUser(testUser);

            Assert.IsTrue(LoginPage.WasLoginSuccessful());
        }

        [TestMethod]
        [Ignore]
        public void SuccessfulLogin()
        {

            var testUser = new User("username", "password");

            LoginPage.LoginUser(testUser);       

            Assert.IsTrue(SeleniumHelper.IsContentonPage("Hola pablo!"));
        }

    }
}
