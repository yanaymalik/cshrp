using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set
            {
                if (grade >= 0 && grade <=100)
                {
                    sumGrade -= grade;
                    grade = value;

                    sumGrade += grade;
                }
            }
        }
        private static int sumGrade = 0;
        private static int counter = 0;

        public Student(int grade)
        {
            Grade = grade;
            counter++;
        }
        //non static func
        public  string GetGrade()
        {
            return $"The avg grades of thestudents is:{grade} {sumGrade / counter}";
        }
        public static string GetTotalGrade()
        {
            return $"The avg grades of the {counter} students is: {sumGrade/counter}";
        }

    }
}
