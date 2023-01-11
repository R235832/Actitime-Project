using Actitime_Project.Base;
using Actitime_Project.Pages;
using Actitime_Project.Utilities;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project
{
    public class LoginTest:AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
       
        public void ValidLoginTest(string username,string password,string properlink)

        {
            LoginPage logindata = new LoginPage(driver);
            logindata.EnterUserName(username);
            logindata.EnterPassword(password);
            logindata.ClickOnLogin();
           
            string homePage = driver.Url;
            Assert.That(homePage, Is.EqualTo(properlink));

        }
        [Test, TestCaseSource(typeof(DataSource), (nameof(DataSource.InvalidLoginData)))]
        public void InvalidLoginTest(string username,string password,string errorMessage)
        {
            LoginPage logindata = new LoginPage(driver);
            logindata.EnterUserName(username);
            logindata.EnterPassword(password);
            logindata.ClickOnLogin();

           
            string printMessage=logindata.GetErrorMessage();
            Assert.That(printMessage.Contains(errorMessage));
        }
    }
}
