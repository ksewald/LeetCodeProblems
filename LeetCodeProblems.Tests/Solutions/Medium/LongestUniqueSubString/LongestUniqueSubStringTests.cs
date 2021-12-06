using NUnit.Framework;
using LeetCodeProblems.Solutions.Medium.LongestUniqueSubString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Solutions.Medium.LongestUniqueSubString
{
    class LongestUniqueSubStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetLongestSubStringReturnsCorrectResult()
        {
            //Arrange
            var s1 = "pwwkew";
            var s2 = "abcabcdabc";
            var s3 = "abcdefghijklmnopqrstuvwxyz";
            var s4 = "a";
            string s5 = null;
            var s6 = "";
            var s7 = "    ";

            //Act
            var solution = new Solution();
            var r1 = solution.GetLongestSubString(s1);
            var r2 = solution.GetLongestSubString(s2);
            var r3 = solution.GetLongestSubString(s3);
            var r4 = solution.GetLongestSubString(s4);
            var r5 = solution.GetLongestSubString(s5);
            var r6 = solution.GetLongestSubString(s6);
            var r7 = solution.GetLongestSubString(s7);


            //Assert
            Assert.AreEqual("wke", r1);
            Assert.AreEqual("abcd", r2);
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", r3);
            Assert.AreEqual("a", r4);
            Assert.AreEqual(null, r5);
            Assert.AreEqual(string.Empty, r6);
            Assert.AreEqual(" ", r7);
        }
    }
}
