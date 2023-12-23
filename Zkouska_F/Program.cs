using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkouska_F
{
    internal class Program
    {
        /* f) Napište funkci, která má na vstupu pole znaků a vrátí pole, do kterého ze vstupního pole překopíruje 
          pouze ty znaky, které jsou číslicemi (na místa ostatních znaků dát vždy např. hvězdičku).
        Případné změny vstupního pole uvnitř funkce se nesmí v hlavním programu projevit
        (tedy vstupní pole musí po skončení funkce nadále obsahovat i nečíselné znaky). Na konci programu tedy vypište nejen nové pole, ale i původní pole vypište, aby se ověřilo, že je funkce nezměnila.
        Potom přepracujte na subrutinu (neplatí pro zkoušku z Javy).
        V hlavním programu musí být použity jiné názvy proměnných než v subrutině či funkci. 
        Vstupy a výstupy budou v hlavním programu. Funkce musí fungovat dobře i v případě,
        že se v hlavním programu změní rozměr pole.*/
        static void Main(string[] args)
        {
            char[] vstupniPole = new char[5];
            char[] s_upravenePole = new char[5];

            Console.WriteLine("Zadejte 5 znaků:");
            for (int i = 0; i < vstupniPole.Length; i++)
            {
                vstupniPole[i] = Convert.ToChar(Console.ReadLine());
            }

            char[] upravenePole = UpravPole(vstupniPole);
            S_UpravPole(vstupniPole, ref s_upravenePole);

            Console.WriteLine("Původní pole: ");
            for (int i = 0; i < vstupniPole.Length; i++)
            {
                Console.Write(vstupniPole[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Zpracované pole: ");
            for (int i = 0; i < upravenePole.Length; i++)
            {
                Console.Write("Fumkce " + upravenePole[i] + " ");
                Console.WriteLine("Subrutina " + s_upravenePole[i] + "");
            }

            Console.WriteLine("Původní pole: \n");
            for (int i = 0; i < upravenePole.Length; i++)
            {
                Console.Write(vstupniPole[i] + " ");

            }

            Console.WriteLine("\nPro ukončení stiskni jakoukoliv klávesu...");
            Console.ReadKey();
        }
        static char[] UpravPole(char[] vstupPole)
        {
            char[] novePole = new char[vstupPole.Length];
            for (int i = 0; i < vstupPole.Length; i++)
            {
                if (Char.IsDigit(vstupPole[i]))
                {
                    novePole[i] = vstupPole[i];
                }
                else
                {
                    novePole[i] = '*';
                }
            }
            return novePole;
        }
        static void S_UpravPole(char[] vstupPole, ref char[] novePole)
        {
            novePole = new char[vstupPole.Length];
            for (int i = 0; i < vstupPole.Length; i++)
            {
                if (Char.IsDigit(vstupPole[i]))
                {
                    novePole[i] = vstupPole[i];
                }
                else
                {
                    novePole[i] = '*';
                }
            }
        }
    }
}
