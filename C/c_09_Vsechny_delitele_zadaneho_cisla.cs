using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_09_Vsechny_delitele_zadaneho_cisla
    {
        /*'c09) Těžší příklad, nepovinný: Zadejte z klávesnice
        'celé kladné číslo větší než dvě, program vypíše všechny jeho dělitele,
        'nepočítaje 1 a sebe sama (použij operátor modulo).
        'Pokud žádný není, oznámí, že se jedná o prvočíslo.
        'Pro kontrolu u čísla 12 jsou dělitele čísla: 2, 3, 4, 6.
        'A číslo 13 je prvočíslo. Pozn.: dělitel nějakého čísla,
        'je takové číslo, kterým je možno dělit beze zbytku.
        'Takže trojka je dělitelem čísla 12, protože
        'se do něj vejde přesně čtyřikrát. Zatímco pětka není dělitele čísla
        '12, protože se tam vejde dvakrát, ale zůstane zbytek 2.
        'Nápověda: Je třeba ve smyčce spočítat počet dělitelů
        '(tedy při každém nalezení dělitele zvýšit toto počitadlo o jedničku).
        'A po smyčce zjistit, zda je počet nulový: v tom případě se jedná o prvočíslo.

        'Prvočíslo je přirozené číslo větší než 1,
        'které je beze zbytku dělitelné jen dvěma děliteli:
        'jedničkou a samo sebou.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_09");

            int vstup, vysledek, pocet_delitelu = 0;
            string txt_vystup = "";

            Console.WriteLine("Zadej číslo: ");
            vstup = int.Parse(Console.ReadLine());
            for (int i = 2; i <= vstup; i++)
            {
                vysledek = vstup % i;
                if (vysledek == 0)
                {
                    pocet_delitelu++;
                    txt_vystup += $"{i}\n";
                }
            }

            if (pocet_delitelu == 1)
            {
                Console.WriteLine(txt_vystup + $"Počet dělitelů bez jedničky je {pocet_delitelu}\n" +
                    $"Číslo {vstup} je prvočíslo.");
            }
            else
            {
                Console.WriteLine(txt_vystup + $"Počet dělitelů bez jedničky je {pocet_delitelu}\n" +
                    $"Číslo {vstup} není prvočíslo.");
            }

            Console.WriteLine("Zmáčkni cokoliv: ");
            Console.ReadKey();
        }
    }
}
