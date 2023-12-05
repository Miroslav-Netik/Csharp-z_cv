using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_01_Nerovnost
    {
        // b1) Určete, zda dvě zadaná
        // čísla x,y splňují nerovnost x+3 < 5y-1
        public static void Mainx(string[] args)
        {
            float cislo_x, cislo_y;

            Console.WriteLine("Zadej číslo x: ");
            cislo_x = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo y: ");
            cislo_y = float.Parse(Console.ReadLine());

            if (cislo_x + 3 < 5 * cislo_y - 1)
            {
                Console.WriteLine($"x + 3 je menší než 5y + 1,\n" +
                    $"{cislo_x + 3} < {cislo_y * 5 - 1}");
            }
            else
            {
                Console.WriteLine($"x + 3 je větší než 5y - 1,\n" +
                    $"{cislo_x + 3} > {cislo_y * 5 - 1}");
            }

            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
    }
}
