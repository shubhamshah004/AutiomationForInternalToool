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
            loginPage = new LoginPage(webDriver);
            loginPage.BrowserOperations();
            loginPage.GotoUrl();

        }
        

        [Test]
        public void Test1()
        {
            loginPage.NormalLogin();

        }

        [TearDown]
        public void TearDown()
        {
            loginPage.Close();

        }
        
    }
}






















