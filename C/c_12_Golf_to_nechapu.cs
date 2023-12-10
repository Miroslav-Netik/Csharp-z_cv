using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_12_Golf_to_nechapu
    {
        /*c12) Sestavte program, který za vás zahraje poslední úder do golfového míčku. Stojíte 3 metry od jamky o průměru 10cm 
         * (tedy vzdálenost 2,95 až 3,05) a na ty 3 metry má vaše chvějící se ruka rozptyl ± 1m (tedy náhodná reálná čísla 2 až 4).
        'Kolikrát ze 100 úderů se strefíte? A na kolikátý pokus jste se poprvé strefili? (program Doc. Homoly)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_12\n");

            double uder;
            int trefa = 0;
            string vypis = "";
            int poradi_prvni_trefy = 0;

            Random rnd = new Random();
            for (int i = 1; i < 100; i++)
            {
                uder = rnd.NextDouble() * (4 - 2) + 2;
                if (i % 10 == 0)
                    vypis += $"{Math.Round(uder, 2)} \n";
                else
                    vypis += $"{Math.Round(uder, 2)} |";
                if (uder >= 2.95 && uder <= 3.05)
                {
                    if (uder >= 2.95 && uder <= 3.05)
                        trefa++;
                    if (poradi_prvni_trefy == 0)
                        poradi_prvni_trefy = i;
                }
            }
            Console.WriteLine($"{vypis}\nZe 100 pokusů jsi se trefil {trefa}x. Pořadí první trefy je {poradi_prvni_trefy}");
        
        Console.WriteLine("\nZmáčkni cokoliv.");
        Console.ReadKey();

        }
}
}
