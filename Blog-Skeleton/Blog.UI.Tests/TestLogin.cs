using Blog.UI.Tests.Models;
using Blog.UI.Tests.Pages.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class TestLogin
    {
        public IWebDriver driver;

        [SetUp]
        public void Init()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
            this.driver.Manage().Window.Maximize();


        }
        [Test, Property("Priority", 1)]
        [Author("TSV")]
        public void ValidLogIn()
        {
            // IWebDriver driver = BrowserHost.Instance.Application.Browser;

            var loginPage = new LoginPage(this.driver);
            LogIn user = new LogIn("Tsvetelina@abv.bg", "123456");
            //var logIn = AccessExcelData.GetTestData("ValidLogin");
            loginPage.NavigatetoBlogLogIn();
            loginPage.FillLogInFormHardCode(user);
            loginPage.AssertValidLogIn1(("Hello"));
            loginPage.AssertValidLogIn2("Log off");
        }

    }
}

