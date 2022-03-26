using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const int M = 15;
            double a = Math.PI / 8;
            double b = 2/ Math.PI;
            double h = (b-a) / M;

            for(double i = a; i <= b; i = i + h)
            {
                double y = Math.Sin(1 / i);
                Console.WriteLine($"Значение функции при числе {i} равна {y}");
            }
            
        }
    }
}
