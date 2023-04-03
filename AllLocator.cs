using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Events;

namespace AutiomationForInternalToool
{
    
    public class AllLocator
    {
        public IWebDriver webDriver;
        By LogInBtn = By.TagName("button");
        By EmailTextBox = By.Id("email");
        By PassTextBox = By.Id("password");

        By LogOutBtn = By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/button[2]");
        By addQuizCat = By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/button[1]");

        public AllLocator(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }
        public void ClickLoginBtn()
        {
            webDriver.FindElement(LogInBtn).Click(); 
        }

        public void clickLogoutBtn()
        {
            webDriver.FindElement(LogOutBtn).Click();
        }

        public void addQuizCategory()
        {
            webDriver.FindElement(addQuizCat).Click();
        }
        public void EnterUsername()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubhamshah@persistent.com");
        }
        public void EnterPassword()
        {
            webDriver.FindElement(PassTextBox).SendKeys("TH$sdjglsdjgfjsdfs@323##");
        }
            
    }
}
