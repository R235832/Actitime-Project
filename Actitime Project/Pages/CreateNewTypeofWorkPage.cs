using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class CreateNewTypeofWorkPage
    {
        private By _EnterNameLocator = By.Id("name");
        private By _statusChooseLocator = By.Name("active");
        private By _categoryChooseLocator = By.Id("billingType_setBillable");
        private By _billingRateLocator = By.Id("billingRate_input");
        private By _clickTypeofWorkLocator = By.XPath("//input[@type='submit']");
        private IWebDriver driver;
        public CreateNewTypeofWorkPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterName(string nameofwork)
        {
            driver.FindElement(_EnterNameLocator).SendKeys(nameofwork);
        }
        public void statusChoose(string status)
        {
            SelectElement realstatus = new SelectElement(driver.FindElement(_statusChooseLocator));
            realstatus.SelectByText(status);
        }
        public void CategoryChoose()
        {
            driver.FindElement(_categoryChooseLocator).Click();
        }
        public void BillingRate(string billingRate)
        {
            driver.FindElement(_billingRateLocator).SendKeys(billingRate);
        }
        public void ClickTRypeofWork()
        {
            driver.FindElement(_clickTypeofWorkLocator).Click();
        }
    }
}
