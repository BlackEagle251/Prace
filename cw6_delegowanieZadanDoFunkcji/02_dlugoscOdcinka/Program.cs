using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_dlugoscOdcinka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.5;
            double y1 = 1.3;
            double x2 = 5.7;
            double y2 = 7.9;

            double dlugosc = przeliczDystans(x1, y1, x2, y2);
            Console.WriteLine($"Długość odcinka: {dlugosc}");
            Console.Read();
        }

        static double przeliczDystans(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            double dystans = Math.Sqrt(dx * dx + dy * dy);
            return dystans;
        }
    }
}
