using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Aplus.AutomationTesting.PageObjectModels
{
    public class HomePagePOM
    {
        private IWebDriver _driver;

        private By _colourDropdownBy = By.Id("ddlColour");
        private By _colourDropdownOptionsBy = By.TagName("option");

        public HomePagePOM(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ColourDropdown()
        {
            return _driver.FindElement(_colourDropdownBy);
        }

        public ReadOnlyCollection<IWebElement> ColourDropdownOptions()
        {
            return ColourDropdown().FindElements(_colourDropdownOptionsBy);
        }
    }
}
