using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            KompleksniBrojKlasa kbk1 = new KompleksniBrojKlasa(2, 4);

            KompleksniBrojStruktura kbs1 = new KompleksniBrojStruktura(3, 5);
            Console.WriteLine($"kbk1 = {kbk1}");
            Console.WriteLine($"kbs1 = {kbs1}\n");
            KompleksniBrojKlasa kbk2 = kbk1;

            KompleksniBrojStruktura kbs2 = kbs1;

            kbk2.RealniDio = 25;
            kbk2.ImaginarniDio = 30;

            kbs2.RealniDio = 50;
            kbs2.ImaginarniDio = 55;

            Console.WriteLine($"kbk1 = {kbk1}");
            Console.WriteLine($"kbk2 = {kbk2}");
            Console.WriteLine($"kbs1 = {kbs1}");
            Console.WriteLine($"kbs2 = {kbs2}");
            Console.ReadKey(true);
        }
    }
}
