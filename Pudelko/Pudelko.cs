using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pudelko.IPudelko;

namespace Pudelko
{
    class Pudelko : IPudelko
    {
        private UnitOfMeasure Unit { get; set; }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        
        public Pudelko(double? a = null, double? b = null, double? c = null, UnitOfMeasure unit = UnitOfMeasure.meter)
        {

            this.A = a == null ? 0.1 : ConvertToMeter((double)a, unit);
            this.B = b == null ? 0.1 : ConvertToMeter((double)b, unit);
            this.C = c == null ? 0.1 : ConvertToMeter((double)c, unit);
            this.Unit = unit;

            if (IsProperWithGuidelines() == false)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        private double ConvertToMeter(double value, UnitOfMeasure unit) 
        {
            switch (unit)
            {
                case UnitOfMeasure.milimeter:
                    return value / 1000;
                case UnitOfMeasure.centimeter:
                    return value / 100;
                default:
                    return value;
            }
        }
        
        //egde must be shorter than 10 meters
        //egde lenght must be positive
        private bool IsProperWithGuidelines() 
        {
            if ( A <=0 || B <=0 || C<=0 || A>10 || B>10 || C>10 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
