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
                Console.WriteLine("Prvek na indexu " + i + " je: " + Numarray[i]);
                Console.WriteLine();
            }

            int sum;
            sum = Numarray.Sum();
            Console.WriteLine("Součet je " + sum);
            Console.ReadKey();


            int average;
            average = (sum / Numarray.Length);
            Console.WriteLine("Průměr je " + average);
            Console.ReadKey();


            int max;
            max = Numarray.Max();
            Console.WriteLine("Maximum je " + max);
            Console.ReadKey();


            int min;
            min = Numarray.Min();
            Console.WriteLine("Minimum je " + min);
            Console.ReadKey();


            int index;
            Console.WriteLine("Zadej prvek a já najdu index");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Index je " + Array.IndexOf(Numarray, index));
            Console.ReadKey();

            Random random = new Random();
            int[] myArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                myArray[i] = random.Next(0, 10);

            }

            int[] counts = new int[10];
            foreach (int number in myArray)
            {
                counts[number]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Počet výskytů čísla " + i + " je: " + counts[i]);
            }
            Console.WriteLine("Řada normálně");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            int[] secArrray= new int[myArray.Length];
            Console.WriteLine("Řada opačně");// nutno opravit
            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myArray[myArray.Length-1 - i]);
            }
            Console.ReadKey();
        }
    }
}
