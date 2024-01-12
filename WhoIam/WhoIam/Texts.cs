using System;

namespace WhoIam
{
    // Třída obsahující texty ve hře
    internal class Texts
    {
        // Text pro přivítání hráče na místě s informacemi o místě a postavě
        public void WelcomeText(string LocationName, string NpcName)
        {
            Console.WriteLine($"Místo: {LocationName}\nS kým si můžeš promluvit: {NpcName}");
        }

        // Informace o tom, kam může hráč dále cestovat
        public void TransportInfo(string place1, string place2, string place3)
        {
            Functions.InfoText();
            Console.WriteLine($"Odtud se můžeš přesunout na místa\n1. {place1}\n2. {place2}\n3. {place3}");
            Functions.ColorBack();
        }

        // Zobrazení informací o místě, postavě a možných cestách
        public void VisitLocation(string locationName, string npcName, string transport1, string transport2, string transport3)
        {
            WelcomeText(locationName, npcName);
            TransportInfo(transport1, transport2, transport3);
        }

        // Text pro volbu hráče
        public void ChoiseText()
        {
            Console.WriteLine("Zadej:\n1 pro dialog s osobou\n2 pro přesun na jiné místo\n3 pro ukončení hry a pokus hádat");
        }

        // Zpráva o správné odpovědi
        public void CorrectAswer(string input)
        {
            Console.WriteLine($"Gratuluji. Vyhrál jsi! Správná odpověď skutečně byla {input}");
        }
    }
}
