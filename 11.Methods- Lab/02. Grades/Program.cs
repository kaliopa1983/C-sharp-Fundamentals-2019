using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintInWords(grade);
        }

       private static void PrintInWords(double grade)
        {
            string gradeInWords = string.Empty;
            if (grade>=2 && grade<=2.99)
            {
                   gradeInWords="Fail";
                Console.WriteLine(gradeInWords);
            }
            else if (grade>=3.00&& grade<3.49)
            {
                gradeInWords = "Poor";
                Console.WriteLine(gradeInWords);
            }
            else if (grade>=3.50 && grade<=4.49)
            {
                gradeInWords = "Good";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >=4.50 && grade<=5.49)
            {
                gradeInWords = "Very good";
                Console.WriteLine(gradeInWords);
            }
            else if (grade >=5.50&& grade<=6.00)
            {
                gradeInWords = "Excellent";
                Console.WriteLine(gradeInWords);
            }
        }
    }
}
