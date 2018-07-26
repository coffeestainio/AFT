using OpenQA.Selenium;
using System.Threading;

namespace Utilities.Helpers
{
    public class SeleniumHelper
    {

        IWebDriver _driver;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;       
        }

        public bool IsContentonPage(string content) {
            Thread.Sleep(4000);
            return _driver.PageSource.Contains(content);
        }
    }
}
