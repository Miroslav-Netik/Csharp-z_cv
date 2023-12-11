using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace E
{
    internal class e_12_Lokalni_maxima
    {
        /*12) Program zjistí indexy všech lokálních maxim(tedy prvků pole, které sousedí s nižšími hodnotami,
    '   čili které mají vlevo i vpravo nižší hodnotu). Např. mějme pole:
        '1 2 3 1 5 6 7 4 3 2 6 5
        'Lokální maxima jsou 3, 7, 6*/
        public static void Mainx(string[] args)
        {

            Console.WriteLine("Jsem E12\n");

            int[] pole_1 = new int[100];
            int nahodne_cislo, n, max;
            int pocet_opakovani;
            string txt_vystup, txt_maxima;

            txt_vystup = "";
            txt_maxima = "";
            n = 1;
            pocet_opakovani = 10;

            Random rnd = new Random();

            //'Naplní pole
            for (int i = 0; i < pocet_opakovani; i++)
            {
                nahodne_cislo = rnd.Next(1, 10);
                pole_1[i] = nahodne_cislo;
                txt_vystup += $"{nahodne_cislo,5}";
            }

            //'Zjistí lokální maximum a zapíše ho do txt_maxima i s indexem
            for (int i = 0; i < pocet_opakovani; i++)
            {
                //max = pole_1[n];
                if (n < pocet_opakovani - 1)
                {
                    max = pole_1[n];
                    if ((max > pole_1[n - 1]) && (max > pole_1[n + 1]))
                    {
                        txt_maxima += $"{pole_1[n]} index: {n}\n";
                    }
                }
                n++;
            }
            Console.WriteLine($"{txt_vystup}\n{txt_maxima}");

            Console.WriteLine("Zmáčkni cokoliv...\n");
            Console.ReadKey();
        }
    }
}
