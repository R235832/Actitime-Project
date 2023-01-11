using Actitime_Project.Base;
using Actitime_Project.Pages;
using Actitime_Project.Utilities;
using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Actitime_Project
{
    public class TypeofWorkTest:AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.createTypeofWorkData))]
        
        public void createTypeofWorkTest(string username,string password,string nameofwork,string status,string billingRate)
        {
            LoginPage logindata = new LoginPage(driver);
            logindata.EnterUserName(username);
            logindata.EnterPassword(password);
            logindata.ClickOnLogin();
            MainPage mainPage= new MainPage(driver);
            mainPage.ClickMenuIcon();
            mainPage.ClicktypeofWork();
            TypeofWorkPage type=new TypeofWorkPage(driver);
            type.ClickCreateTypeofWork();
            CreateNewTypeofWorkPage workpage=new CreateNewTypeofWorkPage(driver);
            workpage.EnterName(nameofwork);
            workpage.statusChoose(status);
            workpage.CategoryChoose();
            workpage.BillingRate(billingRate);
            workpage.ClickTRypeofWork();
            string result= type.CheckNameofWork(nameofwork);
           
            
            Assert.That(result,Is.EqualTo(nameofwork));
            Thread.Sleep(4000);
            //type.DeleteTypeofWork();
            driver.FindElement(By.XPath("//a[contains(normalize-space(),'delete')]")).Click();
            driver.SwitchTo().Alert().Accept();
            Actions action = new Actions(driver);
            driver.FindElement(By.XPath("//a[normalize-space()='Logout']")).Click();



        }
    }
}
