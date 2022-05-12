using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[n];
            for (int i=0; i<n; i++) 
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            //Console.WriteLine("Сумма чисел массива равна = " + MathLib.Sum(arr));
            //Console.ReadKey();
            //Console.WriteLine("Произведение чисел массива равна = " + MathLib.Mult(arr));
            //Console.ReadKey();
            //Console.WriteLine("Среднее геометрическое чисел массива равна = " + MathLib.Srgeom(arr));
            //Console.ReadKey();
            Console.WriteLine("Среднее арифметическое чисел массива равна = " + MathLib.Srsum(arr));
            Console.ReadKey();
        }
    }
}
