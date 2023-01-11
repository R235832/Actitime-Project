using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class TypeofWorkPage
    {
        private By _clickCreateTypeofWorkLocator = By.XPath("//span[normalize-space()='Create Type of Work']");
       
        private IWebDriver driver;
        public TypeofWorkPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickCreateTypeofWork()
        {
            driver.FindElement(_clickCreateTypeofWorkLocator).Click();
        }
        public string CheckNameofWork(string nameofwork)
        {
            string headerlocator = "//a[contains(normalize-space(),'@@@@@')]";
            headerlocator = headerlocator.Replace("@@@@@", nameofwork);
            string workname = driver.FindElement(By.XPath(headerlocator)).Text;
            return workname;
        }
        

    }
}
