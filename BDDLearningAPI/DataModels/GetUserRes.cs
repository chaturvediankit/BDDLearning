using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BDDLearningAPI.DataModels
{
    public class GetUserRes
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }
}
