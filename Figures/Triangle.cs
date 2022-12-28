using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
       
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        private double _p;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)
            {
                a = firstSide;
                b = secondSide;
                c = thirdSide;
                _p = (a + b + c) / 2;
            
            }
            else
            {
                throw new ArgumentException("Triangle with this sides does not exist.");
            }

        }

        public double GetArea()
        {
            
            return Math.Sqrt(_p * (_p - a) * (_p - b) * (_p - c)); 
        }

        public double GetPerimeter()
        {
            return (a + b + c);
        }
        public bool isRectangular()
        {
            return a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a;
        }
    }
}
