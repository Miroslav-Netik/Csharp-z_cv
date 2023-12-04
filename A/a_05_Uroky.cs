using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_05_Uroky
    {
        //  a_5) Zadejte částku peněz, které jsou uloženy v bance, úrok a délku uložení. Vypočítejte,
        //  kolik bude v bance po uplynutí uvedené doby. Nepočítejte úroky z úroků. 
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_05");

            float vyse_vkladu, rocni_urok, vysledna_castka;
            double delka_ulozeni;

            Console.Write("Zadej výši vkladu: ");
            vyse_vkladu = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej roční úrok");
            rocni_urok = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej délku uložení: ");
            delka_ulozeni = float.Parse(Console.ReadLine());
            vysledna_castka = (float)(vyse_vkladu + ((vyse_vkladu * (rocni_urok / 100)) * delka_ulozeni));
            Console.WriteLine($"Výsledná částka je {vysledna_castka}");

            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
    }
}
