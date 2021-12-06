using System;
using System.Numerics;
using LeetCodeProblems.Solutions.Medium.AddTwoNumbers;

namespace LeetCodeProblems.Solutions.Medium.AddTwoNumbers
{
    /// <summary>
    /// Problem Description:  https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var addedResult = BigInteger.Add(GetNumberFromList(l1), GetNumberFromList(l2)).ToString();

            var currentNode = new ListNode();
            var startNode = currentNode;
            for(int i = addedResult.Length - 1; i >= 0; i--)
            {
                currentNode.val = (int) Char.GetNumericValue(addedResult[i]);

                if (i > 0)
                {
                    var nextNode = new ListNode();
                    currentNode.next = nextNode;
                    currentNode = nextNode; 
                }
            }

            return startNode;
        }

        public BigInteger GetNumberFromList(ListNode list)
        {
            //the problem states that the listnodes hold the number
            //in reverse order with each digit being stored in a single node.
            //E.g. the number 123 will be stored as:
            // 3 -> 2 -> 1
            //with 3 being the first node in the list.
            //The challenge farunetees no leading zeros and no negative numbers.

            if (list == null) return 0;

            var strResult = string.Empty;

            do
            {
                strResult += list.val;
                list = list.next;
            }
            while (list != null);

            //Reverse the string. Avoid using StringBuilder to keep it simple. 
            var s = string.Empty;
            for (int x = strResult.Length - 1; x >= 0; x--)
                s += strResult[x];

            //BigInteger as the resulting number could be up to 100 digits long
            return BigInteger.Parse(s);
        }
    }
}
