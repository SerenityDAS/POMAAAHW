using NUnit.Framework;

namespace Homework.Pages
{
    public partial class QAAutomation
    {   
        public void AssertHeatherTitle(string expected) => Assert.AreEqual(expected, HeatherText.Text);
       
    }
}
