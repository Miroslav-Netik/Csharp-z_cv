using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_10_Zkouseni_male_nasobilky
    {
        /*c_10)Vytvořte program pro zkoušení malé násobilky.
        'Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd.
        'Uživatel napíše výsledek. Pokud to je špatně, napíše počítač
        'správný výsledek. Celkem 10 příkladů, nakonec se zobrazí
        'počet chyb.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_10");

            int operand_1, operand_2;
            int vysledek, vlozeny_vysledek = 0;
            int pocet_cyhb = 0, pocet_spravne = 0;
            int max = 11, min = 0;
            string txt_napis;

            Random rnd = new Random();
            for (int i = 1; i <=5; i++)
            {
                operand_1 = (int)rnd.Next(min, max);
                operand_2 = (int)rnd.Next(min, max);
                txt_napis = $"{operand_1} * {operand_2} = ";
                vysledek = operand_1 * operand_2;
                Console.Write($"Příklad číslo {i} -> " + txt_napis);
                vlozeny_vysledek = int.Parse(Console.ReadLine());
                if (vysledek == vlozeny_vysledek)
                {
                    pocet_spravne++;
                }
                else
                {
                    pocet_cyhb++;
                    Console.WriteLine($"Chyba! {txt_napis} {vysledek} a ne {vlozeny_vysledek}");
                }
            }
            Console.WriteLine($"Počet chyb je {pocet_cyhb} \n" +
                $"Počet správně je {pocet_spravne}");

            Console.WriteLine("\nZmáčkni cokoli...");
            Console.ReadKey();
        }
    }
}
