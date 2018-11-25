using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace tesk_cookie_
{
    
    class Program
    {
        class cookie
        {
            private string gluten;
            public string Gluten
            {
                get { return gluten; }
                set
                {
                    if (value == "1")
                    {
                        gluten = "With gluten";
                    }
                    else if (value == "0")
                    {
                        gluten = "Gluten free";
                    }; }
            }
            private int eggs;
            public int Eggs
            {
                get { return eggs; }
                set { eggs = value; }
            }
            private double sugar;
            public double Sugar
            {
                get { return sugar; }
                set { sugar = value; }
            }
           
            private double flour;
            public double Flour
            {
                get { return flour; }
                set { flour = value; }
            }
            public void printcookie()
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"  -*-*-*cookie {i + 1} *-*-*-");
                    Console.WriteLine($"The cookie contains:\n"
                    + $"Gluten: {gluten} \n"
                    + $"Eggs: {Eggs} \n"
                    + $"Sugar: {Sugar} (grams)\n"
                    + $"Flour: {Flour} (grams)\n"
                    );
                }
                
            }
        }
        static void Main(string[] args)
        {
            cookie[] listCookies = new cookie[3];
            for (int i = 0; i < 3; i++)
                listCookies[i] = new cookie();
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine($"-*-*-*  Choose what will be in the cookie number {i + 1}  *-*-*-");
                Console.WriteLine("press 0 gluten free \npress 1 With gluten ");
                listCookies[i].Gluten = Console.ReadLine();
                
                Console.WriteLine("How many eggs?");
                listCookies[i].Eggs = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("how much sugar? (grams)");
                listCookies[i].Sugar = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("how much flour? (grams)");
                listCookies[i].Flour = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            }
            listCookies[0].printcookie();
            Console.ReadKey();
            Console.Clear();
            listCookies[0].Sugar = 4.15;
            listCookies[0].printcookie();
            Console.ReadKey();
            Console.Clear();
            listCookies[0] = listCookies[1];
            listCookies[1].Eggs = 2;
            listCookies[0].printcookie();
            Console.ReadKey();
        }
    }
}
