﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_02_Losovani_sazky
    {
        public static void Mainx(string[] args)
        {
            /* 2) Stroj na losování Sazky se porouchal. Tahal sice z osudí čísla 1 až 49, ale některá opakovaně. Vytvořte funkci,
        'které se předá pole takovýchto čísel, funkce pole vrátí očištěné od druhých a dalších výskytů opakujících se čísel
        '(pro jednoduchost stačí, aby na jejich místě dosadila nulu). Nevadí, že tedy může být ve výsledku méně čísel než požadovaných pět.*/
            Console.WriteLine("Jsem F2_02\n");

            int[] pole_tazenych = new int[100];
            int[] pole_upravene = new int[100];
            int[] s_pole_upravene = new int[100];
            int tazene_cislo, rozsah_max, rozsah_min;
            int pocet_opakovani;
            string txt_vystup,txt_vystup_2 = "", txt_upraveny_vystup, txt_upraveny_vystup_2;

            txt_upraveny_vystup = "";
            txt_upraveny_vystup_2 = "";
            txt_vystup = "";
            rozsah_max = 50;
            rozsah_min = 1;
            pocet_opakovani = 25;

            Random rnd = new Random();

            for (int i = 0; i < pocet_opakovani; i++)
            {
                tazene_cislo = rnd.Next(rozsah_min, rozsah_max);
                txt_vystup += $"{tazene_cislo}, ";
                pole_tazenych[i] = tazene_cislo;
            }

            // Výpis zadaných hodnot z pole
            for (int i = 0; i < pocet_opakovani; i++)
            {
                txt_vystup_2 += pole_tazenych[i] + ", ";
            }
            Console.WriteLine(txt_vystup + "\n" + txt_vystup_2);

            // Výpis hodnot se zjištěnou duplicitou funkcí
            pole_upravene = F_Ocisti(pole_tazenych);
            for (int i = 0; i < pocet_opakovani; i++)
            {
                txt_upraveny_vystup += pole_upravene[i] + ", ";
            }
            Console.WriteLine("Funkce ->    " + txt_upraveny_vystup);

            // Výpis hodnot se zjištěnou duplicitou Subrutinou
            S_Ocisti(pole_tazenych,ref s_pole_upravene);
            for (int i = 0; i < pocet_opakovani; i++)
            {
                txt_upraveny_vystup_2 += s_pole_upravene[i] + ", ";
            }
            Console.WriteLine($"Subrutina -> {txt_upraveny_vystup_2}");

            Console.WriteLine("\nStisni cokoliv...");
            Console.ReadKey();
        }

        static int[]F_Ocisti(int[] vstupni_pole)
        {
            // Za duplicitní hodnoty dosadí nulu
            int[] vystupni_pole = new int[vstupni_pole.Length];

            //'Naplním vystupní pole vstupním, aby se vstupnímu nic nestalo
            for (int i = 0; i < vstupni_pole.Length; i++)
            {
                vystupni_pole[i] = vstupni_pole[i];
            }

            //'Pak postupně projíždím výstupní
            for (int i = 0; i < vstupni_pole.Length; i++)
            {
                for (int j = i + 1; j < vstupni_pole.Length; j++)
                {
                    if (vystupni_pole[i] == vystupni_pole[j])
                    {
                        vystupni_pole[j] = 0;
                    }
                }
            }
            return vystupni_pole;
        }
        static void S_Ocisti(int[] vstupni_pole, ref int[] vystupni_pole)
        {
            // Za duplicitní hodnoty dosadí nulu
            
            //'Naplním vystupní pole vstupním, aby se vstupnímu nic nestalo
            for (int i = 0; i < vstupni_pole.Length; i++)
            {
                vystupni_pole[i] = vstupni_pole[i];
            }

            //'Pak postupně projíždím výstupní
            for (int i = 0; i < vstupni_pole.Length; i++)
            {
                // Vždy od dalšího indexu, který už byl porovnán se zbytkem
                for (int j = i + 1; j < vstupni_pole.Length; j++)
                {
                    if (vystupni_pole[i] == vystupni_pole[j])
                    {
                        vystupni_pole[j] = 0;
                    }
                }
            }
        }
    }
}
