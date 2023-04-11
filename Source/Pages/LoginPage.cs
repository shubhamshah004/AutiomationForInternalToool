using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal.Execution;

namespace AutiomationForInternalToool.Source.Pages
{
    
    public class LoginPage
    {
        public IWebDriver webDriver;
        AllLocator locator;
        string url = "https://localhost:7226/";
        string EmptyUsernameWarning = "The Email field is required.";
        string EmptyPassWarinig = "The Password field is required.";

        String InvalidUsernamWarning = "The Email field is not a valid e-mail address.";
        string InvalidPassWarning = "Passwords must be at least 8 characters and contain the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)";
        String NotContainPersiWarning = "Email must contain @persistent.com";
        string WrongPassWarning = "Invalid name and password";
        public LoginPage(IWebDriver webDriver)
        {
            locator = new AllLocator(webDriver);
            this.webDriver = webDriver;
        }
        public void BrowserOperations()    
        {
            locator = new AllLocator(webDriver);
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        public void GotoUrl() 
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }

        public void AdminLogin()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(3000);
            locator.EnterUsernameAdmin();
            Thread.Sleep(1000);
            locator.EnterPassword();
            Thread.Sleep(1000);
            locator.ClickLoginBtn();
            Thread.Sleep(3000);

        }
        public void AssessLogin()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(3000);
            locator.EnterUserNameAssessee();
            Thread.Sleep(1000);
            locator.EnterPassword();
            Thread.Sleep(1000);
            locator.ClickLoginBtn();
            Thread.Sleep(1000);

        }
        public void VerifyWarningforEmptyUsernameAndEmptyPassword()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(2000);
            locator.ClickLoginBtn();
            Thread.Sleep(3000);
            string WarningForUsernameFromUi = locator.GetEmptyUsernameWarning();
            Assert.That(WarningForUsernameFromUi, Is.EqualTo(EmptyUsernameWarning));
            string WarningForPassFromUI = locator.GetEmptyPassWarning();
            Assert.That(WarningForPassFromUI, Is.EquivalentTo(EmptyPassWarinig));
            TestContext.WriteLine("Successfully Given Warning for Empty Username and Password");

        }
        public void VerifyWrongUsernameAndWrongPassWarning()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(2000);
            locator.EnterWrongUsername();
            locator.ClickLoginBtn();
            Thread.Sleep(2000);
            string WarningForWrongUsernameFromUI = locator.GetWrongUserameWarning();
            Assert.That(WarningForWrongUsernameFromUI, Is.EqualTo(NotContainPersiWarning));
            locator.ClearTheUsernameField();
            locator.EnterRightUsername();
            Thread.Sleep(2000);
            locator.EnterWrongPass();
            Thread.Sleep(2000);
            locator.ClickLoginBtn();
            Thread.Sleep(2000);
            string WarningForWrongPassFromUI = locator.GetWrongPassWarining();
            Assert.That(WarningForWrongPassFromUI, Is.EqualTo(WrongPassWarning));
            TestContext.WriteLine("Successfully Given Warning for Wrong Username (not contain @peristent.com) and Wrong Psssword");

        }

        public void VerifyInvalidUsernameAndInvalidPassWarning()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(2000);
            locator.EnterInvalidUsername();
            locator.EnterInvalidPass();
            locator.ClickLoginBtn();
            Thread.Sleep(2000);
            string WarningForInvalidUsernameFromUI = locator.GetInvalidUsernameWarnign();
            string WarningForInvalidPassFromUI = locator.GetInvalidPasssWarning();
            Assert.That(WarningForInvalidUsernameFromUI, Is.EqualTo(InvalidUsernamWarning));
            Assert.That(WarningForInvalidPassFromUI, Is.EqualTo(InvalidPassWarning));
            TestContext.WriteLine("Successfully Given Warning for Invalid Username");

        }

        
       

    }



}

