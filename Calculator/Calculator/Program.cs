using System;

namespace Calculator
{
    internal class Program
    {
        static double num = 0;
        static double result = 0;

        static void Main(string[] args)
        {
            int fun = 0;
            while (true)
            {
                num = 0;
                Console.Clear();
                Console.WriteLine("Nyní si zvolte funkci kalkulačky!" + Environment.NewLine + "Pro převod na binární kód zvolte 1" + Environment.NewLine + "Pro běžnou kalkulačku zvolte 2");
                fun = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (fun)
                {
                    case 1:
                        Binary();
                        break;

                    case 2:
                        Console.WriteLine("Zadejte číslo:");
                        num = Convert.ToDouble(Console.ReadLine());
                        Calc();
                        break;

                    default:
                        Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                        break;
                }
            }
        }

        public static void Binary()
        {
            Console.WriteLine("Zadejte číslo pro převod:");
            string numInput = Console.ReadLine();
            if (Int32.TryParse(numInput, out int number))
            {
                string binary = Convert.ToString(number, 2);
                Console.WriteLine("Výsledek převodu na binární kód: " + binary);
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte platné číslo.");
            }
            Console.WriteLine("Stiskněte klávesu pro restart kalkulačky.");
            Console.ReadKey();
        }

        public static void Calc()
        {
            Console.WriteLine("Zadejte operaci (+, -, *, /):");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = Plus(result, num);
                    break;

                case "-":
                    result = Minus(result, num);
                    break;

                case "*":
                    result = Times(result, num);
                    break;

                case "/":
                    if (num != 0)
                    {
                        result = Divide(result, num);
                    }
                    else
                    {
                        Console.WriteLine("Nelze dělit nulou!!!");
                        Console.WriteLine("Stiskněte klávesu pro restart kalkulačky.");
                        Console.ReadKey();
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Neplatná operace.");
                    Console.WriteLine("Stiskněte klávesu pro restart kalkulačky.");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Průběžný výsledek: " + result);
            Console.WriteLine("Stiskněte klávesu pro restart kalkulačky nebo mezerník pro zobrazení výsledku.");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Result(result);
                result = 0;
            }
            else
            {
                Calc();
            }
        }

        public static double Plus(double result, double num)
        {
            return result + num;
        }

        public static double Minus(double result, double num)
        {
            return result - num;
        }

        public static double Times(double result, double num)
        {
            return result * num;
        }

        public static double Divide(double result, double num)
        {
            return result / num;
        }

        public static void Result(double result)
        {
            Console.WriteLine("Výsledek je " + result);
            Console.ReadKey();
        }
    }
}
