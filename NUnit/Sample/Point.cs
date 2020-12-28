using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Point
    {
        private double x;
        private double y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public double GetDistance(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.X, 2) + Math.Pow(y - p.Y, 2));
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
