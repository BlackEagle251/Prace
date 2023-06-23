using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_najwiekszyNajmniejszyElementTablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 5, 2, 8, 1, 9, 3, 6, 7, 4 };
            int minWartosc = tablica.Min();
            int maxWartosc = tablica.Max();

            Console.WriteLine("Najmniejszy element: " + minWartosc);
            Console.WriteLine("Największy element: " + maxWartosc);
            Console.ReadLine();
        }
    }
}
