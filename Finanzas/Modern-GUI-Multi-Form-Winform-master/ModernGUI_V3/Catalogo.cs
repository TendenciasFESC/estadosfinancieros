using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ModernGUI_V3
{
    public partial class Catalogo : Form
    {
     

        public Catalogo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finanzasDataSet.PasivoLargoPlazo' table. You can move, or remove it, as needed.
            this.pasivoLargoPlazoTableAdapter.Fill(this.finanzasDataSet.PasivoLargoPlazo);
            // TODO: This line of code loads data into the 'finanzasDataSet.PasivoCortoPlazo' table. You can move, or remove it, as needed.
            this.pasivoCortoPlazoTableAdapter.Fill(this.finanzasDataSet.PasivoCortoPlazo);
            // TODO: This line of code loads data into the 'finanzasDataSet.CapitalContable' table. You can move, or remove it, as needed.
            this.capitalContableTableAdapter.Fill(this.finanzasDataSet.CapitalContable);
            // TODO: This line of code loads data into the 'finanzasDataSet.ActivoNoCirculante' table. You can move, or remove it, as needed.
            this.activoNoCirculanteTableAdapter.Fill(this.finanzasDataSet.ActivoNoCirculante);
            // TODO: This line of code loads data into the 'finanzasDataSet.ActivoCirculante' table. You can move, or remove it, as needed.
            this.activoCirculanteTableAdapter.Fill(this.finanzasDataSet.ActivoCirculante);
            // TODO: This line of code loads data into the 'finanzasDataSet.ActivoCirculante' table. You can move, or remove it, as needed.
            this.activoCirculanteTableAdapter.Fill(this.finanzasDataSet.ActivoCirculante);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.activoCirculanteTableAdapter.FillBy(this.finanzasDataSet.ActivoCirculante);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView4.Visible = false;
            dataGridView5.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = true;
            dataGridView5.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            dataGridView5.Visible = true;

        }
    }
}
