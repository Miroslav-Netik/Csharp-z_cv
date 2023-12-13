using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_11_Vyskyty_retezce
    {
        /*F1_ 11) Sestavte funkci Vyskyty se dvěma parametry - textovými řetězci. Druhý parametr je subřetězec,
    '(případně jen jednoznakový řetězec. Výsledkem volání funkce je počet opakování druhého parametru v parametru prvním.
    'Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí například počet písmen "A" v tomto řetězci.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F1_11\n");

            string txt_vstup, txt_vystup;
            char txt_kontrolovany;
            int pocet_nalezenych = 0;

            Console.WriteLine("Zadej text: ");
            txt_vstup = Console.ReadLine();
            Console.WriteLine("Zadej znak který hledáš: ");
            txt_kontrolovany = char.Parse(Console.ReadLine());

            Console.WriteLine($"Funkce -> Počet nalezených znaků '{txt_kontrolovany}' je {F_Vyskyty(txt_vstup, txt_kontrolovany)}.");
            S_Vyskyty(txt_vstup, txt_kontrolovany,ref pocet_nalezenych);
            Console.WriteLine($"Subrutina -> Počet nalezených znaků '{txt_kontrolovany}' je {pocet_nalezenych}.");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int F_Vyskyty(string prvni, char druhy)
        {
            char znak;
            int pocitadlo = 0;

            for (int i = 0; i < prvni.Length; i++)
            {
                znak = prvni[i];
                if (druhy == znak)
                {
                    pocitadlo++;
                }
            }
            return pocitadlo;
        }
        static void S_Vyskyty(string prvni, char druhy,ref int vystup)
        {
            char znak;
            int pocitadlo = 0;

            for (int i = 0; i < prvni.Length; i++)
            {
                znak = prvni[i];
                if (druhy == znak)
                {
                    pocitadlo++;
                }
            }
            vystup = pocitadlo;
        }
       
        
    }
}
