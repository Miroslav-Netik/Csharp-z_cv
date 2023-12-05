using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_03_Zadej_teplotu
    {
        //  a_3) Zadejte teplotu v 6,12 a 18 hodin. Vytiskne se průměrná denní teplota.

        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_03.");

            float teplota_v_6;
            float teplota_v_12;
            float teplota_v_18;
            float prumerna_teplota;

            Console.WriteLine("Zadej teplotu v 6 hodin: ");
            teplota_v_6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej teplotu ve 12 hodin: ");
            teplota_v_12 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej teplotu v 18 hodi");
            teplota_v_18 = float.Parse(Console.ReadLine());

            prumerna_teplota = (teplota_v_12 + teplota_v_6 + teplota_v_18) / 3;

            Console.WriteLine($"Průměrná teplota je {prumerna_teplota}.");

            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }

    }
}
