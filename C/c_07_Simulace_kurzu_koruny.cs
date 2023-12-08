using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_07_Simulace_kurzu_koruny
    {
        //c 07): použití modulo. Nasimulujte minutu po minutě kurz koruny
        //'k euru prvních dvacet minut po opuštění
        //'kurzového závazku ČNB. Bude oscilovat
        //'mezi 26 (včetně) a 28 (ne včetně) Kč/Euro.
        //'V MsgBoxu je vypište (pomocí Mod) tak,
        //'že budou vždy po pěti na
        //'řádku (oddělené tabulátorem či čárkou nebo mezerou).
        //'Vypište s dvěma desetinnými čísly.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_07");

            float kurz_min = 26;
            double kurz_max = 28;
            double nahodne;
            string txt_vystup = "";

            Random rnd = new Random();
            for (int i = 1; i <= 20; i++)
            {
                //.ToString("F2") -> vynutí vypsání čísla se dvěma desetinnými místy.
                nahodne = Math.Round(rnd.NextDouble() * (kurz_max - kurz_min) + kurz_min, 2);
                txt_vystup += $"{nahodne.ToString("F"), 5}    ";
                if (i > 1 && i % 5 == 0)
                {
                    txt_vystup += "\n";
                }
            }
            Console.WriteLine(txt_vystup);

            Console.WriteLine("Zmáčkni cokoliv.");
            Console.ReadKey();
        }
    }
}
