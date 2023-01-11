using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class LoginPage
    {
        private By _usernameLocator = By.Id("username");
        private By _passwordLocator = By.Name("pwd");
        private By _clickOnLoginLocator = By.Id("loginButton");
        private By _forgotpasswordLocator =By.XPath("//a[normalize-space()='Forgot your password?']");
        private By _errorLocator = By.XPath("//span[normalize-space()='Username or Password is invalid. Please try again.']");
        private By _forgotpassswordLinkLocator = By.XPath("//a[normalize-space()='Forgot your password?']");
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        { 
            this.driver = driver; 
        }
        public  void EnterUserName(string username)  
        {
            driver.FindElement(_usernameLocator).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(_clickOnLoginLocator).Click();
        }
        public void ForgotPassword()
        {
            driver.FindElement(_forgotpasswordLocator).Click();
        }
        public string GetErrorMessage()
        {
            return driver.FindElement(_errorLocator).Text;
        }
        public void ForgotpassswordLink()
        {
            driver.FindElement(_forgotpassswordLinkLocator).Click();
           

        }

    }
}
