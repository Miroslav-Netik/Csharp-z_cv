using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_11_Matrix_prehozeni
    {
        /*e11) Program Doc. Homoly: Dvojrozměrné pole: Naplňte zadáním pole 4x4. Poté ji zobrazí překlopenou kolem hlavní diagonály
        '(tedy prohodí indexy řádků a sloupců). Takže například místo pole:
        '1  2  3  4 
        '5  6  7  8 
        '9 10 11 12
        '13 14 15 16 
        '   bude pole
        '1  5  9  13
        '2  6  10 14
        '3  7  11 15
        '4  8  12 16*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_11\n");

            int[,] pole_1 = new int[4, 4];
            int pocitadlo;
            string txt_vystup, txt_prohozene;
            pocitadlo = 1;
            txt_vystup = "";
            txt_prohozene = "";

            //'Naplní pole
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pole_1[i, j] = pocitadlo;
                    pocitadlo++;
                    txt_vystup += $"{pole_1[i, j],3}";
                }
                txt_vystup += $"\n";
            }
            //'Prohození indexů
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    txt_prohozene += $"{pole_1[j, i],3}";
                }
                txt_prohozene += $"\n";
            }
            //  Výpis hodnot
            Console.WriteLine($"{txt_vystup}\n{txt_prohozene}");

            Console.WriteLine("Zmáčkni cokoliv...\n");
            Console.ReadKey();
        }
    }
}
