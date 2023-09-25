using System;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        private static void Main()
        {
            int bankPlayer = 1000;
            int bankComp = 100000;
            int bid;
            int num;
            int round = 0;
            Random random = new Random();
            while (bankPlayer > 0 && bankComp > 0)
            {
                Console.WriteLine("Tvůj aktuální zůstatek je: " + bankPlayer + " goldů" + Environment.NewLine + "Zadej sázku");
                bid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sázka je " + bid.ToString());
                if (bid > bankPlayer)
                {
                    Console.WriteLine("Nemůžeš vsadit, víc než máš!");
                }
                else
                {
                    Console.WriteLine("Zvol počáteční hodnotu");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Zadaná hodnota je " + num.ToString());
                    while (num != 1)
                    {
                        num = random.Next(1, num);
                        if (round % 2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Hráč táhl číslo " + num.ToString());
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Počítač táhl číslo " + num.ToString());
                            Console.WriteLine("Nyní je čas na hráči. Zmáčkni tlačítko");
                            Console.ReadKey();
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        round++;
                    }
                    if (round % 2 != 0)
                    {
                        Console.WriteLine("Hráč vyhrál " + bid.ToString() + " goldů");
                        bankPlayer += bid;
                        bankComp -= bid;
                    }
                    else
                    {
                        Console.WriteLine("Počítač vyhrál " + bid.ToString() + " goldů");
                        bankPlayer -= bid;
                        bankComp += bid;
                    }
                    Console.WriteLine("Stav účtu hráče je: " + bankPlayer + " počítače: " + bankComp);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;             
                Console.ReadKey();
            }
            Console.WriteLine("Nedostatečné finance jednoho z hráčů");
            Console.ReadKey();
        }
    }
}
