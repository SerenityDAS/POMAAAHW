using NUnit.Framework;

namespace Homework.Pages
{
    [TestFixture]
    public class POMTestsQA : BaseTest
    {
        private QAAutomation _softUni;

        [SetUp]
        public void ClassInit()
        {
            _softUni = new QAAutomation(Driver);
        }
        [Test, Description("Assert that there are heading tag <h1> and that contains QA Automation - септември 2019")]
        [Author("Desislava")]

        public void QAAutomationIsOpened()
        {
            _softUni.Navigate();
            _softUni.AssertHeatherTitle("QA Automation - септември 2019");

        }
    }
}
