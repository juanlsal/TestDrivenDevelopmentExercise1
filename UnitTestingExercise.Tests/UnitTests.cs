using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData (3,3,3,9)]
        [InlineData(30, 3, 1, 34)]
        [InlineData(10, 0, 1, 11)]
        [InlineData(5, 23, -5, 23)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            Calculator tester = new Calculator();

            var actual = tester.Add(num1, num2, num3);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 1,2)]
        [InlineData(4, 2, 2)]
        [InlineData(20, -3, 23)]
        [InlineData(10, 5,5)]
        [InlineData(3,2,1)]
        [InlineData(50,23,27)]
        [InlineData(100,23,77)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            Calculator tester = new Calculator();

            var actual = tester.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,5,10)]
        [InlineData(3,5,15)]
        [InlineData(7,4,28)]
        [InlineData(9,5,45)]
        [InlineData(3,7,21)]
        [InlineData(2,60,120)]
        [InlineData(4,8,32)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,1,3)]
        [InlineData(10,2,5)]
        [InlineData(12,6,2)]
        [InlineData(100,10,10)]
        [InlineData(15,3,5)]
        [InlineData(100,5,20)]
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator tester = new Calculator();
            var actual = tester.Divide(num1, num2);
            Assert.Equal(expected, actual);  
        }

    }
}
