using System;

namespace B
{
    internal class b_12_Je_den_a_horko
    {
        //b_12 'Program se zeptá, zda je den a zda je horko
        //'(odpověď a/n). Pouze v případě obou odpovědí kladných
        //'vám navrhne jít si zaplavat. Použijte jen jeden
        //'příkaz IF (ale se složenou podmínkou).
        //'Jednodušší varianta: předpokládejme, že uživatel bude
        //'uvědoměle zadávat malá písmena.Složitější
        //'varianta: program bude reagovat stejně na „a“ i „A“
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_12");

            //string odpoved;   //Pro verzi s třístavovým příkazem
            char den, horko;
            Console.WriteLine("Je den? (A/N): ");
            den = Console.ReadLine()[0];
            Console.WriteLine("Je horko? (A/N): ");
            horko = Console.ReadLine()[0];
            den = Char.ToUpper(den);
            horko = char.ToUpper(horko);
            //odpoved je špatně - pro podmínku nn
            //odpoved = (horko is 'A' && den is 'A') ? "Jdi si zaplavat" : (horko is 'A' && den is 'N') ? "Je noc, jdi spát" : "Je zima, zůstaň doma.";
            if (den == 'A' && horko == 'A')
            {
                Console.WriteLine("Jdi si zaplavat.");
            }
            else if (den == 'A' && horko == 'N')
            {
                Console.WriteLine("Je zima, zůstaň doma.");
            }
            else if (den == 'N' && horko == 'A')
            {
                Console.WriteLine("V noci jdi spát.");
            }
            else
            {
                Console.WriteLine("Je noc a zima, kašli na to...");
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
