using NUnit.Framework;
using LeetCodeProblems.Solutions.Medium.ReverseInteger;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Solutions.Medium.ReverseInteger
{
    class StringToIntegerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(10, 1)]
        [TestCase(-10, -1)]
        [TestCase(11, 11)]
        [TestCase(-11, -11)]
        [TestCase(12, 21)]
        [TestCase(-12, -21)]
        [TestCase(2147483647, 0)]
        [TestCase(-2147483647, -0)]
        [TestCase(-2147483648, 0)]
        [TestCase(2147483647, 0)]
        public void ReverseIntegerReturnsCorrectResult(int input, int expectedResult)
        {
            //Arrange
            var solution = new Solution();

            //Act
            var actualResult = solution.Reverse(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
