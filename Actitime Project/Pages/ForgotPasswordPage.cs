using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class forgotPasswordPage
    {
        private By _headercheckLocator = By.Id("headerContainer");
        private IWebDriver driver;
        public forgotPasswordPage(IWebDriver driver)
        { 
            this.driver = driver; 
        }
        public string Headercheck()
        {
            string headerofThePage = driver.FindElement(_headercheckLocator).Text;
            return headerofThePage;
        }
    }
}
