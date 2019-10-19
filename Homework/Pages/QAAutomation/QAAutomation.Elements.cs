using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class QAAutomation : BasePage
    {
        public QAAutomation(IWebDriver driver)
            : base(driver)

        {
        }
        //public new string Url => "https://www.softuni.bg";

        public IWebElement Trainings => Driver.FindElement(By.XPath(@"//*[@id='header-nav']/div[1]/ul/li[2]/a/span"));
        
        public IWebElement QAModule => Driver.FindElement(By.XPath(@"//*[@id='header-nav']/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/h2/a"));
        
        public IWebElement QAAutomationCourse => Driver.FindElement(By.XPath(@"/html/body/div[2]/div/section[2]/div[2]/div[3]/div/a/div[2]/h4"));
        
        public IWebElement HeatherText => Wait.Until(c => c.FindElement(By.XPath(@"/html/body/div[2]/header/h1")));
    }
}
