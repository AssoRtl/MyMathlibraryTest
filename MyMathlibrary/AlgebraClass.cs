using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathlibrary
{
    public class AlgebraClass
    {
        public static double RowSumm(double[] mass)
        {
            double sum = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                sum+= mass[i];  
            }
            return sum;
        }
        public static double RowMax(double[] mass)
        {
            double max = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i]>max)
                {
                    max= mass[i];
                }
            }
            return max;
        }
        public static double RowMin(double[] mass)
        {
            double min = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < min)
                {
                    min= mass[i];
                }
            }
            return min;
        }
        public static double RowAvg(double[] mass)
        {
            double sum = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                sum += mass[i];
            }
            return sum/mass.Length;
        }
    }
}
