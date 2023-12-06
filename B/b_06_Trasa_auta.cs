using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_06_Trasa_auta
    {
        // b_06 -První auto ujelo trasu s1 za čas t1 a
        //'druhé trasu s2 za čas t2. (údaje zadejte).
        //'Spočítejte průměrnou rychlost obou aut a
        //'vypište zprávu "... auto je o ... rychlejší".
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_06.");

            float s_1, s_2, t_1, t_2;
            float vysledek_1, vysledek_2, rozdil_vysledku;

            Console.WriteLine("Zadej vzdálenost 1: ");
            s_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej čas 1: ");
            t_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej vzdálenost 2: ");
            s_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej čas 2: ");
            t_2 = float.Parse(Console.ReadLine());
            vysledek_1 = s_1 / t_1;
            vysledek_2 = s_2 / t_2;
            rozdil_vysledku = Math.Abs(vysledek_1 - vysledek_2);
            Console.WriteLine(vysledek_1 > vysledek_2 ? $"První auto je o {rozdil_vysledku} rychlejší." :
                $"Druhé auto je o {rozdil_vysledku} rychlejší. ");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
