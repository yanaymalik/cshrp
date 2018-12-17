using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza(90, true, 8);

            Console.WriteLine($"our pizza has {p.NumOfSlices} slices and costs {p.Price}");

            Console.WriteLine("the pizza is: " + ((p.IsVeg) ? " veg" : "non-veg"));
        }
    }
}
