using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesk_car_
{
    class Program
    {
        class Car
        {
            private int carspeed;
            public int Carspeed
            {
                get { return carspeed; }
                set { carspeed = value; }
            }
            private string company;
            public string Company
            {
                get { return company; }
                set
                {
                    if (value == "1")
                    {
                        company = "Mercedes"; 
                    }
                    if (value == "2")
                    {
                        company = "B.M.W.";
                    }
                    if (value == "3")
                    {
                        company = "ford";
                    }
                    ; }
            }
            private string color;

            public string Color
            {
                get { return color; }
                set {
                    if (value == "1")
                    {
                        color = "Red";
                    }
                    if (value == "2")
                    {
                        color = "Blue";
                    }
                    if (value == "3")
                    {
                        color = "yellow";
                    }; }
            }


            public void printcar()
            {
                Console.WriteLine($"Car details \n company: {company}\n   color:{color}\n  speed:{carspeed}\n");
            }
        }
        static void Main(string[] args)
        {
            string choice;
            Car car1 = new Car();
            Console.WriteLine("Please Select a car company \n 1 - Mercedes \n 2 - B.M.W. \n 3 - ford");
            car1.Company = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please Select a car color \n 1 - Red \n 2 - Blue \n 3 - yellow");
            car1.Color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter car speed");
            car1.Carspeed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            car1.printcar();
            Console.WriteLine("To speed ud press + \n to slow press - \n to stop the car press 0");
            choice = Console.ReadLine();
            while (choice != "+" && choice != "-" && choice != "0")
            {
                Console.WriteLine("Please enter again + / - / 0\n");
                choice = Console.ReadLine();
            }
            Console.Clear();
            if (choice == "+")
            {
                car1.Carspeed += 1;
                car1.printcar();
            }
            else if(choice == "-")
            {
                car1.Carspeed -= 1;
                car1.printcar();
            }
            else if (choice == "0")
            {
                car1.Carspeed = 0;
                car1.printcar();
                Console.WriteLine("your car stop\n");
            }
            car1.Carspeed -= 2;
            car1.printcar();
            car1.Carspeed = 0;
            car1.printcar();
            Console.WriteLine("your car stop");
        }
    }
}
