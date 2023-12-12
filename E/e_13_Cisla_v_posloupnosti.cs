using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_13_Cisla_v_posloupnosti
    {
        /*'13) Je dána posloupnost celých čísel (ne lineární, tedy čísla budou nějak na přeskáčku).
        ''Zjistěte, zda se v dané posloupnosti nějaké číslo opakuje. 13 b) až to vyřešíte, vytvořte další program, kde zjistíte, která čísla se opakují.
        '13c) přidejte ještě informaci, kolikrát se opakují.
        'Pozn. 13b a 13c jsou těžké, je možno přeskočit*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_13\n");

            long[] pole_cisel = new long[100], pole_opakovanych = new long[100];
            int velikost;
            int nahodne;
            int rozsah_min, rozsah_max;
            int pocitadlo, max, min;
            string txt_generovana_cisla, txt_opakovana_cisla, txt_obsah_pole;

            txt_generovana_cisla = "";
            txt_opakovana_cisla = "";
            txt_obsah_pole = "";
            nahodne = 0;
            velikost = 10;
            rozsah_min = 1;
            rozsah_max = 11;
            pocitadlo = 0;

            max = rozsah_min;
            min = rozsah_max;

            Random rnd = new Random();

            //'Naplní pole náhodnými celými čísĺy a nastaví min a max
            for (int i = 0; i <= velikost; i++)
            {
                nahodne = rnd.Next(rozsah_min, rozsah_max);
                pole_cisel[i] = nahodne;
                if (nahodne < min)
                {
                    min = nahodne;
                }
                if (nahodne > max)
                {
                    max = nahodne;
                }
                txt_generovana_cisla += $"{nahodne,4}";
            }
            Console.WriteLine($"{txt_generovana_cisla}\nmin = {min}\nmax = {max}");

            // Jen pro kontrolu obsahu pole
            for (int i = 0; i <= velikost; i++)
            {
                txt_obsah_pole += $"{pole_cisel[i],4}";
            }
            Console.WriteLine(txt_obsah_pole);

            // Zjistí, jestli se nějaké číslo opakuje a které to je
            for (int i = min; i <= max; i++)
            {
                pocitadlo = 0;
                for (int j = 0; j <= velikost; j++)
                {
                    if (i == pole_cisel[j])
                    {
                        pocitadlo++;
                    }
                    if (pocitadlo > 1 && j == velikost)
                    {
                        txt_opakovana_cisla += $"{i}, ";
                        pocitadlo = 0;
                    }
                }
            }
            Console.WriteLine($"Čísla s opakovaným výskytem jsou: {txt_opakovana_cisla, 4}");
           
            Console.WriteLine("\nPro ukončení stiskni cokoliv...");
            Console.ReadKey();
        }
    }
}
