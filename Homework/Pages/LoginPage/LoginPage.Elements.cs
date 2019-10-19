using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework.Pages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
        }
        //public new string Url => "http://automationpractice.com/index.php?controller=my-account";
        public IWebElement SignInButton => Driver.FindElement(By.ClassName("login"));

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));

        public IWebElement UrlRegistationForm => Driver.FindElement(By.XPath("//*[@id='noSlide']/h1"));

    }
}