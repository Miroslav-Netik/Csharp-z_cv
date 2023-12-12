using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_04_Prestupny_rok_gregoriansky
    {
        /* 4) Napište funkci (a pak předělejte na subrutinu), které se předá rok (čtyřciferný) a která vrací logickou hodnotu "True",
        'pokud je rok přestupný (přepracujte z Juliánského kalendáře z BasicCv.doc na Gregoriánský).  Řešte dvěma způsoby:
        'dvěma podmínkami (či if-else) i jednou složenou podmínkou.
        'Potřebná teorie: Podle gregoriánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi.
        'Ale roky dělitelné stem jsou přestupné jenom tehdy, jsou-li dělitelné také 400. Přestupnými roky jsou proto
        'například roky 1600, 2000, 2400 apod., zatímco roky 1700, 1800, 1900, 2100 atd. přestupné nejsou. (zdroj: wikipedia)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F1_04\n");

            int zadany_rok;
            bool vystup_rok = false;

            Console.Write("Zadej rok (čtyřciferný): ");
            zadany_rok = int.Parse(Console.ReadLine());

            // Volání funkcí
            if (F_prestupny_rok(zadany_rok))
            {
                Console.WriteLine($"Funkce - Rok {zadany_rok} je přestupný.");
            }
            else
            {
                Console.WriteLine($"Funkce - Rok {zadany_rok} není přestupný.");
            }

            // Volání Subrutinou
            S_prestupny_rok(zadany_rok, ref vystup_rok);
            if (vystup_rok)
            {
                Console.WriteLine($"Subrutina - Rok {zadany_rok} je přestupný.");
            }
            else
            {
                Console.WriteLine($"Subrutina - Funkce - Rok {zadany_rok} není přestupný.");
            }
      
            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        // Kód Funkce a Subrutiny 
        static bool F_prestupny_rok(int rok)
        {
            // Zjistí. jestli je zadaný rok přestupný
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void S_prestupny_rok(int rok, ref bool vystup)
        {
            // Zjistí, jestli je zadaný rok přestupný
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                vystup = true;
            }
            else
            {
                vystup = false;
            }
        }
    }
}
