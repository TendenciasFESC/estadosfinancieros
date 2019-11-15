using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace ModernGUI_V3
{
    public partial class BalanceGral : Form
    {
        
        
        public BalanceGral()
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
            button9.Visible = false;
            print.Visible = false;
        }

        private void terminar(string[,] balance, int mayor)
        {
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
            balance[mayor + 5, 0] = "Total Activos";
            balance[mayor + 5, 1] = Convert.ToString(textBox6.Text);
            balance[mayor + 5, 2] = "Total Pasivos y CC";
            balance[mayor + 5, 3] = Convert.ToString(textBox7.Text);
            DataTable tabla = new DataTable();
            DataRow renglon;
            tabla.Columns.Add(new DataColumn("Activos"));
            tabla.Columns.Add(new DataColumn("cantidad1"));
            tabla.Columns.Add(new DataColumn("Pasivos"));
            tabla.Columns.Add(new DataColumn("Cantidad2"));
            for (int k = 0; k < mayor + 6; k++)
            {
                renglon = tabla.NewRow();
                renglon[0] = balance[k, 0];
                renglon[1] = balance[k, 1];
                renglon[2] = balance[k, 2];
                renglon[3] = balance[k, 3];
                tabla.Rows.Add(renglon);
            }
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Visible = true;
        }

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                MessageBox.Show("Guardado con exito!", "Listo!");
                limpiar();
            }
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
            //Prueba Git
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
                int mayor = sumaAc;
                string[,] balance = new string[sumaAc+6,4];
                terminar(balance, mayor);
            }
            else
            {
                int mayor = SumaP;
                string[,] balance = new string[SumaP+6, 4];
                terminar(balance, mayor);
                
            }
            button9.Visible = true;
            print.Visible = true;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dataGridView1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;

                    if (col.Index < dataGridView1.ColumnCount - 1)
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dataGridView1.RowCount - 1) * DGV_ALTO);
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index == dataGridView1.RowCount) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }
    }
}
