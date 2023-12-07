using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_16_SC_Kalkulacka
    {
        //'b_16) Uživatel zadá dvě čísla. Poté se objeví nabídka, zda chce sčítat, odčítat, násobit, dělit nebo končit.
        //'Poté se objeví výsledek vybrané operace se zadanými čísly nebo program skončí
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_16");

            int volba;
            float operand_1, operand_2, vysledek = 0;
            string znamenko = "";
            Console.WriteLine("Zadej první číslo: ");
            operand_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo: ");
            operand_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Výběr typu operace: " +
                            "\nSčítání - 1" +
                            "\nOdčítání - 2" +
                            "\nNásobení - 3" +
                            "\nDělení - 4");
            volba = int.Parse(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    vysledek = operand_1 + operand_2;
                    znamenko = "+"; break;
                case 2:
                    vysledek = operand_1 - operand_2;
                    znamenko = "-"; break;
                case 3:
                    vysledek = operand_1 * operand_2;
                    znamenko = "*"; break;
                case 4:
                    if (operand_2 == 0)
                    {
                        Console.WriteLine("Nebudu raději dělit nulou...");
                    }
                    else
                    {
                        vysledek = operand_1 / operand_2;
                        znamenko = ":";
                    }
                    break;

            }
            if (volba >= 1 && volba <= 4 && operand_2 != 0)
            {
                Console.WriteLine($"{operand_1} {znamenko} {operand_2} = {vysledek}");
            }

            Console.WriteLine("Zmáčkni enter...");
            Console.ReadLine();
        }
    }
}
