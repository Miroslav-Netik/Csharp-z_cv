using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace F1
{

    internal class F1_08_Pocet_dni_mesice
    {
        /* 8) Sestavte funkci PocetDniMesice, která má jako jediný parametr číslo měsíce. Výsledkem volání funkce
        'je počet dní tohoto měsíce (nebo -1, není-li hodnota měsíce správná).
        'Přestupné roky pro únor neuvažujte. Funkci ověřte na zadání: sestavte program,
        'který načte číslo měsíce a poté zobrazí, kolik dní má tento měsíc.
        'Vyzkoušejte i pro měsíc = 13. Návod: řešte pomocí složené podmínky nebo konstrukcí Select case.
        '(program Doc. Homoly)*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsme F-01_08\n");

            int zadane_cislo_mesice;
            int dni_mesice, cislo_mesice_subrutiny;
            int x = 0;

            Console.Write("Zadej číslo měsíce: ");
            zadane_cislo_mesice = int.Parse(Console.ReadLine());
            dni_mesice = PocetDniMesice(zadane_cislo_mesice);
            Console.WriteLine($"Funkce - Počet dní měsíce číslo {zadane_cislo_mesice} je {dni_mesice}.");

            S_pocet_dni_mesice(zadane_cislo_mesice,ref x);
            Console.WriteLine($"Subrutina - Počet dní měsíce číslo {zadane_cislo_mesice} je {x}.");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static int PocetDniMesice(int cislo)
        {
            switch (cislo)
            {

                case 1:
                    return 31; break;
                case 2:
                    return 28; break;
                case 3:
                    return 31; break;
                case 4:
                    return 30; break;
                case 5:
                    return 31; break;
                case 6:
                    return 30; break;
                case 7:
                    return 31; break;
                case 8:
                    return 31; break;
                case 9:
                    return 30; break;
                case 10:
                    return 31; break;
                case 11:
                    return 30; break;
                case 12:
                    return 31; break;
                default:
                    return -1; break;

            }
        }
        static void S_pocet_dni_mesice(int cislo, ref int vystup)
        {
            switch (cislo)
            {

                case 1:
                    vystup = 31; break;
                case 2:
                    vystup = 28; break;
                case 3:
                    vystup = 31; break;
                case 4:
                    vystup = 30; break;
                case 5:
                    vystup = 31; break;
                case 6:
                    vystup = 30; break;
                case 7:
                    vystup = 31; break;
                case 8:
                    vystup = 31; break;
                case 9:
                    vystup = 30; break;
                case 10:
                    vystup = 31; break;
                case 11:
                    vystup = 30; break;
                case 12:
                    vystup = 31; break;
                default:
                    vystup = -1; break;
            }
        }
    }
}
