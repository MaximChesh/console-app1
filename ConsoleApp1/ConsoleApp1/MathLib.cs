using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathLib
    {
        public static double Sum(double[] arrange)
        {
            double sum = 0;
            for (int i = 0; i < arrange.Length; i++)
            {
                sum += arrange[i];
            }
            return (sum);
        }
        public static double Mult(double[] arrange)
        {
            double mult = 1;
            for (int i = 0; i < arrange.Length; i++)
            {
                mult = arrange[i];
            }
            return (mult);
        }
        public static double Srgeom(double[] arrange)
        {
            double geom = 1;
            for (int i = 0; i < arrange.Length; i++)
            {
                geom *= arrange[i];
            }
            geom = Math.Pow(geom, 1.0 / arrange.Length);
            return (geom);
        }
        public static double Srsum(double[] arrange)
        {
            double srsum = 0;
            for (int i = 0; i < arrange.Length; i++)
            {
                srsum += arrange[i];
            }
            srsum /= arrange.Length;
            return (srsum);
        }
    }
}
