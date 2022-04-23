using System;

namespace PudelkoLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pudelko pudelko = new Pudelko(unit: UnitOfMeasure.milimeter);
            Pudelko pudelko2 = new Pudelko(200, 100, 150, unit: UnitOfMeasure.milimeter);
            Console.WriteLine("A: " + pudelko.A);
            Console.WriteLine("B: " + pudelko.B);
            Console.WriteLine("C: " + pudelko.C);
            Console.WriteLine(pudelko.ToString());
            Console.WriteLine(pudelko.ToString("cm"));
            Console.WriteLine(pudelko.ToString("mm"));
            Console.WriteLine($"Objestosc: {pudelko.Objetosc}");
            Console.WriteLine($"Pole: {pudelko.Pole}");
            Pudelko pudelko3 = new Pudelko(1, 3.05, 2.1);
            Pudelko pudelko4 = new Pudelko(2100, 1000, 3050, unit: UnitOfMeasure.milimeter);
            Console.WriteLine($"Equals: {pudelko3.Equals(pudelko4)}");
            Console.WriteLine($"HashCode: {pudelko.GetHashCode()}");
            Console.WriteLine($"Wymiary pudelka na pudelko1 i pudelko2:  {(pudelko + pudelko2).ToString()}");
            double[] result = pudelko.ConvertToArray(pudelko);
            Console.Write($"Explicit: ");
            foreach (var item in result)
            {
                Console.Write($" {item}");
            }            


        }
    }
}
