using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BDDLearningAPI.DataModels;
using RestSharp;

namespace BDDLearningAPI.HelperClass
{
    public class RequestHelper
    {
        private RestClient client;
        private RestRequest request;
        private RestResponse response;
        public RestClient SetUrl(string baseUrl, string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            client = new RestClient(url);
            return client;
        }
        public RestRequest CreateGetRequest()
        {
            request = new RestRequest()
            {
                Method = Method.Get
            };
            request.AddHeader("Accept", "application/json");
            return request;
        }
        public RestRequest CreatePostRequest(CreateUserReq payload)
        {
            request = new RestRequest()
            {
                Method = Method.Post
            };
            request.AddHeader("Accept", "application/json");
            request.AddBody(payload);
            request.RequestFormat = DataFormat.Json;
            return request;
        }
        public RestRequest CreatePutRequest(CreateUserReq payload)
        {
            request = new RestRequest()
            {
                Method = Method.Put
            };
            request.AddHeader("Accept", "application/json");
            request.AddBody(payload);
            request.RequestFormat = DataFormat.Json;
            return request;

        }
        public RestRequest CreateDeleteRequest()
        {
            request = new RestRequest()
            {
                Method = Method.Delete
            };
            request.AddHeader("Accept", "application/json");
            return request;
        }
        public async Task<RestResponse> ExecuteAPI(RestClient restClient,RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }




    }
}
