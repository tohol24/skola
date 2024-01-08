using System;

namespace ClassPlayground
{
    internal class Rectangle
    {
        int width;
        int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void CalculateArea()
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
        public void CalculateAspectRatio()
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

<<<<<<< HEAD
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
=======
            if (width <= 0 || height <= 0)
            {
                Console.WriteLine("");
                return;
            }

            int WidthAspect = width;
            int HeightAspect = height;
            bool repat = true;
            while (repat == true)
            {
                for (int i = 10; i >= 1; i--)
                {
                    if (i == 1)
                    {
                        repat = false;
                    }
                    if (WidthAspect % i == 0 && HeightAspect % i == 0 && i != 1)
                    {
                        WidthAspect /= i;
                        HeightAspect /= i;
>>>>>>> 429bcb18aad6e90b5c3543ef3611d9b31c1117c3
                        i = 10;
                    }
                }
            }

<<<<<<< HEAD
            Console.WriteLine($"Poměr šířka:výška je {widthRatio}:{heightRatio}");
=======
            Console.WriteLine("Poměr stran: " + WidthAspect + ":" + HeightAspect);

>>>>>>> 429bcb18aad6e90b5c3543ef3611d9b31c1117c3
        }
        public void ContainsPoint()
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
