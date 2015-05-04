using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandelbrot.controller
{
    class Database
    {
        int testCounter = 25;
        /**
         *  Beschreibt die Schnittstelle zur Datenbank
         *  
         *  Liest und beschreibt die Datenbank
         * 
         **/
        public Database()
        {
            //Datenbank initialisieren
        }

        /**
         * Schreibt einen neuen Datensatz in die Datenbank
         * 
         * @args 
         **/
        public void writeData(int newIterationStep, model.Point newPoint)
        {
        }

        public Dataset readData(model.Point newPoint)
        {
            //read Data at Point
            //return... iterationstep?
            return null;
        }

        internal int getIterationCountForPoint(int x, int y)
        {
            testCounter++;
            if (testCounter > 64)
            {
                testCounter = 0;
            }
            return testCounter;
        }
    }
}
