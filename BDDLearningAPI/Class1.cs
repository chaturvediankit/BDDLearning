using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BDDLearningAPI.DataModels;
using NUnit.Framework;
using RestSharp;

namespace BDDLearningAPI
{
    internal class Class1
    {
        
        private RestRequest request;
        private RestClient client;
        private RestResponse response;

        [Test]
        public async Task TestAPIAsync()
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
        public async Task TestAPIPOST()
        {
            client = new RestClient("https://reqres.in/api/users/");
            request.Method = Method.Post;
            request.AddBody(new CreateUserReq
            {
                job = "QA",
                name = "Ankit"

            }) ;

        }
    }
}
