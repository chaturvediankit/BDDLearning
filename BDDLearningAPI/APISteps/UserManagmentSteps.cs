using System;
using TechTalk.SpecFlow;

namespace BDDLearningAPI.APISteps
{
    [Binding]
    public class UserManagmentSteps
    {
        [Given(@"User Enters user id (.*)")]
        public void GivenUserEntersUserId(int id)
        {
            
        }

        [When(@"User send get user request")]
        public void WhenUserSendGetUserRequest()
        {
           
        }

        [Then(@"Validate user details (.*) (.*) and Http response code (.*)")]
        public void ThenValidateUserDetailsJanetWeaverAndHttpResponseCode(string firstName,string lastName,int httpCode)
        {
            
        }

        [Given(@"User eneters job (.*)")]
        public void GivenUserEnetersJob(string job)
        {
            
        }

        [Given(@"User enters role (.*)")]
        public void GivenUserEntersRole(string role)
        {
            
        }

        [When(@"User send create user request")]
        public void WhenUserSendCreateUserRequest()
        {
            
        }

        [Then(@"User should get created")]
        public void ThenUserShouldGetCreated()
        {
         
        }

        [Given(@"user want to update user id (.*)")]
        public void GivenUserWantToUpdateUserId(int id)
        {
       
        }

        [When(@"User send update user request")]
        public void WhenUserSendUpdateUserRequest()
        {
      
        }

        [Then(@"User should get updated")]
        public void ThenUserShouldGetUpdated()
        {
            
        }

        [When(@"User send delete user request")]
        public void WhenUserSendDeleteUserRequest()
        {
           
        }

        [Then(@"Validate user is deleted (.*)")]
        public void ThenValidateUserIsDeleted(int httpCode)
        {
            
        }
    }
}
