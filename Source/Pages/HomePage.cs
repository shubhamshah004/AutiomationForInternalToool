using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutiomationForInternalToool.Source.Pages
{
    public class HomePage
    {
        
        public IWebDriver webDriver;
        AllLocator locator;
        string url = "https://localhost:7226/homepage";

        public HomePage(IWebDriver webDriver)
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
        public void testhomepage()
        {
            locator = new AllLocator(webDriver);
            Thread.Sleep(3000);

            locator.clickLogoutBtn();

    }
        public void Close()
        {
            webDriver.Quit();
        }

    }
}
