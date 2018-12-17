using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public const int SIZE = 6;
        static void Main(string[] args)
        {
            int[] Price_list = new int[] {10,20,30,40,50,60};
            Boolean[] ifVeg = new Boolean[] { true, false, true, false, true, false};
            Boolean[] is_ext = new Boolean[] { true, false, true, false, true, false };
            Boolean[] is_dipp = new Boolean[] { false, true, false, false, true, false };
            int[] num_Slices = new int[] {8,6,10};
            int[] num_top = new int[] {2,4,6};
            Food[] food = new Food[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                if (i<3)
                   food[i] = new Pizza(Price_list[i], ifVeg[i], num_Slices[i],num_top[i]);
                else
                    food[i] = new Chips(Price_list[i], ifVeg[i], is_ext[i], is_dipp[i]);
                if (food[i] is Pizza)
                {
                    Console.WriteLine($"Pizza number: {i + 1}");
                    Console.WriteLine($"num of slices : {((Pizza)food[i]).NumOfSlices}\nnumber of topping: {((Pizza)food[i]).NumOfToppings}\nis veg? {((Pizza)food[i]).IsVeg}\nprice: {((Pizza)food[i]).Price}");
                    Console.WriteLine("****************");
                }
                else
                {
                    Console.WriteLine($"Chips number: {i + 1}");
                    Console.WriteLine($"The chips is extra big? {((Chips)food[i]).IsExtraBig}\nThe chips with dipp? {((Chips)food[i]).IsWithDipps}\nis veg? {((Chips)food[i]).IsVeg}\nprice: {((Chips)food[i]).Price}");
                    Console.WriteLine("****************");
                }
            }
        }
    }
}
