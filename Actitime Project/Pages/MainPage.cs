using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class MainPage
    {
        private By _clickMenuLocator = By.XPath("(//div[@class=\"menu_icon\"])[2]");
        private By _clickworkLocator = By.XPath("//a[normalize-space()='Types of Work']");
        private By _clickonUserLocator = By.Id("container_users");
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickMenuIcon()
        {
            driver.FindElement(_clickMenuLocator).Click();
        }
        public void ClicktypeofWork()
        {
            driver.FindElement(_clickworkLocator).Click();
        }
        public void ClickonUsers()
        {
            driver.FindElement(_clickonUserLocator).Click();
        }
       
    }
}
