using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_12_tezsi_objem_valce
    {
        //  a_12) Sestavte program, který se zeptá na průměr vašeho kruhového bazénu a poté na jeho výšku (obojí v metrech).
        //  Poté zobrazí, kolik tun vody se do něj vejde (1 m3 vody = 1 tuna). (program Doc. Homoly)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_12");

            float zadany_prumer, zadana_vyska;
            float hmotnost, polomer;

            Console.WriteLine("Jaký má tvůj kruhový bazén průměr?: ");
            zadany_prumer = float.Parse(Console.ReadLine());
            Console.WriteLine("Jakou má výšku?: ");
            zadana_vyska = float.Parse((Console.ReadLine()));
            hmotnost = (float)(Math.PI * ((zadany_prumer / 2) * (zadany_prumer / 2)) + zadana_vyska);
            Console.WriteLine($"Do bazénu se vejde {hmotnost} tun vody.");
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
