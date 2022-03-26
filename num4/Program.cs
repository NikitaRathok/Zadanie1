using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B:");
            int b = int.Parse(Console.ReadLine());

            for(int i = a;i<=b;i++)
            {
                if (i >= 0)
                {
                    Console.WriteLine($"Число в цикле for {i}");
                }
            }
            Console.WriteLine("=====================");
            

            int k = a;
            while(k<=b)
            {
                if(k>=0)
                {

                    Console.WriteLine($"Число в цикле while {k}");
                    
                }
                k++;
            }
            Console.WriteLine("=====================");
            int n = a;
            do
            {
                if(n>=0)
                {
                    Console.WriteLine($"Число в цикле do while {n}");
                    
                }
                n++;
                
            } while (n <= b);

        }
    }
}
