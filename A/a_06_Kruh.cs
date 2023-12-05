using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_06_Kruh
    {
        //  a_6) Zadejte poloměr kruhu. Vypočítejte obvod (o=2r) a plochu (P=r2).
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_06.");

            float polomer, obvod, plocha;

            Console.WriteLine("Zadej poloměr kruhu: ");
            polomer = float.Parse(Console.ReadLine());
            obvod = (float)(2 * Math.PI * polomer);
            plocha = (float)(Math.PI * (polomer * polomer));
            Console.WriteLine($"Obvod kruhu je {obvod}\n" +
                $"Plocha kruhu je {plocha}");

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
}
