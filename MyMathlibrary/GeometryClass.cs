using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathlibrary
{
    public class GeometryClass
    {
        public static double SquareTriangle(double a, double h)
        {
            double sq = (a * h) / 2;
            return sq;
        }
        public static double SquareSquare(double a)
        {
            double sq = a*a;
            return sq;
        }
        public static double SquareRectangle(double a, double b)
        {
            double sq = a*b;
            return sq;
        }
        public static double SquareRhomb(double d1, double d2)
        {
            double sq = (d1*d2)/2;
            return sq;
        }
        public static double SquareRound(double r)
        {
            double P = 3.14;
            double sq = P*(r*r);
            return sq;
        }
    }
}
