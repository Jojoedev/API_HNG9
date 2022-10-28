using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Biodata
    {
        
        public string slackName { get; set; }
        public string Stack { get; set; }

        public int Age { get; set; }
        public string Details { get; set; }

        public Biodata(string name, string spec, int age, string details)
        {   
            slackName = name;
            Stack = spec;
            Age = age;
            Details = details;

        }
    }
}
