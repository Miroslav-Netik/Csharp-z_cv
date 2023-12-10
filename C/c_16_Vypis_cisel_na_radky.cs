using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C
{
    internal class c_16_Vypis_cisel_na_radky
    {
        /* 16) Vypište 10 řádků. Na prvním řádku číslo 1, na druhém řádku 12, na třetím 123 atd. (použijte vnořenou smyčku)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_16\n");

            string txt_vystup = "";

            for (int i = 1; i <= 10; i++) {
                for (int j = 1; j <= i ; j++)
                {
                    txt_vystup += $"{j}";
                }
                txt_vystup += "\n";
            }
            Console.WriteLine(txt_vystup);

            Console.WriteLine("\nZmáčkni cokoliv");
            Console.ReadKey();
        }
    }
}
