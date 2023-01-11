using Actitime_Project.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project
{
    public class LoginUiTest : AutomationWrapper
    {
        [Test]
        public void ValidTitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("actiTIME - Login"));
        }
        [Test]
        public void ValidPlaceHolderTest()
        {
            string actualUserNamePlaceHolder = driver.FindElement(By.Id("username")).GetAttribute("placeholder");
            string actualPasswordPlaceHolder = driver.FindElement(By.Name("pwd")).GetAttribute("placeholder");
            Assert.That(actualUserNamePlaceHolder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceHolder, Is.EqualTo("Password"));

        }
    }
}
