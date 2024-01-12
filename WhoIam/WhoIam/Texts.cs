using System;

namespace WhoIam
{
    internal class Texts
    {

        public void WelcomeText(string LocationName, string NpcName) // Přivítání hráče na místě
        {
            Console.WriteLine($"Místo: {LocationName}\nS kým si můžeš promluvit: {NpcName}");
        }

        public void TransportInfo(string place1, string place2, string place3) //Informace o tom, kam může hráč dále cestovat
        {
            Functions.InfoText();
            Console.WriteLine($"Odtud se můžeš přesunout na místa\n1. {place1}\n2. {place2}\n3. {place3}");
            Functions.ColorBack();
        }

        public void VisitLocation(string locationName, string npcName ,string transport1,string transport2, string transport3) // Získání dat pro texty
        {
            WelcomeText(locationName, npcName);
            TransportInfo(transport1, transport2, transport3);            
        }
        public void ChoiseText()
        {
            Console.WriteLine("Zadej:\n1 pro dialog s osobou\n2 pro přesun na jiné místo\n3 pro ukončení hry a pokus hádat");
        }
        public void CorrectAswer(string input)
        {
            Console.WriteLine($"Gratuluji. Vyhrál jsi! Správná odpověď skutečně byla {input}");
        }
    }
}
