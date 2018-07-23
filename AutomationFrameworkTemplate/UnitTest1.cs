using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Helpers;

namespace AutomationFrameworkTemplate
{
    [TestClass]
    public class UnitTest1 : TestBaseClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebDriver.Navigate().GoToUrl("http://www.google.com");
            
        }
    }
}
