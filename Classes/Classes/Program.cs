using System;

namespace Classes
{
    internal class Program
    {
        class Human
        {
            public int age;
            public int height;
            public int weight;
            public string iq;
            public string eyeColor;
            public string name;

            public void PrintMessage()
            {
                if (name == null)
                {
                    name = "Bezejmený člověk";
                }

                if (Convert.ToInt32(iq) < 78)
                {

                    if (Convert.ToInt32(iq) < 58)
                    {
                        iq = "pod průměrem Somálska";
                    }
                    else
                    {
                        iq = "pod průměrem chytřejší opice";
                    }
                }
                else
                {
                    iq = "normálního člověka";
                }

                Console.WriteLine($"{name} je starý {age} let a má IQ {iq} ");

            }

            public Human(int age, int height, int weight, string iq, string eyeColor, string name)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.iq = iq;
                this.eyeColor = eyeColor;
                this.name = name;
            }

            public float BMI()
            {
                float heightToMeters = height / 100;
                float bmi = weight / (heightToMeters * heightToMeters);
                return bmi;
            }
        }
        static void Main(string[] args)
        {
            Human Cigismund = new Human(32, 151, 50, "30", "Brown", "Cigismund");
            Cigismund.PrintMessage();
            float bmi = Cigismund.BMI(); ;
            Console.WriteLine($"Má BMI {bmi}");

            Human mike = new Human(18, 205, 98, "60", "Brown", "Mike");
            mike.PrintMessage();
            bmi = mike.BMI();

            Console.WriteLine($"Má BMI {bmi}");

            Human Albert = new Human(18, 172, 60, "150", "Brown", "Albert");
            Albert.PrintMessage();
            bmi = Albert.BMI();
            Console.WriteLine($"Má BMI {bmi}");


            Console.ReadKey();
        }
    }
}
