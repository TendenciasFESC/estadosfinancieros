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


namespace ModernGUI_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void utilidadbruta()
        {
            try
            {
                textBox3.Text = Convert.ToString(double.Parse(textBox1.Text) - double.Parse(textBox2.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void utilidadantesISR()
        {
            try
            {
                textBox8.Text = Convert.ToString(double.Parse(textBox5.Text) + double.Parse(textBox6.Text) - double.Parse(textBox7.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void utilidadNeta()
        {
            try
            {
                textBox11.Text = Convert.ToString(double.Parse(textBox8.Text) - double.Parse(textBox9.Text) - double.Parse(textBox10.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void limpiar()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            dataGridView1.Visible = false;
            print.Visible = false;
            button9.Visible = false;
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            utilidadbruta();

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            utilidadbruta();

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = Convert.ToString(double.Parse(textBox3.Text) - double.Parse(textBox4.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            utilidadantesISR();
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            utilidadantesISR();

        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            utilidadNeta();

        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            utilidadNeta();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[,] estado = new string[2, 11];

            try
            {
                estado[0, 0] = label1.Text;
                estado[0, 1] = label2.Text;
                estado[0, 2] = label3.Text;
                estado[0, 3] = label4.Text;
                estado[0, 4] = label5.Text;
                estado[0, 5] = label6.Text;
                estado[0, 6] = label7.Text;
                estado[0, 7] = label8.Text;
                estado[0, 8] = label9.Text;
                estado[0, 9] = label10.Text;
                estado[0, 10] = label11.Text;

                estado[1, 0] = textBox1.Text;
                estado[1, 1] = textBox2.Text;
                estado[1, 2] = textBox3.Text;
                estado[1, 3] = textBox4.Text;
                estado[1, 4] = textBox5.Text;
                estado[1, 5] = textBox6.Text;
                estado[1, 6] = textBox7.Text;
                estado[1, 7] = textBox8.Text;
                estado[1, 8] = textBox9.Text;
                estado[1, 9] = textBox10.Text;
                estado[1, 10] = textBox11.Text;

                DataTable tabla = new DataTable();
                DataRow renglon;
                tabla.Columns.Add(new DataColumn("Estado de resultados"));
                tabla.Columns.Add(new DataColumn("Cantidad"));
                for (int i = 0; i < 11; i++)
                {
                    renglon = tabla.NewRow();
                    renglon[0] = estado[0, i];
                    renglon[1] = estado[1, i];
                    tabla.Rows.Add(renglon);
                }
                dataGridView1.DataSource = tabla;
                dataGridView1.Columns[0].Width = 350;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Visible = true;
                print.Visible = true;
                button9.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos o formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dataGridView1);
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
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 8), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
