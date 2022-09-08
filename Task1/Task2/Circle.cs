using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle : Shape
    {
        public Circle(Double radius)
        {
            this.radius = radius;
        }

        private Double radius;
        public override Double CalculateArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
