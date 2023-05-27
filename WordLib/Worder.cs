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
            // Basic implementation: compare the word with its reverse
            char[] wordChars = word.ToCharArray();
            Array.Reverse(wordChars);
            string reversedWord = new string(wordChars);
            return word.Equals(reversedWord);
        }
    }
}
