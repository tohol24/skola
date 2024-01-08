using System;

namespace WhoIam
{
    internal class Texts
    {

        public void WelcomeText(string LocationName, string NpcName)
        {
            Console.WriteLine($"Místo: {LocationName}\nS kým si můžeš promluvit: {NpcName}");
        }

        public void TransportInfo(string place1, string place2, string place3)
        {
            System.Warning();
            Console.WriteLine($"Odtud se můžeš přesunout na místa\n1. {place1}\n2. {place2}\n3. {place3}");
        }
    }
}
