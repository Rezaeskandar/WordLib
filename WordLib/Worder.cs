using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLib
{
    public class Worder
    {
        public static bool IsPalindrome(string word)
        {
            // basic implementation: compare the word with its reverse
            char[] wordChars = word.ToCharArray();
            Array.Reverse(wordChars);
            string reversedWord = new string(wordChars);
            return word.Equals(reversedWord);
        }
        public static int CountLetters(string word)
        {
            int letterCount = 0;
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }
            return letterCount;
        }
    }
}
