using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFrameworkTemplate
{
    public class TestBaseClass : SuperBaseClass
    {

        [TestInitialize]
        public void Setup()
        {
            WebDriver = new ChromeDriver();
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
