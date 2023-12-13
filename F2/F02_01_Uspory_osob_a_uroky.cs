using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F02_01_Uspory_osob_a_uroky
    {
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F02_01");

            double[] pole_uspor = new double[100];
            double zadana_uspora, zadany_urok;
            int pocitadlo = 0;
            string txt_vystup = "", txt_vystup_z_pole = "";

            Console.WriteLine("Zadej úrok: ");
            zadany_urok = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej uspořenou částku (0 pro konec): ");
            zadana_uspora = double.Parse(Console.ReadLine());

            while (zadana_uspora != 0) // Naplní pole
            {
                pole_uspor[pocitadlo] = zadana_uspora;
                pocitadlo++;
                Console.WriteLine("Zadej uspořenou částku (0 pro konec): ");
                zadana_uspora = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j < pocitadlo; j++) // Vypíše obsah pole
            {
                txt_vystup += $"{pole_uspor[j]}, ";
            }
            Console.WriteLine(txt_vystup);

            double[] pole_urokovane = F_SpoctiUrok(pole_uspor, zadany_urok); // Volá funkci uročení
            for (int j = 0; j < pocitadlo; j++) // Vypíše  obsah úročeného pole funkcí
            {
                txt_vystup_z_pole += $"{pole_urokovane[j]}, ";
            }
            Console.WriteLine($"Funkce - > {txt_vystup_z_pole}");

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static double[] F_SpoctiUrok(double[] pole, double urok)
        {
            double[] vnitrni_pole = new double[pole.Length];
            double odkladaci, prepocet_uroku;

            prepocet_uroku = urok / 100;

            for (int i = 0; i < pole.Length; i++)
            {
                odkladaci = pole[i] + pole[i] * prepocet_uroku;
                vnitrni_pole[i] = odkladaci;
            }
            return vnitrni_pole;
        }
       
    }
}
