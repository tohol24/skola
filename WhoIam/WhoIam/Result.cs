using System;

namespace WhoIam
{
    // Třída pro kontrolu a vyhodnocení výsledků hry
    internal class Result
    {
        // Metoda pro kontrolu, zda hráč chce ukončit hru
        public void Check()
        {
            Functions.Warning("Opravdu chceš hru ukončit?");
            string Answer = Console.ReadLine().ToString().ToLower();

            // Pokud hráč nechce ukončit hru, přesune se na poslední místo
            if (Answer == "n")
            {
                Transport transport = new Transport();
                Functions.Warning("Nyní nelze hru ukončit");
                transport.MoveToLast();
            }
            else
            {
                AskForAnswer();
            }
        }

        // Metoda pro zadání definitivní odpovědi od hráče
        public void AskForAnswer()
        {
            Functions.Warning("Nyní vepiš odpověď");
            string input = Console.ReadLine().ToString();
            Console.WriteLine($"Je toto definitivní odpověď - {input}? Zadej A pro pokračování, N pro opakování.");

            // Kontrola, zda hráč potvrzuje svou odpověď nebo chce zadat novou
            if (Console.ReadLine().ToString().ToLower() == "a")
            {
                Answers answer = new Answers();
                answer.CheckAnswers(input);
            }
            else
            {
                //Při odpovědi "n" nebo něco jiného se znovu spustí možnost odpovědět
                AskForAnswer();
            }
        }
    }
}
