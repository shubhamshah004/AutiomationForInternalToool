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


        public void NormalLogin()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(3000);
            locator.EnterUsername();
            Thread.Sleep(1000);
            locator.EnterPassword();
            Thread.Sleep(1000);
            locator.EnterPassword();
            
        }

    }



}

