namespace ModernGUI_V3
{
    partial class graficas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graficas));
            this.chart2017 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2018 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2017)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2018)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2017
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2017.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2017.Legends.Add(legend1);
            this.chart2017.Location = new System.Drawing.Point(12, 12);
            this.chart2017.Name = "chart2017";
            this.chart2017.Size = new System.Drawing.Size(386, 266);
            this.chart2017.TabIndex = 0;
            this.chart2017.Text = "chart1";
            // 
            // chart2018
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2018.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2018.Legends.Add(legend2);
            this.chart2018.Location = new System.Drawing.Point(404, 12);
            this.chart2018.Name = "chart2018";
            this.chart2018.Size = new System.Drawing.Size(386, 266);
            this.chart2018.TabIndex = 1;
            this.chart2018.Text = "chart1";
            // 
            // graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.chart2018);
            this.Controls.Add(this.chart2017);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "graficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "graficas";
            this.Load += new System.EventHandler(this.graficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2017)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2018)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2017;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2018;
    }
}