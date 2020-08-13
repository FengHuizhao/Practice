using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Select
    {
        public Select(string input, string name)
        {
            this.value = input;
            this.name = name;
        }

        public string value { get; set; }

        public string name { get; set; }
    }
}
