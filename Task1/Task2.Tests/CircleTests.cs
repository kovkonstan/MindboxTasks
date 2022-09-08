using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task2.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateAreaCircleResult()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            var result = circle.CalculateArea();

            // Assert
            Assert.Equal(Math.PI * 25, result);
        }

    }
}
