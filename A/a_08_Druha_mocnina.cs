using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_08_Druha_mocnina
    {
        //  a_8) Zadejte číslo, počítač vypíše: Druhá mocnina čísla…  je...
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_08.");

            float zadani, vysledek;

            Console.WriteLine("Zadej číslo k umocnění: ");
            zadani = float.Parse(Console.ReadLine());
            vysledek = zadani * zadani;
            Console.WriteLine($"{zadani} na druhou je {vysledek}.");

            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
    }
}
