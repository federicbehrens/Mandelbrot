using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandelbrot.controller
{
    class Dataset
    {
        int iterationStep;
        model.Point coordinate;

        public Dataset(int newIterationStep, model.Point newPoint)
        {
            iterationStep = newIterationStep;
            coordinate = newPoint;
        }

        public int getIterationStep()
        {
            return iterationStep;
        }

        public model.Point getCoordinate()
        {
            return coordinate;
        }
    }
}
