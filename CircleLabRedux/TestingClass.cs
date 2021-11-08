using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircleLabRedux
{
    public class TestingClass
    {

        [Theory]
        [InlineData(5, 31.42)]
        [InlineData(2, 12.57)]

        public void CheckCircumference(double radius, double expected)
        {
            //Arrange
            Circle c = new Circle();

            //Act
            //since this returns a double, we store that in 'actual'
            double actual = c.CalculateCircumference(radius); 

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        //we don't pass any variables because it doesn't have inline data to give
        public void CheckCircumference2()
        {
            Circle c = new Circle();
            double actual = c.CalculateCircumference(7);
            Assert.Equal(31.42, actual);
        }
        
    }
}
