using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_01_Pocet_dnu_a_hodin
    {
        //  a_1) Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek může být reálné číslo)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a-01"); //  Jen pro ověření, co je spuštěno

            int pocet_dnu;
            int pocet_hodin;
            int pocet_hodin_celkem;
            const int hodin_ve_dni = 24;

            Console.Write("Zadej počet dnů: ");
            pocet_dnu = int.Parse(Console.ReadLine());
            Console.Write("Zadej počet hodin: ");
            pocet_hodin = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pocet dnů je {pocet_dnu}\n" +
                $"Počet hodin je {pocet_hodin}");
            pocet_hodin_celkem = pocet_dnu * hodin_ve_dni + pocet_hodin;    //výpočet počtu hodin
            Console.WriteLine($"Počet hodin celkem je {pocet_hodin_celkem}");
            Console.ReadLine();
        }
    }
}
