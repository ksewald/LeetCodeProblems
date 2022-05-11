using System.Text;

namespace LeetCodeProblems.Solutions.Medium.StringToInteger
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart(' ');
            var sb = new StringBuilder();
            foreach(char c in s)
            {
                var asciiCode = (int)c;
                if ((sb.Length == 0 && (asciiCode == 43 || asciiCode == 45)) || 
                    (asciiCode >= 47 && asciiCode <= 57)) sb.Append(c);
                else break;
            }

            if (sb.Length == 0 || (sb.Length == 1 && (sb[0] == '-' || sb[0] == '+'))) return 0;

            return int.TryParse(sb.ToString(), out var result) ? 
                result : 
                sb[0] == '-' ? 
                    int.MinValue : 
                    int.MaxValue;
        }
    }
}
