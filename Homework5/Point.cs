using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworke3
{
    internal class Point
    {
        public int x; 
        public int y;

        public Point ()
        {

        }

        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point (Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public double distance(int x,int y)
        {
            return Math.Sqrt(Math.Pow((this.x - x),2) + Math.Pow((this.y - y), 2));
        }

        public double distance()
        {
            return distance(0, 0);
        }

        public double distance(Point p)
        {
            return distance(p.x, p.y);
        }
    }
}
