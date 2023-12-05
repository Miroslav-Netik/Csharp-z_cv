using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_10_Rad_na_stupne
    {
        //  a_10) Převeďte úhel zadaný v radiánech na stupně.
        //Návod: řešte trojčlenkou. Plnému kruhu odpovídá
        //360 stupňů nebo 2 pí radiánů
        //(přibližně 6,28 radiánů).
        //Tedy jeden radián je 180/pi  = 57,296 stupňů.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_10.");

            float zadane_radiany, vypoctene_stupne;
            Console.WriteLine("Zadej úhel v radiánech: ");
            zadane_radiany = float.Parse(Console.ReadLine());
            vypoctene_stupne = (float)(360 * (zadane_radiany / (2 * Math.PI)));
            Console.WriteLine($"{zadane_radiany} rad je {vypoctene_stupne} stupňů.");

            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
    }
}
