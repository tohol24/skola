using System;

namespace WhoIam
{
    // Třída reprezentující přesun mezi místy ve hře
    internal class Transport
    {
        // Akce pro jednotlivá místa
        public Action place1;
        public Action place2;
        public Action place3;

        // Akce pro poslední navštívené místo
        Action lastPlace = Places.Clinic;

        // Metoda pro přesun na vybrané místo
        public void Move(Action place1, Action place2, Action place3)
        {
            this.place1 = place1;
            this.place2 = place2;
            this.place3 = place3;

            int input = 0;

            Console.WriteLine("Zadej číslo místa 1-3");
            input = Functions.ValidateNumber(input);
            Functions.Clear();
            switch (input)
            {
                case 1:
                    lastPlace = place1;
                    place1();
                    break;
                case 2:
                    lastPlace = place2;
                    place2();
                    break;
                case 3:
                    lastPlace = place3;
                    place3();
                    break;
                default:
                    // Pokud hráč zadá neplatné číslo, znovu se mu nabídne výběr místa
                    Move(place1, place2, place3);
                    break;
            }
        }

        // Metoda pro přesun na posledně navštívené místo
        public void MoveToLast()
        {
            lastPlace();
        }
    }
}
