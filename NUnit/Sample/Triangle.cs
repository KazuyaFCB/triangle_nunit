using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Triangle
    {
        private double e1;
        private double e2;
        private double e3;
        public double E1
        {
            get { return e1; }
        }
        public double E2
        {
            get { return e2; }
        }
        public double E3
        {
            get { return e3; }
        }
        public Triangle()
        {
            e1 = e2 = e3 = 0;
        }
        public Triangle(Point v1, Point v2, Point v3)
        {
            e1 = v1.GetDistance(v2);
            e2 = v2.GetDistance(v3);
            e3 = v3.GetDistance(v1);
        }
        public bool isTriangle()
        {
            return (e1 + e2 > e3 && e1 + e3 > e2 && e2 + e3 > e1);
        }
        public bool isEquilateralTriangle()
        {
            return e1.ToString() == e2.ToString() && e1.ToString() == e3.ToString();
        }
        public bool isRightAndIsoscelesTriangle()
        {
            return (e1.ToString() == e2.ToString() && (e1 * e1 + e2 * e2).ToString() == (e3 * e3).ToString()) || (e1.ToString() == e3.ToString() && (e1 * e1 + e3 * e3).ToString() == (e2 * e2).ToString()) || (e2.ToString() == e3.ToString() && (e2 * e2 + e3 * e3).ToString() == (e1 * e1).ToString());
        }
        public bool isRightTriangle()
        {
            return ((e1 * e1 + e2 * e2).ToString() == (e3 * e3).ToString()) || ((e1 * e1 + e3 * e3).ToString() == (e2 * e2).ToString()) || ((e2 * e2 + e3 * e3).ToString() == (e1 * e1).ToString());
        }
        public bool isIsoscelesTriangle()
        {
            return (e1.ToString() == e2.ToString()) || (e1.ToString() == e3.ToString()) || (e2.ToString() == e3.ToString());
        }
        
        public string classifyTriangle()
        {
            if (!isTriangle())
                return "Không phải tam giác";
            if (isEquilateralTriangle())
                return "Tam giác đều";
            if (isRightAndIsoscelesTriangle())
                return "Tam giác vuông cân";
            if (isRightTriangle())
                return "Tam giác vuông";
            if (isIsoscelesTriangle())
                return "Tam giác cân";
            return "Tam giác thường";
        }
        public double calPerimeter()
        {
            if (!isTriangle()) return -1;
            return e1 + e2 + e3;
        }
    }
}
