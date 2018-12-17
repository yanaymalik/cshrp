using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.SumOfOperations);
            int num1 = 9, num2 = 3;
            Console.WriteLine($"{num1} + {num2} = {Calculator.Calc(num1,num2,'+')}");
            Console.WriteLine(Calculator.SumOfOperations);

            Console.WriteLine($"{num1} - {num2} = {Calculator.Calc(num1, num2, '-')}");
            Console.WriteLine(Calculator.SumOfOperations);

            Console.WriteLine($"{num1} + {num2} = {Calculator.Calc(num1, num2, '*')}");
            Console.WriteLine(Calculator.SumOfOperations);

            Console.WriteLine($"{num1} / {num2} = {Calculator.Calc(num1, num2, '/')}");
            Console.WriteLine(Calculator.SumOfOperations);
        }
    }
}
