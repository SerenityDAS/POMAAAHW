using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace Homework
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void InitializeTest()
        {
            ChromeOptions options = new ChromeOptions();

            options.PlatformName = "Windows";
            options.BrowserVersion = "77.0";

            Driver = new RemoteWebDriver(new Uri("http://192.168.1.2:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
