using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Food
    {
        //Seperate menu
        public const string partition = "*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*";
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private Boolean kosher;

        public Boolean Kosher
        {
            get { return kosher; }
            set { kosher = value; }
        }
        private string maker_name;

        public string Maker_name
        {
            get { return maker_name; }
            set { maker_name = value; }
        }
        private int expiration_year;

        public int Expiration_year
        {
            get { return expiration_year; }
            set { expiration_year = value; }
        }
        //constructor
        public Food(string name, int price, Boolean kosher, string manufacturer_name, int expiration_year)
        {
            Name = name;
            Price = price;
            Kosher = kosher;
            Maker_name = manufacturer_name;
            Expiration_year = expiration_year;
        }
        //Expiry date checking function
        public string ex_date()
        {
            DateTime todaysDate = DateTime.Now.Date;
            int year = todaysDate.Year;
            string ex = year >= expiration_year ? $"The {Name} Expired date is good" : $"The {Name} has expired";
            return ex;
        }
        //Kosher checking function
        public string if_kosher()
        {
            string k = kosher == true ? "The food is kosher" : "The food is not kosher";
            return k;
        }
        //Menu printing function
        public void Product_info()
        {
            string date = $" Product: {name}\n price: {price}\n {if_kosher()}\n Maker: {maker_name}\n {ex_date()}";
            Console.WriteLine(date);
            Console.WriteLine(partition);
        }

    }
}
