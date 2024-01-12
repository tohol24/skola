using System;

namespace WhoIam
{
    internal class Program
    {
        private static int SelectedCharacter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine($"Vítej ve hře Kdo jsem?\nTvým cílem bude procházet Prahou a mluvit s lidmi.\nNa základě informací budeš muset uhodnout, kdo jsi.");
            Functions.Warning($"Klikni pro pokračování a instrukce");
            Console.ReadKey();
            Tutorial();         
        }
        static void Tutorial()
        {
            Console.WriteLine($"Hra se ovládá pouze čísly 1 až 4. Ta spustí vybrané interakce a přesuny na místa\nMaximální počet rozhovorů je 6");
            Functions.Warning($"Klikni pro pokračování");
            Console.ReadKey();
            ChooseLevel();
        }
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

                    Character Karel = new Character(1,"Karel IV.", 1316, "Český král a římský císař");
                    break;
                case 2:
                    Character Franz = new Character(2,"Franz Kafka", 1883, "Český německy píšící spisovatel");
                    break;
                case 3:
                    Character Masaryk = new Character(3,"Tomáš Garrigue Masaryk", 1850, "První československý prezident");
                    break;
                default:
                    ChooseLevel();
                    break;
            }
            SelectedCharacter = Level;
            Functions.Clear();
            Functions.StartGame();
            Console.ReadKey();
        }
        public static int SelectCharacter()
        {
            return SelectedCharacter;
        }
    }
}
