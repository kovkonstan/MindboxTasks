using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle : Shape
    {
        public Triangle(Double a, Double b, Double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private Double a, b, c;

        public override Double CalculateArea()
        {
            if (a > b + c || b > a + c || c > a + b)
            {
                return 0;
            }

            var halfPerimeter = (a + b + c) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        public Boolean IsTriangleRectangular()
        {
            Double hypotenuse, cathet1, cathet2;
            if (a > b && a > c)
            {
                hypotenuse = a;
                cathet1 = b;
                cathet2 = c;
            }
            else if (b > c)
            {
                hypotenuse = b;
                cathet1 = a;
                cathet2 = c;
            }
            else
            {
                hypotenuse = c;
                cathet1 = a;
                cathet2 = b;
            }

            return Math.Pow(hypotenuse, 2) == Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2);

        }
    }
}
