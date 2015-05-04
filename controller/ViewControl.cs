using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Mandelbrot.controller
{
    class ViewControl
    {

        private model.Model myModel;
        private view.Form1 myMainView;

        public ViewControl(model.Model newModel, view.Form1 newMainView)
        {
            myModel = newModel;
            myMainView = newMainView;
        }

        public void fillGraphPanel(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color color = myModel.getColorAtPoint(i, j);
                    myMainView.setColorAtPoint(i, j, color);
                }
            }
        }
    }
}
