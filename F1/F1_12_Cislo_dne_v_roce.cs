using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class F1_12_Cislo_dne_v_roce
    {
        /* F1 - 12) Sestavte funkci CisloDneVRoce, která má tři parametry: prvním je číslo dne, druhým číslo měsíce, třetím číslo roku
         * včetně století.
        'Výsledkem volání funkce je pořadové číslo zadaného dne v daném roce (nebo -1, jestliže takové datum neexistuje).
        'Uvažujte i přestupné roky. Funkci ověřte na zadání: sestavte program, který postupně načte den, měsíc a rok, a poté zobrazí,
        'kolikátý den v roce to je. Vyzkoušejte i pro den = 32 nebo pro měsíc = 13. Dále vyzkoušejte pro [31/12/1900] a pro [31/12/2000]. 
        'V programu využijete datový typ Date a funkce Weekday, WeekdayName a CDate
        'Pozor, Excel považuje chybně rok 1900 za přestupný. 
        'Tento program je dost náročný, můžete si jej nechat na konec*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jesm F1_12\n");

            int cislo_dne, cislo_mesice, cislo_roku, pocet_dnu, s_pocet_dnu = 0;

            Console.WriteLine("Zadej číslo dne: ");
            cislo_dne = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo měsíce: ");
            cislo_mesice = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej číslo roku: ");
            cislo_roku = int.Parse(Console.ReadLine());

            pocet_dnu = F_CisloDneVroce(cislo_dne, cislo_mesice, cislo_roku); // Funkce
            Console.WriteLine($"Funkce - > Pořadové číslo dne je {pocet_dnu}");
            S_CisloDneVroce(cislo_dne, cislo_mesice, cislo_roku, ref s_pocet_dnu); // Subrutina
            Console.WriteLine($"Subrutina - > Pořadové číslo dne je {s_pocet_dnu}");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        // Následují funkce a subrutina
        static int F_CisloDneVroce(int den, int mesic, int rok)
        {
            // FUNKCE - Zjistí pořadové číslo dne v roce, počítá i přestupné roky
            // Volá funkci na zjištění počtu dnů v měsící
            int soucet_dnu = 0;
            if (den > 0 && den <= PocetDniMesice(mesic, rok) && rok > 999)
            {
                for (int i = 1; i <= mesic; i++)
                {
                    soucet_dnu += PocetDniMesice(i, rok);
                }
                soucet_dnu = soucet_dnu - PocetDniMesice(mesic, rok) + den;
                return soucet_dnu;
            }
            else
            { return -1; }
        }
        static void S_CisloDneVroce(int den, int mesic, int rok, ref int vystup)
        {
            // SUBRUTINA - Zjistí pořadové číslo dne v roce, počítá i přestupné roky
            // Volá funkci na zjištění počtu dnů v měsící
            int soucet_dnu = 0;
            if (den > 0 && den <= PocetDniMesice(mesic, rok) && rok > 999)
            {
                for (int i = 1; i <= mesic; i++)
                {
                    soucet_dnu += PocetDniMesice(i, rok);
                }
                soucet_dnu = soucet_dnu - PocetDniMesice(mesic, rok) + den;
                vystup = soucet_dnu;
            }
            else
            { vystup = -1; }
        }
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
        static int PocetDniMesice(int cislo, int rok)
        {
            // Zjistí počet dnů v měsíci
            // Volá funkci na zjištění přestupného roku
            switch (cislo)
            {

                case 1:
                    return 31;
                case 2:
                    if (F_prestupny_rok(rok))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default:
                    return -1;

            }
        }
    }
}
