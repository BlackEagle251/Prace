using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _1_typyWyliczeniowe
{
    // Typ wyliczeniowy dla dni tygodnia
    enum dniTygodnia
    {
        [Description("Poniedzialek")]
        Poniedzialek,
        [Description("Wtorek")]
        Wtorek,
        [Description("Sroda")]
        Sroda,
        [Description("Czwartek")]
        Czwartek,
        [Description("Piatek")]
        Piatek,
        [Description("Sobota")]
        Sobota,
        [Description("Niedziela")]
        Niedziela
    }

    // Typ wyliczeniowy dla etapów prania w pralce automatycznej
    enum etapPrania
    {
        [Description("Pranie")]
        Pranie,
        [Description("Plukanie")]
        Plukanie,
        [Description("Wirowanie")]
        Wirowanie,
        [Description("Suszenie")]
        Suszenie
    }

    // Typ Wyliczeniowy dla posiłków w ciągu dnia
    enum posilek
    {
        [Description("Sniadanie")]
        Sniadanie,
        [Description("Obiad")]
        Obiad,
        [Description("Kolacja")]
        Kolacja,
        [Description("Przekaska")]
        Przekaska

    }

    //Typ wyliczeniowy dla bierków szachowych
    enum bierkiSzachowe
    {
        [Description("Krol")]
        Krol,
        [Description("Krolowa")]
        Krolowa,
        [Description("Wieza")]
        Wieza,
        [Description("Goniec")]
        Goniec,
        [Description("Skoczek")]
        Skoczek,
        [Description("Pionek")]
        Pionek
    }
    class Program
    {
        static void Main(string[] args)
        {
            dniTygodnia dzisiaj = dniTygodnia.Poniedzialek;
            Console.WriteLine($"Dzisiaj jest {dzisiaj}");

            etapPrania etap = etapPrania.Pranie;
            Console.WriteLine($"Bieżący etap prania: {etap}");

            posilek mojPosilek = posilek.Obiad;
            Console.WriteLine($"Obecnie mam {mojPosilek}");

            bierkiSzachowe bierek = bierkiSzachowe.Goniec;
            Console.WriteLine($"Bierek szachowy: {bierek}");

            Console.Read();


        }
    }
}
