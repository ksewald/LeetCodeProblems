using System;

namespace LeetCodeProblems.Solutions.Medium.ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var startIndex = x < 0 ? 1 : 0;
            var xArr = x.ToString().ToCharArray();
            Array.Reverse(xArr, startIndex, xArr.Length - startIndex);
            return int.TryParse(new string(xArr), out int result) ? result : 0;
        }
    }
}
