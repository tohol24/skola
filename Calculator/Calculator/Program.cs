using System;

namespace Calculator
{
    internal class Program
    {
        static double num = 0;  // Číslo pro počítání
        static double result = 0;  // Průběžný výsledek

        static void Main()
        {
            int fun = 0;  // Funkce kalkulačky
            while (true)
            {
                num = 0;
                Console.Clear();
                Console.WriteLine("Nyní si zvol funkci kalkulačky!\n\nPro převod na binární kód zvol 1\nPro běžnou kalkulačku zvol 2\nPro goniometrickou kalkulačku zvol 3");
                int.TryParse(Console.ReadLine(), out fun);
                Console.Clear();

                switch (fun)
                {
                    case 1:
                        Binary();
                        break;

                    case 2:
                        Console.WriteLine("Zadej číslo:");
                        double.TryParse(Console.ReadLine(), out result);
                        Calc();
                        break;
                    case 3:
                        Gonio();
                        break;

                    default:
                        Console.WriteLine("Neplatná volba. Zkus to znovu.");
                        break;
                }
            }
        }

        public static void Binary() // Převod na binární kód
        {
            int numInput = 0;
            Console.WriteLine("Zadej číslo pro převod:");
            if (int.TryParse(Console.ReadLine(), out numInput))
            {
                string binary = Convert.ToString(numInput, 2);
                Console.WriteLine("Výsledek převodu na binární kód: " + binary);
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadej platné číslo.");
            }
            Console.WriteLine("Stiskni klávesu pro restart kalkulačky.");
            Console.ReadKey();
        }

        public static void Calc() // Kalkulačka
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zadej operaci (+, -, *, /) nebo mezerník pro výsledek:");
                ConsoleKeyInfo key = Console.ReadKey();
                string sign = key.KeyChar.ToString();  // Znak uživatele
                Console.ForegroundColor = ConsoleColor.White;

                if (key.Key == ConsoleKey.Spacebar)
                {
                    Result(result);  // Zobrazení výsledku
                    result = 0;
                }
                else if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
                {
                    Console.WriteLine("\nZadej další číslo:");
                    double.TryParse(Console.ReadLine(), out num);
                }
                else
                {
                    Console.WriteLine("\nNeplatná operace. Kalkulačka se restartuje.");
                    Console.ReadKey();
                    return;
                }

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
                            Console.WriteLine("Stiskni klávesu pro restart kalkulačky.");
                            Console.ReadKey();
                            return;
                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine("=" + result);
            }

        }

        public static void Gonio() // Goniometrie
        {
            Console.WriteLine("Zadej úhel na převod:");
            if (double.TryParse(Console.ReadLine(), out double deg))
            {
                double radiany = deg * (Math.PI / 180); // Převod úhlu ze stupňů na radiány

                double sin = Math.Sin(radiany);
                double cos = Math.Cos(radiany);
                double tg = Math.Tan(radiany);

                Console.WriteLine("Sinus úhlu " + deg + "° je " + sin);
                Console.WriteLine("Cosinus úhlu " + deg + "° je " + cos);
                Console.WriteLine("Tangens úhlu " + deg + "° je " + tg);
                Console.WriteLine("Cotangens úhlu " + deg + "° je " + 1/tg);

            }
            else
            {
                Console.WriteLine("Neplatný vstup.");
            }
            Console.ReadKey();
        }

        public static double Plus(double result, double num) // Součet
        {
            return result + num;
        }

        public static double Minus(double result, double num) // Rozdíl
        {
            return result - num;
        }

        public static double Times(double result, double num) // Součin
        {
            return result * num;
        }

        public static double Divide(double result, double num) // Podíl
        {
            return result / num;
        }

        public static void Result(double result) // Výsledek
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVýsledek je " + result);
            Console.ReadKey();
            Main();
        }
    }
}
