using System;

namespace WhoIam
{
    // Třída obsahující dialogy a interakce s postavami ve hře
    internal class Dialogs
    {
        // Instance programu pro získání vybrané postavy
        Program program = new Program();

        // Texty dialogů pro jednotlivé postavy
        private string dialog1 = ""; // Karel IV
        private string dialog2 = ""; // Kafka
        private string dialog3 = ""; // Masaryk

        // Metoda pro zobrazení dialogu podle vybrané postavy
        public void ShowDialog(string dialog1, string dialog2, string dialog3)
        {
            int Character = Program.SelectCharacter();
            switch (Character)
            {
                case 1:
                    Functions.Warning(dialog1);
                    break;
                case 2:
                    Functions.Warning(dialog2);
                    break;
                case 3:
                    Functions.Warning(dialog3);
                    break;
                default:
                    break;
            }
        }

        // Metoda pro získání jména postavy
        public void GetNpc(Action NpcName)
        {
            NpcName();
        }

        // Metody pro jednotlivé postavy s jejich dialogy
        public void AsianTourist()
        {
            dialog1 = "商件拒";
            dialog2 = "Vás znají po celém světě. 유니코드로";
            dialog3 = "Hệ thống có thể ngẫu";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void TourGuide()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Librarian()
        {
            dialog1 = "Nemohu sloužit, takto staré knihy jsou uzamčené v depozitáři.";
            dialog2 = "Literatura v cizích jazycích je vzadu!";
            dialog3 = "Rukopisy máme ve druhém patře. Tam je můžete kritizovat.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Receptionist()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void HamSeller()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void DrugDealer()
        {
            dialog1 = "";
            dialog2 = "Ty vaše knihy čoveče! To musel bejt materiál...";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void BusPassenger()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);

        }
        public void Passanger()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Student()
        {
            dialog1 = "";
            dialog2 = "Na entomologii jsme vaše dílo studovali, ale těch nepřesností...";
            dialog3 = ""; 
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void CVUTstudent()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void TicketSeller()
        {
            dialog1 = "Lety do Lucemburska bohužel nezprostředkováváme.";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Teacher()
        {
            dialog1 = "";
            dialog2 = "Raději si promluvte s učiteli češtiny a němčiny.";
            dialog3 = "Škoda, že tomu období, kdy jste žil se už v naší škole moc nevěnujeme.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Gravedigger()
        {
            dialog1 = "";
            dialog2 = "Židovský hřbitov je v ulici Želivského.";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Stranger()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
            ShowDialog(dialog1, dialog2, dialog3);
        }
    }
}
