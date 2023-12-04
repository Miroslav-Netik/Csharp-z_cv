using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_11_Bezecka_trat
    {
        //  a_11) Sestavte program, který se zeptá na délku běžecké trati v metrech a poté na čas běžce na
        //  této trati ve vteřinách. Poté zobrazí, jakou průměrnou rychlostí v [km/hod] běžec běžel. (program Doc. Homoly)¨
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_11.");

            const float konstanta = (float)3.6;
            float trat, cas, vysledek;
            Console.WriteLine("Zadej délku trati v metrech: ");
            trat = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej dobu běhu v sekundách: ");
            cas = float.Parse(Console.ReadLine());
            vysledek = (trat / cas) * konstanta;
            Console.WriteLine($"Průměrná rychlost běžce v je {vysledek} km/h.");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
