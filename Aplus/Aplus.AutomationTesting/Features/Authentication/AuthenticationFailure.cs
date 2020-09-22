using Aplus.AutomationTesting.PageObjectModels;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Aplus.AutomationTesting.Features.Authentication
{
    [Binding]
    public sealed class AuthenticationFailure
    {
        private IWebDriver _driver;
        public AuthenticationFailure(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the login form contains invalid email and invalid password")]
        public void GivenTheLoginFormContainsInvalidEmailAndInvalidPassword()
        {
            var loginPage = new LoginPagePOM(_driver);
            loginPage.GoToPage();
            loginPage.PopulateLoginForm(Constants.EmailInValid, Constants.PasswordInvalid);
        }

        [When(@"I submit the login form")]
        public void WhenISubmitTheLoginForm()
        {
            var loginPage = new LoginPagePOM(_driver);
            loginPage.LoginSubmitBtn().Click();
        }

        [Then(@"a validation message is displayed ""(.*)""")]
        public void ThenAValidationMessageIsDisplayed(string expectedMessage)
        {
            var loginPage = new LoginPagePOM(_driver);
            loginPage.ValidationContent().Text.Should().Be(expectedMessage);
        }

    }
}
