using System;
using System.ComponentModel;
using Xunit;
using System.Linq;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(2, 2, 2, 6)]
        [InlineData(5, 1, 9, 15)]
        [InlineData(1, 0, -1, 0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var result = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            int actual = result.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1, 4)]
        [InlineData(12, 6, 6)]
        [InlineData(21, 1, 20)]
        [InlineData(5, 10, -5)]
        [InlineData(0, 1, -1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var result = new Calculator();

            //Act
            int actual = result.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 6, 18)]
        [InlineData(2, 0, 0)]
        [InlineData(-3, -3, 9)]
        [InlineData(-2, 2, -4)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var result = new Calculator();

            //Act
            int actual = result.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        [InlineData(12, -3, -4)]
        [InlineData(-15, 5, -3)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 1, 0)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var result = new Calculator();
            //Act
            int actual = result.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
