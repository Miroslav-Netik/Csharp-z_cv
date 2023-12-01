using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    internal class Hello
    {
        public static void Mainx(string[] args)
        {
            char znak = 'a';
            Console.WriteLine("Ahoj lidi...");
            Console.WriteLine(znak);
            Console.WriteLine((int)znak);   //operátor přetypování je uzavřen v závorkách
            Console.WriteLine((char)97);
            Console.ReadLine();
        }
    }
}
