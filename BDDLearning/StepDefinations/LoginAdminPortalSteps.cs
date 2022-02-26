using System;
using TechTalk.SpecFlow;

namespace BDDLearning.StepDefinations
{
    [Binding]
    public class LoginAdminPortalSteps
    {
        [Given(@"User is on admin portal login page")]
        public void GivenUserIsOnAdminPortalLoginPage()
        {
            throw new PendingStepException();
        }

        [When(@"User Enters credential (.*) and (.*)")]
        public void WhenUserEntersValid(String username, string password)
        {
            throw new PendingStepException();
        }

        [When(@"User Clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"User should be logged in sussefully")]
        public void ThenUserShouldBeLoggedInSussefully()
        {
            throw new PendingStepException();
        }
        
        [Then(@"User should get (.*)")]
        public void ThenUserShouldGetError(String errorMessage)
        {
            throw new PendingStepException();
        }
    }
}
