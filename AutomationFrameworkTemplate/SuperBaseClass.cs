using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace AutomationFrameworkTemplate
{

    public class SuperBaseClass
    {
        private IWebDriver _driver;
        private DataHelper _dataHelper;
        private SeleniumHelper _seleniumHelper;
        public IWebDriver WebDriver
        {
            get
            {
                return _driver;
            }

            set => _driver = value;
        }

        public SeleniumHelper SeleniumHelper {
            get {
                if (_seleniumHelper == null)
                    _seleniumHelper = new SeleniumHelper(WebDriver);
                return _seleniumHelper;
            }
        }

        public DataHelper DataHelper
        {
            get
            {
                if (_dataHelper == null)
                    _dataHelper = new DataHelper();
                return _dataHelper;
            }
        }
    }

}
