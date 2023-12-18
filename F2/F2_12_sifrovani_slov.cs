using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class F2_12_sifrovani_slov
    {
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem F02_12");

            string[] pole_znaku_nezasifrovane = new string[50];
            string[] pole_znaku_sifrovanych = new string[50];
            char[] pole_subrutina = new char[50];
            int pocitadlo = 0;
            int sifrovaci_krok;
            string vstup_text;
            string txt_zadane_znaky = "";
            string txt_vystup = "";
           
            int i = 0;

            Console.WriteLine("Zadej jednotlivá slova bez háčků a čárek," +
                " která chceš zašifrovat (0 ukončuje zadávání): ");
            vstup_text = Console.ReadLine();
           
            

            // Naplním pole slovy...
            do
            {
                pole_znaku_nezasifrovane[i] = vstup_text;
                txt_zadane_znaky += pole_znaku_nezasifrovane[i] + ", ";
                i++;
                pocitadlo++;
                vstup_text = Console.ReadLine();
            } while (vstup_text != "0");
            Console.WriteLine("Zadej šifrovací krok (1 - 25): ");
            sifrovaci_krok = int.Parse(Console.ReadLine());

            Console.WriteLine(txt_zadane_znaky);

            // Výpis šifrovaného funkcí
            pole_znaku_sifrovanych = SifrujSlova(pole_znaku_nezasifrovane, sifrovaci_krok, pocitadlo);
            for (int j = 0; j < pole_znaku_sifrovanych.Length; j++)
            {
                txt_vystup += pole_znaku_sifrovanych[j] + "\n";
            }
            Console.WriteLine();
            Console.WriteLine(txt_vystup);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
        static string[] SifrujSlova(string[] pole_vstupni, int posun, int pocet_slov)
        {
            
            string[] pole_sifrovanych_slov = new string[pocet_slov];
            //char[] pole_pismenek = new char[1000];
            string sifrovane_slovo = "";
            string slovo = "";
            for (int i = 0; i < pocet_slov; i++)
            {
                slovo = pole_vstupni[i];
                if (slovo != null)
                {
                    char[] pole_pismenek = new char[slovo.Length];
                    for (int j = 0; j < slovo.Length; j++)
                    {
                        pole_pismenek[j] = Convert.ToChar(slovo[j]);
                    }
                    char[] pole_zasifrovanych_pismenek = new char[slovo.Length];
                    pole_zasifrovanych_pismenek = Sifruj(pole_pismenek, posun);
                    for (int k = 0; k < pole_pismenek.Length; k++)
                    {
                        sifrovane_slovo += pole_zasifrovanych_pismenek[k];
                    }
                    pole_sifrovanych_slov[i] = sifrovane_slovo;
                    sifrovane_slovo = "";

                }
                
            }
            return pole_sifrovanych_slov;
        }
        static char[] Sifruj(char[] pole_vstupni, int posun)
        {
            //'Caesarova sifra
            //'Posune zadana velka nebo mala pismena o zadany kladny krok
            //'Sifruje jen písmena, ostatní znaky nechá beze změn
            //'Maxinalni krok 25
            //'V ASCII - velka pismena 65 - 90, mala 97 - 122

            char[] pole_sifrovane = new char[pole_vstupni.Length];
            int kod_pismena, korekce, posunuti;

            for (int i = 0; i < pole_vstupni.Length; i++)
            {
                //kod_pismena = (int)Convert.ToChar(pole_vstupni[i]);
                kod_pismena = (int)pole_vstupni[i];
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
                pole_sifrovane[i] = (char)posunuti;
            }
            return pole_sifrovane;
        }
    }
}
