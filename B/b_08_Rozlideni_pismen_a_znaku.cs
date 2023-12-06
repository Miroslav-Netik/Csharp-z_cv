using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_08_Rozlideni_pismen_a_znaku
    {
        //b_08) 'Uživatel zadá znak, program odpoví,
        //'zda se jedná o velké písmeno, malé písmeno,
        //'číslici nebo jiný znak. Řešte pomocí else
        //'if. (nebo je možno řešit i složenou podmínkou).
        //'U písmen uvažujte jen písmena anglické abecedy
        //'(tedy bez háčků a čárek).
        //'Řešte intervalem (čili od-do), tedy využijte toho,
        //'že číslice jsou v ASCII za sebou seřazeny podle
        //'hodnoty (podobně velká písmena seřazená podle
        //'anglické abecedy a stejně tak i malá písmena).
        //'Tedy neřešte výčtem (vyjmenováním jednotlivých
        //'písmenek).
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_08");

            char[] zadany_znak;
            int znak;

            Console.WriteLine("Zadej znak: ");
            

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
}
