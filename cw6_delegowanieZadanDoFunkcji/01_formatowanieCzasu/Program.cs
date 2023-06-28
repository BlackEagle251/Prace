using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_formatowanieCzasu
{
    class Program
    {
        static void Main(string[] args)
        {
            int czas = 332;
            string ustawionyCzas = formatCzasu(czas);
            Console.WriteLine(ustawionyCzas); // Wyjście 00:05:32
            Console.Read();
        }

        static string formatCzasu(int czas)
        {
            int godzina = czas / 3600;
            int minuta = czas % 3600 / 60;
            int sekunda = czas % 60;

            return $"{ godzina: 00}:{ minuta: 00}:{ sekunda:00}";
        }
    }
}
