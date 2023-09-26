using System;

namespace RockPaperScissors
{
    internal class Program
    {
        int scorePc = 0; // skóre počítače
        int scorePlayer = 0; // skóre hráče
        string item = ""; // předmět hráče string
        int itemPc = 0; // předmět PC
        int itemPlayer = 0; // předmět hráče
        Random rng = new Random(); // instance třídy Random pro generování náhodných čísel

        static void Main(string[] args)
        {
            Program function = new Program();
            Console.WriteLine("Vítej ve hře. Stiskni klávesu pro začátek hry");
            Console.ReadKey();
            function.Hra();
        }

        public void Hra()
        {
            Program function = new Program();

            while (true) // Změna podmínky na nekonečnou smyčku
            {
                item = ""; // Resetujeme volbu hráče pro každé kolo

                Console.WriteLine("Pro nůžky zadej N, pro kámen K, pro papír P");
                item = Console.ReadLine();
                item = item.ToLower();

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
                        Console.WriteLine("Toto není platná volba");
                        continue; // Pokračujeme ve smyčce, abychom získali platný vstup
                }

                itemPc = rng.Next(1, 4); // 1=kámen, 2=nůžky, 3=papír

                switch (itemPc)
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

                function.result();

                Console.WriteLine("Aktuální skóre hráče je: " + scorePlayer + Environment.NewLine + "Počítače: " + scorePc);
                Console.WriteLine("Pro restart hry zmáčkni libovolné tlačítko");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void result()
        {
            if (itemPc == itemPlayer)
            {
                Console.WriteLine("Remíza!");
            }
            else if ((itemPlayer == 1 && itemPc == 2) || (itemPlayer == 2 && itemPc == 3) || (itemPlayer == 3 && itemPc == 1))
            {
                Console.WriteLine("Hráč vyhrál!");
                scorePlayer++;
            }
            else if ((itemPc == 1 && itemPlayer == 2) || (itemPc == 2 && itemPlayer == 3) || (itemPc == 3 && itemPlayer == 1))
            {
                Console.WriteLine("Počítač vyhrál!");
                scorePc++;
            }
        }
    }
}
