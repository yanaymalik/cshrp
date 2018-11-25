using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_mtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int ROW, COL;
            Console.WriteLine("enter number for rwos and number col");
            ROW = Convert.ToInt32(Console.ReadLine());
            COL = Convert.ToInt32(Console.ReadLine());
            int center = ROW / 2;
            string[][] matrix = new string[ROW][];
            for (int i = 0; i < ROW; i++)
            {
                matrix[i] = new string[COL];
                for (int j = 0; j < COL; j++)
                {
                    if (i == j)
                        matrix[i][j] = "main";
                    else if (i + j == ROW -1)
                        matrix[i][j] = "sub";
                    else if(i < j)
                        matrix[i][j] = "up";
                    else if(i > j)
                        matrix[i][j] = "down";
                }
            }
            matrix[center][center] = "center";
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    Console.Write($"{matrix[i][j]}\t");
                }
                Console.WriteLine();

            }
        }
    }
}
