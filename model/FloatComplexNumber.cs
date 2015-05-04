using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandelbrot.model
{
    class FloatComplexNumber
    {

        double realPart;
        double imaginaryPart;

        public FloatComplexNumber(double real, double imaginary)
        {
            realPart = real;
            imaginaryPart = imaginary;
        }

        public double getRealPart()
        {
            return realPart;
        }

        public double getimaginaryPart()
        {
            return imaginaryPart;
        }

        public static FloatComplexNumber operator *(FloatComplexNumber f1, FloatComplexNumber f2)
        {
            /** 
             * c1 * c2 = (r1 + i1)(r2 + i2) = r1*r2 + r1*i2 + r2*i1 + i1*i2
             * 
             * r = r1*r2 - i1*i2 ( weil i*i = -1)
             * i = r1*i2 + r2*i1
            **/

            double rPart1 = f1.getRealPart() * f2.getRealPart();
            double rPart2 = f1.getimaginaryPart() * f2.getimaginaryPart();
            double rPart = rPart1 - rPart2;

            double iPart1 = f1.getRealPart() * f2.getimaginaryPart();
            double iPart2 = f2.getRealPart() * f1.getimaginaryPart();
            double iPart = iPart1 + iPart2;

            return new FloatComplexNumber(rPart,iPart);
        }

        public static FloatComplexNumber operator +(FloatComplexNumber f1, FloatComplexNumber f2)
        {

            double rPart = f1.getRealPart() + f2.getRealPart();
            double iPart = f1.getimaginaryPart() + f2.getimaginaryPart();

            return new FloatComplexNumber(rPart, iPart);
        }

        internal double getAbsoluteValue()
        {
            double returnValue = (realPart * realPart) + (imaginaryPart * imaginaryPart);
            returnValue = Math.Sqrt(returnValue);

            return returnValue;
        }
    }
}
