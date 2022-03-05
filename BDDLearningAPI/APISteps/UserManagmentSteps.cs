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
        RestClient client;
        RestRequest request;
        RestResponse response;
        RequestHelper requestHelper = new RequestHelper();
        [Given(@"User Enters user id (.*)")]
        public void GivenUserEntersUserId(int id)
        {
            endPoint = endPoint + id;
        }

        [When(@"User send get user request")]
        public async Task WhenUserSendGetUserRequestAsync()
        {
            client=requestHelper.SetUrl(TestContext.Parameters.Get("baseUrl"), endPoint);
            request=requestHelper.CreateGetRequest();
            response = await requestHelper.ExecuteAPI(client, request);
        }

        [Then(@"Validate user details (.*) (.*) and Http response code (.*)")]
        public void ThenValidateUserDetailsJanetWeaverAndHttpResponseCode(string firstName,string lastName,int httpCode)
        {
            int httpResponseCode = ((int)response.StatusCode);
            Assert.IsTrue(httpResponseCode == httpCode, "HTTP Response Code not matching");
            Assert.IsTrue(response.Content.Contains(firstName), "First name not maching");
            Assert.IsTrue(response.Content.Contains(lastName), "First name not maching");

        }
        [When(@"User send delete user request")]
        public async Task WhenUserSendDeleteUserRequestAsync()
        {
            client=requestHelper.SetUrl(TestContext.Parameters.Get("baseUrl"), endPoint);
            request = requestHelper.CreateDeleteRequest();
            response = await requestHelper.ExecuteAPI(client, request);
        }

        [Then(@"Validate user is deleted (.*)")]
        public void ThenValidateUserIsDeleted(int httpCode)
        {
            int httpResponseCode = ((int)response.StatusCode);
            Assert.IsTrue(httpResponseCode == httpCode, "HTTP Response Code not matching");

        }
        
    }
}
