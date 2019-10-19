using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class GoogleSearch : BasePage
    {
        public GoogleSearch(IWebDriver driver)
            : base(driver)

        {
        }
        //public new string Url => "https://www.google.com/";

        public IWebElement textfield => Driver.FindElement(By.Name("q"));

        public IWebElement Firstpage => Wait.Until(t => t.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div[1]/a[1]/h3")));
    }
}
