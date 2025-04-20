using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Circle
    {
        double radius = 0;

        public Circle ()
        {

        }

        public Circle (int radius)
        {
            this.radius = (double)radius;
        }

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public Circle (Circle input)
        {
            this.radius = input.radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return this.radius;
        }

        public double getPerimeter()
        {
            return 2 * this.radius * Math.PI;
        }

        public double getArea ()
        {
            return Math.Pow(this.radius,2) * Math.PI;
        }
    }
}
