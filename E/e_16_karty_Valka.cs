using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_16_karty_Valka
    {
        /* 'e16) Simulace karetní hry Vojna pro dva hráče a 32 karet (čtyři barvy s hodnotami
        '7 až 14, tedy 7,8,9,10, spodek, svršek, král, eso). Na začátku oba hráči dostanou
        'náhodně šestnáct karet. Na monitoru se zobrazí šestnáct vyložení obou hráčů s informací,
        'kdo dané vyložení vyhrál. Na konci vyhrává ten, který vyhrál nejvíce vyložení.
        'V jednodušší variantě se neřeší vyložení stejných hodnot. V dokonalejší variantě
        'se vykládá ještě jednou, vítěz si pak připíše dvě vítězství. (Dost náročný.)*/

        // Random rnd = new Random();
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_16 Válka");

            int j, karta, hodnotaKarty;
            int remiza = 0, vitez2 = 0, vitez1 = 0;
            string strVitez = "", vypis = "Hráč 1     Hráč 2     Vyhrál hráč\n";
            int[,] poleKaret = new int[16, 2];
            int[] poleBarev = new int[14];

            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    karta = rnd.Next(7, 15);
                    poleBarev[karta] = poleBarev[karta] + 1;

                    if (poleBarev[karta] > 4)
                    {
                        hodnotaKarty = 0;
                        do
                        {
                            karta = rnd.Next(1, 4);
                            hodnotaKarty ++;

                        } while (poleBarev[karta] < 3 || hodnotaKarty >= 8);

                        poleBarev[karta]++;
                    }
                    poleBarev[karta]++;
                }
            }

            for (int i = 0; i <= 15 ; i++)
            {
                if (poleKaret[i, 0] > poleKaret[i, 1])
                {
                    vitez1 = vitez1 + 1 + remiza;
                    vypis += $" {poleKaret[i, 0]}   {}";
                    vypis += $" {poleKaret[i, 0]}   {}";
                }
            }
            /*

            For i = 0 To 15
                If poleKaret(i, 0) > poleKaret(i, 1) Then
                  vitez1 = vitez1 + 1 + remiza
                  vypis = vypis + "  " + Str(poleKaret(i, 0)) + Chr(9) + Str(poleKaret(i, 1)) + Chr(9) + "hrac 1 "
                  remiza = 0
                ElseIf poleKaret(i, 0) < poleKaret(i, 1) Then
                  vitez2 = vitez2 + 1 + remiza
                  vypis = vypis + "  " + Str(poleKaret(i, 0)) + Chr(9) + Str(poleKaret(i, 1)) + Chr(9) + "hrac 2"
                  remiza = 0
                ElseIf poleKaret(i, 0) = poleKaret(i, 1) Then            'pokud nastane remiza, promenna remiza =1 a v dalsim vylozeni karet se pricte tento bod + bod za vyhru vylozeni tomu, ktery toto vylozeni vyhral, vezme tedy i bod za remizu
                  remiza = remiza + 1
                  vypis = vypis + "  " + Str(poleKaret(i, 0)) + Chr(9) + Str(poleKaret(i, 1)) + Chr(9) + "remiza"
                End If
              vypis = vypis + Chr(10)
            Next

            If vitez1 > vitez2 Then
              strVitez = "hru vyhral hrac 1"
            ElseIf vitez1 < vitez2 Then
              strVitez = "hru vyhral hrac 2"
            Else
              strVitez = "hra skoncila remizou"
            End If

            MsgBox vypis + Chr(10) + Chr(10) + "hrac 1 nahral " + Str(vitez1) + " bodu" + Chr(10) + "hrac 2 nahral " + Str(vitez2) + " bodu" + Chr(10) + Chr(10) + strVitez*/

            Console.WriteLine("\nPro ukončení stiskni jakoukoliv klávesu...");
            Console.ReadKey();
        }
    }
}
