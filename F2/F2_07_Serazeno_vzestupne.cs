using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_07_Serazeno_vzestupne
    {
        /*F2 -  7) Sestavte program, který nejprve čte řadu čísel ukončených nulou, která už do řady nepatří. Pole se předá funkci,
        'která sdělí (boolean), zda jsou čísla seřazena vzestupně. Tedy každé další číslo je větší než předchozí.
        ''Čili stačí jeden jediný pokles a už to není pravda.*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F2_07\n");

            double[] pole_cisel = new double[100];
            double vstup_zadani_cisla;
            int pocitadlo = 0;
            string txt_vystup = "";
            string txt_vystup_plati = "";

            Console.WriteLine("Zadej číslo (0 pro ukončení): ");
            vstup_zadani_cisla = double.Parse(Console.ReadLine());

            while (vstup_zadani_cisla != 0)
            {
                pole_cisel[pocitadlo] = vstup_zadani_cisla;
                txt_vystup += pole_cisel[pocitadlo] + ", ";
                pocitadlo++;
                vstup_zadani_cisla = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(txt_vystup);

            if (F_Vzestupne(pole_cisel) == true)
            {
                Console.WriteLine("Čísla jsou vzesupně.");
            }
            else
            {
                Console.WriteLine("Ťak ne. Čísla nejsou vzestupně...");
            }

            /*

            If Vzestupne(pole_cisel) Then
                txt_vystup_plati = "Čísla jsou řazena vzestupně."
            Else
                txt_vystup_plati = "Čísla nejsou vzestupně."
            End If

            MsgBox(txt_vystup + Chr(10) + txt_vystup_plati)*/

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static bool F_Vzestupne(double[] pole_vstup)
        {
            //Jakmile je cislo nasledujici cislo v poli
            //vetsi nebo rovno predchozimu, je podmínka false

            for (int i = 0; i < pole_vstup.Length - 1; i++)
            {
                if (pole_vstup[i + 1] != 0)
                {
                    if (pole_vstup[i + 1] <= pole_vstup[i])
                    {
                        return false;
                    }
                }      
            }
            return true;
            
          
        }
    }
}
