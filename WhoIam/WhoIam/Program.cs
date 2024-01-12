using System;

namespace WhoIam
{
    internal class Program
    {
        private static int SelectedCharacter = 0;

        // Hlavní funkce programu
        static void Main(string[] args)
        {
            // Vstupní uvítací zpráva
            Console.WriteLine($"Vítej ve hře Kdo jsem?\nTvým cílem bude procházet Prahou a mluvit s lidmi.\nNa základě informací budeš muset uhodnout, kdo jsi.");
            Functions.Warning($"Klikni pro pokračování a instrukce");
            Console.ReadKey();
            Tutorial();
        }

        // Tutoriál pro hráče
        static void Tutorial()
        {
            // Instrukce pro ovládání hry
            Console.WriteLine($"Hra se ovládá pouze čísly 1 až 4. Ta spustí vybrané interakce a přesuny na místa\nMaximální počet rozhovorů je 6");
            Functions.Warning($"Klikni pro pokračování");
            Console.ReadKey();
            ChooseLevel();
        }

        // Volba úrovně/postavy
        static void ChooseLevel()
        {
            int Level = 0;
            Console.WriteLine($"Zvol postavu 1-3");
            Level = Functions.ValidateNumber(Level);
            Console.WriteLine($"Byla zvolena postava {Level}");
            Dialogs dialog = new Dialogs();
            switch (Level)
            {
                case 1:
                    // Vytvoření instance postavy Karel IV.
                    Character Karel = new Character(1, "Karel IV.", 1316, "Český král a římský císař");
                    break;
                case 2:
                    // Vytvoření instance postavy Franz Kafka
                    Character Franz = new Character(2, "Franz Kafka", 1883, "Český německy píšící spisovatel");
                    break;
                case 3:
                    // Vytvoření instance postavy Tomáš Garrigue Masaryk
                    Character Masaryk = new Character(3, "Tomáš Garrigue Masaryk", 1850, "První československý prezident");
                    break;
                default:
                    // Pokud uživatel vybere neplatnou úroveň, znovu se mu nabídne výběr
                    ChooseLevel();
                    break;
            }
            SelectedCharacter = Level;
            Functions.Clear();
            Functions.StartGame();
            Console.ReadKey();
        }

        // Funkce pro získání vybrané postavy
        public static int SelectCharacter()
        {
            return SelectedCharacter;
        }
    }
}
