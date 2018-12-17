using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Pizza:Food
    {
        private int numOfSlices;

        public Pizza(decimal price, bool isVeg, int numOfSlices) : base(price, isVeg)
        {
            NumOfSlices = numOfSlices;
        }

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }
        public void sayHallo()
        {
            Console.WriteLine($"hii from pizza");
        }
    }
}
