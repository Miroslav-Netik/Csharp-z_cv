using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkouska_E
{
    internal class Program
    {
        /* e) Zadejte řadu čísel ukončenou nulou (tu již do pole neukládejte). 
         * Poté se program zeptá, zda chcete vytisknout kladná čísla nebo záporná. 
         * A pak vypíše záporné, počet a průměr záporných nebo případně vypíše kladná, 
         * počet a průměr kladných*/
        static void Main(string[] args)
        {
            // Zkouška E

            int[] poleCisel = new int[100];
            int pocitadlo = 0, vstup, soucetKladna = 0, pocitadloKladna = 0, soucetZaporna = 0, pocitadloZaporna = 0;

            Console.WriteLine("Zadejte řadu celých čísel ukončenou nulou (maximálně 100 čísel):");
            while ((vstup = Convert.ToInt32(Console.ReadLine())) != 0 && pocitadlo < 100)
            {
                poleCisel[pocitadlo] = vstup;
                if (vstup > 0)
                {
                    soucetKladna += vstup;
                    pocitadloKladna++;
                }
                else if (vstup < 0)
                {
                    soucetZaporna += vstup;
                    pocitadloZaporna++;
                }
                pocitadlo++;
            }

            Console.WriteLine("Chcete vytisknout kladná čísla nebo záporná? (k/z)");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'k')
            {
                Console.WriteLine("Kladná čísla:");
                for (int i = 0; i < pocitadlo; i++)
                {
                    if (poleCisel[i] > 0)
                    {
                        Console.WriteLine(poleCisel[i]);
                    }
                }
                Console.WriteLine("Počet kladných čísel: " + pocitadloKladna);
                Console.WriteLine("Průměr kladných čísel: " + (double)soucetKladna / pocitadloKladna);
            }
            else if (choice == 'z')
            {
                Console.WriteLine("Záporná čísla:");
                for (int i = 0; i < pocitadlo; i++)
                {
                    if (poleCisel[i] < 0)
                    {
                        Console.WriteLine(poleCisel[i]);
                    }
                }
                Console.WriteLine("Počet záporných čísel: " + pocitadloZaporna);
                Console.WriteLine("Průměr záporných čísel: " + (double)soucetZaporna / pocitadloZaporna);
            }
            else
            {
                Console.WriteLine("Neplatná volba.");
            }
            Console.WriteLine("\nPro ukončení stiskni jakoukoliv klávesu...");
            Console.ReadKey();

        }
    }
}
