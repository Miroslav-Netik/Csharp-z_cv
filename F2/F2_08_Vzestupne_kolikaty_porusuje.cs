using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_08_Vzestupne_kolikaty_porusuje
    {
        /* F2 - 8) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří. Pole se předá funkci,
        'která sdělí, kolikátý prvek v řadě porušuje vzestupné řazení čísel. Pokud je pole celé vzestupné, pak vrátí -1*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_08\n");

            double[] pole_cisel = new double[10];
            double vstup_zadani_cisla;
            double vysledek_funkcce;
            int i = 0;
            string txt_vystup = "";
            int s_hodnota = -1;

            // Naplnění pole ručně
            Console.WriteLine("Zadej číslo (0 pro ukončení): ");
            vstup_zadani_cisla = double.Parse(Console.ReadLine());
            while (vstup_zadani_cisla != 0)
            {
                pole_cisel[i] = vstup_zadani_cisla;
                txt_vystup += pole_cisel[i] + ", ";
                i++;
                vstup_zadani_cisla = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(txt_vystup);

            //Vypis FUNKCE
            vysledek_funkcce = F_KolikatyNeniVzestupny(pole_cisel);
            if (vysledek_funkcce == -1)
            {
                Console.WriteLine("Čísla jsou řazena vzestupně.");
            }
            else
            {
                Console.WriteLine($"Čísla nejsou řazena vzestupně. Porušuje prvek číslo {vysledek_funkcce + 1}");
            }

            //Vypis SUBRUTINA
            S_KolikatyNeniVzestupny(pole_cisel, ref s_hodnota);
            if (vysledek_funkcce == -1)
            {
                Console.WriteLine("Čísla jsou řazena vzestupně.");
            }
            else
            {
                Console.WriteLine($"Čísla nejsou řazena vzestupně. Porušuje prvek číslo {s_hodnota + 1}");
            }

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int F_KolikatyNeniVzestupny(double[] pole_vstup)
        {
            //  'Jakmile je cislo nasledujici číslo v poli menší nez predchozi, prepne vetsi_2 na True

            int kolikaty_porusuje = 0;
            for (int i = 0; i < pole_vstup.Length - 1; i++)
            {
                if (pole_vstup[i + 1] != 0)
                {
                    if (pole_vstup[i] >= pole_vstup[i + 1])
                    {
                        kolikaty_porusuje = i + 1;
                        return kolikaty_porusuje;
                    }
                }
            }
            return -1;
        }
        static void S_KolikatyNeniVzestupny(double[] pole_vstup,ref int vystup)
        {
            vystup = -1;
            int kolikaty_porusuje = 0;
            for (int i = 0; i < pole_vstup.Length - 1; i++)
            {
                if (pole_vstup[i + 1] != 0)
                {
                    if (pole_vstup[i] >= pole_vstup[i + 1])
                    {
                        kolikaty_porusuje = i + 1;
                        vystup = kolikaty_porusuje;
                        break;
                    }
                }
            }
        }
    }
}
