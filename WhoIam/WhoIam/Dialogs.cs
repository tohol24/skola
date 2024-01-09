using System;

namespace WhoIam
{
    internal class Dialogs
    {
        int charNumber = 0;
        String dialog1 = (""); //KarelIV
        String dialog2 = (""); //Kafka
        String dialog3 = (""); //Masaryk
        public void ShowDialog(string dialog1, string dialog2, string dialog3)
        {
            switch (charNumber)
            {
                case 1:
                    Console.WriteLine(dialog1);
                    break;
                case 2:
                    Console.WriteLine(dialog2);
                    break;
                case 3:
                    Console.WriteLine(dialog3);               
                    break;

                default:
                    break;
            }
        }
        public void AsianTourist()
        {
             dialog1 = ("商件拒");
             dialog2 = ("");
             dialog3 = ("Hệ thống có thể ngẫu");
        }
        public void TourGuide()
        {
             dialog1 = ("");
             dialog2 = ("");
             dialog3 = ("");
        }
        public void Librarian()
        {
             dialog1 = ("");
             dialog2 = ("");
             dialog3 = ("");
        }
        public void Receptionist()
        {
            dialog1 = "";
            dialog2 = "";
            dialog3 = "";
        }

    }
}
