using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_romb
{
    class Program
    {
        static void Main()
        {
            int podejscia = 0;
            int wysokosc = 0;

            while (podejscia < 3)
            {
                Console.WriteLine("Podaj nieparzystą wysokość rombu (większą lub równą 3):");
                wysokosc = Convert.ToInt32(Console.ReadLine());

                if (wysokosc >= 3 && wysokosc % 2 != 0)
                    break;

                podejscia++;
                

                

            }

            if (podejscia == 3)
            {
                Console.WriteLine("Podano nieprawidłową wartość trzy razy. Zakończono program");
                Console.ReadKey();
                return;

            }

            char borderChar = GetRandomChar(new char[] { '#', '@', '|', '*' });
            char innerChar = GetRandomChar(new char[] { '.', ':', '-', '+' });

            int polWysokosc = wysokosc / 2;

            for (int i = 0; i < wysokosc; i++)
            {
                int spacje = Math.Abs(polWysokosc - i);
                int chars = wysokosc - 2 * spacje;

                for (int j = 0; j < spacje; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < chars; j++)
                {
                    if (j == 0 || j == chars - 1 || i == 0 || i == wysokosc - 1)
                        Console.WriteLine(borderChar);
                    else
                        Console.Write(innerChar);
                }
                
                Console.WriteLine();

            }

            Console.ReadKey();

        }
        static char GetRandomChar(char[] chars)
        {
            Random random = new Random();
            int index = random.Next(chars.Length);
            return chars[index];
        }
    }
}
