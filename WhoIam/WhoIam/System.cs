using System;

namespace WhoIam
{
    internal class System
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
        public static void Warning()
        {
            Console.ForegroundColor = ConsoleColor.Red;
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
