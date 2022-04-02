using System;
using static Pudelko.IPudelko;

namespace Pudelko
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko pudelko = new Pudelko(a:1, unit: UnitOfMeasure.milimeter);
            //Pudelko pudelko2 = new Pudelko();
            Console.WriteLine(pudelko.A);
            Console.WriteLine(pudelko.B);
            Console.WriteLine(pudelko.C);
            Console.WriteLine(pudelko.ToString() ); 
        }
    }
}
