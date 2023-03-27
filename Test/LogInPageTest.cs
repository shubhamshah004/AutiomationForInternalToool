using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutiomationForInternalToool.Source.Pages;
using System.Xml.Serialization;

namespace AutiomationForInternalToool.Test
{
    [TestFixture]
    public class Tests
    {
  
        IWebDriver webDriver;
        LoginPage loginPage;
        string url = "https://localhost:7226/";

        [SetUp]
        public void OpenBrowser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            loginPage = new LoginPage(webDriver);


        }
        

        [Test]
        public void Test1()
        {
            
            loginPage.GotoUrl(url);
            Thread.Sleep(10000);
            loginPage.EnterUserName();
            loginPage.EnterPassword();
            loginPage.ClickLoginBtn();

        }

        [TearDown]
        public void TearDown()
        {
            loginPage.Close();

        }
        
    }
}






















