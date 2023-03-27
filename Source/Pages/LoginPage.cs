using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutiomationForInternalToool.Source.Pages
{
    
    public class LoginPage
    {
        public IWebDriver webDriver;
        By LogInBtn = By.TagName("button");
        By EmailTextBox = By.Id("email");
        By PassTextBox = By.Id("password");


        public LoginPage(IWebDriver webDriver)
        { 
            this.webDriver = webDriver;
        }
       
        

        public void GotoUrl(string url) 
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }


        public void NormalLogin()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubhamshah@persistent.com");
            System.Threading.Thread.Sleep(3000);
            webDriver.FindElement(PassTextBox).SendKeys("TH$sdjglsdjgfjsdfs@323##");
            webDriver.FindElement(LogInBtn).Click();
            System.Threading.Thread.Sleep(3000);
        }
        public void EnterUserName()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubhamshah@persistent.com");

        }
        public void EnterPassword()
        {
            webDriver.FindElement(PassTextBox).SendKeys("TH$sdjglsdjgfjsdfs@323##");
        }
        public void ClickLoginBtn()
        {
            webDriver.FindElement(LogInBtn).Click();

        }



    }
}
