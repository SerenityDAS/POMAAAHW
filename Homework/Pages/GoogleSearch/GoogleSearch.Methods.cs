using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class GoogleSearch
    {
        public void Navigate()
        {
            Navigate("https://www.google.com/");
            textfield.SendKeys("Selenium");
            textfield.SendKeys(Keys.Enter);
            Firstpage.Click();
            
        }
    }
}
