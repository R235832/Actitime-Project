using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Pages
{
    public class NeverloggedinPage
    {
        private IWebDriver driver;
        public NeverloggedinPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string CheckUserName(string realName)
        {
            string headerlocator = "(//div[contains(normalize-space(),'@@@@@')])[10]";

            headerlocator = headerlocator.Replace("@@@@@", realName);
            string enterUserName = driver.FindElement(By.XPath(headerlocator)).Text;
            return enterUserName;

        }
    }
}
