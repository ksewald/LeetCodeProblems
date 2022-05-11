using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Solutions.Easy.ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            //It is important that open and close parentheses share the same index in the below arrays. 
            var open = new char[] { '(', '{', '[' };
            var close = new char[] { ')', '}', ']' };

            foreach (var c in s)
            {
                //Check if current char is an openning parantheses
                if (Array.Exists<char>(open, openChar => openChar == c))
                {
                    stack.Push(c);
                }
                else if (Array.Exists<char>(close, closeChar => closeChar == c))
                {
                    if (stack.Count == 0) return false;
                    if (stack.Peek() == open[Array.IndexOf(close, c)]) stack.Pop();
                    else return false;
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
