using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Zanamenko
    {
        public static void Mainx(string[] args)
        {
            int i, znamenko;
            Console.WriteLine("Zadej číslo: ");
            i = int.Parse(Console.ReadLine());

            znamenko = 0;
            if (i < 0)
                znamenko = -1;
            if (i == 0)
                znamenko = 0;
            if (i > 0)
                znamenko = 1;
            Console.WriteLine("Znaménko čísla je {0} (-1: zap., 0:nula, 1:klad)", znamenko);
            {

            }
        }
    }
}
