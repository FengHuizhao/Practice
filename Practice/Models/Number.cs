using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Number
    {
        public Number(string input)
        {
            this.value = input;
        }

        public string value { get; set; }
    }
}
