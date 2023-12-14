using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_09_Pocet_hodu_kostkou_procentualne
    {
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e 09");

            int pocet_hodu;
            string s = "";
            int[] pole = new int[100];
            int[] vyskyt = new int[100];

            Console.WriteLine("Zadej počet hodů:");
            pocet_hodu = int.Parse(Console.ReadLine());

            //Naplní pole hodnotami náhodných hodů
            Random rnd = new Random();
            for (int i = 0; i < pocet_hodu; i++)
            {
                pole[i] = rnd.Next(1, 7);
                s += pole[i] + ", ";
            }
            s += "\n";

            // Spočítá jednotlivá hozená čísla tím, že na indexy nového pole, 
            // odpovídající hodnotám hodů, uložených ve starém poli,
            // přičte jedničku... :-) Jak prosté... Ale příjít na to!
            for (int i = 0; i < pocet_hodu; i++)
            {
                vyskyt[pole[i]]++; // Na index číslo pole[i], vložím jedničku,
                                   // tím napočítám počet jednotlivých čísel
            }

            // Vypíše počty jednotlivých hození a počet jejich procent
            for (int i = 1; i <= 6; i++)
            {
                s += $"{i} padlo {vyskyt[i]}x, což je {vyskyt[i] / (float)pocet_hodu * 100} %\n";
            }
            Console.WriteLine(s);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
    }
}
