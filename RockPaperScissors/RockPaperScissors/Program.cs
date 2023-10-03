using System;

namespace RockPaperScissors
{
    internal class Program
    {
        int scorePC = 0; // skóre počítače
        int scorePlayer = 0; // skóre hráče
        string item = ""; // předmět hráče string
        int itemPC = 0; // předmět PC
        int itemPlayer = 0; // předmět hráče
        Random rng = new Random(); // instance třídy Random pro generování náhodných čísel

        private static void Main(string[] args)
        {
            Program function = new Program();
            Console.WriteLine("Vítej ve hře. Stiskni klávesu pro začátek hry");
            Console.WriteLine(); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            function.Hra();
        }

        public int Hra()
        {
            Program function = new Program();

            while (true)
            {
                item = "";

                Console.WriteLine("Pro nůžky zadej N, pro kámen K, pro papír P");
                item = Console.ReadLine();
                item = item.ToLower();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;

                switch (item)
                {
                    case "k":
                        Console.WriteLine("Zvolil jsi kámen");
                        itemPlayer = 1;
                        break;
                    case "n":
                        Console.WriteLine("Zvolil jsi nůžky");
                        itemPlayer = 2;
                        break;
                    case "p":
                        Console.WriteLine("Zvolil jsi papír");
                        itemPlayer = 3;
                        break;
                    default:
                        Console.WriteLine("Toto není platná volba"); // Když není ani jedno písmeno správné
                        continue;
                }

                itemPC = rng.Next(1, 4); // 1=kámen, 2=nůžky, 3=papír
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                switch (itemPC)  // Vypsání předmětu PC 
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

                if (itemPC == itemPlayer)   // Výpočítání výsledku
                {
                    Console.WriteLine("!REMÍZA!");
                }
                else if ((itemPlayer == 1 && itemPC == 2) || (itemPlayer == 2 && itemPC == 3) || (itemPlayer == 3 && itemPC == 1))
                {
                    Console.WriteLine("Hráč vyhrál");
                    scorePlayer++;
                }
                else
                {
                    Console.WriteLine("Počítač vyhrál");
                    scorePC++;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Aktuální skóre hráče je: " + scorePlayer + Environment.NewLine + "Počítače: " + scorePC);
                Console.WriteLine("Pro další hru zmáčkni libovolné tlačítko");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
