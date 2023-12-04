using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_09_Zisk
    {
        //  a_9) Z  klávesnice se  zadá očekávaný a  skutečný zisk. Počítač oznámí, kolika procent bylo dosaženo.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_09.");

            float ocekavany, skutecny, vysledek;

            Console.WriteLine("Zadej výši očekávaného příjnu: ");
            ocekavany = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej výši skutečného příjmu: ");
            skutecny = float.Parse(Console.ReadLine());
            vysledek = (skutecny / ocekavany) * 100;
            Console.WriteLine($"Bylo dosaženo {vysledek}% skutečného příjmu.");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
