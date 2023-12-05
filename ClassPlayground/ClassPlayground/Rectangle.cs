using System;

namespace ClassPlayground
{
    /*
 * TODO:
 * 1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *    Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x,y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví*/
    internal class Rectangle
    {
        public void CalculateArea(int width, int height)
        {
            try
            {
                int result = 0;

                result = width * height;
                Console.WriteLine("Obsah plochy je " + result);

            }
            catch (System.Exception)
            {
                Console.WriteLine("Chyba");
                Console.ReadKey();
            }
        }
        public void CalculateAspectRatio(int width, int height)
        {
            if (width > height)
            {
                Console.WriteLine("Obdelník je široký");
            }
            else if (height == width)
            {
                Console.WriteLine("Jedná se o čtverec");
            }
            else
            {
                Console.WriteLine("Obdelník je vysoký");
            }

            int WidthAspect = width;
            int HeightAspect = height;

            for (int i = Math.Min(width, height); i > 1; i--)
            {
                if (width % i == 0 && height % i == 0)
                {
                    WidthAspect /= i;
                    HeightAspect /= i;
                }
            }

            Console.WriteLine("Poměr stran: " + WidthAspect + ":" + HeightAspect);


            Console.WriteLine("Poměr stran: " + WidthAspect + ":" + HeightAspect);

        }
        public void ContainsPoint(int width, int height)
        {
            int x = 0;
            int y = 0;
            bool inside = false;
            Console.WriteLine("Zadej bod na ose X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej bod na ose y");
            y = Convert.ToInt32(Console.ReadLine());


            if (x <= width && y <= height)
            {
               inside= true;
                Console.WriteLine($"Výrok, že bod je uvnitř je {inside}");
            }
        }
    }
}
