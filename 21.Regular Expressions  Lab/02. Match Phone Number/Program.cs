using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+[0-9]{3}(\s|-)[0-9]{1}(\1)[0-9]{3}(\1)\d{4}\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);
            var machedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",machedPhones));
        }
    }
}
