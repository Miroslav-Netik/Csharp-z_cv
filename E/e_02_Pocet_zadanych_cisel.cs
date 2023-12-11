using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_02_Pocet_zadanych_cisel
    {
        /*2e) Zadejte několik čísel, ukončete nulou. Potom zadáte některé z předtím zadaných čísel.
        'Program vypíše, kolikrát toto číslo předtím padlo. */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_02.\n");

            int[] pole_cisel = new int[100];
            int zadane_cislo_pole, zadany_dotaz;
            int pocitadlo = 0, pocitaadlo_vyskytu = 0;
            string txt_pole = "";

            Console.WriteLine("Zadej čísla do pole:");
            zadane_cislo_pole = int.Parse(Console.ReadLine());

            while (zadane_cislo_pole != 0)  // Naplní pole
            {
                pole_cisel[pocitadlo] = zadane_cislo_pole;
                txt_pole += $"{pole_cisel[pocitadlo]}, ";   // Slouží jen k následnému výpisu obsahu pole
                pocitadlo++;
                zadane_cislo_pole = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Zadej hledané číslo: ");
            zadany_dotaz = int.Parse(Console.ReadLine());

            for (int i = 0; i < pocitadlo; i++) // Spočítá výskyt hledaného čísla
            {
                if (zadany_dotaz == pole_cisel[i])
                {
                    pocitaadlo_vyskytu++;
                }
            } // Konec for i

            Console.WriteLine($"{txt_pole}\nČíslo {zadany_dotaz} je tam {pocitaadlo_vyskytu}x.");

            Console.WriteLine("\nZmáčkni cokoliv.");
            Console.ReadKey();
        }
    }
}
