using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_17_SC_Kurz_smena_penez
    {
        //'b_17) Zadejte částku v Kč a pak si z nabídky vyberte měnu, na kterou chcete směnit
        //(např. DEM, USD, FRF atd.). Počítač přepočítá částku na tuto měnu.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_17_Tezsi");

            double zadana_castka, vystupni_castka;
            int volba = 0;
            string txt_prevod = "";

            Console.WriteLine("Zadej částku v korunách: ");
            zadana_castka = double.Parse(Console.ReadLine());
            Console.WriteLine("Na jakou měnu chceš převádět?:" +
                            "\n1 - EUR" +
                            "\n2 - USD" +
                            "\n3 - FRF");
            volba = int.Parse(Console.ReadLine());
            switch(volba)
            {
                case 1:
                    {
                        vystupni_castka = zadana_castka / 24;
                        txt_prevod = $"{vystupni_castka} EUR";
                    }break;
                case 2:
                    {
                        vystupni_castka = zadana_castka / 26;
                        txt_prevod = $"{vystupni_castka} USD";
                    }break;
                case 3:
                    {
                        vystupni_castka = zadana_castka / 30;
                        txt_prevod = $"{vystupni_castka} FRF";
                    }break;

            }
            Console.WriteLine(txt_prevod);

            Console.WriteLine("Zmáčkni Enter...");
            Console.ReadLine();
        }
    }
}
