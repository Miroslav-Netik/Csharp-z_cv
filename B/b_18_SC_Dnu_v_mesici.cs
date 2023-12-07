using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_18_SC_Dnu_v_mesici
    {
        //b_18) Zadejte číslo měsíce (1 až 12). Program vypíše, kolik má měsíc dní (únor má zjednodušeně 28 dní). Proveďte pomocí if i case.
        //'01-31/ 02-28/ 03-31/ 04-30/ 05-31/ 06-30/ 07-31/ 08-31/ 09-30/ 10-31/ 11-30/ 12-31
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_18");

            int volba;
            string txt_mesic;

            Console.WriteLine("Zadej číslo měsíce: ");
            volba = int.Parse(Console.ReadLine());
            switch (volba)
            {
                case 1:
                    {
                        txt_mesic = "Leden má 31 dnů.";
                    }
                    break;
                case 2:
                    {
                        txt_mesic = "Únor ma 28 dnů.";
                    }
                    break;
                case 3:
                    {
                        txt_mesic = "Březen má 31 dnů.";
                    }
                    break;
                case 4:
                    {
                        txt_mesic = "Duben má 30 dnů.";
                    }
                    break;
                case 5:
                    {
                        txt_mesic = "Květen má 31 dnů.";
                    }
                    break;
                case 6:
                    {
                        txt_mesic = "Červen má 30 dnů.";
                    }
                    break;
                case 7:
                    {
                        txt_mesic = "Červenec má 31 dnů.";
                    }
                    break;
                case 8:
                    {
                        txt_mesic = "Srpen má 31 dnů.";
                    }
                    break;
                case 9:
                    {
                        txt_mesic = "Září má 30 dnů.";
                    }
                    break;
                case 10:
                    {
                        txt_mesic = "Říjen má 31 dnů.";
                    }
                    break;
                case 11:
                    {
                        txt_mesic = "Listopad má 30 dnů.";
                    }
                    break;
                case 12:
                    {
                        txt_mesic = "Prosinec má 31 dnů.";
                    }
                    break;
                default:
                    {
                        txt_mesic = "Fakt nevím...";
                    }
                    break;
            }
            Console.WriteLine(txt_mesic);

            Console.WriteLine("Zmáčkni Enter...");
            Console.ReadLine();
        }
    }
}
