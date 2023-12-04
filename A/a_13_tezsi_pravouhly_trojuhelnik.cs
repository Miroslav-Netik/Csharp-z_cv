using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_13_tezsi_pravouhly_trojuhelnik
    {
        //  a_13) Zadejte délku odvěsen pravoúhlého trojúhelníka. Program pomocí Pythagorovy věty vypočte délku přepony.
        //  Pro kontrolu: zadáte-li odvěsny o délce 3 a 4, pak výsledek je 5 (přesněji 5,0, protože výsledek odmocniny
        //  se musí ukládat do desetinného typu )
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_13");

            float prepona, odvesna_1, odvesna_2;

            Console.WriteLine("Zadej délku první odvěsny: ");
            odvesna_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej délku druhé odvěsny: ");
            odvesna_2 = float.Parse(Console.ReadLine());
            prepona = (float)Math.Sqrt(odvesna_1 * odvesna_1 + odvesna_2 * odvesna_2);
            Console.WriteLine($"Přepona trojúhelníku je {prepona} dlouhá.");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
