using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_15_SC_Co_delat_podle_pocasi
    {
        //b_15) Program se zeptá, jak je venku, nabídne vám: úmorné vedro, zima, déšť, mlha, tma, chumelenice, atd.
        //'Podle toho vám navrhne, co máte dělat, např. dobře se obléci, jít na plovárnu atd. Nepoužívejte příkaz IF.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_15_tezsi");

            int volba;

            Console.WriteLine("Jak je venku? " +
                "\n1 - Krásně" +
                "\n2 - Prší" +
                "\n3 - Sněží" +
                "\nTvoje volba: ");
            volba = int.Parse(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    Console.WriteLine("Je krásně, vem si plavky."); break;
                case 2:
                    Console.WriteLine("Prší. Vem si deštník."); break;
                case 3:
                    Console.WriteLine("Humelí. Vem si kožich."); break;
                default:
                    Console.WriteLine("Tak to vážně nevím."); break;
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
