using System;
using System.Text.Json;
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
    public class UserManagmentSteps
    {
        String endPoint = "api/users/";
        
        [Given(@"User Enters user id (.*)")]
        public void GivenUserEntersUserId(int id)
        {
           
            
        }

        [When(@"User send get user request")]
        public async Task WhenUserSendGetUserRequestAsync()
        {

            
           
        }

        [Then(@"Validate user details (.*) (.*) and Http response code (.*)")]
        public void ThenValidateUserDetailsJanetWeaverAndHttpResponseCode(string firstName,string lastName,int httpCode)
        {
            

        }
        [When(@"User send delete user request")]
        public async Task WhenUserSendDeleteUserRequestAsync()
        {
            
        }

        [Then(@"Validate user is deleted (.*)")]
        public void ThenValidateUserIsDeleted(int httpCode)
        {
       
        }
        
    }
}
