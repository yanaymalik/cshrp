using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //size of arr
        public const int SIZE = 5;
        static void Main(string[] args)
        {
            //Create + Fill objects
            string[] Name_list = new string[] { "Ice cream", "Chocolate", "Popcorn", "Fries", "Nachos" };
            int[] Price_list = new int[] { 5, 10, 13, 15, 16 };
            Boolean[] ifKosher = new Boolean[] { true, false, true, false, true };
            string[] manufacturer_List = new string[] { "Tnuva", "Nestle", "Strauss", "lay's", "Osem" };
            int[] Expiration_list = new int[] { 2018, 2017, 2019, 2017, 2018 };
            Food[] food = new Food[SIZE];
            for (int i = 0; i < SIZE; i++)
                food[i] = new Food(Name_list[i], Price_list[i], ifKosher[i],
                                       manufacturer_List[i], Expiration_list[i]);
            //Food menu Cinema
            Console.WriteLine("*-*-*-*- Cinema food menu -*-*-*-*");
            //Print the menu
            for (int i = 0; i < SIZE; i++)
                food[i].Product_info();
        }
    }
}
