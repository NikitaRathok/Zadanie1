using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину основанания  треугольника ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину первой стороны треугольник");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второй стороны треугольник");
            double c = double.Parse(Console.ReadLine());

            if (b == c)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }    
        }
    }
}
