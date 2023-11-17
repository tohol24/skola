using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] myArray = CreateBoard();
            PrintBoard(myArray);

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = GetInputRow();
            PrintRow(myArray, nRow);

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = GetInputColumn();
            PrintColumn(myArray, nColumn);

            //TODO 4: Vypiš hlavní diagonálu pole.
            PrintMainDiagonal(myArray);

            //TODO 5: Vypiš vedlejší diagonálu pole.
            PrintSecondaryDiagonal(myArray);
        }

        private static int[,] CreateBoard()
        {
            int[,] myArray = new int[5, 5];
            int next = 1;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = next;
                    next++;
                }
            }
            return myArray;
        }

        private static void PrintBoard(int[,] myArray)
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

        private static int GetInputRow()
        {
            Console.WriteLine("Zadej řádek k vyhledání:");
            int nRow = Convert.ToInt32(Console.ReadLine());
            return nRow;
        }

        private static void PrintRow(int[,] myArray, int nRow)
        {
            Console.WriteLine("Nyní vypíši řádek: " + nRow);
            for (int j = 0; j < myArray.GetLength(0); j++)
            {
                Console.Write(myArray[nRow, j] + " ");
            }
            Console.WriteLine();
        }

        private static int GetInputColumn()
        {
            Console.WriteLine("Zadej SLOUPEC k vyhledání:");
            int nColumn = Convert.ToInt32(Console.ReadLine());
            return nColumn;
        }

        private static void PrintColumn(int[,] myArray, int nColumn)
        {
            Console.WriteLine("Nyní vypíši sloupec: " + nColumn);
            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                Console.WriteLine(myArray[i, nColumn] + " ");
            }
            Console.WriteLine();
        }

        private static void PrintMainDiagonal(int[,] myArray)
        {
            Console.WriteLine("Hlavní diagonala: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i, i] + " ");
            }
            Console.WriteLine();
        }

        private static void PrintSecondaryDiagonal(int[,] myArray)
        {
            Console.WriteLine("Vedlejší diagonala: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i, myArray.GetLength(0) - 1 - i] + " ");
            }
<<<<<<< HEAD
=======
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst = 0;
            int yFirst = 0;
            int xSecond = 1;
            int ySecond = 1;
            int first = board[xFirst, yFirst];
            int second = board[xSecond, ySecond];
            int temp = first;
            board[xFirst, yFirst] = second;
            board[xSecond, ySecond] = temp;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                    next++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int tempRow = board[nRowSwap, i];
                board[nRowSwap, i] = board[mRowSwap, i];
                board[mRowSwap, i] = tempRow;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                    next++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                int tempCol = board[i, nColSwap];
                board[i, nColSwap] = board[i, mColSwap];
                board[i, mColSwap] = tempCol;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                    next++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 0; i < board.GetLength(0) / 2; i++)
            {
                int tempMain = board[i, i];
                int reversed = board.GetLength(0) - 1;
                board[i, i] = board[reversed, reversed];
                board[reversed, reversed] = tempMain;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                    next++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = 4; i >= board.GetLength(0) / 2; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    int tempSide = board[i, j];
                    board[i, j] = board[j, i];
                    board[j, i] = tempSide;
                }
            }
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                    next++;
                }
                Console.WriteLine();
            }
>>>>>>> 4a8cbbe6fba223166cc568e79aead240c1c2e789
            Console.WriteLine();
            Console.ReadKey();
        }

<<<<<<< HEAD
        //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
        //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
        int xFirst, yFirst, xSecond, ySecond;

        //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
        int nRowSwap = 0;
        int mRowSwap = 1;

        //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
        int nColSwap = 0;
        int mColSwap = 1;

        //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.


        //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.

=======
>>>>>>> 4a8cbbe6fba223166cc568e79aead240c1c2e789
    }
}
