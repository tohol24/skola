using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial} a {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();

        }

        static int Factorial(int n)
        {
            int num = 0;
            if (n <= 0) return 0;
            if (n == 1)
            {
                return n;
            }
            else
            {
                num = n * Factorial(n - 1);
                Console.WriteLine("Nyní" + num);
                return num;
            }
        }

        static int Fibonacci(int n)
        {
            int num = 0;
            if (n <= 0) return 0;
            if (n==1)
            {
                return 1;
            }
            else
            {
                num = Fibonacci(n - 1) + Fibonacci(n - 2);
                Console.WriteLine("Nyní" + num);
                return num;
            }
        }
    }
}
