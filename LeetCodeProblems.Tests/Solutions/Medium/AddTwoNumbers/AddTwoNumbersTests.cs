using NUnit.Framework;
using LeetCodeProblems.Solutions.Medium.AddTwoNumbers;
using System.Text;
using System;
using System.Numerics;

namespace LeetCodeProblems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Tests

        [Test]
        public void AddingTwoListsReturnsExpectedResultWithRepeatingNumbers()
        {
            //Arrange
            var l1 = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 1
                    }
                }
            };

            var l2 = new ListNode
            {
                val = 1,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3
                    }
                }
            };

            //Act
            var solution = new Solution();
            var actualResult = solution.AddTwoNumbers(l1, l2);

            //Assert
            Assert.AreEqual("444", ListToString(actualResult));
            Assert.AreEqual(3, GetListDepth(actualResult));
        }

        [Test]
        public void AddingTwoListsReturnsExpectedResultWithNonRepeatingNumbers()
        {
            //Arrange
            var l1 = new ListNode
            {
                val = 7,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 9
                    }
                }
            };

            var l2 = new ListNode
            {
                val = 6,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 4
                    }
                }
            };

            //Act
            var solution = new Solution();
            var actualResult = solution.AddTwoNumbers(l1, l2);

            //Assert
            Assert.AreEqual("3631", ListToString(actualResult));
            Assert.AreEqual(4, GetListDepth(actualResult));
        }

        [Test]
        public void AddingListsOfDifferentSizesReturnsExpectedResult()
        {
            //Arrange
            var l1 = new ListNode
            {
                val = 7,
                next = new ListNode
                {
                    val = 3,
                    next = new ListNode
                    {
                        val = 9
                    }
                }
            };

            var l2 = new ListNode
            {
                val = 6,
                next = new ListNode
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode
                        {
                            val = 7,
                            next = new ListNode
                            {
                                val = 1
                            }
                        }
                    }
                }
            };

            //Act
            var solution = new Solution();
            var actualResult = solution.AddTwoNumbers(l1, l2);

            //Assert
            Assert.AreEqual("36381", ListToString(actualResult));
            Assert.AreEqual(5, GetListDepth(actualResult));
        }

        [Test]
        public void AddingVeryLargeListsReturnsExpectedResult()
        {
            //Arrange
            var l1 = BuildListOfSize(100);
            var l2 = BuildListOfSize(100);


            //Act
            var solution = new Solution();
            var actualResult = solution.AddTwoNumbers(l1, l2);

            //Assert
            var res = BigInteger.Add(BigInteger.Parse(ReverseString(ListToString(l1))), BigInteger.Parse(ReverseString(ListToString(l2))));
            var resStr = res.ToString();
            var resReversedStr = ReverseString(resStr);

            Assert.AreEqual(resStr.Length, GetListDepth(actualResult));
            Assert.AreEqual(resReversedStr, ListToString(actualResult));            
        }

        #endregion

        #region Helper Methods

        private string ListToString(ListNode list)
        {
            var sbResult = new StringBuilder();

            do
            {
                sbResult.Append(list.val);
                list = list.next;
            }
            while (list != null);

            return sbResult.ToString();
        }

        private int GetListDepth(ListNode list)
        {
            int depth = 0;

            while (list != null)
            {
                depth++;
                list = list.next;
            }

            return depth;
        }

        private string ReverseString(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;

            var sb = new StringBuilder(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
                sb.Append(Char.GetNumericValue(s[i]));

            return sb.ToString();
        }

        private ListNode BuildListOfSize(int listSize)
        {
            var startNode = new ListNode();
            var currentNode = startNode;
            var rand = new Random();

            for (int i = 0; i < listSize; i++)
            {
                var val = rand.Next(0, 9);

                //Cant have a leading zero
                if (val == 0 && i == listSize - 1) val++;

                currentNode.val = val;

                if (i < listSize - 1)
                {
                    var nextNode = new ListNode();
                    currentNode.next = nextNode;
                    currentNode = nextNode;
                }
            }

            return startNode;
        }

        #endregion
    }
}