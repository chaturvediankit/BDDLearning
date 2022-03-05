using System;
using System.Collections.Generic;
using System.Text;

namespace BDDLearningAPI.DataModels
{
    public class CreateUserRes
    {
        public string name { get; set; }
        public string job { get; set; }
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }
}
