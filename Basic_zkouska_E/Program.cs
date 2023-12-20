using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Basic_zkouska_E
{
    internal class Program
    {
        /*e) Zadejte z klávesnice řadu čísel ukončenou nulou (tu již do pole neukládejte). Poté program zobrazí průměr čísel na lichých POZICÍCH.
    '(Řešte ve dvou cyklech, jeden bude sloužit pro naplnění pole a druhý pro zpracovávání pole.) */
        static void Main(string[] args)
        {
            /* e) Zadejte z klávesnice řadu čísel ukončenou nulou (tu již do pole neukládejte). 
             * Poté program zobrazí průměr čísel na lichých POZICÍCH.
            '(Řešte ve dvou cyklech, jeden bude sloužit pro naplnění pole a druhý pro zpracovávání pole.)*/
            Console.WriteLine("Jsem zadání zkoušky Basic E težší");

            int[] cisla_p = new int[100];
            int i = 0;
            int vst_cislo;
            int soucet = 0;
            int pocitadlo = 0;
            double prumer = 0;
            string txt_zadani = "";

            // Naplnění pole
            Console.WriteLine("Zadej číslo (0 pro ukončení): ");
            do
            {
                vst_cislo = int.Parse(Console.ReadLine());
                if (vst_cislo == 0)
                {
                    break;
                }
                cisla_p[i] = vst_cislo;
                txt_zadani += cisla_p[i] + ", ";
                i++;
            } while (true);
            Console.WriteLine(txt_zadani);

            // Výpis součtu a průměru lichých čísel z pole
            for (int j = 0; j < 100; j = j + 2)
            {
                if (cisla_p[j] != 0)
                {
                    soucet += cisla_p[j];
                    pocitadlo++;
                }
            }
            prumer = soucet / (double)pocitadlo;
            Console.WriteLine("Součet čísel na lichých pozicích je {0}" +
                "\nJejich průměr je {1} ", soucet, prumer);
            
            Console.WriteLine("\nPro uknčení stiskni jakoukoliv klávesu...");
            Console.ReadKey();
        }
    }
}
