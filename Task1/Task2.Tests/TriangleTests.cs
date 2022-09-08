using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Task2.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateAreaTriangleResult()
        {
            // Arrange
            Triangle triangle = new Triangle(3,4,5);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void CheckCorrectnessOfTriangleSides()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 6, 1);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            Assert.Equal(0, result);
        }
    }
}
