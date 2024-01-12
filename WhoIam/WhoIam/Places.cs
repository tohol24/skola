using System;
using System.IO;

namespace WhoIam
{
    public class Places //Tato třída obsahuje všechna místa. Možnosti přesunů a seznam tamních NPC.
    {
        private static readonly Texts texts = new Texts();
        private static readonly Transport transport = new Transport();
        private static readonly Dialogs dialogs = new Dialogs();

        public static void OldTownSquare()
        {
            texts.VisitLocation("Staroměstské náměstí", "Prodejce pražské šunky", "Karlův most", "Václavské náměstí", "Karlova univerzita");
            Functions.Menu(CharlesBridge, WenceslasSquare, CharlesUniversity, dialogs.HamSeller);
            Console.ReadKey();
        }
        public static void CharlesBridge()
        {
             texts.VisitLocation("Karlův most", "Asijský turista", "Pražský hrad", "Staroměstské náměstí", "Národní knihovna");
            Functions.Menu(PragueCastle, OldTownSquare, NationalLibrary, dialogs.AsianTourist);
            Console.ReadKey();
        }
        public static void NationalLibrary()
        {
            texts.VisitLocation("Národní knihovna", "Knihovnice", "Karlův most", "Staroměstské náměstí", "Karlova univerzita");
            Functions.Menu(CharlesBridge, OldTownSquare, CharlesUniversity, dialogs.Librarian);
            Console.ReadKey();
        }

        public static void PragueCastle()
        {
            texts.VisitLocation("Pražský hrad", "Průvodce", "Letiště Praha", "Karlův Most", "ČVUT");
            Functions.Menu(Airport, CharlesBridge, TechnicalUniversity, dialogs.TourGuide);
            Console.ReadKey();
        }
        public static void WenceslasSquare()
        {
            texts.VisitLocation("Václavské náměstí", "Pochybný prodejce", "Hlavní nádraží", "Staroměstské náměstí", "Karlova univerzita");
            Functions.Menu(MainTrainStation, OldTownSquare, CharlesUniversity, dialogs.DrugDealer);
            Console.ReadKey();
        }
        public static void MainTrainStation()
        {
            texts.VisitLocation("Hlavní nádraží", "Čekající cestující", "Václavské náměstí", "A.N. Florenc", "Olšanské hřbitovy");
            Functions.Menu(WenceslasSquare, FlorencBusStation, Cemetery, dialogs.Passanger);
            Console.ReadKey();
        }
        public static void FlorencBusStation()
        {
            texts.VisitLocation("Autobusové nádraží Florenc", "Cestující do Kadaně", "Hlavní nádraží", "Staroměstské náměstí", "Olšanské hřbitovy");
            Functions.Menu(MainTrainStation, OldTownSquare, Cemetery, dialogs.BusPassenger);
            Console.ReadKey();
        }
        public static void CharlesUniversity()
        {
            texts.VisitLocation("Karlova Univerzita", "Student Historie", "Václavské náměstí", "Staroměstské náměstí", "Národní knihovna");
            Functions.Menu(WenceslasSquare, OldTownSquare, NationalLibrary, dialogs.Student);
            Console.ReadKey();
        }
        public static void TechnicalUniversity()
        {
            texts.VisitLocation("ČVUT", "Zdejší student", "Pražský hrad", "Letiště", "Smíchov");
            Functions.Menu(PragueCastle, Airport, Smichov, dialogs.CVUTstudent);
            Console.ReadKey();
        }
        public static void Airport()
        {
            texts.VisitLocation("Letiště Praha", "Prodejce letenek", "Pražský hrad", "ČVUT", "Smíchov");
            Functions.Menu(PragueCastle, TechnicalUniversity, Smichov, dialogs.TicketSeller);
            Console.ReadKey();
        }
        public static void Voderadska()
        {
            texts.VisitLocation("Gymnázium Voděradská", "Profesor dějepisu", "Olšanské hřbitovy", "Hlavní nádraží", "Národní knihovna");
            Functions.Menu(Cemetery, MainTrainStation, FlorencBusStation, dialogs.Teacher);
            Console.ReadKey();
        }
        public static void Cemetery()
        {
            texts.VisitLocation("Olšanské hřbitovy", "Hrobník", "Gymnázium Voděradská", "Václavské náměstí", "Hlavní nádraží");
            Functions.Menu(Voderadska, WenceslasSquare, MainTrainStation, dialogs.Gravedigger);

            Console.ReadKey();
        }
        public static void Smichov()
        {
            texts.VisitLocation("Smíchov", "Náhodný kolemjdoucí", "Pražský hrad", "Letiště", "ČVUT");
            Functions.Menu(PragueCastle, Airport, TechnicalUniversity, dialogs.Stranger);

            Console.ReadKey();
        }
        public static void Clinic()
        {
            Console.WriteLine($"Právě jsi se probudil na jakési klinice. Na vrátnici sedí starší paní. Zaptej se jí, co se ti stalo.");
            Functions.Menu(PragueCastle, CharlesBridge, NationalLibrary, dialogs.Receptionist);

            Console.ReadKey();

        }

    }
}
