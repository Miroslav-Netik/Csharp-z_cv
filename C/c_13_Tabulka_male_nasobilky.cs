using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_13_Tabulka_male_nasobilky
    {

        public static void Mainx(string[] args)
        {/*13) Vypište tabulku malé násobilky.Bude 10 sloupců (+záhlaví) a 10 řádků (+záhlaví). Tedy první sloupec a první řádek jsou záhlaví:
        '    1   2   3   4     5    6   7   8   9  10      toto je záhlaví
        '1   1   2   3   4     5    6   7   8   9  10
        '2   2   4   6   8   10 12 14 16 18 20
        '3   3   6   9  12  15 18 21 24 27 30
        '4   atd.
          */
            Console.WriteLine("Jsem c_13\n");

            int j, nasobky = 10;
            string prvni_mezera = " ";
            string radek = "", prvni_radek = "", tabulka = "";

            for (int i = 1; i <= nasobky; i++)
            {
                for (j = 1; j <= nasobky; j++)
                {
                    radek += $"{i * j, 4}";
                }
                if (i == 1)
                {
                    prvni_radek = $"{prvni_mezera, 5}{radek}";
                }
                radek = $"{i ,4} {radek}";
                tabulka += $"{radek} \n" ;
                radek = "";
            }
            Console.WriteLine($"{prvni_radek}\n{tabulka}");

            Console.WriteLine("\nZmáčkni cokoliv.");
            Console.ReadKey();
        }
    }
}
