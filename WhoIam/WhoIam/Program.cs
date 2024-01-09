using System;

namespace WhoIam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Vítej ve hře Kdo jsem?\nTvým cílem bude procházet Prahou a mluvit s lidmi.\nNa základě informací budeš muset uhodnout, kdo jsi.");
            System.Warning();
            Console.WriteLine($"Klikni pro pokračování a instrukce");
            System.ColorBack();
            Console.ReadKey();
            Tutorial();
        }
        static void Tutorial()
        {
            Console.WriteLine($"Hra se ovládá pouze čísly 1 až 4. Ta spustí vybrané interakce a přesuny na místa\nMaximální počet rozhovorů je 6");
            System.Warning();
            Console.WriteLine($"Klikni pro pokračování");
            System.ColorBack();
            Console.ReadKey();
            ChooseLevel();
        }
        static void ChooseLevel()
        {
            int Level = 0;
            Console.WriteLine($"Zvol postavu 1-3");
            Level = System.ValidateNumber(Level);
            Console.WriteLine($"Byla zvolena postava {Level}");
            switch (Level)
            {
                case 1:
                    Character Karel = new Character("Karel IV.", 1316, "Český král a římský císař");
                    break;
                case 2:
                    Character Franz = new Character("Franz Kafka", 1883, "Český německy píšící spisovatel");
                    break;
                case 3:
                    Character Masaryk = new Character("Tomáš Garrigue Masaryk", 1850, "První československý prezident");
                    break;
                default:
                    ChooseLevel();
                    break;
            }
            System.StartGame();
            Console.ReadKey();
        }
    }
}
