using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pudelko
{
    class Pudelko : IPudelko
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        public Pudelko(double a= 0.1, double b = 0.1, double c = 0.1, IPudelko.UnitOfMeasure unit = IPudelko.UnitOfMeasure.centimeter)
        {
            switch (unit)
            {
                case IPudelko.UnitOfMeasure.milimeter:
                    this.A = a * 1000;
                    this.B = b * 1000;
                    this.C = c * 1000;
                    break;
                case IPudelko.UnitOfMeasure.centimeter:
                    this.A = a * 100;
                    this.B = b * 100;
                    this.C = c * 100;
                    break;
                case IPudelko.UnitOfMeasure.meter:
                    this.A = a;
                    this.B = b;
                    this.C = c;
                    break;
                default:
                    this.A = a * 100;
                    this.B = b * 100;
                    this.C = c * 100;
                    break;
            }

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
