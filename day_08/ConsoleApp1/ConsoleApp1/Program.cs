using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(100);
            Student s2 = new Student(60);
            Student s3 = new Student(80);
            s1.Grade = 95;

            Student.GetTotalGrade();
        }
    }
}
