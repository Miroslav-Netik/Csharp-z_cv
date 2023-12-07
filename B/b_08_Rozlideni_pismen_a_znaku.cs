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

            char zadany_znak;
            int znak;

            Console.WriteLine("Zadej písmenko nebo číslíčko: ");
            zadany_znak = Console.ReadLine()[0];
            //zadany_znak = (char)Console.Read(); 
            znak = (zadany_znak);
            //Při použití Console.Read() je potřeba vyprázdnit vstupní buffer,
            //protože v něm zůstal Enter, a ten pak odentruje následující Console.WriteLine()
            //while (Console.In.Peek() != -1)   
            //    Console.In.Read();
            if (znak >= 48 && znak <= 57)
            { 
                Console.WriteLine("Znak je číslo."); 
            }
            else if (znak >= 65 && znak <= 90)
            {
                Console.WriteLine("Znak je velké písmeno.");
            }
            else if (znak >= 97 && znak <= 122)
            {
                Console.WriteLine("Znak je malé písmeno.");
            }
            else
            { Console.WriteLine("Znak je asi něco jiného..."); }

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
}
