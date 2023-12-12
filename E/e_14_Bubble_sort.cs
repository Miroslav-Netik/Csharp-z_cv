using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_14_Bubble_sort
    {
        /*14) Vygenerujte deset celých čísel a setřiďte je.  Použijte např. algoritmus Bublinkového třídění (Bubble sort)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_14\n");

            long[] pole_cisel = new long[100];
            long nahodna, porovnavaci;
            int velikost;
            string txt_nahodna, txt_serazena;

            txt_nahodna = "";
            txt_serazena = "";
            velikost = 10;

            Random rnd = new Random();
            // Naplnění pole náhodnými čísly
            for (int i = 0; i < velikost; i++)
            {
                nahodna = rnd.Next(1, 101);
                pole_cisel[i] = nahodna;
                txt_nahodna += $"{nahodna,4}";
            }
            Console.WriteLine(txt_nahodna, 4);
            //Seřazení čísel
            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost - 1; j++)
                {
                    if (pole_cisel[j] > pole_cisel[j + 1])
                    {
                        porovnavaci = pole_cisel[j];
                        pole_cisel[j] = pole_cisel[j + 1];
                        pole_cisel[j + 1] = porovnavaci;
                    }
                }
            }
            // Odečet seřazených hodnot z pole
            for (int i = 0; i < velikost; i++)
            {
                txt_serazena += $"{pole_cisel[i],4}";
            }
            Console.WriteLine($"Seřazená čísla jsou: {txt_serazena}");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
    }
}
