using System;

namespace B
{
    internal class b_04_Nejvetsi_nejmensi
    {
        //Zadejte tři čísla, počítač zjistí,
        //které je největší a které nejmenší.
        //Aby program nebyl příliš dlouhý,
        //tak nemusíte uvažovat případy,
        //že by nějaká dvě čísla byla stejně velká.
        public static void Mainx(string[] args)
        {
            Console.WriteLine("Jsem b_04");
            float prvni_cislo, druhe_cislo, treti_cislo, max, min;

            Console.WriteLine("Zadej první číslo: ");
            prvni_cislo = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej druhé číslo: ");
            druhe_cislo = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadej třetí číslo: ");
            treti_cislo = float.Parse(Console.ReadLine());
            max = prvni_cislo;
            min = prvni_cislo;
            if (druhe_cislo > max)
            {
                max = druhe_cislo;
            }
            if (treti_cislo > max)
            {
                max = treti_cislo;
            }
            if (druhe_cislo < min)
            {
                min = druhe_cislo;
            }
            if (treti_cislo < min)
            {
                min = treti_cislo;
            }
            Console.WriteLine($"Nejmenší je {min}, největší je {max}");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
