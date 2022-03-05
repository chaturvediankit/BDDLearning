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
        private  CreateUserReq createUserReq;
        public AddOrUpdateUserSteps(CreateUserReq createUserReq)
        {
            this.createUserReq = createUserReq;
        }
        String endPoint = "api/users";
        RestClient client;
        RestRequest request;
        RestResponse response;
        RequestHelper requestHelper = new RequestHelper();

        [Given(@"User eneters job (.*)")]
        public void GivenUserEnetersJob(string job)
        {
            createUserReq.job = job;
        }

        [Given(@"User enters name (.*)")]
        public void GivenUserEntersRole(string name)
        {
            createUserReq.name = name;
        }

        [When(@"User send create user request")]
        public async Task WhenUserSendCreateUserRequestAsync()
        {
            client = requestHelper.SetUrl(TestContext.Parameters.Get("baseUrl"), endPoint);
            request = requestHelper.CreatePostRequest(createUserReq);
            response = await requestHelper.ExecuteAPI(client, request);

        }

        [Then(@"User should get created")]
        public void ThenUserShouldGetCreated()
        {
            int httpResponseCode = ((int)response.StatusCode);
            Assert.IsTrue(httpResponseCode == 201, "HTTP Response Code not matching");
            CreateUserRes createUserRes = JsonConvert.DeserializeObject<CreateUserRes>(response.Content);
            Assert.IsTrue(createUserRes.job.Equals(createUserReq.job), "Not matching");
        }

        [Given(@"user want to update user id (.*)")]
        public void GivenUserWantToUpdateUserId(int id)
        {
            endPoint = endPoint + "/" + id;
        }

        [When(@"User send update user request")]
        public async Task WhenUserSendUpdateUserRequest()
        {
            client = requestHelper.SetUrl(TestContext.Parameters.Get("baseUrl"), endPoint);
            request = requestHelper.CreatePutRequest(createUserReq);
            response = await requestHelper.ExecuteAPI(client, request);

        }

        [Then(@"User should get updated")]
        public void ThenUserShouldGetUpdated()
        {
            int httpResponseCode = ((int)response.StatusCode);
            Assert.IsTrue(httpResponseCode == 200, "HTTP Response Code not matching");
            UpdateUserRes updateUserRes = JsonConvert.DeserializeObject<UpdateUserRes>(response.Content);
            Assert.IsTrue(updateUserRes.job.Equals(createUserReq.job), "Not matching");

        }
    }
}
