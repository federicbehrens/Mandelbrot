using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandelbrot.model
{
    class Point
    {
        private double r;
        private double i;

        /**
         * Beschreibt eine Koordinate in einem Koordinatensystem
         * 
         * @args 
         *  double real   Realteil der Koordinate (x)
         *  double img   Imaginärteil der Koordinate (y)
         **/
        public Point(double real, double img)
        {
            r = real;
            i = img;
        }

        public double getRealKoordinate()
        {
            return r;
        }

        public double getImaginaryKoordinate()
        {
            return i;
        }
    }
}
