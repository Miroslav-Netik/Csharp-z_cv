using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F2_04_Pocet_Vyskytu
    {
        /*F2 - 4) Sestavte funkci PocetVyskytu, která má dva parametry: Prvním je jednorozměrné pole čísel A, druhým
    'je číslo C.
    'Výsledkem funkce je celé číslo udávající, kolikrát se číslo C vyskytuje v poli A. Funkci ověřte
    'na zadání:
    'sestavte program, který postupně načte pole A a hodnotu C, a poté zobrazí počet výskytů
    'hodnoty C v poli A. */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2 - 04\n");

            int[] pole_hodnot = new int[100];
            int hledeane_cislo, pocet_opakovani;
            int max, min;
            string txt_vystup,txt_vystup_2 ,txt_generovana_cisla;
            int vyskyty = 0;
            max = 1000;
            min = 1;
            pocet_opakovani = 100;
            txt_generovana_cisla = "";

            Random rnd = new Random();
            // Console.WriteLine("Zadej hledané číslo: ");
            // hledeane_cislo = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocet_opakovani; i++)
            {
                pole_hodnot[i] = rnd.Next(min, max);
                txt_generovana_cisla += pole_hodnot[i] + ", ";
            }
            Console.WriteLine("Generovaná čísla jsou: " + txt_generovana_cisla);
            Console.Write("Zadej hledané číslo: ");
            hledeane_cislo = int.Parse(Console.ReadLine()); // Přemístěno za výpis gen. čísel

            // Výpis počtu hledaného čísla funkcí
            txt_vystup = $"Počet výskytů čísla {hledeane_cislo} je {F_PocetVyskytu(pole_hodnot, hledeane_cislo)}";
            Console.WriteLine(txt_vystup);

            // Výpis počtu hledaných čísel Subrutinou
            S_PocetVyskytu(pole_hodnot, hledeane_cislo, ref vyskyty);
            txt_vystup_2 = $"Počet výskytů čísla {hledeane_cislo} je {vyskyty}";
            Console.WriteLine(txt_vystup_2);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int F_PocetVyskytu(int[] A, int C)
        {
            // Funkce - Zjistí počet výskytu čísla C v zadaném poli A
            int pocitadlo = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == C)
                {
                    pocitadlo++;
                }
            }
            return pocitadlo;
        }
        static void S_PocetVyskytu(int[] A, int C, ref int pocet)
        {
            // Subrutina - Zjistí počet výskytu čísla C v zadaném poli A
            int pocitadlo = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == C)
                {
                    pocitadlo++;
                }
            }
            pocet = pocitadlo;
        }
    }
}
