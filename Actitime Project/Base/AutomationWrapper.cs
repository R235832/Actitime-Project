using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project.Base
{
    public class AutomationWrapper
    {
        protected IWebDriver driver;
        [SetUp]
        public void AfterMethod()
        {
            string browsername = "edge";
            if (browsername.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if (browsername.ToLower().Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://demo.actitime.com/login.do";
        }
        [TearDown]
        public void BeforeMethod()
        {
          
            driver.Quit();
        }
    }
}

