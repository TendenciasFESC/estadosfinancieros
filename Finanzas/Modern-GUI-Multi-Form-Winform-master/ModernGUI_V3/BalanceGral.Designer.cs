namespace ModernGUI_V3
{
    partial class BalanceGral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.activoCirculanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finanzasDataSet = new ModernGUI_V3.finanzasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.activoNoCirculanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pasivoCortoPlazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.pasivoLargoPlazoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.capitalContableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.activoCirculanteTableAdapter = new ModernGUI_V3.finanzasDataSetTableAdapters.ActivoCirculanteTableAdapter();
            this.activoNoCirculanteTableAdapter = new ModernGUI_V3.finanzasDataSetTableAdapters.ActivoNoCirculanteTableAdapter();
            this.capitalContableTableAdapter = new ModernGUI_V3.finanzasDataSetTableAdapters.CapitalContableTableAdapter();
            this.pasivoCortoPlazoTableAdapter = new ModernGUI_V3.finanzasDataSetTableAdapters.PasivoCortoPlazoTableAdapter();
            this.pasivoLargoPlazoTableAdapter = new ModernGUI_V3.finanzasDataSetTableAdapters.PasivoLargoPlazoTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activoCirculanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activoNoCirculanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasivoCortoPlazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasivoLargoPlazoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalContableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.activoCirculanteBindingSource;
            this.comboBox1.DisplayMember = "NombreCuenta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "NombreCuenta";
            // 
            // activoCirculanteBindingSource
            // 
            this.activoCirculanteBindingSource.DataMember = "ActivoCirculante";
            this.activoCirculanteBindingSource.DataSource = this.finanzasDataSet;
            // 
            // finanzasDataSet
            // 
            this.finanzasDataSet.DataSetName = "finanzasDataSet";
            this.finanzasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Activo circulante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Avtivo no circulante";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.activoNoCirculanteBindingSource;
            this.comboBox2.DisplayMember = "NombreCuenta";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(22, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "NombreCuenta";
            // 
            // activoNoCirculanteBindingSource
            // 
            this.activoNoCirculanteBindingSource.DataMember = "ActivoNoCirculante";
            this.activoNoCirculanteBindingSource.DataSource = this.finanzasDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pasivo a Corto Plaxo";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.pasivoCortoPlazoBindingSource;
            this.comboBox3.DisplayMember = "NombreCuenta";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(25, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "NombreCuenta";
            // 
            // pasivoCortoPlazoBindingSource
            // 
            this.pasivoCortoPlazoBindingSource.DataMember = "PasivoCortoPlazo";
            this.pasivoCortoPlazoBindingSource.DataSource = this.finanzasDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pasivo a Largo Plazo";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.pasivoLargoPlazoBindingSource;
            this.comboBox4.DisplayMember = "NombreCuenta";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(25, 218);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.ValueMember = "NombreCuenta";
            // 
            // pasivoLargoPlazoBindingSource
            // 
            this.pasivoLargoPlazoBindingSource.DataMember = "PasivoLargoPlazo";
            this.pasivoLargoPlazoBindingSource.DataSource = this.finanzasDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Capital Contable";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.capitalContableBindingSource;
            this.comboBox5.DisplayMember = "NombreCuenta";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(25, 277);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 18;
            this.comboBox5.ValueMember = "NombreCuenta";
            // 
            // capitalContableBindingSource
            // 
            this.capitalContableBindingSource.DataMember = "CapitalContable";
            this.capitalContableBindingSource.DataSource = this.finanzasDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(300, 278);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 278);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // activoCirculanteTableAdapter
            // 
            this.activoCirculanteTableAdapter.ClearBeforeFill = true;
            // 
            // activoNoCirculanteTableAdapter
            // 
            this.activoNoCirculanteTableAdapter.ClearBeforeFill = true;
            // 
            // capitalContableTableAdapter
            // 
            this.capitalContableTableAdapter.ClearBeforeFill = true;
            // 
            // pasivoCortoPlazoTableAdapter
            // 
            this.pasivoCortoPlazoTableAdapter.ClearBeforeFill = true;
            // 
            // pasivoLargoPlazoTableAdapter
            // 
            this.pasivoLargoPlazoTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Cantidad});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(392, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 164);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Activo Circulante";
            this.columnHeader1.Width = 98;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 95;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(392, 188);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(243, 164);
            this.listView2.TabIndex = 36;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Activo No Circulante";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(641, 18);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(243, 164);
            this.listView3.TabIndex = 37;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pasivo a Corto Plazo";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cantidad";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(641, 188);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(243, 164);
            this.listView4.TabIndex = 38;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pasivo a Largo Plazo";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cantidad";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(641, 358);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(243, 164);
            this.listView5.TabIndex = 39;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Capital Contable";
            this.columnHeader9.Width = 115;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cantidad";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(535, 528);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 40;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(784, 528);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 41;
            this.textBox7.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Total Activo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Total Pasivo+CC";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 642);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(103, 642);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 46;
            this.button8.Text = "terminar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(876, 546);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(809, 642);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 48;
            this.button9.Text = "Guardar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModernGUI_V3.Properties.Resources.close_window;
            this.pictureBox1.Location = new System.Drawing.Point(944, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 313;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(728, 642);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 314;
            this.print.Text = "imprimir";
            this.print.UseVisualStyleBackColor = true;
            this.print.Visible = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // BalanceGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 677);
            this.Controls.Add(this.print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BalanceGral";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activoCirculanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finanzasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activoNoCirculanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasivoCortoPlazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasivoLargoPlazoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capitalContableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private finanzasDataSet finanzasDataSet;
        private System.Windows.Forms.BindingSource activoCirculanteBindingSource;
        private finanzasDataSetTableAdapters.ActivoCirculanteTableAdapter activoCirculanteTableAdapter;
        private System.Windows.Forms.BindingSource activoNoCirculanteBindingSource;
        private finanzasDataSetTableAdapters.ActivoNoCirculanteTableAdapter activoNoCirculanteTableAdapter;
        private System.Windows.Forms.BindingSource capitalContableBindingSource;
        private finanzasDataSetTableAdapters.CapitalContableTableAdapter capitalContableTableAdapter;
        private System.Windows.Forms.BindingSource pasivoCortoPlazoBindingSource;
        private finanzasDataSetTableAdapters.PasivoCortoPlazoTableAdapter pasivoCortoPlazoTableAdapter;
        private System.Windows.Forms.BindingSource pasivoLargoPlazoBindingSource;
        private finanzasDataSetTableAdapters.PasivoLargoPlazoTableAdapter pasivoLargoPlazoTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button print;
    }
}