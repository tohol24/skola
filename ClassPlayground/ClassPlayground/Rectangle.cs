using System;

namespace ClassPlayground
{
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

            int heightRatio = height;
            int widthRatio = width;

            for (int i = 10; i > 0; i--)
            {
                if (heightRatio % i == 0 && widthRatio % i == 0)
                {
                    heightRatio /= i;
                    widthRatio /= i;

                    if (i == 1)
                    {
                        break;
                    }
                    else
                    {
                        i = 10;
                    }
                }
            }

            Console.WriteLine($"Poměr šířka:výška je {widthRatio}:{heightRatio}");
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
                inside = true;
                Console.WriteLine($"Výrok, že bod je uvnitř je {inside}");
            }
        }
    }
}
