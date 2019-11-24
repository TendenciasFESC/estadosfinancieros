using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desbloquear()
        {
            label37.Visible = true; label38.Visible = true; label39.Visible = true;
            label40.Visible = true;label41.Visible = true;label42.Visible = true;label43.Visible = true;label44.Visible = true;label45.Visible = true;label46.Visible = true;label47.Visible = true;label48.Visible = true;label49.Visible = true;
            label50.Visible = true;label51.Visible = true; label52.Visible = true;label53.Visible = true;label54.Visible = true;label55.Visible = true;label56.Visible = true;label57.Visible = true;label58.Visible = true;label59.Visible = true;
            label60.Visible = true;label61.Visible = true;label62.Visible = true;label63.Visible = true;label64.Visible = true;label65.Visible = true;label66.Visible = true;label67.Visible = true;label68.Visible = true;label69.Visible = true;
            label70.Visible = true;label71.Visible = true;label72.Visible = true;

        }

        private void desbloquear1()
        {
            label73.Visible = true;
            label74.Visible = true;
            label75.Visible = true;
            label76.Visible = true;
            label77.Visible = true;
            label78.Visible = true;
            label79.Visible = true;
            label80.Visible = true;
            label81.Visible = true;
            label82.Visible = true;
            label83.Visible = true;
            label84.Visible = true;
            label85.Visible = true;
            label86.Visible = true;
            label87.Visible = true;
            label88.Visible = true;
            label89.Visible = true;
            label90.Visible = true;
            label91.Visible = true;
            label92.Visible = true;
            label93.Visible = true;
            label94.Visible = true;
            label95.Visible = true;
            label96.Visible = true;
            label97.Visible = true;
            label98.Visible = true;
            label99.Visible = true;
            label100.Visible = true;
            label101.Visible = true;
            label102.Visible = true;
            label103.Visible = true;
            label104.Visible = true;
            label105.Visible = true;
            label106.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tactivos1.Text = (double.Parse(textBox1.Text) + double.Parse(textBox3.Text) + double.Parse(textBox5.Text) + double.Parse(textBox7.Text) + double.Parse(textBox9.Text) + double.Parse(textBox11.Text) + double.Parse(textBox13.Text)).ToString();
                tactivos2.Text = (double.Parse(textBox2.Text) + double.Parse(textBox4.Text) + double.Parse(textBox6.Text) + double.Parse(textBox8.Text) + double.Parse(textBox10.Text) + double.Parse(textBox12.Text) + double.Parse(textBox14.Text)).ToString();
                tpasivo1.Text = (double.Parse(textBox15.Text) + double.Parse(textBox17.Text) + double.Parse(textBox19.Text) + double.Parse(textBox21.Text) + double.Parse(textBox23.Text) + double.Parse(textBox25.Text) + double.Parse(textBox27.Text)).ToString();
                tpasivo2.Text = (double.Parse(textBox16.Text) + double.Parse(textBox18.Text) + double.Parse(textBox20.Text) + double.Parse(textBox22.Text) + double.Parse(textBox24.Text) + double.Parse(textBox26.Text) + double.Parse(textBox28.Text)).ToString();
                tcapital1.Text = (double.Parse(textBox29.Text) + double.Parse(textBox31.Text) + double.Parse(textBox33.Text) + double.Parse(textBox35.Text)).ToString();
                tcapital2.Text = (double.Parse(textBox30.Text) + double.Parse(textBox32.Text) + double.Parse(textBox34.Text) + double.Parse(textBox36.Text)).ToString();
                tpc1.Text = (double.Parse(tpasivo1.Text) + double.Parse(tcapital1.Text)).ToString();
                tpc2.Text = (double.Parse(tcapital2.Text) + double.Parse(tpasivo2.Text)).ToString();
                button2.Enabled = true;

                tactivos1.Visible = true;
                tactivos2.Visible = true;
                tpasivo1.Visible = true;
                tpasivo2.Visible = true;
                tcapital1.Visible = true;
                tcapital2.Visible = true;
                tpc1.Visible = true;
                tpc2.Visible = true;
                button3.Enabled = true;


            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (shareddata.Instance.bancos).ToString();
                textBox2.Text = (shareddata.Instance.bancos2).ToString();
                textBox3.Text = (shareddata.Instance.instrumentos_financieros).ToString();
                textBox4.Text = (shareddata.Instance.instrumentos_financieros2).ToString();
                textBox5.Text = (shareddata.Instance.cyddiversos).ToString();
                textBox6.Text = (shareddata.Instance.cyddiversos2).ToString();
                textBox7.Text = (shareddata.Instance.almacen).ToString();
                textBox8.Text = (shareddata.Instance.almacen2).ToString();
                textBox9.Text = (shareddata.Instance.pagos_anticipados).ToString();
                textBox10.Text = (shareddata.Instance.pagos_anticipados2).ToString();
                textBox11.Text = (shareddata.Instance.edificios).ToString();
                textBox12.Text = (shareddata.Instance.edificios2).ToString();
                textBox13.Text = (shareddata.Instance.softysis).ToString();
                textBox14.Text = (shareddata.Instance.softysis2).ToString();
                textBox15.Text = (shareddata.Instance.proovedores).ToString();
                textBox16.Text = (shareddata.Instance.proovedores2).ToString();
                textBox17.Text = (shareddata.Instance.acreedores).ToString();
                textBox18.Text = (shareddata.Instance.acreedores2).ToString();
                textBox19.Text = (shareddata.Instance.retencion).ToString();
                textBox20.Text = (shareddata.Instance.retencion2).ToString();
                textBox21.Text = (shareddata.Instance.impuestos).ToString();
                textBox22.Text = (shareddata.Instance.impuestos2).ToString();
                textBox23.Text = (shareddata.Instance.provisiones).ToString();
                textBox24.Text = (shareddata.Instance.provisiones2).ToString();
                textBox25.Text = (shareddata.Instance.otros).ToString();
                textBox26.Text = (shareddata.Instance.otros2).ToString();
                textBox27.Text = (shareddata.Instance.credito).ToString();
                textBox28.Text = (shareddata.Instance.credito2).ToString();
                textBox29.Text = (shareddata.Instance.capital_social).ToString();
                textBox30.Text = (shareddata.Instance.capital_social2).ToString();
                textBox31.Text = (shareddata.Instance.aportacion).ToString();
                textBox32.Text = (shareddata.Instance.aportacion2).ToString();
                textBox33.Text = (shareddata.Instance.reservas).ToString();
                textBox34.Text = (shareddata.Instance.reservas2).ToString();
                textBox35.Text = (shareddata.Instance.utilidads).ToString();
                textBox36.Text = (shareddata.Instance.utilidads2).ToString();
                button1.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Sin Datos, Debe Generar las graficas en Origenes y Aplicaciones para poder obtener los Analisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tpasivo2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label37.Text =(Math.Round((double.Parse(textBox1.Text)*100)/double.Parse(tactivos1.Text),2)+"%").ToString();
            label39.Text = (Math.Round((double.Parse(textBox3.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label41.Text = (Math.Round((double.Parse(textBox5.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label43.Text = (Math.Round((double.Parse(textBox7.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label45.Text = (Math.Round((double.Parse(textBox9.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label47.Text = (Math.Round((double.Parse(textBox11.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label49.Text = (Math.Round((double.Parse(textBox13.Text) * 100) / double.Parse(tactivos1.Text), 2) + "%").ToString();
            label38.Text = (Math.Round((double.Parse(textBox2.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label40.Text = (Math.Round((double.Parse(textBox4.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label42.Text = (Math.Round((double.Parse(textBox6.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label44.Text = (Math.Round((double.Parse(textBox8.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label46.Text = (Math.Round((double.Parse(textBox10.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label48.Text = (Math.Round((double.Parse(textBox12.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();
            label50.Text = (Math.Round((double.Parse(textBox14.Text) * 100) / double.Parse(tactivos2.Text), 2) + "%").ToString();

            label51.Text = (Math.Round((double.Parse(textBox15.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label53.Text = (Math.Round((double.Parse(textBox17.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label55.Text = (Math.Round((double.Parse(textBox19.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label57.Text = (Math.Round((double.Parse(textBox21.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label59.Text = (Math.Round((double.Parse(textBox23.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label61.Text = (Math.Round((double.Parse(textBox25.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label63.Text = (Math.Round((double.Parse(textBox27.Text) * 100) / double.Parse(tpasivo1.Text), 2) + "%").ToString();
            label52.Text = (Math.Round((double.Parse(textBox16.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label54.Text = (Math.Round((double.Parse(textBox18.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label56.Text = (Math.Round((double.Parse(textBox20.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label58.Text = (Math.Round((double.Parse(textBox22.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label60.Text = (Math.Round((double.Parse(textBox24.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label62.Text = (Math.Round((double.Parse(textBox26.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();
            label64.Text = (Math.Round((double.Parse(textBox28.Text) * 100) / double.Parse(tpasivo2.Text), 2) + "%").ToString();

            label65.Text = (Math.Round((double.Parse(textBox29.Text) * 100) / double.Parse(tcapital1.Text), 2) + "%").ToString();
            label67.Text = (Math.Round((double.Parse(textBox31.Text) * 100) / double.Parse(tcapital1.Text), 2) + "%").ToString();
            label69.Text = (Math.Round((double.Parse(textBox33.Text) * 100) / double.Parse(tcapital1.Text), 2) + "%").ToString();
            label71.Text = (Math.Round((double.Parse(textBox35.Text) * 100) / double.Parse(tcapital1.Text), 2) + "%").ToString();
            label66.Text = (Math.Round((double.Parse(textBox30.Text) * 100) / double.Parse(tcapital2.Text), 2) + "%").ToString();
            label68.Text = (Math.Round((double.Parse(textBox32.Text) * 100) / double.Parse(tcapital2.Text), 2) + "%").ToString();
            label70.Text = (Math.Round((double.Parse(textBox34.Text) * 100) / double.Parse(tcapital2.Text), 2) + "%").ToString();
            label72.Text = (Math.Round((double.Parse(textBox36.Text) * 100) / double.Parse(tcapital2.Text), 2) + "%").ToString();

            desbloquear();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label73.Text = (Math.Round(double.Parse(label38.Text) - double.Parse(label37.Text), 2)).ToString();
            label75.Text = (Math.Round(double.Parse(label40.Text) - double.Parse(label39.Text), 2)).ToString();
            label77.Text = (Math.Round(double.Parse(label42.Text) - double.Parse(label41.Text), 2)).ToString();
            label79.Text = (Math.Round(double.Parse(label44.Text) - double.Parse(label43.Text), 2)).ToString();
            label81.Text = (Math.Round(double.Parse(label46.Text) - double.Parse(label45.Text), 2)).ToString();
            label83.Text = (Math.Round(double.Parse(label48.Text) - double.Parse(label47.Text), 2)).ToString();
            label85.Text = (Math.Round(double.Parse(label50.Text) - double.Parse(label49.Text), 2)).ToString();

            label87.Text = (Math.Round(double.Parse(label52.Text) - double.Parse(label51.Text), 2)).ToString();
            label89.Text = (Math.Round(double.Parse(label54.Text) - double.Parse(label53.Text), 2)).ToString();
            label91.Text = (Math.Round(double.Parse(label56.Text) - double.Parse(label55.Text), 2)).ToString();
            label93.Text = (Math.Round(double.Parse(label58.Text) - double.Parse(label57.Text), 2)).ToString();
            label95.Text = (Math.Round(double.Parse(label60.Text) - double.Parse(label59.Text), 2)).ToString();
            label97.Text = (Math.Round(double.Parse(label62.Text) - double.Parse(label61.Text), 2)).ToString();
            label99.Text = (Math.Round(double.Parse(label64.Text) - double.Parse(label63.Text), 2)).ToString();

            label101.Text = (Math.Round(double.Parse(label66.Text) - double.Parse(label65.Text), 2)).ToString();
            label103.Text = (Math.Round(double.Parse(label68.Text) - double.Parse(label67.Text), 2)).ToString();
            label105.Text = (Math.Round(double.Parse(label70.Text) - double.Parse(label69.Text), 2)).ToString();
            label107.Text = (Math.Round(double.Parse(label72.Text) - double.Parse(label71.Text), 2)).ToString();

            desbloquear1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Analisis_Load(object sender, EventArgs e)
        {

        }
    }
}
