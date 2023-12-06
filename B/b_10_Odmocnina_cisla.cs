using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_10_Odmocnina_cisla
    {
        // b_10 - 'Zadejte číslo. Počítač vypíše:
        //'!Odmocnina čísla ... je ..." nebo oznámí,
        //'že odmocninu záporného čísla počítat nebude.
        //'odmocnenec je dole, odmocnitel je nahoře
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b10");

            double zaklad;

            Console.WriteLine("Zadej číslo pro odmocnění: ");
            zaklad = double.Parse(Console.ReadLine());
            Console.WriteLine((zaklad > 0) ? $"{Math.Sqrt(zaklad)}" : $"Odmocninu z {zaklad} prostě nebudu počítat!");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
