using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_03_Cviceni_subrutiny
    {
        /*F2 - 3) Cvičení na subrutinu: Napište subrutinu, která vytiskne řádek obsahující N znaků Z.
    'Údaje N a Z jsou vstupními parametry subrutiny.
    'Pozn.: toto nelze provést jako funkci! Pozn.: použití MsgBox v subrutině či funkci je výjimečné,
    'nepoužívejte tento postup v jiných programech.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_03\n");

            int pocet_opakovani;

            Console.Write("Zadej počet písmen: ");
            pocet_opakovani = int.Parse(Console.ReadLine());
            S_TiskniZ(pocet_opakovani);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static void S_TiskniZ(int n)
        {
            // Vypíše n krát "Z"
            string vystup = "";
            for (int i = 0; i < n; i++)
            {
                vystup += "Z";
            }
            Console.WriteLine(vystup);
        }
    }
}
