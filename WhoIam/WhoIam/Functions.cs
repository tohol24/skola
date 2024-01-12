using System;

namespace WhoIam
{
    internal class Functions
    {     
        public static void StartGame()
        {
            Places.Clinic();
        }
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
        public static void Menu(Action place1, Action place2, Action place3, Action NpcName)
        {
            Transport transport = new Transport();
            Dialogs dialog = new Dialogs();
            Texts texts = new Texts();
            while (true)
            {
                texts.ChoiseText();
                int Option = Convert.ToInt32(Console.ReadLine());
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
                        break;
                }
            }          
        }
        public static void Warning(string input)
        {
            string WarningText = input;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(WarningText);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void InfoText()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public static void ColorBack()
        {
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void Clear()
        {
            Console.Clear();
        }
    }
}
