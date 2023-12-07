using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_13_Chcete_skoncit
    {
        //b_13)'Počítač se zeptá: "Chcete skončit? (A/N)"
        //'Při stisku A program skončí, při stisku čehokoliv
        //'jiného se vypíše "A stejně
        //'skončím!" a program skončí.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_13");

            char dotaz;

            Console.WriteLine("Chceš skončit? (A/N): ");
            dotaz = Console.ReadLine()[0];
            dotaz = char.ToUpper(dotaz);

            if (dotaz != 'A')
            {
                Console.WriteLine("Stejně skončím :-)");
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
