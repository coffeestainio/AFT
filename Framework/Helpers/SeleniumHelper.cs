using OpenQA.Selenium;

namespace Utilities.Helpers
{
    public class SeleniumHelper
    {

        IWebDriver _driver;

        public SeleniumHelper(IWebDriver driver)
        {
            _driver = driver;
            
        }
    }
}
