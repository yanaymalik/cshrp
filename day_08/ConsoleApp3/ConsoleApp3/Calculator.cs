using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class Calculator
    {
        private static int sumOfOperations;

        public static int SumOfOperations
        {
            get { return sumOfOperations; }
            set { sumOfOperations = value; }
        }
        static Calculator()
        {
            Console.WriteLine("static constructor is running");
        }
        public static int Calc(int num1, int num2, char operation)
        {
            SumOfOperations++;
            switch (operation)
            {
                 
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*':return num1 * num2;
                case '/':return num1 / num2;
            }
          return 0;
        }

    }
}
