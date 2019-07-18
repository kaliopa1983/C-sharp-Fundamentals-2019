using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Student
{

    class Program
    {

        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
           
            for (int i = 0; i < countOfStudents; i++)
            {

                Student student = new Student();
                string[] inputArguments = Console.ReadLine().Split(' ');

                string firstName = inputArguments[0];
                string lastName = inputArguments[1];

                List<double> grades = inputArguments.Skip(1).Skip(2).Select(double.Parse).ToList();
                students.Add(student);
                grades.Sort();
                grades.Reverse();



                foreach (var s in students.OrderBy(s => s.grades))
                {
                    Console.WriteLine($"{firstName} {lastName}: {grades}");
                }


            }
            
            


        }
    }


    class Student
    {

       
         string firstName { get; set; }
        string lastName { get; set; } 
        public List<double> grades { get; set; }

        
    }
}