using OpenQA.Selenium;

namespace Aplus.AutomationTesting.PageObjectModels
{
    public class LoginPagePOM
    {
        private IWebDriver _driver;
        public readonly string Url = "https://apautotest.azurewebsites.net/Identity/Account/Login?ReturnUrl=%2F";

        private By _emailFieldBy = By.Id("Input_Email");
        private By _loginFormBy = By.Id("account");
        private By _passwordFieldBy = By.Id("Input_Password");
        private By _loginSubmitBtnBy = By.TagName("button");
        private By _validationContentBy = By.ClassName("validation-summary-errors");

        public LoginPagePOM(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement EmailField()
        {
            return _driver.FindElement(_emailFieldBy);
        }

        public void GoToPage()
        {
            _driver.Navigate().GoToUrl(Url);
        }
        public IWebElement LoginForm()
        {
            return _driver.FindElement(_loginFormBy);
        }
        public IWebElement PasswordField()
        {
            return _driver.FindElement(_passwordFieldBy);
        }
        public IWebElement LoginSubmitBtn()
        {
            return LoginForm().FindElement(_loginSubmitBtnBy);
        }

        public IWebElement ValidationContent()
        {
            return LoginForm().FindElement(_validationContentBy);
        }

        public void PopulateLoginForm(string email, string password)
        {
            EmailField().SendKeys(email);
            PasswordField().SendKeys(password);
        }
    }
}
