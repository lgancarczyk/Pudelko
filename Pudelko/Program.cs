﻿using System;
using static Pudelko.IPudelko;

namespace Pudelko
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko pudelko = new Pudelko( unit: UnitOfMeasure.milimeter);
            //Pudelko pudelko2 = new Pudelko();
            Console.WriteLine("A: " + pudelko.A);
            Console.WriteLine("B: " + pudelko.B);
            Console.WriteLine("C: " + pudelko.C);
            Console.WriteLine(pudelko.ToString());
            Console.WriteLine(pudelko.ToString("cm"));
            Console.WriteLine(pudelko.ToString("mm"));
            Console.WriteLine($"Objestosc: {pudelko.Objetosc}");
            Console.WriteLine($"Pole: {pudelko.Pole}");
        }
    }
}
