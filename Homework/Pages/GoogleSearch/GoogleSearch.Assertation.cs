using NUnit.Framework;

namespace Homework.Pages
{
    public partial class GoogleSearch
    {
        public void AssertTitle(string title) => Assert.AreEqual(title, Driver.Title); 
    }
}
