using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maturita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;    
            String input="";
            Console.WriteLine("Zadej číslo 1");
            input = Console.ReadLine();
            num1 = int.Parse(input);
            Console.WriteLine($"{num1}");
            Console.WriteLine("Zadej číslo 2");
            input = Console.ReadLine();
            num2 = int.Parse(input);
            Console.WriteLine($"{num2}");
            BasicMath(num1, num2);
        }
        public static void BasicMath(int num1, int num2)
        {
            int sum;
            int sub;
            int multiply;
            float divide;
            float power;
            float square;
            sum = num1 + num2;
            Console.WriteLine($"{sum}");
            sub = num1 - num2;
            Console.WriteLine($"{sub}");
            multiply = num1 * num2;
            Console.WriteLine($"{multiply}");
            divide = (float)num1 / num2;
            Console.WriteLine($"{divide}");
            power = (float)Math.Pow(divide, 2);
            Console.WriteLine($"{power}");
            square = (float)Math.Sqrt(divide);
            Console.WriteLine($"{square}");
            Verification(sum, sub, multiply);
            Console.ReadKey();
        }
        public static void Verification(int sum, int sub, int multiply)
        {
            if (sum < 0){Console.WriteLine($"Proměnná sum je záporná");}                                     
            else if (sum > 0){ Console.WriteLine($"Proměnná sum je kladná");}                                   
            else{Console.WriteLine($"Proměnná sum je 0");}         
            if(sub>multiply){Console.WriteLine("Rozdíl je větší než podíl");}               
            else { Console.WriteLine("Podíl je větší než rozdíl");}
            Stop();

        }
        public static void Stop()
        {

        }
    }
}
