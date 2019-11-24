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
        double a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,a26,a27,a28,a29,a30,a31,a32,a33,a34,a35,a36;

        private void label75_Click(object sender, EventArgs e)
        {

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
            label107.Visible = true;
            label108.Visible = true;

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
            a1 = Math.Round((double.Parse(textBox1.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label37.Text =(a1 + "%").ToString();
            a3 = Math.Round((double.Parse(textBox3.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label39.Text = (a3 + "%").ToString();
            a5 = Math.Round((double.Parse(textBox5.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label41.Text = (a5 + "%").ToString();
            a7 = Math.Round((double.Parse(textBox7.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label43.Text = (a7 + "%").ToString();
            a9 = Math.Round((double.Parse(textBox9.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label45.Text = (a9 + "%").ToString();
            a11 = Math.Round((double.Parse(textBox11.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label47.Text = (a11 + "%").ToString();
            a13 = Math.Round((double.Parse(textBox13.Text) * 100) / double.Parse(tactivos1.Text), 2);
            label49.Text = (a13 + "%").ToString();

            a2 = Math.Round((double.Parse(textBox2.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label38.Text = (a2 + "%").ToString();
            a4 = Math.Round((double.Parse(textBox4.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label40.Text = (a4+"%").ToString();
            a6 = Math.Round((double.Parse(textBox6.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label42.Text = (a6 + "%").ToString();
            a8 = Math.Round((double.Parse(textBox8.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label44.Text = (a8 + "%").ToString();
            a10 = Math.Round((double.Parse(textBox10.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label46.Text = (a10 + "%").ToString();
            a12 = Math.Round((double.Parse(textBox12.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label48.Text = (a12 + "%").ToString();
            a14 = Math.Round((double.Parse(textBox14.Text) * 100) / double.Parse(tactivos2.Text), 2);
            label50.Text = (a14 + "%").ToString();

            a15 = Math.Round((double.Parse(textBox15.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label51.Text = (a15 + "%").ToString();
            a17 = Math.Round((double.Parse(textBox17.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label53.Text = (a17 + "%").ToString();
            a19 = Math.Round((double.Parse(textBox19.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label55.Text = (a19 + "%").ToString();
            a21 = Math.Round((double.Parse(textBox21.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label57.Text = (a21 + "%").ToString();
            a23= Math.Round((double.Parse(textBox23.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label59.Text = (a23 + "%").ToString();
            a25 = Math.Round((double.Parse(textBox25.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label61.Text = (a25 + "%").ToString();
            a27 = Math.Round((double.Parse(textBox27.Text) * 100) / double.Parse(tpasivo1.Text), 2);
            label63.Text = (a27 + "%").ToString();

            a16 = Math.Round((double.Parse(textBox16.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label52.Text = (a16 + "%").ToString();
            a18 = Math.Round((double.Parse(textBox18.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label54.Text = (a18 + "%").ToString();
            a20 = Math.Round((double.Parse(textBox20.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label56.Text = (a20 + "%").ToString();
            a22 = Math.Round((double.Parse(textBox22.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label58.Text = (a22 + "%").ToString();
            a24 = Math.Round((double.Parse(textBox24.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label60.Text = (a24 + "%").ToString();
            a26 = Math.Round((double.Parse(textBox26.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label62.Text = (a26 + "%").ToString();
            a28 = Math.Round((double.Parse(textBox28.Text) * 100) / double.Parse(tpasivo2.Text), 2);
            label64.Text = (a28 + "%").ToString();

            a29 = Math.Round((double.Parse(textBox29.Text) * 100) / double.Parse(tcapital1.Text), 2);
            label65.Text = (a29 + "%").ToString();
            a31 = Math.Round((double.Parse(textBox31.Text) * 100) / double.Parse(tcapital1.Text), 2);
            label67.Text = (a31 + "%").ToString();
            a33 = Math.Round((double.Parse(textBox33.Text) * 100) / double.Parse(tcapital1.Text), 2);
            label69.Text = (a33 + "%").ToString();
            a35 = Math.Round((double.Parse(textBox35.Text) * 100) / double.Parse(tcapital1.Text), 2);
            label71.Text = (a35 + "%").ToString();

            a30 = Math.Round((double.Parse(textBox30.Text) * 100) / double.Parse(tcapital2.Text), 2);
            label66.Text = (a30 + "%").ToString();
            a32 = Math.Round((double.Parse(textBox32.Text) * 100) / double.Parse(tcapital2.Text), 2);
            label68.Text = (a32 + "%").ToString();
            a34 = Math.Round((double.Parse(textBox34.Text) * 100) / double.Parse(tcapital2.Text), 2);
            label70.Text = (a34 + "%").ToString();
            a36 = Math.Round((double.Parse(textBox36.Text) * 100) / double.Parse(tcapital2.Text), 2);
            label72.Text = (a36 + "%").ToString();

            desbloquear();
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label73.Text = (Math.Round(double.Parse(textBox1.Text)-double.Parse(textBox2.Text),2)).ToString();
            label75.Text = (Math.Round(double.Parse(textBox3.Text) - double.Parse(textBox4.Text), 2)).ToString();
            label77.Text = (Math.Round(double.Parse(textBox5.Text) - double.Parse(textBox6.Text), 2)).ToString();
            label79.Text = (Math.Round(double.Parse(textBox7.Text) - double.Parse(textBox8.Text), 2)).ToString();
            label81.Text = (Math.Round(double.Parse(textBox9.Text) - double.Parse(textBox10.Text), 2)).ToString();
            label83.Text = (Math.Round(double.Parse(textBox11.Text) - double.Parse(textBox12.Text), 2)).ToString();
            label85.Text = (Math.Round(double.Parse(textBox13.Text) - double.Parse(textBox14.Text), 2)).ToString();
            label87.Text = (Math.Round(double.Parse(textBox15.Text) - double.Parse(textBox16.Text), 2)).ToString();
            label89.Text = (Math.Round(double.Parse(textBox17.Text) - double.Parse(textBox18.Text), 2)).ToString();
            label91.Text = (Math.Round(double.Parse(textBox19.Text) - double.Parse(textBox20.Text), 2)).ToString();
            label93.Text = (Math.Round(double.Parse(textBox21.Text) - double.Parse(textBox22.Text), 2)).ToString();
            label95.Text = (Math.Round(double.Parse(textBox23.Text) - double.Parse(textBox24.Text), 2)).ToString();
            label97.Text = (Math.Round(double.Parse(textBox25.Text) - double.Parse(textBox26.Text), 2)).ToString();
            label99.Text = (Math.Round(double.Parse(textBox27.Text) - double.Parse(textBox26.Text), 2)).ToString();
            label101.Text = (Math.Round(double.Parse(textBox29.Text) - double.Parse(textBox30.Text), 2)).ToString();
            label103.Text = (Math.Round(double.Parse(textBox31.Text) - double.Parse(textBox32.Text), 2)).ToString();
            label105.Text = (Math.Round(double.Parse(textBox33.Text) - double.Parse(textBox34.Text), 2)).ToString();
            label107.Text = (Math.Round(double.Parse(textBox35.Text) - double.Parse(textBox36.Text), 2)).ToString();

            label74.Text = ((Math.Round((double.Parse(label73.Text)/double.Parse(textBox2.Text))*100,2))+"%").ToString();
            label76.Text = ((Math.Round((double.Parse(label75.Text) / double.Parse(textBox4.Text)) * 100, 2))+ "%").ToString();
            label78.Text = ((Math.Round((double.Parse(label77.Text) / double.Parse(textBox6.Text)) * 100, 2)) + "%").ToString();
            label80.Text = ((Math.Round((double.Parse(label79.Text) / double.Parse(textBox8.Text)) * 100, 2)) + "%").ToString();
            label82.Text = ((Math.Round((double.Parse(label81.Text) / double.Parse(textBox10.Text)) * 100, 2)) + "%").ToString();
            label84.Text = ((Math.Round((double.Parse(label83.Text) / double.Parse(textBox12.Text)) * 100, 2)) + "%").ToString();
            label86.Text = ((Math.Round((double.Parse(label85.Text) / double.Parse(textBox14.Text)) * 100, 2)) + "%").ToString();
            label88.Text = ((Math.Round((double.Parse(label87.Text) / double.Parse(textBox16.Text)) * 100, 2)) + "%").ToString();
            label90.Text = ((Math.Round((double.Parse(label89.Text) / double.Parse(textBox18.Text)) * 100, 2)) + "%").ToString();
            label92.Text = ((Math.Round((double.Parse(label91.Text) / double.Parse(textBox20.Text)) * 100, 2)) + "%").ToString();
            label94.Text = ((Math.Round((double.Parse(label93.Text) / double.Parse(textBox22.Text)) * 100, 2)) + "%").ToString();
            label96.Text = ((Math.Round((double.Parse(label95.Text) / double.Parse(textBox24.Text)) * 100, 2)) + "%").ToString();
            label98.Text = ((Math.Round((double.Parse(label97.Text) / double.Parse(textBox26.Text)) * 100, 2)) + "%").ToString();
            label100.Text = ((Math.Round((double.Parse(label99.Text) / double.Parse(textBox28.Text)) * 100, 2)) + "%").ToString();
            label102.Text = ((Math.Round((double.Parse(label101.Text) / double.Parse(textBox30.Text)) * 100, 2)) + "%").ToString();
            label104.Text = ((Math.Round((double.Parse(label103.Text) / double.Parse(textBox32.Text)) * 100, 2)) + "%").ToString();
            label106.Text = ((Math.Round((double.Parse(label105.Text) / double.Parse(textBox34.Text)) * 100, 2)) + "%").ToString();
            label108.Text = ((Math.Round((double.Parse(label107.Text) / double.Parse(textBox36.Text)) * 100, 2)) + "%").ToString();




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
