using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public class SelectServices
    {
        public Select chooseProduct(string input)
        {
            if (input.Equals("1"))
            {
                Select select = new Select("1", "Sun Glasses");
                return select;
            }
            else if (input.Equals("2"))
            {
                Select select = new Select("2", "Height");
                return select;
            }
            else
            {
                Select select = new Select(input, "none");
                return select;
            }
        }
    }
}
