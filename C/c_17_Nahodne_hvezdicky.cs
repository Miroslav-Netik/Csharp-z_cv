using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_17_Nahodne_hvezdicky
    {
        /*7) Počítač popíše 20 řádků náhodným počtem hvězdiček.(použijte vnořenou smyčku)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_17\n");

            Random rnd = new Random();
            int nahodne;
            string txt_vystup = "";

            for (int i = 1; i <= 10000; i++)
            {
                nahodne = rnd.Next(1, 100);
                for (int j = 1; j <= nahodne; j++)
                {
                    txt_vystup += "*";
                }
                txt_vystup += "\n";
            }
            Console.WriteLine(txt_vystup);

            Console.WriteLine("\nZmáčkni cokoliv");
            Console.ReadKey();
        }
    }
}
