using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    internal class b_02_Delitelnost_x_y
    {
        //b2) Zadejte dvě celá čísla x a y. Zjistěte, zda číslo x
        //je beze zbytku dělitelné číslem y
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_02.");

            int operand_1, operand_2;

            Console.WriteLine("Zadej první číslo: ");
            operand_1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo: ");
            operand_2 =int.Parse(Console.ReadLine());

            if (operand_1 % operand_2 == 0) 
            {
                Console.WriteLine("Je dělitelné beze zbytku...");
            }
            else
            {
                Console.WriteLine("Není dělitelné beze zbytku...");
            }

            Console.WriteLine("Press enter...");
            Console.ReadLine();
        }
    }
}
