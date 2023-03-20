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

namespace AutiomationForInternalToool
{
    
    public class Browser_ops
    {
        IWebDriver? webDriver;
        public void OpenBrowser()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
        }

        public string Title
        {
            get { return webDriver.Title; }
        }

        public void Goto(string url)
        {
            webDriver.Url = url;
        }

        public void Close()
        {
            webDriver.Quit();
        }

        public IWebDriver getDriver
        {
            get { return webDriver; }
        }
    }
    public class Tests
    {
        Browser_ops brow = new Browser_ops();
        String test_url = "https://www.duckduckgo.com";
        IWebDriver driver;




        [SetUp]
        public void Setup()
        {
            brow.OpenBrowser();
        }

        [Test]
        public void Test1()
        {
            brow.Goto(test_url);
            System.Threading.Thread.Sleep(4000);

            driver = brow.getDriver;

            IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));

            element.SendKeys("LambdaTest");

            /* Submit the Search */
            element.Submit();

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Assert.Pass();
        }








        [TearDown]
        public void close_Browser()
        {
            brow.Close();
        }
    }
}













    








