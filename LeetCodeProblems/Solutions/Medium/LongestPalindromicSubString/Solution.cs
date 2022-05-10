using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Solutions.Medium.LongestPalindrominSubString
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1) return s;

            var longestPalindrome = s[0].ToString(); //Initially the first letter is the longest palindrome
            for (int palindromeStartIndex = 0; palindromeStartIndex < s.Length; palindromeStartIndex++)
            {
                var sl = s.Substring(palindromeStartIndex, s.Length - palindromeStartIndex);
                while (true)
                {
                    var palindromeEndIndex = sl.LastIndexOf(s[palindromeStartIndex]);

                    if (palindromeEndIndex <= 0) break;

                    var potentialPalindrome = Slice(sl, 0, palindromeEndIndex);

                    if (potentialPalindrome == Reverse(potentialPalindrome))
                    {
                        if (potentialPalindrome.Length > longestPalindrome.Length)
                            longestPalindrome = potentialPalindrome;
                        break;
                    }

                    var truncate = sl.Substring(0, palindromeEndIndex);
                    var lastIndex = truncate.LastIndexOf(s[palindromeStartIndex]);

                    if (lastIndex <= 0)
                        break;

                    sl = truncate.Substring(0, lastIndex + 1);
                }
            }


            return longestPalindrome;
        }


        private static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string Slice(string str, int startIndex, int endIndex)
        {
            return str.Substring(startIndex, endIndex + 1 - startIndex);
        }
    }
}
