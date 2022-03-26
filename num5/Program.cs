using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int b = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                
                 s +=  i;
     
            }
            Console.WriteLine("========");
            Console.WriteLine(s);
        }
    }
}
