using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_09_Porovnani_dvou_cisel
    {
        //b 09)'Zadejte dvě čísla, počítač napíše
        //'"První číslo je větší (nebo menší)" (příliš lehké)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_09");

            float cislo_1, cislo_2;
            Console.WriteLine("Zadej číslo 1: ");
            cislo_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo 2: ");
            cislo_2 = float.Parse(Console.ReadLine());

            if (cislo_1 > cislo_2)
            { Console.WriteLine("První číslo je větší..."); }
            else if (cislo_1 < cislo_2)
            { Console.WriteLine("Druhé číslo je větší..."); }
            else
            { Console.WriteLine("Čísla jsou stejná."); }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
