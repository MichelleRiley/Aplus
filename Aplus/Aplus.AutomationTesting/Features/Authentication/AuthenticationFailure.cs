using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Aplus.AutomationTesting.Features.Authentication
{
    [Binding]
    public sealed class AuthenticationFailure
    {
        [Given(@"the login form is invalid")]
        public void GivenTheLoginFormIsInvalid()
        {

        }

        [When(@"I submit the login form")]
        public void WhenISubmitTheLoginForm()
        {

        }

        [Then(@"a validation message is displayed ""(.*)""")]
        public void ThenAValidationMessageIsDisplayed(string p0)
        {

        }

    }
}
