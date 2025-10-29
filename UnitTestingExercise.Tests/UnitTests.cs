using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4, 7, 8, 19)]
        [InlineData(5, 4, 3, 12)]
        [InlineData(8, 15, 7, 30)]
        [InlineData(-3, -2, -6, -11)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(4, 9, -18, -5)]

        

    public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var Addtest = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            
            var  actual = Addtest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(4, 7, -3)]
        [InlineData(5, 4, 1)]
        [InlineData(8, 15, -7)]
        [InlineData(-3, -2, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 9, -5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            
            var subtractTest = new Calculator();
            
            //Act
            
            var  actual = subtractTest.Subtract(minuend, subtrhend);


            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7, 9, 63)]//Add test data <-------
        [InlineData(4, 7, 28)]
        [InlineData(5, 4, 20)]
        [InlineData(8, 15, 120)]
        [InlineData(-3, -2, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 9, 36)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            
            var MultiplyTest = new Calculator();

            //Act
            
            var  actual = MultiplyTest.Multiply(num1, num2);

            //Assert
            
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(4, 8, 0.5)]
        [InlineData(5, 5, 1)]
        [InlineData(8, 2, 4)]
        [InlineData(-3, -1, 3)]
        [InlineData(-5, 50, -0.1)]
        [InlineData(3, 9, 0.33)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            
            var DivideTest = new Calculator();

            //Act
            var  actual = DivideTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
