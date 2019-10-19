
using OpenQA.Selenium;
using System;

namespace Homework.Pages
{
    public partial class LoginPage
    {
        public void Positive(LoginPage loginPage)
        {
            loginPage.Positive("http://automationpractice.com/index.php");
            loginPage.SignInButton.Click();
            loginPage.Email.SendKeys("anyemail@gmail.com");
            loginPage.Submit.Click();
            loginPage.Wait.Until(r => r.FindElement(By.Id("email")).GetAttribute("value") != string.Empty);
        }
    } 
}
