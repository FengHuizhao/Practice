using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Product
    {
        public Product(string name, string desc)
        {
            this.Name = name;
            this.Describe = desc;
        }

        public string Name { get; set; }

        public string Describe { get; set; }
    }
}
