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

        private void limpiar()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            textBox6.Text = "0";
            textBox7.Text = "0";
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finanzasDataSet.PasivoLargoPlazo' Puede moverla o quitarla según sea necesario.
            this.pasivoLargoPlazoTableAdapter.Fill(this.finanzasDataSet.PasivoLargoPlazo);
            // TODO: esta línea de código carga datos en la tabla 'finanzasDataSet.PasivoCortoPlazo' Puede moverla o quitarla según sea necesario.
            this.pasivoCortoPlazoTableAdapter.Fill(this.finanzasDataSet.PasivoCortoPlazo);
            // TODO: esta línea de código carga datos en la tabla 'finanzasDataSet.CapitalContable' Puede moverla o quitarla según sea necesario.
            this.capitalContableTableAdapter.Fill(this.finanzasDataSet.CapitalContable);
            // TODO: esta línea de código carga datos en la tabla 'finanzasDataSet.ActivoNoCirculante' Puede moverla o quitarla según sea necesario.
            this.activoNoCirculanteTableAdapter.Fill(this.finanzasDataSet.ActivoNoCirculante);
            // TODO: esta línea de código carga datos en la tabla 'finanzasDataSet.ActivoCirculante' Puede moverla o quitarla según sea necesario.
            this.activoCirculanteTableAdapter.Fill(this.finanzasDataSet.ActivoCirculante);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                ListViewItem uno = new ListViewItem(comboBox1.Text);
                uno.SubItems.Add(textBox1.Text);
                listView1.Items.Add(uno);
                textBox1.Text = "";
                Double suma = 0;
                foreach(ListViewItem item in listView1.Items)
                {
                    suma += Convert.ToDouble(item.SubItems[1].Text);
                }
                foreach (ListViewItem item1 in listView2.Items)
                {
                    suma += Convert.ToDouble(item1.SubItems[1].Text);
                }
                textBox6.Text = Convert.ToString(suma);
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                ListViewItem uno = new ListViewItem(comboBox2.Text);
                uno.SubItems.Add(textBox2.Text);
                listView2.Items.Add(uno);
                textBox2.Text = "";
                Double suma = 0;
                foreach (ListViewItem item in listView2.Items)
                {
                    suma += Convert.ToDouble(item.SubItems[1].Text);
                }
                foreach (ListViewItem item1 in listView1.Items)
                {
                    suma += Convert.ToDouble(item1.SubItems[1].Text);
                }
                textBox6.Text = Convert.ToString(suma);
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox3.Text.Equals(""))
            {
                ListViewItem uno = new ListViewItem(comboBox3.Text);
                uno.SubItems.Add(textBox3.Text);
                listView3.Items.Add(uno);
                textBox3.Text = "";
                Double suma = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    suma += Convert.ToDouble(item.SubItems[1].Text);
                }
                foreach (ListViewItem item2 in listView4.Items)
                {
                    suma += Convert.ToDouble(item2.SubItems[1].Text);
                }
                foreach (ListViewItem item3 in listView5.Items)
                {
                    suma += Convert.ToDouble(item3.SubItems[1].Text);
                }
                textBox7.Text = Convert.ToString(suma);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals(""))
            {
                ListViewItem uno = new ListViewItem(comboBox4.Text);
                uno.SubItems.Add(textBox4.Text);
                listView4.Items.Add(uno);
                textBox4.Text = "";
                Double suma = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    suma += Convert.ToDouble(item.SubItems[1].Text);
                }
                foreach (ListViewItem item2 in listView4.Items)
                {
                    suma += Convert.ToDouble(item2.SubItems[1].Text);
                }
                foreach (ListViewItem item3 in listView5.Items)
                {
                    suma += Convert.ToDouble(item3.SubItems[1].Text);
                }
                textBox7.Text = Convert.ToString(suma);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!textBox5.Text.Equals(""))
            {
                ListViewItem uno = new ListViewItem(comboBox5.Text);
                uno.SubItems.Add(textBox5.Text);
                listView5.Items.Add(uno);
                textBox5.Text = "";
                Double suma = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    suma += Convert.ToDouble(item.SubItems[1].Text);
                }
                foreach (ListViewItem item2 in listView4.Items)
                {
                    suma += Convert.ToDouble(item2.SubItems[1].Text);
                }
                foreach (ListViewItem item3 in listView5.Items)
                {
                    suma += Convert.ToDouble(item3.SubItems[1].Text);
                }
                textBox7.Text = Convert.ToString(suma);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox6.Text) != double.Parse(textBox7.Text))
            {
                MessageBox.Show("El balance no cuadra", "Error");
                return;
            }

            int sumaAc, SumaP;

            sumaAc = listView1.Items.Count;
            sumaAc += listView2.Items.Count;
            SumaP = listView3.Items.Count;
            SumaP += listView4.Items.Count;
            SumaP += listView5.Items.Count;


            if (sumaAc > SumaP)
            {
                string[,] balance = new string[sumaAc+6,4];
                int i = 0;
                double sum = 0;
                foreach(ListViewItem item in listView1.Items)
                {
                    balance[i, 0] = item.Text;
                    balance[i, 1] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 1]);
                    i++;
                }
                balance[i, 0] = "Total";
                balance[i, 1] = Convert.ToString(sum);
                i++;
                balance[i, 0] = "Activo No Circulante";
                balance[i, 1] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView2.Items)
                {
                    balance[i, 0] = item.Text;
                    balance[i, 1] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 1]);
                    i++;
                }
                balance[i, 0] = "Total";
                balance[i, 1] = Convert.ToString(sum);
                i = 0;
                sum = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                i++;
                balance[i, 2] = "Pasivo a Largo Plazo";
                balance[i, 3] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView4.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                i++;
                balance[i, 2] = "Capital contable";
                balance[i, 3] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView5.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                DataTable tabla = new DataTable();
                DataRow renglon;
                tabla.Columns.Add(new DataColumn("Activos"));
                tabla.Columns.Add(new DataColumn("cantidad1"));
                tabla.Columns.Add(new DataColumn("Pasivos"));
                tabla.Columns.Add(new DataColumn("Cantidad2"));
                for (int k = 0; k < sumaAc + 5; k++)
                {
                    renglon = tabla.NewRow();
                    renglon[0] = balance[k, 0];
                    renglon[1] = balance[k, 1];
                    renglon[2] = balance[k, 2];
                    renglon[3] = balance[k, 3];
                    tabla.Rows.Add(renglon);
                }
                dataGridView1.DataSource = tabla;
                dataGridView1.Visible = true;
            }
            else
            {
                string[,] balance = new string[SumaP+6, 4];
                int i = 0;
                double sum = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    balance[i, 0] = item.Text;
                    balance[i, 1] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 1]);
                    i++;
                }
                balance[i, 0] = "Total";
                balance[i, 1] = Convert.ToString(sum);
                i++;
                balance[i, 0] = "Activo No Circulante";
                balance[i, 1] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView2.Items)
                {
                    balance[i, 0] = item.Text;
                    balance[i, 1] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 1]);
                    i++;
                }
                balance[i, 0] = "Total";
                balance[i, 1] = Convert.ToString(sum);
                i = 0;
                sum = 0;
                foreach (ListViewItem item in listView3.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                i++;
                balance[i, 2] = "Pasivo a Largo Plazo";
                balance[i, 3] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView4.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                i++;
                balance[i, 2] = "Capital contable";
                balance[i, 3] = "";
                i++;
                sum = 0;
                foreach (ListViewItem item in listView5.Items)
                {
                    balance[i, 2] = item.Text;
                    balance[i, 3] = item.SubItems[1].Text;
                    sum += double.Parse(balance[i, 3]);
                    i++;
                }
                balance[i, 2] = "Total";
                balance[i, 3] = Convert.ToString(sum);
                DataTable tabla = new DataTable();
                DataRow renglon;
                tabla.Columns.Add(new DataColumn("Activos"));
                tabla.Columns.Add(new DataColumn("cantidad1"));
                tabla.Columns.Add(new DataColumn("Pasivos"));
                tabla.Columns.Add(new DataColumn("Cantidad2"));
                for (int k = 0; k < sumaAc + 5; k++)
                {
                    renglon = tabla.NewRow();
                    renglon[0] = balance[k, 0];
                    renglon[1] = balance[k, 1];
                    renglon[2] = balance[k, 2];
                    renglon[3] = balance[k, 3];
                    tabla.Rows.Add(renglon);
                }
                dataGridView1.DataSource = tabla;
                dataGridView1.Visible = true;
            }


           
            foreach (ListViewItem item in listView2.Items)
            {
            }
            foreach (ListViewItem item in listView3.Items)
            {
            }
            foreach (ListViewItem item in listView4.Items)
            {
            }
            foreach (ListViewItem item in listView5.Items)
            {
            }
            
        }
    }
}
