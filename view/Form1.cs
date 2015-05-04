using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mandelbrot.view
{
    public partial class Form1 : Form
    {
        private model.Model myModel;
        private controller.ViewControl myViewControl;

        /**
        * Diese Klasse erstellt und verwaltet die grafische Oberfläche
        * 
        **/
        public Form1()
        {

            InitializeComponent();

            myModel = new model.Model(pnlShowPanel.Width, pnlShowPanel.Height);
            myViewControl = new controller.ViewControl(myModel, this);
        }

        private void btnShowGraph_Click(object sender, System.EventArgs e)
        {
            myModel.setMaxIterations(Convert.ToInt32(tb_maxIterations.Text));
            myModel.setMaxCoordinates(Convert.ToDouble(tb_maxR.Text), Convert.ToDouble(tb_minR.Text), Convert.ToDouble(tb_maxI.Text), Convert.ToDouble(tb_minI.Text));

            myViewControl.fillGraphPanel(pnlShowPanel.Width, pnlShowPanel.Height);            
        }

        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
     
        }

        /**
         * Setzt die Farbe der Koordinate
         * 
         * x, y Beschreibt die Koordinate, welche eingefärbt werden soll
         * color beschreibt die Farbe für die Koordinate
         **/
        internal void setColorAtPoint(int x, int y, Color color)
        {
            Graphics graphics = pnlShowPanel.CreateGraphics();
            graphics.FillRectangle(new SolidBrush(color),x, y, 1, 1);
        }
    }
}
