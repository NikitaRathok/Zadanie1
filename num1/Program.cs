using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            double x = double.Parse(Console.ReadLine());

            if(x>1&&x<2)
            {
                double y = Math.Pow(x - 2, 2)+6;
                Console.WriteLine(y);
            }
            else if(x>= 2)
            {
                double y = Math.Log10(x + 3 * Math.Sqrt(x));
                Console.WriteLine(y);
            }
        }
    }
}
