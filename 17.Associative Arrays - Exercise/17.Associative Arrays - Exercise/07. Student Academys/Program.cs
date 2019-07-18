using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academys
{
    internal class Program
    {
       

        private static void Main()
        {
            
            Dictionary <string,List<double> >studentsDetails= new Dictionary<string,List< double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentsName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsDetails.ContainsKey(studentsName))
                {
                    studentsDetails[studentsName] = new List<double>();
                }
                
                
                    studentsDetails[studentsName].Add(grade);
                
            }
                studentsDetails = studentsDetails
                    .Where(x => x.Value.Average() >= 4.50)
                    .OrderByDescending(x => x.Value.Average())
                    .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(string.Join(Environment.NewLine,
                    studentsDetails.Select(x => $"{x.Key} -> {x.Value.Average():f2}")));
                    

            

        }
    }
}
