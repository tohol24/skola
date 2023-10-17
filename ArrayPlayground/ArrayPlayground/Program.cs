using System;
using System.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Numarray = { 1, 2, 4, 8, 16 };

            for (int i = 0; i < Numarray.Length; i++)
            {
                Console.WriteLine(Numarray[i]);
                Console.WriteLine();
            }

            int sum;
            sum = Numarray.Sum();
            Console.WriteLine(sum);

            int average;
            average = (sum / Numarray.Length);
            Console.WriteLine(average);

            int max;
            max = Numarray.Max();
            Console.WriteLine(max);

            int min;
            min = Numarray.Min();
            Console.WriteLine(min);

            int index;
            int Position;
            Console.WriteLine("Zadej prvek a já najdu index");
            Position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Array.IndexOf(Numarray, Position));

            Random random = new Random();
            int[] array= new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = random.Next(1, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.WriteLine();
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            int[] reverseArray = new int[Numarray.Length];
            for (int i = Numarray.Length - 1; i >= 0; i--)
            {
                reverseArray[Numarray.Length - i - 1] = Numarray[i];
            }
            for (int i = 0; i < reverseArray.Length; i++)
            {
                Console.WriteLine(reverseArray[i]);
            }

            Console.ReadKey();
        }
    }
}
