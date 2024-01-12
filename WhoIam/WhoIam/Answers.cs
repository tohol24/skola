using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WhoIam
{
    // Třída pro kontrolu odpovědí hráče a jejich vyhodnocení
    internal class Answers
    {
        // Metoda pro kontrolu a vyhodnocení odpovědi hráče
        public void CheckAnswers(string input)
        {
            int Character = Program.SelectCharacter();
            Texts texts = new Texts();

            switch (Character)
            {
                case 1:
                    // Odpovědi pro postavu Karel IV.
                    var answers1 = new List<string>()
                    {
                        "Karel IV.",
                        "KarelIV.",
                        "Karel IV",
                        "KarelIV",
                        "Karel Čtvrtý"
                    };

                    // Kontrola, zda hráčova odpověď odpovídá některé z platných odpovědí pro postavu Karel IV.
                    for (int i = 0; i < (answers1.Count()); i++)
                    {
                        if (answers1[i] == input)
                        {
                            i = answers1.Count() - 1;
                            texts.CorrectAswer(answers1[0]);
                        }
                        else
                        {
                            Fail();
                        }
                    }
                    break;

                case 2:
                    // Odpovědi pro postavu Franz Kafka
                    var answers2 = new List<string>()
                    {
                        "Franz Kafka",
                        "Kafka"
                    };

                    // Kontrola, zda hráčova odpověď odpovídá některé z platných odpovědí pro postavu Franz Kafka
                    for (int i = 0; i < (answers2.Count()); i++)
                    {
                        if (answers2[i] == input)
                        {
                            i = answers2.Count() - 1;
                            texts.CorrectAswer(answers2[0]);
                        }
                        else
                        {
                            Fail();
                        }
                    }
                    break;

                case 3:
                    // Odpovědi pro postavu Tomáš Garrigue Masaryk
                    var answers3 = new List<string>()
                    {
                        "Tomáš Garrigue Masaryk",
                        "TGM",
                        "T.G.M.",
                        "T. G. M.",
                        "T. G. Masaryk",
                        "Masaryk",
                        "Garrigue Masaryk",
                        "Tomáš Masaryk"
                    };

                    // Kontrola, zda hráčova odpověď odpovídá některé z platných odpovědí pro postavu Tomáš Garrigue Masaryk
                    for (int i = 0; i < (answers3.Count()); i++)
                    {
                        if (answers3[i] == input)
                        {
                            i = answers3.Count() - 1;
                            texts.CorrectAswer(answers3[0]);
                        }
                        else
                        {
                            Fail();
                        }
                    }
                    break;
            }
        }

        // Metoda pro ukončení hry při neúspěšné odpovědi
        public void Fail()
        {
            Console.WriteLine("Toto bohužel není správná odpověď. Zkus to znovu. Stiskni");
            Console.ReadKey();
            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
            Environment.Exit(0);
        }
    }
}
