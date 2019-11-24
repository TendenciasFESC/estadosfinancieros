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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tactivos1.Text = (double.Parse(textBox1.Text) + double.Parse(textBox3.Text) + double.Parse(textBox5.Text) + double.Parse(textBox7.Text) + double.Parse(textBox9.Text) + double.Parse(textBox11.Text) + double.Parse(textBox13.Text)).ToString();
                tactivos2.Text = (double.Parse(textBox2.Text) + double.Parse(textBox4.Text) + double.Parse(textBox6.Text) + double.Parse(textBox8.Text) + double.Parse(textBox10.Text) + double.Parse(textBox12.Text) + double.Parse(textBox14.Text)).ToString();
                button2.Enabled = true;
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
                tpasivo1.Text = (double.Parse(textBox15.Text)+double.Parse(textBox17.Text) + double.Parse(textBox19.Text) + double.Parse(textBox21.Text) + double.Parse(textBox23.Text) + double.Parse(textBox25.Text) + double.Parse(textBox27.Text)).ToString();
                tpasivo2.Text = (double.Parse(textBox16.Text)+double.Parse(textBox18.Text) + double.Parse(textBox20.Text) + double.Parse(textBox22.Text) + double.Parse(textBox24.Text) + double.Parse(textBox26.Text) + double.Parse(textBox28.Text)).ToString();
                button3.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tcapital1.Text = (double.Parse(textBox29.Text) + double.Parse(textBox31.Text) + double.Parse(textBox33.Text) + double.Parse(textBox35.Text)).ToString();
                tcapital2.Text = (double.Parse(textBox30.Text) + double.Parse(textBox32.Text) + double.Parse(textBox34.Text) + double.Parse(textBox36.Text)).ToString();
                tpc1.Text = (double.Parse(tpasivo1.Text) + double.Parse(tcapital1.Text)).ToString();
                tpc2.Text = (double.Parse(tcapital2.Text) + double.Parse(tpasivo2.Text)).ToString();

                button4.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox1.Text) > double.Parse(textBox2.Text))
                {
                    label37.Text = ((double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString());
                    label38.Text = Convert.ToString(0);
                }
                else
                {
                    label38.Text = ((double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString());
                    label37.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox3.Text) > double.Parse(textBox4.Text))
                {
                    label39.Text = ((double.Parse(textBox3.Text) - double.Parse(textBox4.Text)).ToString());
                    label40.Text = Convert.ToString(0); ;
                }
                else
                {
                    label40.Text = ((double.Parse(textBox4.Text) - double.Parse(textBox3.Text)).ToString());
                    label39.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox5.Text) > double.Parse(textBox6.Text))
                {
                    label41.Text = ((double.Parse(textBox5.Text) - double.Parse(textBox6.Text)).ToString());
                    label42.Text = Convert.ToString(0); ;
                }
                else
                {
                    label42.Text = ((double.Parse(textBox6.Text) - double.Parse(textBox5.Text)).ToString());
                    label41.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox7.Text) > double.Parse(textBox8.Text))
                {
                    label43.Text = ((double.Parse(textBox7.Text) - double.Parse(textBox8.Text)).ToString());
                    label44.Text = Convert.ToString(0); ;
                }
                else
                {
                    label44.Text = ((double.Parse(textBox8.Text) - double.Parse(textBox7.Text)).ToString());
                    label43.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox9.Text) > double.Parse(textBox10.Text))
                {
                    label45.Text = ((double.Parse(textBox9.Text) - double.Parse(textBox10.Text)).ToString());
                    label46.Text = Convert.ToString(0); ;
                }
                else
                {
                    label46.Text = ((double.Parse(textBox10.Text) - double.Parse(textBox9.Text)).ToString());
                    label45.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox11.Text) > double.Parse(textBox12.Text))
                {
                    label47.Text = ((double.Parse(textBox11.Text) - double.Parse(textBox12.Text)).ToString());
                    label48.Text = Convert.ToString(0); ;
                }
                else
                {
                    label48.Text = ((double.Parse(textBox12.Text) - double.Parse(textBox11.Text)).ToString());
                    label47.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox13.Text) > double.Parse(textBox14.Text))
                {
                    label49.Text = ((double.Parse(textBox13.Text) - double.Parse(textBox14.Text)).ToString());
                    label50.Text = Convert.ToString(0); ;
                }
                else
                {
                    label50.Text = ((double.Parse(textBox14.Text) - double.Parse(textBox13.Text)).ToString());
                    label49.Text = Convert.ToString(0); ;
                }

                if (double.Parse(textBox15.Text) > double.Parse(textBox16.Text))
                {
                    label17.Text = ((double.Parse(textBox15.Text) - double.Parse(textBox16.Text)).ToString());
                    label109.Text = Convert.ToString(0); ;
                }
                else
                {
                    label109.Text = ((double.Parse(textBox16.Text) - double.Parse(textBox15.Text)).ToString());
                    label17.Text = Convert.ToString(0); ;
                }

                if (double.Parse(textBox17.Text) > double.Parse(textBox18.Text))
                {
                    label51.Text = ((double.Parse(textBox17.Text) - double.Parse(textBox18.Text)).ToString());
                    label52.Text = Convert.ToString(0); ;
                }
                else
                {
                    label52.Text = ((double.Parse(textBox18.Text) - double.Parse(textBox17.Text)).ToString());
                    label51.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox19.Text) > double.Parse(textBox20.Text))
                {
                    label53.Text = ((double.Parse(textBox19.Text) - double.Parse(textBox20.Text)).ToString());
                    label54.Text = Convert.ToString(0); ;
                }
                else
                {
                    label54.Text = ((double.Parse(textBox20.Text) - double.Parse(textBox19.Text)).ToString());
                    label53.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox21.Text) > double.Parse(textBox22.Text))
                {
                    label55.Text = ((double.Parse(textBox21.Text) - double.Parse(textBox22.Text)).ToString());
                    label56.Text = Convert.ToString(0); ;
                }
                else
                {
                    label56.Text = ((double.Parse(textBox22.Text) - double.Parse(textBox21.Text)).ToString());
                    label55.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox23.Text) > double.Parse(textBox24.Text))
                {
                    label57.Text = ((double.Parse(textBox23.Text) - double.Parse(textBox24.Text)).ToString());
                    label58.Text = Convert.ToString(0); ;
                }
                else
                {
                    label58.Text = ((double.Parse(textBox24.Text) - double.Parse(textBox23.Text)).ToString());
                    label57.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox25.Text) > double.Parse(textBox26.Text))
                {
                    label59.Text = ((double.Parse(textBox25.Text) - double.Parse(textBox26.Text)).ToString());
                    label60.Text = Convert.ToString(0); ;
                }
                else
                {
                    label60.Text = ((double.Parse(textBox26.Text) - double.Parse(textBox25.Text)).ToString());
                    label59.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox27.Text) > double.Parse(textBox28.Text))
                {
                    label61.Text = ((double.Parse(textBox27.Text) - double.Parse(textBox28.Text)).ToString());
                    label62.Text = Convert.ToString(0); ;
                }
                else
                {
                    label62.Text = ((double.Parse(textBox28.Text) - double.Parse(textBox27.Text)).ToString());
                    label61.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox29.Text) > double.Parse(textBox30.Text))
                {
                    label63.Text = ((double.Parse(textBox29.Text) - double.Parse(textBox30.Text)).ToString());
                    label64.Text = Convert.ToString(0); ;
                }
                else
                {
                    label64.Text = ((double.Parse(textBox30.Text) - double.Parse(textBox29.Text)).ToString());
                    label63.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox31.Text) > double.Parse(textBox32.Text))
                {
                    label65.Text = ((double.Parse(textBox31.Text) - double.Parse(textBox32.Text)).ToString());
                    label66.Text = Convert.ToString(0); ;
                }
                else
                {
                    label66.Text = ((double.Parse(textBox32.Text) - double.Parse(textBox31.Text)).ToString());
                    label65.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox33.Text) > double.Parse(textBox34.Text))
                {
                    label67.Text = ((double.Parse(textBox33.Text) - double.Parse(textBox34.Text)).ToString());
                    label68.Text = Convert.ToString(0); ;
                }
                else
                {
                    label68.Text = ((double.Parse(textBox34.Text) - double.Parse(textBox33.Text)).ToString());
                    label67.Text = Convert.ToString(0); ;
                }
                if (double.Parse(textBox35.Text) > double.Parse(textBox36.Text))
                {
                    label105.Text = ((double.Parse(textBox35.Text) - double.Parse(textBox36.Text)).ToString());
                    label106.Text = Convert.ToString(0); ;
                }
                else
                {
                    label106.Text = ((double.Parse(textBox36.Text) - double.Parse(textBox35.Text)).ToString());
                    label105.Text = Convert.ToString(0); ;
                }

                double taumento;
                taumento = (double.Parse(label17.Text)+double.Parse(label37.Text) + double.Parse(label39.Text) + double.Parse(label41.Text) + double.Parse(label43.Text) + double.Parse(label45.Text) + double.Parse(label47.Text) + double.Parse(label49.Text) + double.Parse(label51.Text) + double.Parse(label53.Text) + double.Parse(label55.Text) + double.Parse(label57.Text) + double.Parse(label59.Text) + double.Parse(label61.Text) + double.Parse(label63.Text) + double.Parse(label65.Text) + double.Parse(label67.Text) + double.Parse(label105.Text));
                label101.Text = Convert.ToString(taumento);
                label102.Text = Convert.ToString(double.Parse(label109.Text) + double.Parse(label38.Text) + double.Parse(label40.Text) + double.Parse(label42.Text) + double.Parse(label44.Text) + double.Parse(label46.Text) + double.Parse(label48.Text) + double.Parse(label50.Text) + double.Parse(label52.Text) + double.Parse(label54.Text) + double.Parse(label56.Text) + double.Parse(label58.Text) + double.Parse(label60.Text) + double.Parse(label62.Text) + double.Parse(label64.Text) + double.Parse(label66.Text) + double.Parse(label68.Text) + double.Parse(label106.Text)).ToString();
                button5.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(textBox1.Text) < double.Parse(textBox2.Text))
                {
                    label69.Text = ((double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString());
                    label70.Text = Convert.ToString(0);
                }
                else
                {
                    label70.Text = ((double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString());
                    label69.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox3.Text) < double.Parse(textBox4.Text))
                {
                    label71.Text = ((double.Parse(textBox4.Text) - double.Parse(textBox3.Text)).ToString());
                    label72.Text = Convert.ToString(0);
                }
                else
                {
                    label72.Text = ((double.Parse(textBox3.Text) - double.Parse(textBox4.Text)).ToString());
                    label71.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox5.Text) < double.Parse(textBox6.Text))
                {
                    label73.Text = ((double.Parse(textBox6.Text) - double.Parse(textBox5.Text)).ToString());
                    label74.Text = Convert.ToString(0);
                }
                else
                {
                    label74.Text = ((double.Parse(textBox5.Text) - double.Parse(textBox6.Text)).ToString());
                    label73.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox7.Text) < double.Parse(textBox8.Text))
                {
                    label75.Text = ((double.Parse(textBox8.Text) - double.Parse(textBox7.Text)).ToString());
                    label76.Text = Convert.ToString(0);
                }
                else
                {
                    label76.Text = ((double.Parse(textBox7.Text) - double.Parse(textBox8.Text)).ToString());
                    label75.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox9.Text) < double.Parse(textBox10.Text))
                {
                    label77.Text = ((double.Parse(textBox10.Text) - double.Parse(textBox9.Text)).ToString());
                    label78.Text = Convert.ToString(0);
                }
                else
                {
                    label78.Text = ((double.Parse(textBox9.Text) - double.Parse(textBox10.Text)).ToString());
                    label77.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox11.Text) < double.Parse(textBox12.Text))
                {
                    label79.Text = ((double.Parse(textBox12.Text) - double.Parse(textBox11.Text)).ToString());
                    label80.Text = Convert.ToString(0);
                }
                else
                {
                    label80.Text = ((double.Parse(textBox11.Text) - double.Parse(textBox12.Text)).ToString());
                    label79.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox13.Text) < double.Parse(textBox14.Text))
                {
                    label81.Text = ((double.Parse(textBox14.Text) - double.Parse(textBox13.Text)).ToString());
                    label82.Text = Convert.ToString(0);
                }
                else
                {
                    label82.Text = ((double.Parse(textBox13.Text) - double.Parse(textBox14.Text)).ToString());
                    label81.Text = Convert.ToString(0);
                }

                if (double.Parse(textBox15.Text) > double.Parse(textBox16.Text))
                {
                    label110.Text = ((double.Parse(textBox15.Text) - double.Parse(textBox16.Text)).ToString());
                    label111.Text = Convert.ToString(0);
                }
                else
                {
                    label111.Text = ((double.Parse(textBox16.Text) - double.Parse(textBox15.Text)).ToString());
                    label110.Text = Convert.ToString(0);
                }



                if (double.Parse(textBox17.Text) > double.Parse(textBox18.Text))
                {
                    label83.Text = ((double.Parse(textBox17.Text) - double.Parse(textBox18.Text)).ToString());
                    label84.Text = Convert.ToString(0);
                }
                else
                {
                    label84.Text = ((double.Parse(textBox18.Text) - double.Parse(textBox17.Text)).ToString());
                    label83.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox19.Text) > double.Parse(textBox20.Text))
                {
                    label85.Text = ((double.Parse(textBox19.Text) - double.Parse(textBox20.Text)).ToString());
                    label86.Text = Convert.ToString(0);
                }
                else
                {
                    label86.Text = ((double.Parse(textBox20.Text) - double.Parse(textBox19.Text)).ToString());
                    label85.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox21.Text) > double.Parse(textBox22.Text))
                {
                    label87.Text = ((double.Parse(textBox21.Text) - double.Parse(textBox22.Text)).ToString());
                    label88.Text = Convert.ToString(0);
                }
                else
                {
                    label88.Text = ((double.Parse(textBox22.Text) - double.Parse(textBox21.Text)).ToString());
                    label87.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox23.Text) > double.Parse(textBox24.Text))
                {
                    label89.Text = ((double.Parse(textBox23.Text) - double.Parse(textBox24.Text)).ToString());
                    label90.Text = Convert.ToString(0);
                }
                else
                {
                    label90.Text = ((double.Parse(textBox24.Text) - double.Parse(textBox23.Text)).ToString());
                    label89.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox25.Text) > double.Parse(textBox26.Text))
                {
                    label91.Text = ((double.Parse(textBox25.Text) - double.Parse(textBox26.Text)).ToString());
                    label92.Text = Convert.ToString(0);
                }
                else
                {
                    label92.Text = ((double.Parse(textBox26.Text) - double.Parse(textBox25.Text)).ToString());
                    label91.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox27.Text) > double.Parse(textBox28.Text))
                {
                    label93.Text = ((double.Parse(textBox27.Text) - double.Parse(textBox28.Text)).ToString());
                    label94.Text = Convert.ToString(0);
                }
                else
                {
                    label94.Text = ((double.Parse(textBox28.Text) - double.Parse(textBox27.Text)).ToString());
                    label93.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox29.Text) > double.Parse(textBox30.Text))
                {
                    label95.Text = ((double.Parse(textBox29.Text) - double.Parse(textBox30.Text)).ToString());
                    label96.Text = Convert.ToString(0);
                }
                else
                {
                    label96.Text = ((double.Parse(textBox30.Text) - double.Parse(textBox29.Text)).ToString());
                    label95.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox31.Text) > double.Parse(textBox32.Text))
                {
                    label97.Text = ((double.Parse(textBox31.Text) - double.Parse(textBox32.Text)).ToString());
                    label98.Text = Convert.ToString(0);
                }
                else
                {
                    label98.Text = ((double.Parse(textBox32.Text) - double.Parse(textBox31.Text)).ToString());
                    label97.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox33.Text) > double.Parse(textBox34.Text))
                {
                    label99.Text = ((double.Parse(textBox33.Text) - double.Parse(textBox34.Text)).ToString());
                    label100.Text = Convert.ToString(0);
                }
                else
                {
                    label100.Text = ((double.Parse(textBox34.Text) - double.Parse(textBox33.Text)).ToString());
                    label99.Text = Convert.ToString(0);
                }
                if (double.Parse(textBox35.Text) > double.Parse(textBox36.Text))
                {
                    label107.Text = ((double.Parse(textBox35.Text) - double.Parse(textBox36.Text)).ToString());
                    label108.Text = Convert.ToString(0);
                }
                else
                {
                    label108.Text = ((double.Parse(textBox36.Text) - double.Parse(textBox35.Text)).ToString());
                    label107.Text = Convert.ToString(0);
                }
                label103.Text = Convert.ToString(double.Parse(label110.Text) + double.Parse(label69.Text) + double.Parse(label71.Text) + double.Parse(label73.Text) + double.Parse(label75.Text) + double.Parse(label77.Text) + double.Parse(label79.Text) + double.Parse(label81.Text) + double.Parse(label83.Text) + double.Parse(label85.Text) + double.Parse(label87.Text) + double.Parse(label89.Text) + double.Parse(label91.Text) + double.Parse(label93.Text) + double.Parse(label95.Text) + double.Parse(label97.Text) + double.Parse(label99.Text) + double.Parse(label107.Text));
                label104.Text = Convert.ToString(double.Parse(label111.Text) + double.Parse(label70.Text) + double.Parse(label72.Text) + double.Parse(label74.Text) + double.Parse(label76.Text) + double.Parse(label78.Text) + double.Parse(label80.Text) + double.Parse(label82.Text) + double.Parse(label84.Text) + double.Parse(label86.Text) + double.Parse(label88.Text) + double.Parse(label90.Text) + double.Parse(label92.Text) + double.Parse(label94.Text) + double.Parse(label96.Text) + double.Parse(label98.Text) + double.Parse(label100.Text) + double.Parse(label108.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            button6.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                shareddata.Instance.activo1 = double.Parse(tactivos1.Text);
                shareddata.Instance.pasivo1 = double.Parse(tpasivo1.Text);
                shareddata.Instance.capital1 = double.Parse(tcapital1.Text);
                shareddata.Instance.pascap1 = double.Parse(tpc1.Text);
                shareddata.Instance.activo2 = double.Parse(tactivos2.Text);
                shareddata.Instance.pasivo2 = double.Parse(tpasivo2.Text);
                shareddata.Instance.capital2 = double.Parse(tcapital2.Text);
                shareddata.Instance.pascap2 = double.Parse(tpc2.Text);

                shareddata.Instance.bancos = double.Parse(textBox1.Text);
                shareddata.Instance.instrumentos_financieros = double.Parse(textBox3.Text);
                shareddata.Instance.cyddiversos = double.Parse(textBox5.Text);
                shareddata.Instance.almacen = double.Parse(textBox7.Text);
                shareddata.Instance.pagos_anticipados = double.Parse(textBox9.Text);
                shareddata.Instance.edificios = double.Parse(textBox11.Text);
                shareddata.Instance.softysis = double.Parse(textBox13.Text);

                shareddata.Instance.bancos2 = double.Parse(textBox2.Text);
                shareddata.Instance.instrumentos_financieros2 = double.Parse(textBox4.Text);
                shareddata.Instance.cyddiversos2 = double.Parse(textBox6.Text);
                shareddata.Instance.almacen2 = double.Parse(textBox8.Text);
                shareddata.Instance.pagos_anticipados2 = double.Parse(textBox10.Text);
                shareddata.Instance.edificios2 = double.Parse(textBox12.Text);
                shareddata.Instance.softysis2 = double.Parse(textBox14.Text);

                shareddata.Instance.proovedores = double.Parse(textBox15.Text);
                shareddata.Instance.acreedores = double.Parse(textBox17.Text);
                shareddata.Instance.retencion = double.Parse(textBox19.Text);
                shareddata.Instance.impuestos = double.Parse(textBox21.Text);
                shareddata.Instance.provisiones = double.Parse(textBox23.Text);
                shareddata.Instance.otros = double.Parse(textBox25.Text);
                shareddata.Instance.credito = double.Parse(textBox27.Text);

                shareddata.Instance.proovedores2 = double.Parse(textBox16.Text);
                shareddata.Instance.acreedores2 = double.Parse(textBox18.Text);
                shareddata.Instance.retencion2 = double.Parse(textBox20.Text);
                shareddata.Instance.impuestos2 = double.Parse(textBox22.Text);
                shareddata.Instance.provisiones2 = double.Parse(textBox24.Text);
                shareddata.Instance.otros2 = double.Parse(textBox26.Text);
                shareddata.Instance.credito2 = double.Parse(textBox28.Text);

                shareddata.Instance.capital_social = double.Parse(textBox29.Text);
                shareddata.Instance.aportacion = double.Parse(textBox31.Text);
                shareddata.Instance.reservas = double.Parse(textBox33.Text);
                shareddata.Instance.utilidads = double.Parse(textBox35.Text);

                shareddata.Instance.capital_social2 = double.Parse(textBox30.Text);
                shareddata.Instance.aportacion2 = double.Parse(textBox32.Text);
                shareddata.Instance.reservas2 = double.Parse(textBox34.Text);
                shareddata.Instance.utilidads2 = double.Parse(textBox36.Text);

                graficas graf = new graficas();
                graf.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Faltan datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {



            button1.Enabled = true;

        }
    }
}
