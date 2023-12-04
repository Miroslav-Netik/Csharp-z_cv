using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class a_04_mZas_na_kmZah
    {
        //  a_4) Zadejte rychlost v m/s a převeďte na km/hod.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem a_04");

            const float koeficient = 3.6F;
            float m_za_s, km_za_h;

            Console.WriteLine("Zadej m/s");
            m_za_s = float.Parse(Console.ReadLine());
            km_za_h = m_za_s * koeficient;
            Console.WriteLine($"{m_za_s} m/s je {km_za_h} km/h.");

            Console.WriteLine("Stiskni ENTER...");
            Console.ReadLine();
        }
    }
}
