using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_14_Hvezdicky
    {
        /*'14) Vytisknete na prvním řádku jednu hvězdu, na druhém dvě až do desátého.
        'Potom se začnou hvězdy ubírat.
        'Varianta: Totéž, ale na prvním řádku se vytisknou dvě hvězdy, na druhém
        'čtyři atd.
        'Varianta 2: Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
        'třetím a čtvrtém dvě hvězdy atd.
         */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_14\n");

            string hvezda = "*", hvezdy = "", txt_vystup = "";

            for (int i = 1; i <= 10; i++)
            {
                hvezdy += hvezda;
                txt_vystup += $"{hvezdy}\n";
            }
            Console.WriteLine(txt_vystup);
            Console.WriteLine("");

            //Druhá verze
            //prvním řádku se vytisknou dvě hvězdy, na druhém
            //'čtyři atd.
            hvezdy = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        hvezdy += hvezda;
                    } // end for j
                } // end for k
                hvezdy += $"\n";
            } // end for i
            Console.WriteLine(hvezdy);
            Console.WriteLine("");

            //Třetí verze
            //Totéž, ale na prvnim i druhem řádku se vytiskne hvězda, na
            //'třetím a čtvrtém dvě hvězdy atd.
            hvezdy = "";
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        hvezdy += hvezda;
                    }
                    hvezdy += $"\n";
                }
            }
            Console.WriteLine(hvezdy);
            Console.WriteLine("\nZmáčkni cokoliv...");
            Console.ReadKey();
        }
    }
}
