using System;
using System.Threading.Tasks;
using BDDLearningAPI.DataModels;
using BDDLearningAPI.HelperClass;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace BDDLearningAPI.APISteps
{
    [Binding]
    public class AddOrUpdateUserSteps
    {
        private readonly CreateUserReq createUserReq;
        public AddOrUpdateUserSteps(CreateUserReq createUserReq)
        {
            this.createUserReq = createUserReq;
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
        public async Task WhenUserSendCreateUserRequestAsync()
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
    }
}
