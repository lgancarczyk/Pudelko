using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pudelko.IPudelko;

namespace Pudelko
{
    public sealed class Pudelko
    {
        //Basic box properties
        private UnitOfMeasure Unit { get; set; }
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        //Box properties taht has to be counted
        public double Objetosc => Math.Round(A * B * C, 9);

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

        public override string ToString() 
        {
            return $"{A:0.000} m \u00D7 {B:0.000} m \u00D7 {C:0.000} m";
        }
        public string ToString(string format)
        {
            switch (format)
            {
                case("m"):
                    return ToString();
                case ("cm"):
                    return $"{(A*100):0.0} cm \u00D7 {(B*100):0.0} cm \u00D7 {(C*100):0.0} cm";
                case ("mm"):
                    return $"{(A * 1000):0} mm \u00D7 {(B * 1000):0} mm \u00D7 {(C * 1000):0} mm";
                default:
                    throw new FormatException();

            }
        }

    }
}
