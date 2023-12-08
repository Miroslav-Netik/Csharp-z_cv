using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_06_Jako_d1
    {
        //'c 06)Zadejte, kolik je tříd ve škole. Potom postupně zadávejte,
        //'kolik je v každé třídě žáků. Program spočítá, kolik je žáků v celé
        //'škole a průměrný počet žáků ve třídě. (obdoba d1)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_06");

            int pocet_trid, zaku_ve_tride;
            int zaku_celkem = 0;
            float zaku_prumer;
            string txt_vystup = "";

            Console.WriteLine("Zadej počet tříd: ");
            pocet_trid = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pocet_trid; i++)
            {
                Console.WriteLine($"Zadej počet žáků v {i}. třídě: ");
                zaku_ve_tride = int.Parse(Console.ReadLine());
                zaku_celkem += zaku_ve_tride;
                txt_vystup += $"{i}. třída má {zaku_ve_tride} žáků.\n";
            }
            zaku_prumer = (float)zaku_celkem / pocet_trid;
            Console.WriteLine(txt_vystup + $"\nCelkem {zaku_celkem} žáků.\n" + $"Průměrně je {zaku_prumer} žáků na třídu.");

            Console.WriteLine("Zmáčkni cokoliv...");
            Console.ReadKey();
        }
    }
}
