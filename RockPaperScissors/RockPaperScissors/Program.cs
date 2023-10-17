using System;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int scorePC = 0;
            int scorePlayer = 0;
            Random rng = new Random();

            Console.WriteLine("Vítej ve hře. Stiskni klávesu pro začátek hry");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();

            while (true)
            {
                int itemPlayer = GetitemPlayer();
                int itemPC = GetitemPC(rng);

                GameResult(itemPlayer, itemPC, ref scorePlayer, ref scorePC);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Aktuální skóre hráče je: " + scorePlayer + Environment.NewLine + "Počítače: " + scorePC);
                Console.WriteLine("Pro další hru zmáčkni libovolné tlačítko");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private static int GetitemPlayer()
        {
            Console.WriteLine("Pro nůžky zadej N, pro kámen K, pro papír P");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "k":
                    Console.WriteLine("Zvolil jsi kámen");
                    return 1;
                case "n":
                    Console.WriteLine("Zvolil jsi nůžky");
                    return 2;
                case "p":
                    Console.WriteLine("Zvolil jsi papír");
                    return 3;
                default:
                    Console.WriteLine("Toto není platná volba");
                    return GetitemPlayer();
            }
        }

        private static int GetitemPC(Random rng)
        {
            return rng.Next(1, 4);
        }

        private static void GameResult(int itemPlayer, int itemPC, ref int scorePlayer, ref int scorePC) // Tuto funkci pomohl udělat GPT
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (itemPC)
            {
                case 1:
                    Console.WriteLine("PC dává kámen");
                    break;
                case 2:
                    Console.WriteLine("PC dává nůžky");
                    break;
                case 3:
                    Console.WriteLine("PC dává papír");
                    break;
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (itemPlayer == itemPC)
            {
                Console.WriteLine("!REMÍZA!");
            }
            else if ((itemPlayer + 1) == itemPC || (itemPlayer == 3 && itemPC == 1))
            {
                Console.WriteLine("Hráč vyhrál");
                scorePlayer++;
            }
            else
            {
                Console.WriteLine("Počítač vyhrál");
                scorePC++;
            }
        }
    }
}
