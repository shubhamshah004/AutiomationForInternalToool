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
        

        [SetUp]
        public void OpenBrowser()
        {
            loginPage = new LoginPage(webDriver);
            loginPage.BrowserOperations();
            loginPage.GotoUrl();

        }
        

        [Test]
        public void IfUsernameAndPasswordAreEmptyGivesWarning()
        {
            
            loginPage.VerifyWarningforEmptyUsernameAndEmptyPassword();

        }
        [Test]
        public void IfUsernmaeIvalidGivesWarnign()
        {

            loginPage.VerifyInvalidUsernameAndInvalidPassWarning();

        }
        [Test]
        public void IFUsernameIsWrongGivesWarnign()
        {
            loginPage.VerifyWrongUsernameAndWrongPassWarning();
        }

        [TearDown]
        public void TearDown()
        {
            loginPage.Close();

        }
        
    }
}






















