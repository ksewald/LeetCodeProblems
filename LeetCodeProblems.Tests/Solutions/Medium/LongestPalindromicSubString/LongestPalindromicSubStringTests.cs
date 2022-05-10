using NUnit.Framework;
using LeetCodeProblems.Solutions.Medium.LongestPalindrominSubString;
using System;

namespace LeetCodeProblems.Tests.Solutions.Medium.LongestPalindromicSubString
{
    class LongestPalindromicSubStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(null, new string[] { null })]
        [TestCase("", new string[] { "" })]
        [TestCase("   ", new string[] { "   " })]
        [TestCase("ac", new string[] { "a" })]
        [TestCase("abbad", new string[] { "abba" })]
        [TestCase("abbcd", new string[] { "bb" })]
        [TestCase("abbcd", new string[] { "bb" })]
        [TestCase("babad", new string[] { "bab", "aba" })]
        [TestCase("aacabdkacaa", new string[] { "aca" })]
        [TestCase("babadabcdefedcbadhannah", new string[] { "dabcdefedcbad" })]
        [TestCase("abcdefghijklmnophannah", new string[] { "hannah" })]
        public void GetLongestSubStringReturnsCorrectResult(string s, string[] acceptableAnswers)
        {
            //Arrange 
            var solution = new Solution();

            //Act
            var actualResult = solution.LongestPalindrome(s);

            //Assert
            var actualResultIsAcceptable = Array.FindIndex(acceptableAnswers, 
                acceptableAnswer => acceptableAnswer == actualResult) > -1;

            Assert.IsTrue(actualResultIsAcceptable);
        }
    }
}
