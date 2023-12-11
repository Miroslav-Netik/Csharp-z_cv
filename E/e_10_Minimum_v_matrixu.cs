using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_10_Minimum_v_matrixu
    {
        /*e_10) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním po řádcích pole 4x4.
        'Potom zjistěte minimum a zobrazte řádkové a sloupcové indexy buněk, na kterých se minimum nachází */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_10\n");

            long[,] pole_cisle = new long[4, 4];
            int nahodne, min;
            int rozsah_min = 1, rozsah_max = 10;
            string txt_vypis = "", txt_souradnice_minima = "";

            min = rozsah_max;
            Random rnd = new Random();
            // Naplní pole čísly od jedné do deseti
            for (int i = 0, j = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    nahodne = rnd.Next(rozsah_min, rozsah_max);
                    pole_cisle[i, j] = nahodne;
                    txt_vypis += $"{nahodne,3}"; // Naplní výpis jednoho řádku
                } // Konec for j
                txt_vypis += "\n"; // Posun výpisu na další řádek
            } // Konec for i

            // Najde minimum
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pole_cisle[i, j] < min)
                    {
                        min = (int)pole_cisle[i, j];
                    }
                }
            }

            // Najde index minima
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (pole_cisle[i, j] == min)
                    {
                        txt_souradnice_minima += $"{i} , {j}\n";
                    }
                }
            }
            Console.WriteLine($"{txt_vypis}\nMinimum je: {min}\nIndexy minima jsou: \n{txt_souradnice_minima}");

            Console.WriteLine("\nZmáčkni cokoliv...");
            Console.ReadKey();
        }
    }
}
