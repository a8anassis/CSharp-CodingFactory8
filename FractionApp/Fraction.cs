using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    internal class Fraction : IComparable<Fraction>
    {

        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator = 1)
        {
            if (Denominator == 0) 
                throw new DivideByZeroException("Denominator cannot be zero");

            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0) throw new DivideByZeroException("Cannot divide by zero fraction");
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static bool operator ==(Fraction? a, Fraction? b)
        {
            if (a is null) return b is null;
            return a.Equals(b);
        }

        public static bool operator !=(Fraction? a, Fraction? b) => !(a == b);
        
        public static bool operator <(Fraction a, Fraction b) => a.CompareTo(b) < 0;
        public static bool operator >(Fraction a, Fraction b) => a.CompareTo(b) > 0;
        public static bool operator <=(Fraction a, Fraction b) => a.CompareTo(b) <= 0;
        public static bool operator >=(Fraction a, Fraction b) => a.CompareTo(b) >= 0;

        public int CompareTo(Fraction? other)
        {
            if (other is null) return 1;
            int left = Numerator * other.Denominator;
            int right = Denominator * other.Numerator;
            return left.CompareTo(right);
        }

        public override bool Equals(object? obj)
        {
            return obj is Fraction fraction &&
                   Numerator == fraction.Numerator &&
                   Denominator == fraction.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }
    }
}
