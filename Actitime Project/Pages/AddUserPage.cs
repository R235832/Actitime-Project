using DocumentFormat.OpenXml.Wordprocessing;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class AddUserPage
    {
        private By _enterFirstnameLocator = By.Id("createUserPanel_firstNameField");
        private By _enterMiddletnameLocator = By.Id("createUserPanel_middleNameField");
        private By _enterLastnameLocator = By.Id("createUserPanel_lastNameField");
        private By _enterEmailLocator = By.Id("createUserPanel_emailField");
        private By _clickSaveLocator = By.XPath("//div[normalize-space()='Save & Send Invitation']");
        private By _clickCloseLocator = By.XPath("//span[normalize-space()='Close']");
        private IWebDriver driver;
        public AddUserPage(IWebDriver driver)
        { 
            this.driver = driver;
        }
        public void EnterFirstname(string firstname)
        {
            driver.FindElement(_enterFirstnameLocator).SendKeys(firstname);
           
        }
        public void EnterMiddletname(string middlename)
        {
          driver.FindElement(_enterMiddletnameLocator).SendKeys(middlename);
           
        }
        public void EnterLastname(string lastname)
        {
            
            driver.FindElement(_enterLastnameLocator).SendKeys(lastname);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(_enterEmailLocator).SendKeys(email);
        }
        public void ClickSave()
        {
            driver.FindElement(_clickSaveLocator).Click();
        }
        public void ClickClose()
        {
            driver.FindElement(_clickCloseLocator).Click();
        }
    }
}
