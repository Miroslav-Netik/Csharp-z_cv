using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_06_Suda_cisla_z_pole
    {
        /* F2 - 6) Sestavte funkci SudaCislaZpole, která má jediný parametr: pole celých čísel. 
        Výsledkem funkce je jednorozměrné celočíselné pole,
        ve kterém jsou jen sudá čísla obsažená v poli parametru. Funkci ověřte na zadání: sestavte program,
        který načte pole celých čísel
    '   ukončených nulou, která už k číslům nepatří, a pak zobrazí všechna ze zadaných čísel, která jsou sudá. */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem f2_06\n");

            int[] pole_cisel = new int[100];
            int[] pole_sudych = new int[100];
            int[] s_pole_sudych = new int[100];
            int vstup_cislo;
            int pocitadlo = 0;
            string txt_vystup = "", txt_vystup_suda = "";

            // Naplníme pole ručně...
            Console.WriteLine("Zadej čísla (0 pro ukončení): ");
            vstup_cislo = int.Parse(Console.ReadLine());

            while (vstup_cislo != 0)
            {
                pole_cisel[pocitadlo] = vstup_cislo;
                txt_vystup += pole_cisel[pocitadlo] + ", ";
                pocitadlo++;
                vstup_cislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(txt_vystup);

            // Najdeme sudé pomoci FUNKCE
            pole_sudych = F_SudaCislaZpole(pole_cisel);
            for (int i = 0; i < pocitadlo; i++)
            {
                if (pole_sudych[i] != 0) //Protože projde pole "počítadlo krát", a vypisoval by nuly místo lichých...
                {
                    txt_vystup_suda += pole_sudych[i] + ", ";
                }
            }
            txt_vystup_suda += "\n";

            // Najdeme sudé pomocí SUBRUTINY
            S_SudaCislaZpole(pole_cisel, ref s_pole_sudych);
            for (int i = 0; i < pocitadlo; i++)
            {
                if (pole_sudych[i] != 0) //Protože projde pole počítadlo krát, a vypisoval by nuly místo lichých...
                {
                    txt_vystup_suda += s_pole_sudych[i] + ", ";
                }
            }
            Console.WriteLine(txt_vystup_suda);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int[] F_SudaCislaZpole(int[] pole_vstupni)
        {
            //'Ze zadaného pole celých čísel vybere jen sudá
            int[] pole_sudych = new int[pole_vstupni.Length];
            int pocitadlo = 0;

            for (int i = 0; i < pole_vstupni.Length; i++)
            {
                if (pole_vstupni[i] % 2 == 0)
                {
                    pole_sudych[pocitadlo] = pole_vstupni[i];
                    pocitadlo++;
                }
            }
            return pole_sudych;

        }
        static void S_SudaCislaZpole(int[] pole_vstupni, ref int[] pole_vystupni)
        {
            //'Ze zadaného pole celých čísel vybere jen sudá
            int[] pole_sudych = new int[pole_vstupni.Length];
            int pocitadlo = 0;

            for (int i = 0; i < pole_vstupni.Length; i++)
            {
                if (pole_vstupni[i] % 2 == 0)
                {
                    pole_sudych[pocitadlo] = pole_vstupni[i];
                    pocitadlo++;
                }
            }
            pole_vystupni = pole_sudych;
        }
    }
}
