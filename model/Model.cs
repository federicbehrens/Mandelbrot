using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Mandelbrot.model
{
    class Model
    {
        private controller.Database myDatabase;

        //Die vom User bestimmte Maximale anzahl der Berechnungen von einem Punkt (Maximales n)
        private int maxIterations;

        //Maximal und Minimalwerte des Koordinatensystems
        private double maxX;
        private double minX;
        private double maxY;
        private double minY;

        private double xLength;
        private double yLength;
        
        private int showPanelLength;
        private int showPanelHeight;

        /**
         * In dieser Klasse werden alle notwendigen Berechnungen durchgeführt
         * 
         * newShowPanelLength, newShowPanelHeight gibt die Größe des angezeigten Bildes an
         **/
        public Model(int newShowPanelLength, int newShowPanelHeight)
        {
            myDatabase = new controller.Database();

            showPanelLength = newShowPanelLength;
            showPanelHeight = newShowPanelHeight;

            maxIterations = 50;

            maxX = 1;
            minX = -2;
            maxY = 1.5;
            minY = -1.5;

            calculateSteps();

        }

        private void calculateSteps()
        {
            //Absolute längen des Koordinatensystems ermitteln
            xLength = maxX - minX;
            yLength = maxY - minY;

//            xCoordStep = new Fraction(xLength, showPanelLength);
//            yCoordStep = new Fraction(yLength, showPanelHeight);
        }

        internal Color getColorAtPoint(int x, int y)
        {

            calculateSteps();

            Color returnColor = Color.White;

            //z0 = 0

            FloatComplexNumber z = new FloatComplexNumber(0,0);

            double rPart = minX + (x * xLength)/showPanelLength;
            double iPart = maxY - (y * yLength)/showPanelHeight;

            FloatComplexNumber c = new FloatComplexNumber(rPart,iPart);

            /**
            ComplexNumber z = new ComplexNumber(new Fraction(0, 1), new Fraction(0, 1));

            Fraction rFraction = new Fraction(showPanelLength * minX, showPanelLength);

            Fraction iFraction = new Fraction(showPanelHeight * maxY, showPanelHeight);

            ComplexNumber c = new ComplexNumber(rFraction, iFraction);

            **/

            int iterationCounter = recursiveCalculation(z, 0, c);

            if (iterationCounter >= maxIterations)
            {
                returnColor = Color.Black;
            }
            else
            {
                /**
                 *  TODO
                 *  Auslagern!!! rechnungen wenn möglich nur einmal! (Diese methode wird bei jeder koordinate aufgerufen)
                 **/

                //Stufengrüsse der Farbänderung
                int colorStep = 255 / maxIterations;
                int colorDiff = colorStep * iterationCounter;

                double colorDiffLog = Math.Log(iterationCounter, maxIterations);

                

                //Variablen für die Farbanteile
                int colorRed = 0;
                int colorGreen = (int)(255 - (255 * colorDiffLog));
                int colorBlue = (int)(255 * colorDiffLog);

                returnColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
            }

            return returnColor;
        }

        public void getComplexNumberOfCoordinates(int x, int y)
        {
            /**
             * Zähler = (anzahl der Pixel * minX)
             * Nenner = anzahl der Pixel
             **/
        }

        private int recursiveCalculation(FloatComplexNumber z, int iterationCounter, FloatComplexNumber c)
        {
            iterationCounter++;

            //Zn+1 = (Zn)^2 + c
            FloatComplexNumber nextZ = (z * z) + c;

            double newValue = nextZ.getAbsoluteValue();

            if (newValue == 0)
            {
                return maxIterations;
            }
            else if ((newValue > 2) || (iterationCounter >= maxIterations))
            {
                return iterationCounter;
            }
            else
            {
                return recursiveCalculation(nextZ, iterationCounter, c);
            }
        }

        private int recursiveCalculation(ComplexNumber z, int iterationCounter, ComplexNumber c)
        {
            iterationCounter++;

            //Zn+1 = (Zn)^2 + c
            ComplexNumber nextZ = (z * z) + c;

            double newValue = nextZ.getAbsoluteValue();
            if(newValue == 0)
            {
                return maxIterations;
            }
            else if ((newValue > 2) || (iterationCounter >= maxIterations))
            {
                return iterationCounter;
            }
            else{
                return recursiveCalculation(nextZ, iterationCounter, c );
            }
        }

        public void setMaxIterations(int newMaxIterations)
        {
            maxIterations = newMaxIterations;
        }

        public void setMaxCoordinates(double newMaxR, double newMinR, double newMaxI, double newMinI)
        {
            maxX = newMaxR;
            minX = newMinR;
            maxY = newMaxI;
            minY = newMinI;
        }

    }
}
