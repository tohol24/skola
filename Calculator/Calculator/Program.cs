using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fun = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nyní si zvol funcki kalkulačky!" + Environment.NewLine + "Pro převod na binární kód zvol 1" + Environment.NewLine + "Pro běžnou kalkulačku zvol 2");
                fun = Convert.ToInt16(Console.ReadLine());
                Program function = new Program();
                switch (fun)
                {
                    case 1:
                        {
                            function.Binary();
                        }
                        break;

                    case 2:
                        function.Calc();
                        break;
                }
            }
        }

        public void Binary()
        {
            Program function = new Program();

            int cislo = 0;
            Console.WriteLine("Zadej číslo na převod");
            cislo = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(cislo, 2);
            Console.WriteLine(binary);
            Console.WriteLine("Klikni pro restart kalkulačky");
            Console.ReadKey();

        }

        public void Calc()
        {
            Double num1 = 0;
            Double num2 = 0;
            Double result = 0;
            string sign = "";
            Program function = new Program();

            Console.WriteLine("Zadej první číslo");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadej znaménko");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Výsledek je " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("Výsledek je " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Výsledek je " + result);
                    break;
                case "/":
                    if (num1!=0 && num2!=0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Výsledek je " + result);                        
                    }
                    else
                    {
                        Console.WriteLine("Nelze dělit nulou!!!");
                    }
                    break;
                default:
                    Console.WriteLine("Neplatné znaménko");
                    break;


            }
            Console.WriteLine("Klikni pro restart kalkulačky");
            Console.ReadKey();
        }
    }
}
