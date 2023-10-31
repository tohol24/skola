using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchPlayground
{
    internal class Program
    {
        static int LinearSearch(int[] array, int elementToSearch)
        {
            return Array.IndexOf(array, elementToSearch);
        }

        static int BinarySearch(int[] array, int elementToSearch)
        {
            int lower = 0;
            int upper = array.Length - 1;
            int mid = 0;
            int position = 0;

            while (lower <= upper)
            {
                mid = lower + (upper - lower) / 2;
                position++;

                if (array[mid] == elementToSearch)
                {
                    Console.WriteLine("Počet kroků byl " + position);
                    return mid;
                }
                else if (array[mid] < elementToSearch)
                {
                    lower = mid + 1;
                }
                else
                {
                    upper = mid - 1;
                }
            }

            Console.WriteLine("Element nebyl nalezen");
            Console.ReadKey();

            return -1;
        }



        static int BinarySearchRecursive(int[] array, int elementToSearch, int lower, int upper)
        {
            if (lower>upper)
            {
                return -1;
            }
            int mid = lower +(upper - lower) / 2; 
            if (array[mid] == elementToSearch)
            {
                return mid;
            }
            if (array[mid]<elementToSearch)
            {
                return BinarySearchRecursive(array, elementToSearch, mid + 1, upper);
            }
            return BinarySearchRecursive(array, elementToSearch, lower, mid - 1);
        }

        //Naplní pole náhodnými rostoucími čísly.
        static void FillArray(int[] array)
        {
            Random rng = new Random();
            int lastNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = lastNumber + rng.Next(1, 10);
                lastNumber = array[i];
            }
        }

        //Vypíše pole do konzole
        static void WriteArrayToConsole(int[] array, string arrayName)
        {
            Console.Write(arrayName + " = [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]\n\n");
        }

        //Zavolá postupně lineární, binární a rekurzivní binární vyhledávání pro zadané pole (a vypíše jeho jméno pro přehlednost)
        static void SearchArray(int[] array, string arrayName)
        {
            Random rng = new Random();
            int randomElement = array[rng.Next(array.Length)];
            Console.WriteLine($"Prohledávám {arrayName} a hledám v něm prvek {randomElement}:");
            int index;

            index = LinearSearch(array, randomElement);
            Console.WriteLine($"Lineární vyhledávání našlo prvek {randomElement} na indexu {index}");

            index = BinarySearch(array, randomElement);
            Console.WriteLine($"Binární vyhleádávání našlo prvek {randomElement} na indexu {index}");

            index = BinarySearchRecursive(array, randomElement, 0, array.Length - 1);
            Console.WriteLine($"Rekurzivní binární vyhledávání našlo prvek {randomElement} na indexu {index}");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] smallArray = new int[10];
            FillArray(smallArray);

            int[] mediumArray = new int[20];
            FillArray(mediumArray);

            int[] largeArray = new int[30];
            FillArray(largeArray);

            WriteArrayToConsole(smallArray, "Malé pole");
            SearchArray(smallArray, "Malé pole");

            WriteArrayToConsole(mediumArray, "Střední pole");
            SearchArray(mediumArray, "Střední pole");

            WriteArrayToConsole(largeArray, "Velké pole");
            SearchArray(largeArray, "Velké pole");

            Console.ReadKey();
        }
    }
}
