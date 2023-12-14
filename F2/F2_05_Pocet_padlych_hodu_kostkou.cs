using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_05_Pocet_padlych_hodu_kostkou
    {
        /*5) Sestavte funkci PocetPadlych, která kromě předaného pole má i parametr, kolikrát se kostkou hodilo.
        'Výsledkem funkce je jednorozměrné celočíselné pole udávající, kolikrát padla ta která hodnota na kostce.
        'Funkci ověřte na zadání: sestavte program, který se zeptá na počet hodů, vygeneruje pole a pak zobrazí,
        'kolikrát každé číslo padlo. Povšimněte si, že čím více hodů, tím více se počty vyrovnají
        '(podobné e9, ale zde je to s použitím funkce) */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_05\n");



            Console.WriteLine("\nStiskni cokoliv: ");
            Console.ReadKey();
        }
        static int F_PocetPadlychF(int[] poleHodu, int hodu)
        {
            int[] pole_vnitrni = new int[poleHodu.Length];
            int hozeno;

            Random rnd = new Random();
            for (int i = 0; i < hodu; i++)
            {
                hozeno = rnd.Next(1, 7);
            }
            return 0;
        }
        /* Dim pole(5) As Integer
         Dim i As Integer, hozeno As Integer


         For i = 0 To hodu - 1
             hozeno = Int(Rnd()* 6) + 1
             pole(hozeno - 1) = pole(hozeno - 1) + 1         've VS lze i pole(x-1) += 1, nelze ale použít ++
         Next

         PocetPadlychF = pole
     End Function*/
    }
}
