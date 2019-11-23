using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ModernGUI_V3
{
    public partial class graficas : Form
    {
        public graficas()
        {
            InitializeComponent();
            
        }

        

        private void graficas_Load(object sender, EventArgs e)
        {
            string[] series = { "Total activos", "Total pasivos", "Total capital", "Total pasivo mas capital" };
            double[] puntos = new double[4];

            puntos[0] = shareddata.Instance.activo1;
            puntos[1] = shareddata.Instance.pasivo1;
            puntos[2] = shareddata.Instance.capital1;
            puntos[3] = shareddata.Instance.pascap1;

            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("2017");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }

        }
    }
}
