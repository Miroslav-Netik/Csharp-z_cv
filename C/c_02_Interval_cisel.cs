using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_02_Interval_cisel
    {
        //c_01) 'Program vygeneruje deset náhodných celých
        //'čísel (např. od -90 do 100). Zjistěte,
        //'kolik z nich je v určitém intervalu (např.
        //'od 10 do 50)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_02");

            Random rnd = new Random();
            double nahodne_cislo;
            float rozsah_max = 100.0001F, rozsah_min = -10, celkem_v_rozsahu = 0;
            int interval_max = 50, interval_min = 10;
            string txt_vystup = "";

            for (int i = 0, pocitadlo = 1; i < 10; i++, pocitadlo++)
            {
                //nahodne_cislo = rnd.Next(rozsah_min, rozsah_max);
                //nahodne_cislo = min + (max - min) * rnd.NextDouble()  // Obecný vzorec podle binga pro generování náh. desetinných čísel, podle Binga
                //nahodne_cislo = rozsah_min + (rozsah_max -  rozsah_min) * rnd.NextDouble();
                //nahodne_cislo = rnd.Next(rozsah_min, rozsah_max) + rnd.Next() + (-10);
                //vzorec podle Červenky rnd.NextDouble()*(max - min) + min - použiju tento
                nahodne_cislo = Math.Round(rnd.NextDouble() * (rozsah_max - rozsah_min) + (rozsah_min), 2);
                //nahodne_cislo = Math.Round(nahodne_cislo, 2); // to je zbytečné, zaokrouhleni výše
                if (nahodne_cislo >= interval_min && nahodne_cislo <= interval_max)
                {
                    celkem_v_rozsahu += celkem_v_rozsahu++;
                    txt_vystup += $"{pocitadlo,3}. {nahodne_cislo} -> je tam. \n";
                }
                else
                {
                    txt_vystup += $"{pocitadlo,3}. {nahodne_cislo} \n";
                }
            }
            Console.WriteLine(txt_vystup);

            Console.WriteLine("Zmáčkni Enter...");
            Console.ReadLine();
        }
    }
}
