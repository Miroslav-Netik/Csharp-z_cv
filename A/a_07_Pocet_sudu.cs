using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_07_Pocet_sudu
    {
        //  7) Zadejte počet sudů a množství litrů v sudu (ve všech je stejně). Kolik litrů je celkem?
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_07");

            int pocet_sudu;
            float litru_v_sudu, celkem;

            Console.WriteLine("Zadej počet sudů: ");
            pocet_sudu = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolik je litrů v jednom sudu: ");
            litru_v_sudu= float.Parse(Console.ReadLine());
            celkem = pocet_sudu * litru_v_sudu;
            Console.WriteLine($"V {pocet_sudu} sudech je celkem {celkem} litrů.");

            Console.WriteLine("Press ENTER...");
            Console.ReadLine();
        }
    }
}
