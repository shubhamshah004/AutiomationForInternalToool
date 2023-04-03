using AutiomationForInternalToool.Source.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutiomationForInternalToool.Test
{
    [TestFixture]
    public class HomePageTest
    {

        IWebDriver webDriver;
        HomePage homePage;


        [SetUp]
        public void OpenBrowser()
        {
            homePage = new HomePage(webDriver);
            homePage.BrowserOperations();
            homePage.GotoUrl();

        }


        [Test]
        public void Test2()
        {
           // homePage.NormalLogin();

        }

        [TearDown]
        public void TearDown()
        {
            homePage.Close();

        }

    }
}
