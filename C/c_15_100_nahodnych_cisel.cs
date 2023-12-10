using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_15_100_nahodnych_cisel
    {
        /*'15) Vygenerujte 100 náhodných celých čísel od 1 do 5. Zjistěte,
        'zda jsou někdy dvě stejná vedle sebe, která to jsou a jaké je jejich pořadové číslo
         */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_15\n");

            int generovane_cislo, i = 0;
            int prvni_porovnavane = 0, druhe_porovnavane = 0;
            string txt_vystup = "", txt_vystup_generovanych = "";

            Random rnd = new Random();
            for (i = 1; i <= 10; i++)
            {
                generovane_cislo = (int)rnd.Next(1, 6);
                prvni_porovnavane = generovane_cislo;
                if (prvni_porovnavane == druhe_porovnavane)
                {
                    txt_vystup += $"{generovane_cislo} jsou vedle sebe na pozicích {i - 1} a {i}\n";
                }
                else
                {
                    druhe_porovnavane = prvni_porovnavane;
                }
                txt_vystup_generovanych += $"{generovane_cislo} / ";
            }
            Console.WriteLine($"{i}");
            Console.WriteLine($"{txt_vystup_generovanych}\n{txt_vystup}");

            Console.WriteLine("\nZmáčkni cokoliv...");
            Console.ReadKey();
        }
    }
}
