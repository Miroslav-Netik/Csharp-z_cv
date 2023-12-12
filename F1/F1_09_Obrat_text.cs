using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_09_Obrat_text
    {
        /* 9) Sestavte funkci ObratText s jedním parametrem - textovým řetězcem. Výsledkem volání funkce
    'je tentýž textový řetězec, ale má znaky v obráceném pořadí.
    'Funkci ověřte na zadání: sestavte program, který načte textový řetězec a zobrazí ho v
    'obráceném pořadí znaků.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F01_09\n");

            string zadany_text, obraceny_text, sub_obraceny_text = "";

            Console.WriteLine("Zadej slovo pro obracení: ");
            zadany_text = Console.ReadLine();
            obraceny_text = F_ObratText(zadany_text);
            Console.WriteLine($"Funkce -> {obraceny_text}");
            S_ObratText(zadany_text, ref sub_obraceny_text);
            Console.WriteLine($"Subrutina -> {obraceny_text}");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        // Následuje funkce a subrutina
        static string F_ObratText(string text)
        {
            // Obrátí pořadí písmen ve slově (text)
            string obraceny = "";
            char pismeno;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                pismeno = text[i];
                obraceny += pismeno.ToString();
            }
            return obraceny;
        }
        static void S_ObratText(string text, ref string obraceny_vystup)
        {
            // Obrátí pořadí písmen ve slově (text)
            string obraceny = "";
            char pismeno;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                pismeno = text[i];
                obraceny += pismeno.ToString();
            }
            obraceny_vystup = obraceny;
        }
    }
}
