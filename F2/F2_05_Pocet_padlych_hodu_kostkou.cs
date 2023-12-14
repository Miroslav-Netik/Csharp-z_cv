using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_05_Pocet_padlych_hodu_kostkou
    {
        /*5) Sestavte funkci PocetPadlych, která kromě předaného pole má i parametr, kolikrát se kostkou hodilo.
        'Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.
        'Funkci ověřte na zadání: sestavte program, který se zeptá na počet hodů, vygeneruje pole a pak zobrazí,
        'kolikrát každé číslo padlo. Povšimněte si, že čím více hodů, tím více se počty vyrovnají
        '(podobné e9, ale zde je to s použitím funkce) */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_05\n");

            int pocet_hodu;
            string s = "";
            int[] pole = new int[1000];
            int[] vyskyt = new int[1000];
            int[] pole_vyskytu = new int[1000];

            Console.Write("Zadej počet hodů: ");
            pocet_hodu = int.Parse(Console.ReadLine());

            //Naplní pole hodnotami náhodných hodů
            Random rnd = new Random();
            for (int i = 0; i < pocet_hodu; i++)
            {
                pole[i] = rnd.Next(1, 7);
                s += pole[i] + ", ";
            }
            s += "\n";
            s += "Funkce:    \n";

            // Vypíše počty jednotlivých hození FUKNCÍ
            vyskyt = F_PocetPadlychF(pole, pocet_hodu);
            for (int i = 1; i <= 6; i++)
            {
                s += $"{i} padlo {vyskyt[i]}x.\n";
            }
            s += "Subrutina:  \n";

            // Vypíše počty jednotlivých hození SUBRUTINOU
            S_PocetPadlych(pole, pocet_hodu, ref pole_vyskytu);
            for (int i = 1; i <= 6; i++)
            {
                s += $"{i} padlo {pole_vyskytu[i]}x.\n";
            }
            Console.WriteLine(s);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int[] F_PocetPadlychF(int[] poleHodu, int hodu)
        {
            int[] pole_vyskytu = new int[poleHodu.Length];
                // Spočítá jednotlivá hozená čísla tím, že na indexy nového pole, 
                // odpovídající hodnotám hodů, uložených ve starém poli,
                // přičte jedničku... :-) Jak prosté... Ale příjít na to!
                for (int i = 0; i < hodu; i++)
                {
                    pole_vyskytu[poleHodu[i]]++; // Na index číslo pole[i], vložím jedničku,
                                       // tím napočítám počet jednotlivých čísel
                }
            return pole_vyskytu;
        }
        static void S_PocetPadlych(int[] poleHodu, int hodu, ref int[] pole_poctu)
        {
            int[] pole_vyskytu = new int[poleHodu.Length];
            // Spočítá jednotlivá hozená čísla tím, že na indexy nového pole, 
            // odpovídající hodnotám hodů, uložených ve starém poli,
            // přičte jedničku... :-) Jak prosté... Ale příjít na to!
            for (int i = 0; i < hodu; i++)
            {
                pole_vyskytu[poleHodu[i]]++; // Na index číslo pole[i], vložím jedničku,
                                             // tím napočítám počet jednotlivých čísel
            }
            pole_poctu = pole_vyskytu;
        }
        
    }
}
