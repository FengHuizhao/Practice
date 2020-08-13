using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public class ProductServices
    {
        public Product getProductDetail()
        {
            Product product = new Product("sun glasses", "nice one");
            return product;
        }
    }
}
