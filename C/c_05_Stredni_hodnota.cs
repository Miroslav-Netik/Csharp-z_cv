using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    internal class c_05_Stredni_hodnota
    {
        //c_05)'Vygenerujte 20 celých náhodných celých čísel v rozsahu 10..50.
        //'Zjistěte, o kolik se jejich střední hodnota (průměr) liší od
        //'středu intervalu, tedy od 30.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem c_05");

            int nahodne, max = 51, min = 10;
            int soucet = 0;
            float rozdil;
            string txt_vystup = "";

            Random rnd = new Random();
            for (int i = 1, pocitadlo = 1; i <= 20; i++, pocitadlo++)  
            {
                nahodne = rnd.Next(min, max);
                soucet += nahodne;
                txt_vystup += $"{pocitadlo}.{nahodne}\n";
            }
            rozdil = soucet / 20F - 30;
            Console.WriteLine(txt_vystup + "\n" + soucet + "\n" + rozdil);

            Console.WriteLine("Zmáčkni cokoliv.");
            Console.ReadKey();
        }
    }
}
