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

        public int eg = 0;

        private void limpiar()
        {
            chart2017.Series.Clear();
            chart2018.Series.Clear();
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart4.Series.Clear();

            chart2017.Titles.Clear();
            chart2018.Titles.Clear();
            chart1.Titles.Clear();
            chart2.Titles.Clear();
            chart3.Titles.Clear();
            chart4.Titles.Clear();
        }
        private void menosdetalle()
        {

            limpiar();
            string[] series = { "Total activos", "Total pasivos", "Total capital", "Total pasivo mas capital" };
            double[] puntos = new double[4];

            puntos[0] = shareddata.Instance.activo1;
            puntos[1] = shareddata.Instance.pasivo1;
            puntos[2] = shareddata.Instance.capital1;
            puntos[3] = shareddata.Instance.pascap1;

            chart2018.Palette = ChartColorPalette.Pastel;
            chart2018.Titles.Add("2018");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart2018.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);

            }

            puntos[0] = shareddata.Instance.activo2;
            puntos[1] = shareddata.Instance.pasivo2;
            puntos[2] = shareddata.Instance.capital2;
            puntos[3] = shareddata.Instance.pascap2;

            chart2017.Titles.Add("2017");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart2017.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
                //prueba nueva
            }
        }

        private void graficas_Load(object sender, EventArgs e)
        {
            menosdetalle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eg++;
            if (button1.Text == "más detalle")
            {
                this.Size = new Size(908, 679);
                button1.Text = "menos detalle";
                button1.Image = Properties.Resources.remove;
                chart2017.Size = new Size(386, 170);
                chart2018.Size = new Size(386, 170);
                chart2017.Location = new Point(12, 108);
                chart2018.Location = new Point(404, 108);

                limpiar();

                string[] series = { "Bancos", "Instrumentos financieros", "Clientes y deudores diversos", "Almacen", "Pagos anticipadps", "Edificios", "software y sistemas" };
                double[] puntos = new double[7];

                puntos[0] = shareddata.Instance.bancos;
                puntos[1] = shareddata.Instance.instrumentos_financieros;
                puntos[2] = shareddata.Instance.cyddiversos;
                puntos[3] = shareddata.Instance.almacen;
                puntos[4] = shareddata.Instance.pagos_anticipados;
                puntos[5] = shareddata.Instance.edificios;
                puntos[6] = shareddata.Instance.softysis;

                chart2018.Palette = ChartColorPalette.Pastel;
                chart2018.Titles.Add("Activos");

                for (int i = 0; i < series.Length; i++)
                {
                    Series serie = chart2018.Series.Add(series[i]);

                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }

                puntos[0] = shareddata.Instance.bancos2;
                puntos[1] = shareddata.Instance.instrumentos_financieros2;
                puntos[2] = shareddata.Instance.cyddiversos2;
                puntos[3] = shareddata.Instance.almacen2;
                puntos[4] = shareddata.Instance.pagos_anticipados2;
                puntos[5] = shareddata.Instance.edificios2;
                puntos[6] = shareddata.Instance.softysis2;

                chart2017.Titles.Add("Activos");

                for (int i = 0; i < series.Length; i++)
                {
                    Series serie = chart2017.Series.Add(series[i]);

                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }

                string[] seriepas = { "Proveedores", "Acreedores", "Impuestos por pagat", "Provisiones", "Otros pasivos a corto plazo", "Credito hipotecario" };
                double[] puntospas = new double[6];

                puntospas[0] = shareddata.Instance.proovedores;
                puntospas[1] = shareddata.Instance.acreedores;
                puntospas[2] = shareddata.Instance.impuestos;
                puntospas[3] = shareddata.Instance.provisiones;
                puntospas[4] = shareddata.Instance.otros;
                puntospas[5] = shareddata.Instance.credito;

                chart3.Palette = ChartColorPalette.Pastel;
                chart3.Titles.Add("Pasivos");

                for (int i = 0; i < seriepas.Length; i++)
                {
                    Series serie = chart3.Series.Add(seriepas[i]);

                    serie.Label = puntospas[i].ToString();

                    serie.Points.Add(puntospas[i]);
                }

                puntospas[0] = shareddata.Instance.proovedores2;
                puntospas[1] = shareddata.Instance.acreedores2;
                puntospas[2] = shareddata.Instance.impuestos2;
                puntospas[3] = shareddata.Instance.provisiones2;
                puntospas[4] = shareddata.Instance.otros2;
                puntospas[5] = shareddata.Instance.credito2;

                chart1.Titles.Add("Pasivos");

                for (int i = 0; i < seriepas.Length; i++)
                {
                    Series serie = chart1.Series.Add(seriepas[i]);

                    serie.Label = puntospas[i].ToString();

                    serie.Points.Add(puntospas[i]);
                }

                string[] seriecap = { "Capital Social", "aportacion", "Reservas", "utilidades" };
                double[] puntoscap = new double[4];

                puntoscap[0] = shareddata.Instance.capital_social;
                puntoscap[1] = shareddata.Instance.aportacion;
                puntoscap[2] = shareddata.Instance.reservas;
                puntoscap[3] = shareddata.Instance.utilidads;

                chart4.Palette = ChartColorPalette.Pastel;
                chart4.Titles.Add("Capital Contable");

                for (int i = 0; i < seriecap.Length; i++)
                {
                    Series serie = chart4.Series.Add(seriecap[i]);

                    serie.Label = puntoscap[i].ToString();

                    serie.Points.Add(puntoscap[i]);
                }

                puntoscap[0] = shareddata.Instance.capital_social2;
                puntoscap[1] = shareddata.Instance.aportacion2;
                puntoscap[2] = shareddata.Instance.reservas2;
                puntoscap[3] = shareddata.Instance.utilidads2;

                chart2.Titles.Add("Capital Contable");

                for (int i = 0; i < seriecap.Length; i++)
                {
                    Series serie = chart2.Series.Add(seriecap[i]);

                    serie.Label = puntoscap[i].ToString();

                    serie.Points.Add(puntoscap[i]);
                }

            }
            else
            {
                this.Size = new Size(908, 323);
                button1.Text = "más detalle";
                button1.Image = Properties.Resources.plus;
                chart2017.Size = new Size(386, 266);
                chart2018.Size = new Size(386, 266);
                chart2017.Location = new Point(12, 12);
                chart2018.Location = new Point(404, 12);
                menosdetalle();
            }
            if (eg == 20)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
        }
    }
}
