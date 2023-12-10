using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_11_Tabulka_ASCII
    {
        //c11) Tabulka ASCII: zobrazit v  MsgBoxu v levém sloupci čísla
        //'např. 65 až 100 a v pravém příslušný znak.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_11");

            string txt_vystup = "";

            for (int i = 60; i <= 100; i++)
            {
                txt_vystup += $"ASCII ({i}) je {(char)i}\n";
            }
            Console.WriteLine(txt_vystup);
 
            Console.WriteLine("Zmáčkni jakoukoli klávesu...");
            Console.ReadKey();
        }
    }
}
