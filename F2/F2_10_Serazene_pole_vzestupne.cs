using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_10_Serazene_pole_vzestupne
    {
        /*F2 - 10) Obtížné, třídění: Sestavte funkci SerazenePole, která má jediný parametr: pole celých čísel. Výsledkem funkce
        'je jednorozměrné celočíselné pole, ve kterém jsou stejná čísla jako v poli parametru, ale jsou seřazena vzestupně.
        'Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří,
        'a pak zobrazí všechna zadaná čísla ve vzestupném pořadí. (obdoba E14, ale třídění proběhne ve funkci)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_10\n");

            int pocet_opakovani = 20;
            int[] pole_cisel = new int[pocet_opakovani];
            int[] setridene_pole = new int[pocet_opakovani];
            int max = 10;
            int min = 1;
            string txt_vystup = "";
            string txt_setridene = "";

            Random rnd = new Random();
            for (int i = 0; i < pocet_opakovani; i++)
            {
                pole_cisel[i] = rnd.Next(min, max);
                txt_vystup += pole_cisel[i] + ", ";
            }
            Console.WriteLine(txt_vystup);

            setridene_pole = SerazenePole(pole_cisel);
            for (int j = 0; j < setridene_pole.Length; j++)
            {
                txt_setridene += setridene_pole[j] + ", ";
            }
            Console.WriteLine(txt_setridene);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int[] SerazenePole(int[] vstupni_pole)
        {
            int[] setridene_pole = new int[vstupni_pole.Length];
            int odkladaci;

            //Array.Copy(vstupni_pole, setridene_pole, vstupni_pole.Length);
            for (int i = 0; i < vstupni_pole.Length; i++)
            {
                setridene_pole[i] = vstupni_pole[i];
            }

            for (int j = 0; j < setridene_pole.Length; j++)
            {


                for (int i = 0; i < setridene_pole.Length - 1; i++)
                {
                    if (setridene_pole[i] > setridene_pole[i + 1])
                    {
                        odkladaci = setridene_pole[i];
                        setridene_pole[i] = setridene_pole[i + 1];
                        setridene_pole[i + 1] = odkladaci;
                    }
                }
            }
            return setridene_pole;
        }
    }
}

