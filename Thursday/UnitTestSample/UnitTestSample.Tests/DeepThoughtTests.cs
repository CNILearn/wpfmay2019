using System;
using Xunit;

namespace UnitTestSample.Tests
{
    public class DeepThoughtTests
    {
        [Fact]
        public void TheAnswerOfTheUniverseTest()
        {
            // AAA
            // arrange
            var dt = new DeepThought();
            int expected = 42;
            // act
            int actual = dt.TheAnswerOfTheUniverse();
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringWithSmallStringTest()
        {
            // arrange
            var dt = new DeepThought();
            string input = "Ab";
            string expected = "ab";
            // act
            string actual = dt.SomeString(input);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringWithLongStringTest()
        {
            // arrange
            var dt = new DeepThought();
            string input = "AbcdEF";
            string expected = "ABCDEF";
            // act
            string actual = dt.SomeString(input);
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SomeStringWithNullExceptionTest()
        {
            // arrange
            var dt = new DeepThought();
            string input = null;
            // act && assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                dt.SomeString(input);
            });

        }
    }
}
