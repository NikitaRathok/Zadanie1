using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер карты в диапозоне от 6 до 14 включительно");
            int k = int.Parse(Console.ReadLine());

            switch (k)
            {
                case 6:
                    {
                        Console.WriteLine("Достоинство - шестёрка");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Достоинство - семёрка");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Достоинство - восьмёрка");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Достоинство - девятка");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Достоинство - десятка");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("Достоинство - валет");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Достоинство - дама");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("Достоинство - король");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("Достоинство - туз");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Такой карты нет");
                        break;
                    }
            }

        }
    }
}
