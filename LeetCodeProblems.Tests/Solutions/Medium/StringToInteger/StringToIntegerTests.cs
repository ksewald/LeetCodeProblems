using NUnit.Framework;
using LeetCodeProblems.Solutions.Medium.StringToInteger;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Solutions.Medium.StringToInteger
{
    class StringToIntegerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("42", 42)]
        [TestCase("  42", 42)]
        [TestCase("  -42", -42)]
        [TestCase("  -42 3", -42)]
        [TestCase("  -42.6", -42)]
        [TestCase("4193 with words", 4193)]
        [TestCase("2147483647", 2147483647)]
        [TestCase("-2147483647", -2147483647)]
        [TestCase("2147483648", int.MaxValue)]
        [TestCase("-2147483648", int.MinValue)]
        [TestCase("words and 987", 0)]
        [TestCase("+-12", 0)]
        [TestCase("+", 0)]
        [TestCase("+", 0)]
        [TestCase("+w12", 0)]
        public void ReverseIntegerReturnsCorrectResult(string input, int expectedResult)
        {
            //Arrange
            var solution = new Solution();

            //Act
            var actualResult = solution.MyAtoi(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
