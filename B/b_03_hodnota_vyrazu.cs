using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_03_hodnota_vyrazu
    {
        //b3) Úkolem je pro danou dvojici čísel x,y
        //spočítat hodnotu výrazu 1 / (x *y)
        //Pokud by ale byl jmenovatel nulový,
        //tak nepočítat (aby nedošlo k havárii programu), ale vypsat varovné hlášení.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_03");

            float citatel, jmenovatel;

            Console.WriteLine("Zadej co chceš dělit: ");
            citatel = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej čím chceš dělit: ");
            jmenovatel = float.Parse(Console.ReadLine());
            Console.WriteLine((jmenovatel != 0) ? $"Výsledek je {citatel / jmenovatel}" : "Nulou nedělím...");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
