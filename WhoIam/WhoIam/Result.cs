using System;

namespace WhoIam
{
    internal class Result
    {
        public void Check()
        {
            Functions.Warning("Opravdu cheš hru ukončit?");
            string Answer = Console.ReadLine().ToString().ToLower();
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
        public void AskForAnswer()
        {
            Functions.Warning("Nyní vepiš odpověď");
            string input = Console.ReadLine().ToString();
            Console.WriteLine($"Je toto definitivní odpověď - {input}? zadej A pro pokračování, N pro opakování.");
            if (Console.ReadLine().ToString().ToLower() == "a")
            {
                Answers answer = new Answers();
                answer.CheckAnswers(input);
            }
            else
            {
                AskForAnswer();
            }

        }
    }
}