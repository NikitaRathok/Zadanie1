using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int n = int.Parse(Console.ReadLine());
            var mas = n.ToString().ToCharArray();
            var masArr = mas.ToArray();

            Console.WriteLine($"Максимальное число {masArr.Max()}");
            Console.WriteLine($"Минимальное число {masArr.Min()}");
        }
    }
}
