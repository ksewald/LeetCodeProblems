namespace LeetCodeProblems.Solutions.Medium.LongestUniqueSubString
{
    /// <summary>
    /// Challenge Description: https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            return GetLongestSubString(s)?.Length ?? 0;
        }

        public string GetLongestSubString(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) return s;

            var longestCount = 0;
            var longestString = string.Empty;
            var currentString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                var idx = currentString.IndexOf(s[i]);
                if (idx > -1) currentString = currentString.Substring(idx + 1);

                currentString += s[i];

                if (currentString.Length > longestCount)
                {
                    longestCount = currentString.Length;
                    longestString = currentString;
                }
            }

            return longestString;
        }
    }
}
