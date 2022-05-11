using NUnit.Framework;
using LeetCodeProblems.Solutions.Easy.ValidParentheses;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Tests.Solutions.Easy.ValidParentheses
{
    class ValidParenthesesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("", true)]
        [TestCase("()", true)]
        [TestCase("[]", true)]
        [TestCase("{}", true)]
        [TestCase("{}[]()", true)]
        [TestCase("{}([])", true)]
        [TestCase("{{}}", true)]
        [TestCase("{[]}", true)]
        [TestCase("(", false)]
        [TestCase("{", false)]
        [TestCase("{", false)]
        [TestCase("{}}", false)]
        [TestCase("{{}", false)]
        [TestCase("([)]", false)]
        [TestCase("(])", false)]
        public void IsValidReturnsCorrectResult(string input, bool expectedResult)
        {
            //Arrange
            var solution = new Solution();

            //Act
            var actualResult = solution.IsValid(input);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
