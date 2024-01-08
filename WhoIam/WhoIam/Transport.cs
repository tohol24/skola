using System;

namespace WhoIam
{
    internal class Transport
    {
        public Action lastPlace;
        public Action place1;
        public Action place2;
        public Action place3;

        public void Move(Action place1, Action place2, Action place3)
        {
            this.place1 = place1;
            this.place2 = place2;
            this.place3 = place3;

            int input = 0;

            Console.WriteLine("Zadej číslo");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    place1();
                    lastPlace = place1;
                    break;
                case 2:
                    place2();
                    lastPlace = place2;
                    break;
                case 3:
                    place3();
                    lastPlace = place3;
                    break;
                default:
                    break;
            }
        }      
    }
}
