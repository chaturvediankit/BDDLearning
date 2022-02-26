using System;
using BDDLearning.Hooks;
using BDDLearning.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BDDLearning.StepDefinations
{
    [Binding]
    public class LoginAdminPortalSteps
    {
        [Given(@"User is on admin portal login page")]
        public void GivenUserIsOnAdminPortalLoginPage()
        {
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.OpenApplication();
           
        }

        [When(@"User Enters credential (.*) and (.*)")]
        public void WhenUserEntersValid(String username, string password)
        {
            BaseClass baseClass = new BaseClass();
            LoginPage loginPage = new LoginPage(BaseClass.MyDriver);
            baseClass.EneterText(loginPage.usernameTextField, TestContext.Parameters.Get(username));

            
        }

        [When(@"User Clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
           
        }

        [Then(@"User should be logged in sussefully")]
        public void ThenUserShouldBeLoggedInSussefully()
        {
            
        }
        
        [Then(@"User should get (.*)")]
        public void ThenUserShouldGetError(String errorMessage)
        {
            
        }
    }
}
