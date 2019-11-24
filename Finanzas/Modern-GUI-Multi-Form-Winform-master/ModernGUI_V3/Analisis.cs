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
            button4.Enabled = true;
        }
    }
}
