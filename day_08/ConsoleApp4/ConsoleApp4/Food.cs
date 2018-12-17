using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Food
    {
        public Food(decimal price, bool isVeg)
        {
            Price = price;
            IsVeg = isVeg;
        }

        //propfull
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //prop
        public bool IsVeg { get; set; }
    }
}
