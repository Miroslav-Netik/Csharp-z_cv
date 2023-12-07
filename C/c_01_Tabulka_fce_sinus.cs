using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_01_Tabulka_fce_sinus
    {
        //c-01)'Vypište tabulku x funkce sinus(x)
        //'pro x od 0 do 2*PI s krokem 0,1.
        //'Výpis bude vypadat např. takto:
        //'Sin(0, 0) = 0
        //'sin(0,1) = 0,0998 atd.
        //'Nevadí, když místo 0,0998 bude ,0998
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_01");

            string vystup = "";
            double i, vysledek;

            for (i = 0; i < 2 * Math.PI * 10; i++)
            {
                vysledek = Math.Round(Math.Sin(i / 10), 4);
                vystup = vystup + $"{i / 10} = {vysledek}\n";
            }

            Console.WriteLine(vystup);
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
