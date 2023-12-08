using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_03_Sportka_jednodussi
    {
        //c_03)'Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49).
        //'Čísla se (na rozdíl od Sportky) mohou opakovat.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_03");

            int rozsah_max = 50, rozsah_min = 1;
            string txt_vystup = "";

            Random rnd = new Random();
            for (int i = 0; i <= 400; i++)
            {
                txt_vystup += $"{rnd.Next(rozsah_min, rozsah_max)}, ";
            }
            Console.WriteLine(txt_vystup);

            Console.WriteLine("Stiskni cokoliv");
            Console.ReadKey();
        }
    }
}
