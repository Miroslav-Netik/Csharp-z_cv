using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_11_Zjisteni_ctverce
    {
        //b-11)'Zadejte dvě kladná čísla, která představují délky stran
        //'obdélníka. Zjistěte, zda se jedná o čtverec
        //'a zobrazte zprávu ve tvaru: "Čtverec má dálku strany..."
        //'nebo "Obdélník má rozměry ... x"
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_11");

            double strana_1, strana_2, vysledek;

            Console.WriteLine("Zadej délku strany 1: ");
            strana_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej délku strany 2: ");
            strana_2 = double.Parse(Console.ReadLine());
            vysledek = strana_2 * strana_1;
            if (strana_1 <= 0 || strana_2 <= 0)
            {
                Console.WriteLine("To není čtverec ani obdélník...");
            }
            else
            {
                Console.WriteLine(strana_1 != strana_2 ? $"Obdélník má obvod {vysledek}." :
                 $"Čtverec má obvod {vysledek}.");
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
