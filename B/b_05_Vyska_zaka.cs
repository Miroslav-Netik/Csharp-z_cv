using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_05_Vyska_zaka
    {
        // b_05)'Sestavte program, který postupně načte
        //'jméno a výšku prvního žáka, a
        //'jméno a výšku druhého žáka.
        //'Poté zobrazí jméno vyššího z nich.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_05.");

            string jmeno_1, jmeno_2;
            float vyska_1, vyska_2;

            Console.WriteLine("Zadej jméno prvního žáka: ");
            jmeno_1 = Console.ReadLine();
            Console.WriteLine("Zadej výšku prvního žáka: ");
            vyska_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej jméno druhého žáka");
            jmeno_2 = Console.ReadLine();
            Console.WriteLine("Zadej výšku druhého žáka: ");
            vyska_2 = float.Parse(Console.ReadLine());
            Console.WriteLine(vyska_1 > vyska_2 ? $"Žák {jmeno_1} je vyšší než žák {jmeno_2}." : 
                $"Žák {jmeno_2} je vyšší než žák {jmeno_1}.");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
