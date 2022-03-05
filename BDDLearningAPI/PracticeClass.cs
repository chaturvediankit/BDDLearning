using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BDDLearningAPI.DataModels;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;

namespace BDDLearningAPI
{
    internal class PracticeClass
    {
        
        private RestRequest request;
        private RestClient client;
        private RestResponse response;

        [Test]
        public async Task GetUserApiTest()
        {
          client = new RestClient("https://reqres.in/api/users/2");
          request = new RestRequest()
            {
                Method = Method.Get
                
            };
            response = await client.ExecuteAsync(request);
            int i = ((int)response.StatusCode);
            Assert.IsTrue(i==200,"Not Success");

        }
        [Test]
        public async Task CreateUserApiTest()
        {
            client = new RestClient("https://reqres.in/api/users/");

            request = new RestRequest()
            {
                Method = Method.Post

            };
            request.AddBody(new CreateUserReq
            {
                job = "QA",
                name = "Ankit"

            }) ;
            response=await client.ExecuteAsync(request);
            int i = ((int)response.StatusCode);
            Assert.IsTrue(i == 201, "Not Success");

        }
    }
}
