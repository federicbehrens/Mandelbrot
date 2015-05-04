namespace Mandelbrot.view
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShowPanel = new System.Windows.Forms.Panel();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_minI = new System.Windows.Forms.TextBox();
            this.tb_minR = new System.Windows.Forms.TextBox();
            this.tb_maxI = new System.Windows.Forms.TextBox();
            this.tb_maxR = new System.Windows.Forms.TextBox();
            this.tb_maxIterations = new System.Windows.Forms.TextBox();
            this.lbCOordinates = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbIteration = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShowPanel
            // 
            this.pnlShowPanel.AccessibleDescription = "Shows the graph";
            this.pnlShowPanel.AccessibleName = "pnlShowPanel";
            this.pnlShowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShowPanel.Location = new System.Drawing.Point(17, 176);
            this.pnlShowPanel.Name = "pnlShowPanel";
            this.pnlShowPanel.Size = new System.Drawing.Size(801, 801);
            this.pnlShowPanel.TabIndex = 0;
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.AccessibleName = "btnShowGraph";
            this.btnShowGraph.Location = new System.Drawing.Point(396, 19);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(75, 23);
            this.btnShowGraph.TabIndex = 2;
            this.btnShowGraph.Text = "Show graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbIteration);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnShowGraph);
            this.groupBox1.Controls.Add(this.tb_maxIterations);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tb_minI
            // 
            this.tb_minI.Location = new System.Drawing.Point(57, 84);
            this.tb_minI.Name = "tb_minI";
            this.tb_minI.Size = new System.Drawing.Size(100, 20);
            this.tb_minI.TabIndex = 4;
            this.tb_minI.Text = "-1,5";
            // 
            // tb_minR
            // 
            this.tb_minR.Location = new System.Drawing.Point(6, 58);
            this.tb_minR.Name = "tb_minR";
            this.tb_minR.Size = new System.Drawing.Size(100, 20);
            this.tb_minR.TabIndex = 3;
            this.tb_minR.Text = "-2";
            // 
            // tb_maxI
            // 
            this.tb_maxI.Location = new System.Drawing.Point(57, 32);
            this.tb_maxI.Name = "tb_maxI";
            this.tb_maxI.Size = new System.Drawing.Size(100, 20);
            this.tb_maxI.TabIndex = 2;
            this.tb_maxI.Text = "1,5";
            // 
            // tb_maxR
            // 
            this.tb_maxR.Location = new System.Drawing.Point(112, 58);
            this.tb_maxR.Name = "tb_maxR";
            this.tb_maxR.Size = new System.Drawing.Size(100, 20);
            this.tb_maxR.TabIndex = 1;
            this.tb_maxR.Text = "1";
            // 
            // tb_maxIterations
            // 
            this.tb_maxIterations.Location = new System.Drawing.Point(278, 51);
            this.tb_maxIterations.Name = "tb_maxIterations";
            this.tb_maxIterations.Size = new System.Drawing.Size(58, 20);
            this.tb_maxIterations.TabIndex = 0;
            this.tb_maxIterations.Text = "50";
            // 
            // lbCOordinates
            // 
            this.lbCOordinates.AutoSize = true;
            this.lbCOordinates.Location = new System.Drawing.Point(130, 16);
            this.lbCOordinates.Name = "lbCOordinates";
            this.lbCOordinates.Size = new System.Drawing.Size(64, 13);
            this.lbCOordinates.TabIndex = 5;
            this.lbCOordinates.Text = "Koordinaten";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCOordinates);
            this.groupBox2.Controls.Add(this.tb_maxI);
            this.groupBox2.Controls.Add(this.tb_minI);
            this.groupBox2.Controls.Add(this.tb_maxR);
            this.groupBox2.Controls.Add(this.tb_minR);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 122);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbIteration
            // 
            this.lbIteration.AutoSize = true;
            this.lbIteration.Location = new System.Drawing.Point(275, 29);
            this.lbIteration.Name = "lbIteration";
            this.lbIteration.Size = new System.Drawing.Size(57, 13);
            this.lbIteration.TabIndex = 7;
            this.lbIteration.Text = "Iterationen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 997);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlShowPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowPanel;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_minI;
        private System.Windows.Forms.TextBox tb_minR;
        private System.Windows.Forms.TextBox tb_maxI;
        private System.Windows.Forms.TextBox tb_maxR;
        private System.Windows.Forms.TextBox tb_maxIterations;
        private System.Windows.Forms.Label lbIteration;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCOordinates;
    }
}

