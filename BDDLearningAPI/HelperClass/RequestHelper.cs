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
        public RestClient SetUrl(string baseUrl, string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            client = new RestClient(url);
            return client;
        }


    }
}
