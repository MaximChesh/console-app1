using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введите исходную функцию: ");
            string f = Console.ReadLine();
            Console.Write("Введите производную функции: ");
            string prf = Console.ReadLine();

            Console.Write("Введите самое маленькое значение истинного отрезка, a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите самое большое значение истинного отрезка, b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг, h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точность корня, k");
            int k = Convert.ToInt32(Console.ReadLine());
            //создать матрицу на основе a и b ( n = a; b, кол-во элементов в массиве)
            //ввод элементов в матрицу будет осуществлятся через
            //if (int i; i<function.length; i++)
            //дальше результат расчет f будет вводиться в матрицу
            //осуществить поиск на подозрительные отрезки изоляции, находясь в предыдущем if:
            //if () 

            Console.ReadKey();
        }
    }
}
