using System;

namespace WhoIam
{
    // Třída obsahující dialogy a interakce s postavami ve hře
    internal class Dialogs
    {
        readonly Program program = new Program();

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
            dialog1 = "Shāng jiàn jù";
            dialog2 = "Vás znají po celém světě. Arigató";
            dialog3 = "Hệ thống có thể ngẫu";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void TourGuide()
        {
            dialog1 = "Nejspíše hledáte kryptu a hrobky. Ty jsou v Katedrále v podzemí.";
            dialog2 = "Zdravím. Rád vidím jednoho z bývalých obyvatel Zlaté uličky.";
            dialog3 = "Prohlídky prezidentské kanceláře jsou pouze o státních svátcích.";
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
            dialog1 = "Moc vám toho neřeknu. Ale určitě jste tu nejstarší pacient. I ten 2. nejstarší je asi 10x mladší.";
            dialog2 = "Včera jste prý spadl z velké výšky. Naštěstí se vám nic nestalo. Měl jste ale štěstí. Však vy ale víte...";
            dialog3 = "Nevím odkud vás přivezli. Furt jste ale opakoval Šemíku běž pryč. Tak jsme vám dali léky.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void HamSeller()
        {
            dialog1 = "Ať vám chutná. Toto je na účet podniku. Počítám, že budete jíst rukama. Jako za starých časů.";
            dialog2 = "Vám bych vepřovou šunku nedoporučoval. To vaše vegetariánství a k tomu ještě ta náboženská dieta...";
            dialog3 = "Přišel jste na šunku pane? To mi na vás nesedí. Myslel jsem, že jste spíše na nóbl jídlo.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void DrugDealer()
        {
            dialog1 = "*Utekl*";
            dialog2 = "Ty vaše knihy čoveče! To musel bejt materiál...";
            dialog3 = "To je hroznej kostým, fízle.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void BusPassenger()
        {
            dialog1 = "Nečekal bych, že zrovna vás potkám zde. Myslel jsem, že máte panského kočího.";
            dialog2 = "Hlavně v autobuse nedělejte ty vaše proměny. Ať nemusím zastavovat kvůli deratizaci.\n*Další, který mluví o broucích.*";
            dialog3 = "Právě jedu na Moravu. Vy jste z Moravy, co?";
            ShowDialog(dialog1, dialog2, dialog3);

        }
        public void Passanger()
        {
            dialog1 = "To by mne jako seniora 65+ zajímalo, kolik platíte vy jako 650+?";
            dialog2 = "*Pospíchá*";
            dialog3 = "Železniční síť se nám od vaší vlády moc nerozrostla. Ani ty rychlosti moc vyšší nejsou.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Student()
        {
            dialog1 = "*Už pátý, kdo se s tebou chce vyfotit. Jsi tu asi oblíbený.*";
            dialog2 = "Na entomologii jsme vaše dílo studovali, ale těch nepřesností...";
            dialog3 = "Po vás mají univerzitu pojmenovanou jinde.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void CVUTstudent()
        {
            dialog1 = "Tady vám moc neporadíme. Radši se běžte zeptat na Karlovu univerzitu.";
            dialog2 = "Některá vaše díla pro mne byla složitější, než místní fyzika.";
            dialog3 = "*Spěchá na přednášku*";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void TicketSeller()
        {
            dialog1 = "Lety do Lucemburska bohužel nezprostředkováváme.";
            dialog2 = "Pro vás bude lepší roztáhnout krovky a doletět si tam.";
            dialog3 = "O vás vím, že raději jezdíte na koni.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Teacher()
        {
            dialog1 = "Zdravím, vítězi ankety Největší Čech. Zajímavé, že ji mohl vyhrát i Němec...";
            dialog2 = "Raději si promluvte s učiteli češtiny a němčiny.";
            dialog3 = "Významný filozof a politik. Přesně takové kolegy právě sháníme!";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Gravedigger()
        {
            dialog1 = "*Lekl se tě a utekl* ";
            dialog2 = "Židovský hřbitov je v ulici Želivského.";
            dialog3 = "Hřbitov v Lánech má ve správě můj kolega Vondrášek.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
        public void Stranger()
        {
            dialog1 = "*Nemá na tebe čas, jede s dětmi na Karlštejn*";
            dialog2 = "Támhle prodávají skvělá jablka. Ale já vím, že vy s nimi nemáte moc dobré zkušenosti.";
            dialog3 = "Dneska ti politici. To je strašný! Už aby to tu zase bylo jako za vás.";
            ShowDialog(dialog1, dialog2, dialog3);
        }
    }
}
