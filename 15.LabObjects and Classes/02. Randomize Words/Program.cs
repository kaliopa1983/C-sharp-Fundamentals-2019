using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Random rand = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {


                int firstWord = rand.Next(0, words.Length);
                int secondWord = rand.Next(0, words.Length);

                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
                    
            
        }
    }
}
