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
    public partial class razones : Form
    {
        public static double ventas = estado_resultados.Instance.ventas;
        public static double ventas2 = estado_resultados.Instance.ventas2;
        public static double activo1 = shareddata.Instance.activo1;
        public static double activo2 = shareddata.Instance.activo2;
        public static double pasivo1 = shareddata.Instance.pasivo1;
        public static double pasivo2 = shareddata.Instance.pasivo2;
        public static double capital1 = shareddata.Instance.capital1;
        public static double capital2 = shareddata.Instance.capital2;
        public static double utilidads = shareddata.Instance.utilidads;
        public static double utilidads2 = shareddata.Instance.utilidads2;
        public static double utilidad_de_operacion = estado_resultados.Instance.utilidad_de_operacion;
        public static double utilidad_de_operacion2 = estado_resultados.Instance.utilidad_de_operacion2;
        public static double utilidad_bruta = estado_resultados.Instance.utilidad_bruta;
        public static double utilidad_bruta2 = estado_resultados.Instance.utilidad_bruta2;

        public static double actotal1 = ventas / activo1; //rotacion de activo total 2018
        public static double actotal2 = ventas2 / activo2;//rotacion del activo total 2017
        public static double endeudamiento1 = pasivo1 / capital1; //Razon de endeudamiento 2018
        public static double endeudamiento2 = pasivo2 / capital2; //Razon de endeudamiento 2017
        public static double deuda1 = pasivo1 / activo1; //Razon de la deuda 2018
        public static double deuda2 = pasivo2 / activo2; //Razon de la deuda 2017
        public static double rautilidad1 = utilidads / ventas; //Razon de utilidad 2018
        public static double rautilidad2 = utilidads2 / ventas2; //Razon de utilidad 2017
        public static double intotal1 = utilidad_de_operacion / ventas;// Rendimiento sobre la inversion total 2018
        public static double intotal2 = utilidad_de_operacion2 / ventas2; //Rendimiento sobre la inversion total 2017
        public static double utbruta1 = utilidad_bruta / ventas; //Margen de utilidad bruta
        public static double utbruta2 = utilidad_bruta2 / ventas2;
        public static double explotacion1 = utilidad_de_operacion / ventas;//Margen de venta de explotacion 2018
        public static double explotacion2 = utilidad_de_operacion2 / ventas2;//Margen de venta de explotacion 2017
        public static double neto_utilidad1 = (utilidads + utilidad_de_operacion + utilidad_bruta) / ventas; // Margen neto de utilidad2017
        public static double neto_utilidad2 = (utilidads2 + utilidad_de_operacion2 + utilidad_bruta2) / ventas2; // Margen neto de utilidad 2018
        public static double ntotal1 = utilidad_de_operacion / activo1;
        public static double ntotal2 = utilidad_de_operacion2 / activo2;
        public static double retorno = (utilidads + utilidad_de_operacion + utilidad_bruta) / capital1;
        public static double retorn2 = (utilidads2 + utilidad_de_operacion2 + utilidad_bruta2) / capital2;
        public razones()
        {
            InitializeComponent();
        }

        private static void mensajes(string mensaje, string info)
        {
            MessageBox.Show(mensaje, info, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void razones_Load(object sender, EventArgs e)
        {
            //textBox7.Text = deuda2.ToString();
            //textBox8.Text = deuda2.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = deuda2.ToString();
            textBox6.Text = deuda1.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensajes("Eficiencia en el uso de recursos totales para generar ventas",
    "Rotacion del activo total");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mensajes("Relación entre fondos apartados por los acreedores y los socios",
     "Razon de endeudamiento");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mensajes("Proporción del act. financiado mediante deudas",
  "Razon de la deuda");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mensajes("Rendimiento final derivado de las ventas con respecto a la utilidad",
  "^Margen de Utilidad");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = endeudamiento2.ToString();
            textBox4.Text = endeudamiento1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = actotal2.ToString();
            textBox2.Text = actotal1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mensajes("Rentas final obtenidas sobre los activos totales muestra la eficiencia y la eficacia en el uso de los recursos",
 "Rendimiento sobre la inversion total");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox11.Text = utbruta2.ToString();
            textBox12.Text = utbruta1.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mensajes("Porcentaje de utilidad obtenido de las operaciones normales de la empresa",
 "Margen de venta de explotación");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox15.Text = Convert.ToString(neto_utilidad2);
            textBox16.Text = Convert.ToString(neto_utilidad1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            mensajes("Rendimiento final derivado de las ventas con respecto a la utilidad", "Margen neto de utilidad");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = utbruta2.ToString();
            textBox8.Text = utbruta1.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox9.Text = ntotal2.ToString();
            textBox10.Text = ntotal1.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox13.Text = explotacion2.ToString();
            textBox14.Text = explotacion2.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox18.Text = retorn2.ToString();
            textBox17.Text = retorno.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            mensajes("Es Cuanto ganas contra lo que has invertido (se lee en %)", "Retorno de Capital");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mensajes("es el precio del producto una vez deducidos los costos directos e indirectos de fabricación", "Margen de utilidad Bruta");
        }
    }
}
