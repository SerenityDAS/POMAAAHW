using NUnit.Framework;

namespace Homework.Pages
{
    [TestFixture]
    public class POMTestsGoogle : BaseTest
    {
        private GoogleSearch _google;

        [SetUp]
        public void ClassInit()
        {
            _google = new GoogleSearch(Driver);
        }
        [Test, Description("Assert that the first page title loaded after searching selenium in google is - Selenium - Web Browser Automation")]
        [Author("Desislava")]

        public void SeleniunIsFirst()    
        {
            _google.Navigate();
            _google.AssertTitle("Selenium - Web Browser Automation");
        }
    }
}
