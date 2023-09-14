using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num1 = 0;
            Double num2 = 0;
            Double result = 0;
            string sign = "";
            Console.WriteLine("Zadej první číslo");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej znaménko (+ nebo -)");
            sign = Console.ReadLine();
            if (sign=="+")
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
            else 
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
