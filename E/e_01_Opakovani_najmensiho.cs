using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_01_Opakovani_najmensiho
    {
        /*e1) Zadejte řadu čísel ukončenou nulou. Zjistěte nejmenší a vypište, kolikrát se v řadě opakuje.
        '(návod: v druhé smyčce se najde minimum. A tentokrát bude i smyčka třetí, ve které se zjistí,
        'kolikrát se v poli toto minimum vyskytuje). Pozn.: lze řešit i dvěma smyčkami, první a druhá se spojí do jedné.
        'Tedy čísla se zadávají a hned se zjišťuje, zdali není menší, než dosavadní minimum.
           'Pozn.: šlo by to i jednou smyčkou, ale to už je náročnější. A nebylo by v tom případě nutné pole.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("jsem e_01\n");
            double[] pole_cisel = new double[100];
            double cislo_zadane, nejmensi;
            int pocet_opakovani = 0, pocitadlo = 0;
            string txt_pole = "";

            Console.WriteLine("Zadej číslo (0 pro ukončení): ");
            cislo_zadane = double.Parse(Console.ReadLine());
            nejmensi = cislo_zadane;

            while (cislo_zadane != 0)
            {
                pole_cisel[pocitadlo] = cislo_zadane;
                pocitadlo++;
                if (cislo_zadane < nejmensi)
                {
                    nejmensi = cislo_zadane;
                }
                cislo_zadane = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < pocitadlo; i++) // Čtení z pole
            {
                txt_pole += $"{pole_cisel[i]}, "; // Jen pro vypsání obsahu pole
                if (pole_cisel[i] == nejmensi)
                {
                    pocet_opakovani++;
                }
            } // Konec for i
            Console.WriteLine($"\n{txt_pole}\nNejmenší je {nejmensi} a je tam {pocet_opakovani}x.");

            Console.WriteLine("\nZmáčkni cokoliv...");
            Console.ReadKey();
        }
    }
}
