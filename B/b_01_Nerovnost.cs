using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_01_Nerovnost
    {
        public static void Mainx(string[] args)
        {
            //b_01) Určete, zda dvě zadaná
            //čísla x,y splňují nerovnost x+3 < 5y-1
            Console.WriteLine("Jsem b_01.");

            float cislo_x, cislo_y;
            Console.WriteLine("Zadej číslo x: ");
            cislo_x = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo y: ");
            cislo_y = float.Parse(Console.ReadLine());


            Console.WriteLine("Press Enter... ");
            Console.ReadLine();
        }
    }
}
