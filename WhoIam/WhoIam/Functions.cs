using System;

namespace WhoIam
{
    internal class Functions
    {
        // Funkce pro spuštění hry
        public static void StartGame()
        {
            Places.Clinic();
        }

        // Funkce pro ověření, zda vstupní hodnota je platné číslo
        public static int ValidateNumber(int input)
        {
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                return 0;
            }
        }

        // Hlavní herní menu, které zpracovává výběr hráče
        public static void Menu(Action place1, Action place2, Action place3, Action NpcName)
        {
            Transport transport = new Transport();
            Dialogs dialog = new Dialogs();
            Texts texts = new Texts();

            // Nekonečný cyklus pro opakované zobrazení menu
            while (true)
            {
                texts.ChoiseText();
                int Option = Convert.ToInt32(Console.ReadLine());

                // Zpracování volby hráče
                switch (Option)
                {
                    case 1:
                        dialog.GetNpc(NpcName);
                        break;
                    case 2:
                        transport.Move(place1, place2, place3);
                        break;
                    case 3:
                        Result result = new Result();
                        result.Check();
                        break;
                    default:
                        // Pokud hráč zadá neplatnou volbu, zobrazí se menu znovu
                        Menu(place1, place2, place3, NpcName);
                        break;
                }
            }
        }

        // Funkce pro zobrazení varovného textu
        public static void Warning(string input)
        {
            string WarningText = input;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(WarningText);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Funkce pro nastavení barvy textu na tmavě zelenou
        public static void InfoText()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        // Funkce pro obnovení bílé barvy textu
        public static void ColorBack()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Funkce pro vyčištění konzole
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
