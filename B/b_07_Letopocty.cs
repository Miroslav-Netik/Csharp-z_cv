using System;

namespace B
{
    internal class b_07_Letopocty
    {
        //b_07-'Uživatel zadá letopočet (od roku 1600).
        //'Program vrátí název státního útvaru, ve kterém
        //'jsme se tehdy nacházeli (Rakousko, Rakousko-Uhersko,
        //'Československá republika, Protektorát Böhmen und Mähren
        //'atd.). Řešte pomocí else if.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_07.");

            double zadane_datum;
            string obdobi_1 = "Rakousko-Uhersko";
            string obdobi_2 = "Československá republika";
            string obdobi_3 = "Protektorát";
            string obdobi_4 = "ČSSR";
            string obdobi_5 = "ČSFR";
            string obdobi_6 = "ČR";

            Console.WriteLine("Zadej letopočet od 1600 včetně: ");
            zadane_datum = double.Parse(Console.ReadLine());
            if (zadane_datum >= 1600)
            {
                if (zadane_datum < 1918)
                {
                    Console.WriteLine(obdobi_1);
                }
                else if (zadane_datum >= 1918 && zadane_datum < 1939)
                {
                    Console.WriteLine(obdobi_2);
                }
                else if (zadane_datum >= 1939 && zadane_datum < 1946)
                {
                    Console.WriteLine(obdobi_3);
                }
                else if (zadane_datum >= 1946 && zadane_datum < 1990)
                {
                    Console.WriteLine(obdobi_4);
                }
                else if (zadane_datum >= 1990 && zadane_datum < 1994)
                {
                    Console.WriteLine(obdobi_5);
                }
                else
                {
                    Console.WriteLine(obdobi_6);
                }
            }
            else
                Console.WriteLine("Zadání mimo rozsah.");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
