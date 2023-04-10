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
        By EmptyUsernameWarning = By.ClassName("validation-message");
        By EmptypassWrning = By.XPath("//div[contains(text(),'The Password field is required.')]");
        By InvalidUsernameWarning = By.XPath("//div[contains(text(),'The Email field is not a valid e-mail address.')]");
        By NotContainPersiUsernameWaring = By.XPath("//div[contains(text(),'Email must contain @persistent.com')]");
        By WrongPassWarning = By.XPath("//div[contains(text(),'Invalid name and password')]");
        By InvalidPassWarning = By.XPath("//div[contains(text(),'Passwords must be at least 8 characters and contai')]");

        public AllLocator(IWebDriver webDriver)
        {
            this.webDriver = webDriver;

        }
        public void ClickLoginBtn()
        {
            webDriver.FindElement(LogInBtn).Click(); 
        }

        public void EnterUsernameAdmin()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubham_shah@persistent.com");
        }
        public void WrongUsername()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubham_shah");
        }
        public void EnterPassword()
        {
            webDriver.FindElement(PassTextBox).SendKeys("Shubham@1234");
        }
        public void EnterUserNameAssessee()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("assess@persisten.com");
        }


        public String GetEmptyUsernameWarning()
        {
           return webDriver.FindElement(EmptyUsernameWarning).Text;

        }
        public String GetEmptyPassWarning()
        {
            return webDriver.FindElement(EmptypassWrning).Text;

        }


        public String GetInvalidUsernameWarnign()
        {
            return webDriver.FindElement(InvalidUsernameWarning).Text;

        }
        public string GetInvalidPasssWarning()
        {
            return webDriver.FindElement(InvalidPassWarning).Text;
        }
        public void EnterInvalidUsername()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("sdfsfjdsklffdddddds");
        }
        public void EnterInvalidPass()
        {
            webDriver.FindElement(PassTextBox).SendKeys("jdslfj");
        }


        public String GetWrongUserameWarning()
        {
            return webDriver.FindElement(NotContainPersiUsernameWaring).Text;

        }
        public string GetWrongPassWarining()
        {
            return webDriver.FindElement(WrongPassWarning).Text;
        }
        public void EnterWrongUsername()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubham@gmail.com");
        }
        public void EnterWrongPass()
        {
            webDriver.FindElement(PassTextBox).SendKeys("Shubham@3424234@$@#4SDDSD");
        }
        public void EnterRightUsername()
        {
            webDriver.FindElement(EmailTextBox).SendKeys("shubham_shah@persistent.com");
        }
        public void ClearTheUsernameField()
        {
            webDriver.FindElement(EmailTextBox).Clear();    
        }
        public void ClearPassField()
        {
            webDriver.FindElement(PassTextBox).Clear();
        }


    }
}
