using Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;

namespace Pages.Pages
{
    public class LoginPage
    {
        IWebDriver _webDriver;
        SeleniumHelper _seleniumHelper;

        By _txtUsername = By.Id("inputUsername");
        By _txtPassword = By.Id("inputPassword");
        By _btnIngresar = By.Id("buttonIngresar");


        public LoginPage(IWebDriver webDriver, SeleniumHelper seleniumHelper)
        {
            _webDriver = webDriver;
            _seleniumHelper = seleniumHelper;
        }

        public void LoginUser(User user)
        {
            IWebElement txtUsername = _webDriver.FindElement(_txtUsername);
            txtUsername.SendKeys(user.username);

            IWebElement txtPassword = _webDriver.FindElement(_txtPassword);
            txtPassword.SendKeys(user.password);

            IWebElement btnIngresar = _webDriver.FindElement(_btnIngresar);
            btnIngresar.Click();
        }

        public bool WasLoginSuccessful()
        {
            return _seleniumHelper.IsContentonPage("Error: Usuario y contraseña no coinciden");
        }

    }
}
