using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_09_Linearni_posloupnost
    {
        /* 9) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří.
    '   Pole se předá funkci, která sdělí (boolean), zda čísla tvoří lineární aritmetickou (tj. lineární) posloupnost
        '(rozdíl dvou sousedních je vždy tentýž). */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_09\n");

            int[] pole_cisel = new int[10];
            int zadane_cislo;
            int i = 0;
            string txt_vystup = "";
            string txt_Je_neni;
            bool s_posloupnost = false;

            //Zadání čísel - ukončeno nulou
            Console.WriteLine("Zadej číslo posloupnosti (0 pro ukončení): ");
            zadane_cislo = int.Parse(Console.ReadLine());

            do
            {
                pole_cisel[i] = zadane_cislo;
                txt_vystup += pole_cisel[i] + ", ";
                i++;
                zadane_cislo = int.Parse(Console.ReadLine());
            } while (zadane_cislo != 0);

            //FUNKCE - Naplní textovou proměnnou, podle výsledku funkce
            if (ZjistiPosloupnost(pole_cisel))
            {
                Console.WriteLine("Je to posloupnost");
            }
            else
            {
                Console.WriteLine("Není to posloupnost");
            }

            //SUBRUTINA - Naplní textovou proměnnou, podle výsledku subrutiny
            S_ZjistiPosloupnost(pole_cisel, ref s_posloupnost);
            if (s_posloupnost)
            {
                Console.WriteLine("Je to posloupnost");
            }
            else
            {
                Console.WriteLine("Není to posloupnost");
            }

            Console.WriteLine("\nStiskni cokoli...");
            Console.ReadKey();
        }
        static bool ZjistiPosloupnost(int[] vstupni_pole)
        {
            //Zjistí, jestli je zadané pole lineární aritmetická posloupnost          
            int diference;

            if (vstupni_pole.Length > 1)
            {
                diference = vstupni_pole[1] - vstupni_pole[0];

                for (int i = 1; i < vstupni_pole.Length - 1; i++)
                {
                    if (vstupni_pole[i] != 0)
                    {
                        if ((vstupni_pole[i] - vstupni_pole[i - 1]) != diference)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        static void S_ZjistiPosloupnost(int[] vstupni_pole, ref bool vystup)
        {
            {
                //Zjistí, jestli je zadané pole lineární aritmetická posloupnost          
                int diference;

                vystup = true;
                if (vstupni_pole.Length > 1)
                {
                    diference = vstupni_pole[1] - vstupni_pole[0];

                    for (int i = 1; i < vstupni_pole.Length - 1; i++)
                    {
                        if (vstupni_pole[i] != 0)
                        {
                            if ((vstupni_pole[i] - vstupni_pole[i - 1]) != diference)
                            {
                                vystup = false;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
