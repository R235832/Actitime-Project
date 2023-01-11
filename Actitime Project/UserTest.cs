using Actitime_Project.Base;
using Actitime_Project.Pages;
using Actitime_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project
{
    public class UserTest:AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.ValidUserData))]
        
        public void ValidUserTest(string username,string password,string firstname,string middlename,string lastname,string email,string realName)
        {

            LoginPage logindata = new LoginPage(driver);
            logindata.EnterUserName(username);
            logindata.EnterPassword(password);
            logindata.ClickOnLogin();
            MainPage mainPage = new MainPage(driver);
            mainPage.ClickonUsers();
            UsersPage userp=new UsersPage(driver);
            userp.ClickNewUser();
            Thread.Sleep(4000);
            AddUserPage addUserPage= new AddUserPage(driver);
            addUserPage.EnterFirstname(firstname);
            addUserPage.EnterMiddletname(middlename);
            addUserPage.EnterLastname(lastname);
            addUserPage.EnterEmail(email);
            addUserPage.ClickSave();
            addUserPage.ClickClose();
            NeverloggedinPage neverloggedin=new NeverloggedinPage(driver);
            string enterUserName= neverloggedin.CheckUserName(realName);

            
            Assert.That(enterUserName.Contains(realName));

           

        }

    }
}
