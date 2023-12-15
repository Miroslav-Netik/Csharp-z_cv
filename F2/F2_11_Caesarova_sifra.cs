using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace F2
{
    internal class F2_11_Caesarova_sifra
    {
        /* 11) Obdoba f1-3 ale pro pole znaků. Tedy funkce má na vstupu pole znaků, které vrátí zašifrované*/
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem f2_11\n");

            char[] pole_znaku_nezasifrovane = new char[50];
            char[] pole_znaku_sifrovanych = new char[50];
            char[] pole_subrutina = new char[50];
            int sifrovaci_krok;
            string vstup_text;
            string txt_zadane_znaky = "";
            string txt_vystup = "";
            string txt_vystup_2 = "";

            Console.WriteLine("Zadej zprávu bez háčků a čára, kterou chceš zašifrovat: ");
            vstup_text = Console.ReadLine();
            Console.WriteLine("Zadej šifrovací krok (1 - 25): ");
            sifrovaci_krok = int.Parse(Console.ReadLine());

            // Naplním pole písmenkama...
            for (int i = 0; i < vstup_text.Length; i++)
            {
                pole_znaku_nezasifrovane[i] = vstup_text[i];
                txt_zadane_znaky += pole_znaku_nezasifrovane[i] + ", ";
            }
            Console.WriteLine(txt_zadane_znaky);

            // Výpis šifrovaného funkcí
            pole_znaku_sifrovanych = Sifruj(pole_znaku_nezasifrovane, sifrovaci_krok);
            for (int i = 0; i < pole_znaku_sifrovanych.Length; i++)
            {
                txt_vystup += pole_znaku_sifrovanych[i];
            }
            Console.WriteLine(txt_vystup);

            // Výpis šifrovaného subrutinou
            S_Sifruj(pole_znaku_nezasifrovane, sifrovaci_krok,ref pole_subrutina);
            for (int i = 0; i < pole_subrutina.Length; i++)
            {
                txt_vystup_2 += pole_subrutina[i];
            }
            Console.WriteLine(txt_vystup_2);

            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
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
        static void S_Sifruj(char[] pole_vstupni, int posun,ref char[] vystup)
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
            vystup = pole_sifrovane;
        }
    }
}
