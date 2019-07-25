using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var regex = new Regex(@"\s?(:([a-z]{4,}):)(\,|\.|\!|\?| )");

            var matches = regex.Matches(input);

            int emojiPower = 0;

            foreach (Match match in matches)
            {
                foreach (var simbol in match.Groups[2].Value)
                {
                    emojiPower += simbol;
                }
            }

            int[] emoji2 = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            var word = new StringBuilder();

            foreach (var num in emoji2)
            {
                char letter = (char)num;

                word.Append(letter);
            }

            bool containsEmoji = false;

            foreach (Match match in matches)
            {
                if (match.Groups[2].Value == word.ToString())
                {
                    containsEmoji = true;
                    break;
                }
            }

            if (containsEmoji)
            {
                emojiPower *= 2;
            }

            var result = new StringBuilder();

            if (matches.Count != 0)
            {
                result.Append("Emojis found: ");

                foreach (Match match in matches)
                {
                    result.Append(match.Groups[1].Value + ", ");
                }

                result.Remove(result.Length - 2, 2);//премахва запетайката и спейс
                                                    //които остават

                result.AppendLine();
            }

            result.AppendLine($"Total Emoji Power: {emojiPower}");

            Console.WriteLine(result);
        }
    }
}