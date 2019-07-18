using System;
using System.Collections.Generic;

namespace _05._Students
{
    public class Startup
    {

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

        }
        static void Main(string[] args)
        {

           
            string line = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (line != "end")
            {
                string[] token = line.Split();
                string firstName = token[0];
                string lastName = token[1];
                int age = int.Parse(token[2]);
                string city = token[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city


                };

                students.Add(student);
                line = Console.ReadLine();

                string filterCity = Console.ReadLine();
                NewMethod(students, filterCity);
            }
        }

        private static void NewMethod(List<Student> students, string filterCity)
        {
            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}



        
