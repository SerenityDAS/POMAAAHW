using Homework.Pages;
using NUnit.Framework;

namespace Homework
{
    [TestFixture]
    public class POMTests : BaseTest
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;    

        [SetUp]
        public void ClassInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);
            _user = UserFactory.CreateValidUser();
        }

        [Test, Description("Assert that registration page is open.")]
        [Author("Desislava")]
        public void AssertRegistrationPage()
        {
            _loginPage.Positive(_loginPage);
            _loginPage.AssertRegistationPageIsOpened("CREATE AN ACCOUNT");
        }

        [Test, Description("Get an error message by not typing in phone number")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutPhoneNumber()
        {
            _user.Phone = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("You must register at least one phone number.");
        }

        [Test, Description("Get error massage by not typing in first name")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }

        [Test, Description("Get error massage by not typing in last name")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutLastName()
        {
            _user.LastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.");
        }

        [Test, Description("Get an error message by selecting non existing date 31.09.2019")]
        [Author("Desislava")]
        public void FillRegistrationFormWithIvalidBirthday()
        {
            _user.Date = "31";
            _user.Month = "9";
            _user.Year = "2019";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("Invalid date of birth");
        }

        [Test, Description("Get an error message by typing in shorter password than required")]
        [Author("Desislava")]
        public void ErrorMessagePassword()
        {
            _user.Password = "pass";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is invalid.");
        }

        [Test, Description("Get an error message by not typing in address")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutAddess()
        {
            _user.Address = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("address1 is required.");
        }

        [Test, Description("Get an error message by not typing in city")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutCity()
        {
            _user.City = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("city is required.");
        }

        [Test, Description("Get an error message by not typing in post code")]
        [Author("Desislava")]
        public void FillRegistrationFormWithoutPostCode()
        {
            _user.PostCode = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("The Zip/Postal code you've entered is invalid. It must follow this format: 00000");
        }
    }
}
