using OpenQA.Selenium;
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
        By LogInBtn = By.TagName("button");
        By EmailTextBox = By.Id("email");
        By PassTextBox = By.Id("password");

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

    }
}
