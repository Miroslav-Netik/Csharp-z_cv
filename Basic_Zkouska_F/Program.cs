using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Zkouska_F
{
    internal class Program
    {
        /* 'f) Napište funkci, která z pole deseti čísel vrací nejmenší. Přitom čísla budou v 
         * hlavním programu generována například v rozsahu -10,10
        '(ale funkce musí být univerzální, tedy musí si poradit i s čísly v jiném rozsahu). Potom vytvořte subrutinu se stejnou funkčností.
        'Z hlavního programu zavolejte funkci i subrutinu.
        'Pozn.: V hlavním programu musí být použity jiné názvy proměnných než v subrutině či funkci. 
        Vstupy a výstupy budou v hlavním programu
        '(tedy ve funkci a subrutině by neměl být příkaz MsgBox). Funkce musí fungovat dobře beze změny i v případě, 
        že se v hlavním programu změní rozměr pole. */
        static void Main(string[] args)
        {
            Console.WriteLine("Jsem zadání zkoušky VB F - těžší\n");

            //int[] pole_cisel = new int[100];
            int min;
            int rozsah_min = -10;
            int rozsah_max = 10;
            int nejmensi = rozsah_min;
            int pocet_opakovani = 11;
            int[] pole_cisel = new int[pocet_opakovani];
            string txt_generovana = "";

            Random rnd = new Random();
            //Generování čísel v rozsahu rozsah_min až rozsah_max
            for (int i = 0; i < pocet_opakovani; i++)
            {
                pole_cisel[i] = rnd.Next(rozsah_min, rozsah_max);
                txt_generovana += pole_cisel[i] + ", ";
            }
            Console.WriteLine(txt_generovana);

            // Volání funkce
            min = NajdiMin(pole_cisel);
            Console.WriteLine("\nFunkce -> Nejmenší číslo je {0, 5}", min);

            // Volání subrutiny
            S_NajdiMin(pole_cisel, ref nejmensi);
            Console.WriteLine("\nSubrutina -> Nejmenší číslo je {0, 5}", nejmensi);


            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        public static int NajdiMin(int[] cisla)
        {
            // Najde nejmenší v zadaném poli
            int min = cisla[0];
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] < min)
                {
                    min = cisla[i];
                }
            }
            return min;
        }
        public static void S_NajdiMin(int[] cisla,ref int vystup)
        {
            // Najde nejmenší číslo v zadaném poli
            int min = cisla[0];
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] < min)
                {
                    min = cisla[i];
                }
            }
            vystup = min;
        }
    }
}
