using NUnit.Framework;

namespace Homework.Pages
{
    public partial class LoginPage
    {

        public void AssertRegistationPageIsOpened(string expected) => Assert.AreEqual(expected, UrlRegistationForm.Text);
    }
}
