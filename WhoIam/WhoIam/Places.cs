using System;
using System.IO;

namespace WhoIam
{
    public class Places
    {
        private static readonly Texts texts = new Texts();
        private static readonly Transport transport = new Transport();
        private static readonly Dialogs dialogs = new Dialogs();

        public static void OldTownSquare()
        {
            texts.WelcomeText("Staroměstské náměstí", "Prodejce pražské šunky");
            texts.TransportInfo("Karlův most", "Václavské náměstí", "Karlova univerzita");
            transport.Move(CharlesBridge, WenceslasSquare, CharlesUniversity);
        }
        public static void CharlesBridge()
        {
            texts.WelcomeText("Karlův most", "Asijský turista");
            texts.TransportInfo("Pražský hrad", "Staroměstské náměstí", "Národní knihovna");
            dialogs.AsianTourist();
            transport.Move(PragueCastle, OldTownSquare, NationalLibrary);
        }
        public static void NationalLibrary()
        {
            texts.WelcomeText("Národní knihovna", "Knihovnice");
            texts.TransportInfo("Karlův most", "Staroměstské náměstí", "Karlova univerzita");
            dialogs.Librarian();
            transport.Move(CharlesBridge, OldTownSquare, CharlesUniversity);
            Console.ReadKey();
        }
        public static void PragueCastle()
        {
            texts.WelcomeText("Pražský hrad", "Průvodce");
            texts.TransportInfo("Letiště Praha", "Karlův Most", "ČVUT");
            dialogs.TourGuide();
            transport.Move(Airport, CharlesBridge, TechnicalUniversity);
            Console.ReadKey();
        }
        public static void WenceslasSquare()
        {
            texts.WelcomeText("Václavské náměstí", "Pochybný prodejce");
            texts.TransportInfo("Hlavní nádraží", "Staroměstské náměstí", "Karlova univerzita");
            transport.Move(MainTrainStation, OldTownSquare, CharlesUniversity);
            Console.ReadKey();
        }
        public static void MainTrainStation()
        {
            texts.WelcomeText("Hlavní nádraží", "Čekající cestující");
            texts.TransportInfo("Václavské náměstí", "A.N. Florenc", "Olšanské hřbitovy");
            transport.Move(WenceslasSquare, FlorencBusStation, Cemetery);
            Console.ReadKey();
        }
        public static void FlorencBusStation()
        {
            texts.WelcomeText("Autobusové nádraží Florenc", "Cestující do Kadaně");
            texts.TransportInfo("Hlavní nádraží", "Staroměstské náměstí", "Olšanské hřbitovy");
            transport.Move(MainTrainStation, OldTownSquare, Cemetery);
            Console.ReadKey();
        }
        public static void CharlesUniversity()
        {
            texts.WelcomeText("Karlova Univerzita", "Student Historie");
            texts.TransportInfo("Václavské náměstí", "Staroměstské náměstí", "Národní knihovna");
            transport.Move(WenceslasSquare, OldTownSquare, NationalLibrary);
            Console.ReadKey();
        }
        public static void TechnicalUniversity()
        {
            texts.WelcomeText("ČVUT", "Zdejší student");
            texts.TransportInfo("Pražský hrad", "Staroměstské náměstí", "Národní knihovna");
            transport.Move(PragueCastle, OldTownSquare, NationalLibrary);
            Console.ReadKey();
        }
        public static void Airport()
        {
            texts.WelcomeText("Letiště Praha", "Prodejce letenek");
            texts.TransportInfo("Pražský hrad", "ČVUT", "Smíchov");
            transport.Move(PragueCastle, TechnicalUniversity, Smichov);
            Console.ReadKey();
        }
        public static void Voderadska()
        {
            texts.WelcomeText("Gymnáium Voděradská", "Profesor dějepisu");
            texts.TransportInfo("Olšanské hřbitovy", "Hlavní nádraží", "Národní knihovna");
            transport.Move(Cemetery, MainTrainStation, FlorencBusStation);
            Console.ReadKey();
        }
        public static void Cemetery()
        {
            texts.WelcomeText("Olšanské hřbitovy", "Hrobník");
            texts.TransportInfo("Gymnázium Voděradská", "Václavské náměstí", "Hlavní nádraží");
            transport.Move(Voderadska, WenceslasSquare, MainTrainStation);
            Console.ReadKey();
        }
        public static void Smichov()
        {
            texts.WelcomeText("Smíchov", "Náhodný kolemjdoucí");
            texts.TransportInfo("Pražský hrad", "Letiště", "ČVUT");
            transport.Move(PragueCastle, Airport, TechnicalUniversity);
            Console.ReadKey();
        }
        public static void Clinic()
        {
            Console.WriteLine($"Právě jsi se probudil na jakési klinice. Na vrátnici sedí starší paní. Zaptej se jí, co se ti stalo.");
            dialogs.Receptionist();
            transport.Move(PragueCastle, CharlesBridge, NationalLibrary);
            Console.ReadKey();

        }

    }
}
