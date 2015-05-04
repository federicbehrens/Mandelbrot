using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Mandelbrot.model
{
    class ComplexNumber
    {
        private Fraction r;
        private Fraction i;

        public ComplexNumber(Fraction realPart, Fraction imaginaryPart)
        {
            r = realPart;
            i = imaginaryPart;
        }

        public ComplexNumber(int realPart, int imaginaryPart) 
            : this(new Fraction(realPart, 1), new Fraction(imaginaryPart, 1))
        { }

        public Fraction getRealPart()
        {
            return r;
        }

        public Fraction getImaginaryPart()
        {
            return i;
        }

        public double getAbsoluteValue()
        {
            Fraction addedFraction;

            if (r.getNumerator() == 0)
            {
                addedFraction = i;
            }
            else if (i.getNumerator() == 0)
            {
                addedFraction = r;
            }
            else
            {
                Fraction rSquare = new Fraction(r.getNumerator() * r.getNumerator(), r.getDenominator() * r.getDenominator());//new Fraction(r*r);
                Fraction iSquare = new Fraction(i * i);
                addedFraction = rSquare + iSquare;
            
            }

            double returnValue = Math.Sqrt(addedFraction.getNumerator()) / Math.Sqrt(addedFraction.getDenominator());

            return returnValue;
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            /** 
             * c1 * c2 = (r1 + i1)(r2 + i2) = r1*r2 + r1*i2 + r2*i1 + i1*i2
             * 
             * r = r1*r2 - i1*i2 ( weil i*i = -1)
             * i = r1*i2 + r2*i1
            **/

            //r = r1*r2 - i1*i2 ( weil i*i = -1)
            Fraction rFraction = (c1.getRealPart() * c2.getRealPart()) - (c1.getImaginaryPart() * c2.getImaginaryPart());
            //i = r1*i2 + r2*i1
            Fraction iFraction = (c1.getRealPart() * c2.getImaginaryPart()) + (c2.getRealPart() * c1.getImaginaryPart());

            ComplexNumber returnValue = new ComplexNumber(rFraction, iFraction);
            return returnValue;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            
            return new ComplexNumber(c1.getRealPart() + c2.getRealPart(), c1.getImaginaryPart() + c2.getImaginaryPart());
        }
    }
}
