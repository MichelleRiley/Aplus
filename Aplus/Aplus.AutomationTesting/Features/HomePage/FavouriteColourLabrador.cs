using Aplus.AutomationTesting.PageObjectModels;
using FluentAssertions;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Aplus.AutomationTesting.Features
{
    [Binding]
    public sealed class FavouriteColourLabrador
    {
        private IWebDriver _driver;

        public FavouriteColourLabrador(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the I am on the homepage")]
        public void GivenTheIAmOnTheHomepage()
        {
            var loginPage = new LoginPagePOM(_driver);
            loginPage.GoToPage();
            loginPage.PopulateLoginForm(Constants.EmailValid, Constants.PasswordValid);
            loginPage.LoginSubmitBtn().Click();
        }

        [Then(@"the favourite colour labrador dropdown is displayed")]
        public void ThenTheFavouriteColourLabradorDropdownIsDisplayed()
        {
            var homePage = new HomePagePOM(_driver);
            homePage.ColourDropdown().Displayed.Should().BeTrue();
        }

        [Then(@"the favourite colour labrador dropdown contains colours")]
        public void ThenTheFavouriteColourLabradorDropdownContainsColours(Table table)
        {
            var homePage = new HomePagePOM(_driver);
            var dropdownElements = homePage.ColourDropdownOptions();

            var actualDropdownList = new List<string>();

            foreach (var item in dropdownElements)
            {
                actualDropdownList.Add(item.Text);
            }

            foreach (var expectedColour in table.Rows)
            {
                actualDropdownList.Contains(expectedColour[0]).Should().BeTrue();
            }
        }
    }
}
