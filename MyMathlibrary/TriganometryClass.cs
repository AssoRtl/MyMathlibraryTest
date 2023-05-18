using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathlibrary
{
    public class TriganometryClass
    {
        public static double SinA(double a) 
        {
            double res = Math.Sin(a);
            return res;
        }
        public static double CosA(double a) 
        {
            double res = Math.Cos(a);
            return res;
        }
        public static double TanA(double a) 
        {
            double res =  Math.Tan(a);
            return res;
        }
        public static double CtgA(double a) 
        {
            double res = 1 / Math.Tan(a);
            return res;
        }
    }
}
