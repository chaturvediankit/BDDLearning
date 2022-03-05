using System;
using System.Collections.Generic;
using System.Text;

namespace BDDLearningAPI.DataModels
{
    public  class UpdateUserRes
    {
        public string name { get; set; }
        public string job { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
