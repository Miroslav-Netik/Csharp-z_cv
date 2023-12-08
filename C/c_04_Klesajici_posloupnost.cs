using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_04_Klesajici_posloupnost
    {
        // C 04 Vypište klesající posloupnost čísel od 8 do -8.
        //'Varianta: vypište stejnou posloupnost,
        //'ale pouze každé druhé (sudé) číslo.
        //'(Nepoužívejte if.)
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jem c_04.");

            string txt_vyatup = "", txt_vystup_suda = "";

            for (int i = 8; i >= -8; i--)
            {
                txt_vyatup += $"{i}\n";
            }
            for (int j = 8; j >= -8; j -= 2)
            {
                txt_vystup_suda += $"{j}\n";
            }
            Console.WriteLine(txt_vyatup + "\n" + txt_vystup_suda);
            
            Console.WriteLine("Zmáčkni cokoliv.");
            Console.ReadKey();
        }
    }
}
