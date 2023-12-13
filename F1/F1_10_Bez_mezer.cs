using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_10_Bez_mezer
    {/*'F1 - 10) Sestavte funkci BezMezer s jedním parametrem - textovým řetězcem. Výsledkem volání funkce
    'je tentýž textový řetězec, ve kterém však jsou vypuštěny všechny mezery. Funkci ověřte
    'na zadání: sestavte program, který načte textový řetězec a zobrazí ho tak,
    'že v něm jsou vypuštěny všechny mezery. */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F1_10\n");

            string zadany_text, vystupni_text = "";

            Console.WriteLine("Zadej text, který chceš zbavit mezer: ");
            zadany_text = Console.ReadLine();
            Console.WriteLine($"Funkce výsledek -> {F_BezMezer(zadany_text)}");
            S_BezMezer(zadany_text, ref vystupni_text);
            Console.WriteLine($"Subrutina výsledek -> {vystupni_text}");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static string F_BezMezer(string text)
        {
            // Zbaví zadaný text mezer - funkce
            string vystup = "";
            char znak;
            for (int i = 0; i < text.Length; i++)
            {
                znak = text[i];
                if (znak == ' ')
                {
                    vystup += "";
                }
                else
                {
                    vystup += znak;
                }
            }
            return vystup;
        }
        static void S_BezMezer(string text, ref string txt_vystup)
        {
            // Zbaví zadaný text mezer - subrutina
            string vystup = "";
            char znak;
            for (int i = 0; i < text.Length; i++)
            {
                znak = text[i];
                if (znak == ' ')
                {
                    vystup += "";
                }
                else
                {
                    vystup += znak;
                }
            }
            txt_vystup = vystup;
        }
    }
}
