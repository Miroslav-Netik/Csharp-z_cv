using System;

namespace A
{
    internal class Zanamenko
    {
        public static void Mainx(string[] args)
        {
            {
                int i, znamenko;
                Console.WriteLine("Zadej číslo: ");
                i = int.Parse(Console.ReadLine());

                znamenko = 0;
                if (i < 0)
                    znamenko = -1;
                if (i == 0)
                    znamenko = 0;
                if (i > 0)
                    znamenko = 1;
                Console.WriteLine("Znaménko čísla je {0} (-1: zap., 0:nula, 1:klad)", znamenko);
            }
            {
                int[] pole_1 = { 1, 2, 3, 4, 5, };
                foreach (var a in pole_1)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine(pole_1[0]);
            }
            {
                int[] pole_2 = { 1, 2, 3 };
                for (int i = 0; i < pole_2.Length; i++)
                    Console.WriteLine(pole_2[i] + 100);
            }
            {
                string s = "Hello";
                foreach (char ch in s) Console.WriteLine(ch);
            }
            {
                int[] pole_3 = new int[5];
                pole_3[0] = 100;
                pole_3[1] = 1000;

                Array.Sort(pole_3);
                Console.WriteLine("Pozice čísla " + 100 + " je " + Array.BinarySearch(pole_3, 100));
                //Console.WriteLine("Pozice čísla" + cislo + "je" + Array.BinarySearch(pole_2, cislo);
            }
        }

    }
}
