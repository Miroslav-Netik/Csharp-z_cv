using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E
{
    internal class e_15_Prevod_do_morseovky
    {
        /* 15] Uživatel zadá několik slov [bez diakritiky]. Program zapíše tento text v Morseově abecedě.
        //Oddělovačem znaků bude lomítko. zadat všechna slova do jednoho inputboxu, oddělená normálně mezerami.
        //A mezera se překládá taky jako lomítko. Tedy na hranicích slov budou vlastně dvě lomítka.- [Nutná znalost Morseovy abecedy]. */
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem e_15\n");

            string[] pole_morseovky = new string[26];
            string txt_vystup, txt_zadani, zadane_pismeno;
            string prelozene_pismeno;

            pole_morseovky[0] = ".-"; // A
            pole_morseovky[1] = "-..."; // B
            pole_morseovky[2] = "-.-."; // C
            pole_morseovky[3] = "-.."; //D
            pole_morseovky[4] = "."; //E
            pole_morseovky[5] = "..-."; //F
            pole_morseovky[6] = "--."; //G
            pole_morseovky[7] = "...."; //H
            pole_morseovky[8] = ".."; //I
            pole_morseovky[9] = ".---"; //J
            pole_morseovky[10] = "-.-"; //K
            pole_morseovky[11] = ".-.."; //L
            pole_morseovky[12] = "--"; //M
            pole_morseovky[13] = "-."; //N
            pole_morseovky[14] = "---"; //O
            pole_morseovky[15] = ".--."; //P
            pole_morseovky[16] = "--.-"; //Q
            pole_morseovky[17] = ".-."; //R
            pole_morseovky[18] = "..."; //S
            pole_morseovky[19] = "-"; //T
            pole_morseovky[20] = "..-"; //U
            pole_morseovky[21] = "...-"; //V
            pole_morseovky[22] = ".--"; //W
            pole_morseovky[23] = "-..-"; //X
            pole_morseovky[24] = "-.--"; //Y
            pole_morseovky[25] = "--.."; //Z

            prelozene_pismeno = "";
            txt_vystup = "";

            Console.WriteLine("Zadej text pro převod do morseovky: ");
            txt_zadani =  Console.ReadLine().ToUpper();

            Console.WriteLine(txt_zadani);

            for (int i = 0; i < txt_zadani.Length; i++)
            {

            }

              
              //Rozdělení slova na znaky oddělené "/" a nahrazení mezery za "/"
              For i = 1 To Len[txt_zadani]
                  zadane_pismeno = Mid[txt_zadani, i, 1]
                  If zadane_pismeno = " " Then
                      prelozene_pismeno = "/"
                  Else
                      //Platí pro velká písmena, pro malá, pokud bych je nechal by bylo -97
                      prelozene_pismeno = pole_morseovky[Asc[zadane_pismeno] - 65] + "/"
                  End If
                  txt_vystup += prelozene_pismeno

              Next

              MsgBox[txt_vystup]*/


            Console.WriteLine("\nStiskni cokoliv...");
            Console.ReadKey();
        }
    }
}

