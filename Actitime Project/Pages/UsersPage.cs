using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{

    public class UsersPage
    {
        private By _clickNewUserLocator = By.XPath("//div[normalize-space()='New User']");
        private By _clickUserNameContainerLocator = By.XPath("//table[@class='userNameContainer']");

        private IWebDriver driver;
        
        public UsersPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public void ClickNewUser()
        {
            driver.FindElement(_clickNewUserLocator).Click();
        }
        public void ClickUserNameContainer()
        {
            driver.FindElement(_clickUserNameContainerLocator).Click();
        }


    }
}
