using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ModernGUI_V3
{
    public partial class FlujoEfectivo : Form
    {
        public FlujoEfectivo()
        {
            InitializeComponent();
        }

        public List<object> lista = new List<object>();


        public void FillComboTipo()
        {
            comboTipo.Items.Add("Operación");
            comboTipo.Items.Add("Financiación");
            comboTipo.Items.Add("Inversión");
        }
        public void FillComboSigno()
        {
            comboSigno.Items.Add("Positivo");
            comboSigno.Items.Add("Negativo");
        }

        public void sumaTotal()
        {
            Double dblSuma = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text.Substring(item.SubItems[1].Text.Length - 8, 8).Equals("Positivo"))
                {
                    dblSuma += Convert.ToDouble(item.SubItems[2].Text);
                }
                else
                {
                    dblSuma -= Convert.ToDouble(item.SubItems[2].Text);
                }

            }
            tbTotalOp.Text = Convert.ToString(dblSuma);
            dblSuma = 0;

            foreach (ListViewItem item in listView2.Items)
            {
                if (item.SubItems[1].Text.Substring(item.SubItems[1].Text.Length - 8, 8).Equals("Positivo"))
                {
                    dblSuma += Convert.ToDouble(item.SubItems[2].Text);
                }
                else
                {
                    dblSuma -= Convert.ToDouble(item.SubItems[2].Text);
                }
            }
            tbTotalFin.Text = Convert.ToString(dblSuma);
            dblSuma = 0;

            foreach (ListViewItem item in listView3.Items)
            {
                if (item.SubItems[1].Text.Substring(item.SubItems[1].Text.Length - 8, 8).Equals("Positivo"))
                {
                    dblSuma += Convert.ToDouble(item.SubItems[2].Text);
                }
                else
                {
                    dblSuma -= Convert.ToDouble(item.SubItems[2].Text);
                }
            }
            tbTotalInv.Text = Convert.ToString(dblSuma);
            dblSuma = 0;

            dblSuma = Convert.ToDouble(tbTotalOp.Text) + Convert.ToDouble(tbTotalInv.Text) + Convert.ToDouble(tbTotalFin.Text);
            tbTotalGeneral.Text = Convert.ToString(dblSuma);
        }
        public void llenarCuentas()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\src\\catalogo_de_cuentas.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    comboCuenta.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void vaciarCampos()
        {
            comboCuenta.SelectedIndex = -1;
            comboSigno.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
            tbSaldos.Text = "";
        }

        public void leerArchivo()
        {
            String ruta = "";
            Boolean flag = true;
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    ruta = fd.SelectedPath;
                }
                string[] files = Directory.GetFiles(ruta);
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Substring(files[i].Length - 6, 6).Equals("op.txt") || files[i].Substring(files[i].Length - 6, 6).Equals("fi.txt") || files[i].Substring(files[i].Length - 6, 6).Equals("in.txt"))
                    {
                        if (flag == true)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La carpeta seleccionada no contiene un estado de Flujo de Efectivo", "Error");
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    borrarTodo();
                    try
                    {
                        borrarTodo();
                        String line;
                        List<String> lista = new List<String>();
                        StreamReader sr = new StreamReader(ruta + "\\op.txt");
                        line = sr.ReadLine();
                        int x = 0;
                        while (line != null)
                        {
                            lista.Add(line);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        string[] buff = new string[3];
                        foreach (string par in lista)
                        {
                            if (x >= 2)
                            {
                                buff[x] = par;
                                ListViewItem lista1 = new ListViewItem(buff[0]);
                                lista1.SubItems.Add(buff[1]);
                                lista1.SubItems.Add(buff[2]);
                                listView1.Items.Add(lista1);
                                x = 0;

                            }
                            else
                            {
                                buff[x] = par; ;
                                x++;
                            }

                        }
                        sumaTotal();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    try
                    {
                        String line;
                        List<String> lista = new List<String>();
                        StreamReader sf = new StreamReader(ruta + "\\fi.txt");
                        line = sf.ReadLine();
                        int x = 0;
                        while (line != null)
                        {
                            lista.Add(line);
                            line = sf.ReadLine();
                        }
                        sf.Close();
                        string[] buff = new string[3];
                        foreach (string par in lista)
                        {
                            if (x >= 2)
                            {
                                buff[x] = par;
                                ListViewItem lista1 = new ListViewItem(buff[0]);
                                lista1.SubItems.Add(buff[1]);
                                lista1.SubItems.Add(buff[2]);
                                listView2.Items.Add(lista1);
                                x = 0;
                            }
                            else
                            {
                                buff[x] = par;
                                x++;
                            }

                        }
                        sumaTotal();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    try
                    {
                        String line;
                        List<String> lista = new List<String>();
                        StreamReader si = new StreamReader(ruta + "\\in.txt");
                        line = si.ReadLine();
                        int x = 0;
                        while (line != null)
                        {
                            lista.Add(line);
                            line = si.ReadLine();
                        }
                        si.Close();
                        string[] buff = new string[3];
                        foreach (string par in lista)
                        {
                            if (x >= 2)
                            {
                                buff[x] = par;
                                ListViewItem lista1 = new ListViewItem(buff[0]);
                                lista1.SubItems.Add(buff[1]);
                                lista1.SubItems.Add(buff[2]);
                                listView3.Items.Add(lista1);
                                x = 0;
                            }
                            else
                            {
                                buff[x] = par;
                                x++;
                            }

                        }
                        sumaTotal();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                }
            }
        }

        public void borrarTodo()
        {
            if (listView1.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView1.Items)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
            if (listView2.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView2.Items)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
            if (listView3.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView3.Items)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
        }

        private void guardadArchivo()
        {
            String ruta = "";
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    ruta = fd.SelectedPath;
                    try
                    {
                        StreamWriter sw = new StreamWriter(ruta + "\\op.txt");
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                            {
                                string s = listView1.Items[i].SubItems[j].Text;
                                sw.WriteLine(s);

                            }
                        }
                        sw.Close();
                        StreamWriter sf = new StreamWriter(ruta + "\\fi.txt");
                        for (int i = 0; i < listView2.Items.Count; i++)
                        {
                            for (int j = 0; j < listView2.Items[i].SubItems.Count; j++)
                            {
                                string s = listView2.Items[i].SubItems[j].Text;
                                sf.WriteLine(s);

                            }
                        }
                        sf.Close();
                        StreamWriter si = new StreamWriter(ruta + "\\in.txt");
                        for (int i = 0; i < listView3.Items.Count; i++)
                        {
                            for (int j = 0; j < listView3.Items[i].SubItems.Count; j++)
                            {
                                string s = listView3.Items[i].SubItems[j].Text;
                                si.WriteLine(s);

                            }
                        }
                        si.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboTipo.SelectedIndex >= 0 && comboSigno.SelectedIndex >= 0 && !(string.IsNullOrEmpty(tbSaldos.Text)) && comboCuenta.SelectedIndex >= 0)
            {
                switch (comboTipo.SelectedIndex)
                {
                    case 0:
                        ListViewItem lista1 = new ListViewItem(comboCuenta.Text);
                        lista1.SubItems.Add(comboSigno.Text);
                        lista1.SubItems.Add(tbSaldos.Text);
                        listView1.Items.Add(lista1);
                        break;
                    case 1:
                        ListViewItem lista2 = new ListViewItem(comboCuenta.Text);
                        lista2.SubItems.Add(comboSigno.Text);
                        lista2.SubItems.Add(tbSaldos.Text);
                        listView2.Items.Add(lista2);
                        break;
                    case 2:
                        ListViewItem lista3 = new ListViewItem(comboCuenta.Text);
                        lista3.SubItems.Add(comboSigno.Text);
                        lista3.SubItems.Add(tbSaldos.Text);
                        listView3.Items.Add(lista3);
                        break;
                }
                vaciarCampos();
                sumaTotal();
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Error");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
            if (listView2.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView2.SelectedItems)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
            if (listView3.SelectedItems != null)
            {
                foreach (ListViewItem lista in listView3.SelectedItems)
                {
                    lista.Remove();
                }
                sumaTotal();
            }
        }

        private void tbSaldos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                Console.Write(23);
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                leerArchivo();
            }
            catch (Exception)
            {

            }

        }

        private void FlujoEfectivo_Load(object sender, EventArgs e)
        {
            FillComboTipo();
            FillComboSigno();
            llenarCuentas();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            guardadArchivo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
