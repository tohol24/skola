using System;

namespace _2DArray
{
    internal class Program
    {

        static void Main()
        {
            try
            {
                defColor();
                short menu = 0; // Proměná pro volbu menu
                int[,] myArray; // Hlavní matice
                int[,] backArray; // Záloha původní vygenerované matice
                myArray = CreateArray();
                backArray = myArray;
                WriteArray(myArray);
                Functions(menu, myArray, backArray);
            }
            catch (Exception)
            {
                Error();
            }
        }

        static void Functions(short menu, int[,] myArray, int[,] backArray)  // Menu pro uživatele
        {
            while (true)
            {
                try
                {
                    defColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Zvol funkci, kterou chceš. Napiš:\n1 pro vypsánířádku matice\n2 pro vypsání sloupce matice\n3 pro sečtení vygenerované (původní) matice\n4 pro vynásobení součtu prvků kvocientem\n5 pro vynásobení součtem prvků jiné matice\n6 pro přehození čísel na hlavní diagonále\n7 pro překlopení čísel přes hlavní diagonálu");
                    menu = Convert.ToInt16(Console.ReadLine());
                    defColor();
                    switch (menu)
                    {
                        case 1: 
                            writeRow(myArray);
                            break;
                        case 2:
                            writeColumn(myArray);
                            break;
                        case 3:
                            int sum = sumArray(myArray);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Součet matice je {sum}:");
                            break;
                        case 4:
                            multiplyArray(myArray);
                            break;
                        case 5:
                            arrayTimesArray(myArray, backArray);
                            break;
                        case 6:
                            swapMain(myArray, backArray);
                            break;
                        case 7:
                            transposeArray(myArray, backArray);
                            break;
                        default:
                            Console.WriteLine("Bohužel toto ještě neumím, hezký den!");
                            break;
                    }
                }
                catch (Exception)
                {
                    Error();
                }

            }
        }

        static int[,] CreateArray() // Menu pro vytvoření matice matice
        {
            try
            {
                Console.WriteLine($"Napiš:\n1 pro posloupnou matici\n2 pro náhodnou matici");
                short menu = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Nyní zadej výšku matice:");
                int sizeA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nyní zadej šířku matice:");
                int sizeB = Convert.ToInt32(Console.ReadLine());
                clearConsole();
                switch (menu)
                {
                    case 1:
                        return orderedArray(sizeA, sizeB);
                    case 2:
                        return randArray(sizeA, sizeB);
                    default:
                        Error();
                        break;
                }
            }
            catch (Exception)
            {

                Error();
            }
            return null;
        }

        static int[,] randArray(int sizeA, int sizeB) // Vytvoření náhodné matice
        {
            Random random = new Random();
            int[,] myArray = new int[sizeA, sizeB];

            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    myArray[i, j] = random.Next(1, 100);
                }
            }
            return myArray;
        }

        static int[,] orderedArray(int sizeA, int sizeB) // Vytvoření posloupné matice
        {
            try
            {
                int num = 1;
                int[,] myArray = new int[sizeA, sizeB];

                for (int i = 0; i < sizeA; i++)
                {
                    for (int j = 0; j < sizeB; j++)
                    {
                        myArray[i, j] = num;
                        num++;
                    }
                }
                return myArray;
            }
            catch (Exception)
            {
                Error();
                return null;
            }
        }

        static void WriteArray(int[,] myArray) // Vypsání matice
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void writeRow(int[,] myArray) // Součet členů matice
        {
            Console.WriteLine("Zadej řádek k vyhledání:");
            int nRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nyní vypíši řádek: " + nRow);
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[nRow, j] + " ");
            }
            Console.WriteLine();
        }
        static void writeColumn(int[,] myArray) // Součet členů matice
        {
            Console.WriteLine("Zadej SLOUPEC k vyhledání:");
            int nColumn = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Nyní vypíši řádek: " + nColumn);
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(myArray[i, nColumn] + " ");
            }
            Console.WriteLine();
        }

        static int sumArray(int[,] myArray) // Součet členů matice
        {
            int sum = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum += myArray[i, j];
                }
            }
            return sum;
        }

        static void multiplyArray(int[,] myArray)  // Násobení součtu matice kvocientem
        {
            try
            {
                Console.WriteLine("Zadej kvocient, kterým chceš matici násobit");
                int quotient = Convert.ToInt32(Console.ReadLine());
                int result = sumArray(myArray) * quotient;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Násobení součtu matice číslem {quotient} je {result}:");
            }
            catch (Exception)
            {
                Error();
            }
        }

        static void arrayTimesArray(int[,] myArray, int[,] backArray) // Funkce násobení součtu dvou matic
        {
            int sum1 = 0;
            int sum2 = 0;
            int result = 0;
            sum1 = sumArray(backArray);
            myArray = CreateArray();
            sum2 = sumArray(myArray);
            result = sum1 * sum2;
            myArray = backArray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Součin původní matice a nové matice je {result}");
        }

        static void swapMain(int[,] myArray, int[,] backArray) //Přehození číslel na hlavní diagonále
        {
            if (myArray.GetLength(0) == myArray.GetLength(1))
            {
                for (int i = 0; i < myArray.GetLength(0) / 2; i++)
                {
                    int tempMain = myArray[i, i];
                    int reversed = myArray.GetLength(0) - 1;
                    myArray[i, i] = myArray[reversed, reversed];
                    myArray[reversed, reversed] = tempMain;
                }
                WriteArray(myArray);
                myArray = backArray;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nemáš čtvercovou matici. Nelze otočit!");
            }

        }

        static void transposeArray(int[,] myArray, int[,] backArray)  // Transpozice matice přes hlavní diagonálu
        {
            int[,] tempArray = new int[myArray.GetLength(1), myArray.GetLength(0)];
            for (int i = 0; i < myArray.GetLength(0); i++) 
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    tempArray[j, i] = myArray[i, j];
                }
            }
            myArray = tempArray;
            WriteArray(myArray);
            myArray = backArray;
            
        }

        static void Error()  // Funkce pro chybu (Catch)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Byla zadána neplatná hodnota, program se restartuje! Stisktni libovolnou klávesu.");
            Console.ReadKey();
            Main();
            clearConsole();
        }

        static void clearConsole() //Vyčištění konzole
        {
            Console.Clear();
        }

        static void defColor() // Nastavení původní barvy pozadí a textu
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
