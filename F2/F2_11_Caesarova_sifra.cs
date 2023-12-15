using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_11_Caesarova_sifra
    {
        /* 11) Obdoba f1-3 ale pro pole znaků. Tedy funkce má na vstupu pole znaků, které vrátí zašifrované*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem f2_11\n");


            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
    }
    static string[] Sifruj(string[] pole_vstupni, int posun)
    {

        //'Caesarova sifra
        //'Posune zadana velka nebo mala pismena o zadany kladny krok
        //'Sifruje jen písmena, ostatní znaky nechá beze změn
        //'Maxinalni krok 25
        //'V ASCII - velka pismena 65 - 90, mala 97 - 122

        char[] pole_prevodni = new char[pole_vstupni.Length];
        string[] pole_sifrovane = new string[pole_vstupni.Length];
        
        int kod_pismena, korekce, posunuti;

        

        for (int i = 0; i < pole_vstupni.Length; i++)
        {
            kod_pismena = (int)Convert.ToChar(pole_vstupni[i]);
            posunuti = kod_pismena + posun;

            // Pro velká písmena
            if (kod_pismena >= 65 && kod_pismena <= 90)
            {
                // posunuti = kod_pismena + posun;
                if (posunuti >= 90)
                {
                    korekce = posunuti - 90;
                    posunuti = 64 + korekce;
                }
            }
            // Pro malá písmena
            else if (kod_pismena >= 97 && kod_pismena <= 122)
            {
                // posunuti = kod_pismena + posun;
                if (posunuti > 122)
                {
                    korekce = posunuti - 122;
                    posunuti = 96 + korekce;
                }
            }
            else
            {
                posunuti = kod_pismena;
            }
            //pismeno_vystupni = Convert.ToChar(posunuti);
            for (int j = 0; j < pole_vstupni.Length; i++)
            {
                pole_sifrovane[j] = (posunuti).ToString();
            }
        }
        
    }

    /* 

     'Sifruj = Chr(posunuti)
     Return pole_sifrovane
 End Function*/
}
