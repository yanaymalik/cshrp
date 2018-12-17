using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Pizza:Food
    {
        private int numOfSlices;
        private int numOfToppings;
        public Pizza(decimal price, bool isVeg, int numOfSlices, int numOfToppings) : base(price, isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOfToppings = numOfToppings;
        }

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }
        public int NumOfToppings
        {
            get { return numOfToppings; }
            set { numOfToppings = value; }
        }
    }
}
