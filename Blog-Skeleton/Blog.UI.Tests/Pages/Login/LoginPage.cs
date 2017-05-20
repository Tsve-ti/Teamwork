using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.UI.Tests.Models;

namespace Blog.UI.Tests.Pages.Login
{
    public partial class LoginPage : BasePage
    {


        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigatetoBlogLogIn()
        {

            //this.Driver.Navigate().GoToUrl(@"http://localhost:60634/Article/List");
            this.LogInLink.Click();
        }

        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {

                element.SendKeys(string.Empty);
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }

        }

        public void FillLogInForm(LogIn user)
        {
            Type(this.EmailAdress, user.EmailAddress);
            Type(this.Password, user.Password);
            this.LogInButton.Click();

        }

        public void FillLogInFormHardCode(LogIn user)
        {
            Type(this.EmailAdress, user.EmailAddress);
            Type(this.Password, user.Password);
            this.LogInButton.Click();

        }

    }
}
