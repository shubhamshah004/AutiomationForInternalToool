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


        public AllLocator(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }
        public void ClickLoginBtn()
        {
            webDriver.FindElement(LogInBtn).Click(); 
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
