using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalText = Console.ReadLine();
            char[] originalTextArr = originalText.ToCharArray();
            int firstCharInd = 32;
            int offset = (126 - 32) + 3;

            for (int i = 0; i <originalText.Length; i++)
            {
                char oldCharIdx = originalTextArr[i];
                int oldIdxInAlphabet = oldCharIdx - firstCharInd;
                int newIdxInAlphabet = (oldIdxInAlphabet + 3) % offset;
                char newCharIdx = (char)(firstCharInd + newIdxInAlphabet);
                originalTextArr[i] = newCharIdx;
            }
            Console.WriteLine(originalTextArr);
        }
    }
}
