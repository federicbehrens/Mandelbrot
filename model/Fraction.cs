using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandelbrot.model
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int newNumerator, int newDenominator)
        {
            if (newDenominator == 0)
            {
                //throw new System.DivideByZeroException();                
            }

            numerator = newNumerator;
            denominator = newDenominator;
        }

        public Fraction(Fraction newFraction)
            : this(newFraction.getNumerator(), newFraction.getNumerator())
        { }

        public double getValue()
        {
            if (denominator == 0)
            {
                return 0;
            }

            return (double)numerator / (double)denominator;
        }

        public int getNumerator()
        {
            return numerator;
        }

        public int getDenominator()
        {
            return denominator;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.getNumerator() * f2.getNumerator(), f1.getDenominator() * f2.getDenominator());
        }

        public static Fraction operator *(Fraction f1, int f2)
        {
            return new Fraction(f1.getNumerator() * f2, f1.getDenominator());
        }

        public static Fraction operator *(int f1, Fraction f2)
        {
            return f2 * f1;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            if (f1.getDenominator() == f2.getDenominator())
            {
                return new Fraction(f1.getNumerator() + f2.getNumerator(), f1.getDenominator());
            }
            //gemeinsamen nenner bestimmen
            int newDenominator = f1.getDenominator() * f2.getDenominator();
            //alle auf den gleichen nenner bringen
            int newNumerator1 = f1.getNumerator() * f2.getDenominator();
            int newNumerator2 = f2.getNumerator() * f1.getDenominator();

            return new Fraction(newNumerator1 + newNumerator2, newDenominator);
        }

        public static Fraction operator +(Fraction f1, int f2)
        {
            //alle auf den gleichen nenner bringen
            int newNumerator2 = f2 * f1.getDenominator();

            return new Fraction(f1.getNumerator() + newNumerator2, f1.getDenominator());
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            //gemeinsamen nenner bestimmen
            int newDenominator = f1.getDenominator() * f2.getDenominator();
            //alle auf den gleichen nenner bringen
            int newNumerator1 = f1.getNumerator() * f2.getDenominator();
            int newNumerator2 = f2.getNumerator() * f1.getDenominator();

            return new Fraction(newNumerator1 - newNumerator2, newDenominator);
        }

        public static Fraction operator -(Fraction f1, int f2)
        {
            int newNumerator2 = f2 * f1.getDenominator();

            return new Fraction(f1.getNumerator() - newNumerator2, f1.getDenominator());
        }
    }

    
}
