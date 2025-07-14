namespace pulperia_mym
{
    partial class FormPulperia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPulperia));
            tabControl1 = new TabControl();
            tabInicio = new TabPage();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabVentas = new TabPage();
            panel1 = new Panel();
            tabProductos = new TabPage();
            panel3 = new Panel();
            dgvProductos = new DataGridView();
            Id_Producto = new DataGridViewTextBoxColumn();
            Nombre_Producto = new DataGridViewTextBoxColumn();
            Stock_Almacen = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabSolProductos = new TabPage();
            panel4 = new Panel();
            tabOrdenRepo = new TabPage();
            panel5 = new Panel();
            tabRegFactura = new TabPage();
            panel7 = new Panel();
            tabConfig = new TabPage();
            panel8 = new Panel();
            tabReportes = new TabPage();
            panel6 = new Panel();
            btnGenerarGraficos = new Button();
            dgMasvendido = new DataGridView();
            chVentasGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chVentasSemanales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlLogin = new Panel();
            lblPass = new Label();
            lblUser = new Label();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            lblLoginTitle = new Label();
            btnMostrar = new Button();
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabVentas.SuspendLayout();
            tabProductos.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabSolProductos.SuspendLayout();
            tabOrdenRepo.SuspendLayout();
            tabRegFactura.SuspendLayout();
            tabConfig.SuspendLayout();
            tabReportes.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMasvendido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chVentasGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chVentasSemanales).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInicio);
            tabControl1.Controls.Add(tabVentas);
            tabControl1.Controls.Add(tabProductos);
            tabControl1.Controls.Add(tabSolProductos);
            tabControl1.Controls.Add(tabOrdenRepo);
            tabControl1.Controls.Add(tabRegFactura);
            tabControl1.Controls.Add(tabConfig);
            tabControl1.Controls.Add(tabReportes);
            tabControl1.Location = new Point(-1, 11);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(783, 441);
            tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(panel2);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Margin = new Padding(2);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(2);
            tabInicio.Size = new Size(775, 413);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Inicio";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 411);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "descripcion MYM";
            // 
            // button1
            // 
            button1.Location = new Point(638, 17);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(25, 18);
            button1.TabIndex = 4;
            button1.Text = "s";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(675, 16);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(77, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Buscar";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(20, 99);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(731, 197);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(20, 16);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 58);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(panel1);
            tabVentas.Location = new Point(4, 24);
            tabVentas.Margin = new Padding(2);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(2);
            tabVentas.Size = new Size(775, 413);
            tabVentas.TabIndex = 1;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 413);
            panel1.TabIndex = 1;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(panel3);
            tabProductos.Location = new Point(4, 24);
            tabProductos.Margin = new Padding(2);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(2);
            tabProductos.Size = new Size(775, 413);
            tabProductos.TabIndex = 2;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnMostrar);
            panel3.Controls.Add(dgvProductos);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnModificar);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(4, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(769, 413);
            panel3.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id_Producto, Nombre_Producto, Stock_Almacen });
            dgvProductos.Location = new Point(137, 70);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(490, 249);
            dgvProductos.TabIndex = 10;
            // 
            // Id_Producto
            // 
            Id_Producto.HeaderText = "ID";
            Id_Producto.Name = "Id_Producto";
            Id_Producto.ReadOnly = true;
            Id_Producto.Width = 150;
            // 
            // Nombre_Producto
            // 
            Nombre_Producto.HeaderText = "NombreProducto";
            Nombre_Producto.Name = "Nombre_Producto";
            Nombre_Producto.ReadOnly = true;
            Nombre_Producto.Width = 150;
            // 
            // Stock_Almacen
            // 
            Stock_Almacen.HeaderText = "Unidades en almacen";
            Stock_Almacen.Name = "Stock_Almacen";
            Stock_Almacen.ReadOnly = true;
            Stock_Almacen.Width = 150;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.Location = new Point(602, 15);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLight;
            textBox4.Location = new Point(380, 15);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.Location = new Point(126, 15);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(455, 351);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(374, 351);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 18);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 2;
            label4.Text = "Unidades en almacen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 18);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 18);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Producto:";
            // 
            // tabSolProductos
            // 
            tabSolProductos.Controls.Add(panel4);
            tabSolProductos.Location = new Point(4, 24);
            tabSolProductos.Margin = new Padding(2);
            tabSolProductos.Name = "tabSolProductos";
            tabSolProductos.Padding = new Padding(2);
            tabSolProductos.Size = new Size(775, 413);
            tabSolProductos.TabIndex = 3;
            tabSolProductos.Text = "Solicitud de productos";
            tabSolProductos.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Location = new Point(4, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(769, 413);
            panel4.TabIndex = 3;
            // 
            // tabOrdenRepo
            // 
            tabOrdenRepo.Controls.Add(panel5);
            tabOrdenRepo.Location = new Point(4, 24);
            tabOrdenRepo.Margin = new Padding(2);
            tabOrdenRepo.Name = "tabOrdenRepo";
            tabOrdenRepo.Padding = new Padding(2);
            tabOrdenRepo.Size = new Size(775, 413);
            tabOrdenRepo.TabIndex = 4;
            tabOrdenRepo.Text = "Orden de reposición";
            tabOrdenRepo.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Location = new Point(4, 2);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(769, 413);
            panel5.TabIndex = 3;
            // 
            // tabRegFactura
            // 
            tabRegFactura.Controls.Add(panel7);
            tabRegFactura.Location = new Point(4, 24);
            tabRegFactura.Margin = new Padding(2);
            tabRegFactura.Name = "tabRegFactura";
            tabRegFactura.Padding = new Padding(2);
            tabRegFactura.Size = new Size(775, 413);
            tabRegFactura.TabIndex = 6;
            tabRegFactura.Text = "Registrar factura";
            tabRegFactura.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Location = new Point(4, 2);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(769, 413);
            panel7.TabIndex = 3;
            // 
            // tabConfig
            // 
            tabConfig.Controls.Add(panel8);
            tabConfig.Location = new Point(4, 24);
            tabConfig.Margin = new Padding(2);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(2);
            tabConfig.Size = new Size(775, 413);
            tabConfig.TabIndex = 7;
            tabConfig.Text = "Configuración";
            tabConfig.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Location = new Point(4, 2);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(769, 413);
            panel8.TabIndex = 3;
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(panel6);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Margin = new Padding(2);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(2);
            tabReportes.Size = new Size(775, 413);
            tabReportes.TabIndex = 5;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnGenerarGraficos);
            panel6.Controls.Add(dgMasvendido);
            panel6.Controls.Add(chVentasGastos);
            panel6.Controls.Add(chVentasSemanales);
            panel6.Location = new Point(2, 4);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(774, 413);
            panel6.TabIndex = 2;
            // 
            // btnGenerarGraficos
            // 
            btnGenerarGraficos.Location = new Point(345, 366);
            btnGenerarGraficos.Name = "btnGenerarGraficos";
            btnGenerarGraficos.Size = new Size(131, 23);
            btnGenerarGraficos.TabIndex = 4;
            btnGenerarGraficos.Text = "Generar Graficos";
            btnGenerarGraficos.UseVisualStyleBackColor = true;
            // 
            // dgMasvendido
            // 
            dgMasvendido.AllowUserToAddRows = false;
            dgMasvendido.AllowUserToDeleteRows = false;
            dgMasvendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMasvendido.Location = new Point(427, 23);
            dgMasvendido.Name = "dgMasvendido";
            dgMasvendido.ReadOnly = true;
            dgMasvendido.RowHeadersWidth = 62;
            dgMasvendido.Size = new Size(317, 328);
            dgMasvendido.TabIndex = 3;
            // 
            // chVentasGastos
            // 
            chartArea1.Name = "ChartArea1";
            chVentasGastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chVentasGastos.Legends.Add(legend1);
            chVentasGastos.Location = new Point(1, 163);
            chVentasGastos.Name = "chVentasGastos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chVentasGastos.Series.Add(series1);
            chVentasGastos.Size = new Size(317, 186);
            chVentasGastos.TabIndex = 1;
            chVentasGastos.Text = "Ventas y gastos diarios";
            // 
            // chVentasSemanales
            // 
            chartArea2.Name = "ChartArea1";
            chVentasSemanales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chVentasSemanales.Legends.Add(legend2);
            chVentasSemanales.Location = new Point(1, 3);
            chVentasSemanales.Name = "chVentasSemanales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chVentasSemanales.Series.Add(series2);
            chVentasSemanales.Size = new Size(317, 154);
            chVentasSemanales.TabIndex = 0;
            chVentasSemanales.Text = "Ventas Semanales";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.LightSteelBlue;
            pnlLogin.Controls.Add(lblPass);
            pnlLogin.Controls.Add(lblUser);
            pnlLogin.Controls.Add(pictureBox3);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPass);
            pnlLogin.Controls.Add(txtUser);
            pnlLogin.Controls.Add(lblLoginTitle);
            pnlLogin.Location = new Point(-1, -10);
            pnlLogin.Margin = new Padding(2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(780, 476);
            pnlLogin.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(293, 280);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(293, 235);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "Usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(328, 52);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(328, 335);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(293, 296);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(189, 23);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(293, 252);
            txtUser.Margin = new Padding(2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(189, 23);
            txtUser.TabIndex = 1;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(319, 199);
            lblLoginTitle.Margin = new Padding(2, 0, 2, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(127, 25);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar sesión";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(293, 351);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FormPulperia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 449);
            Controls.Add(tabControl1);
            Controls.Add(pnlLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormPulperia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pulperia MYM";
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabVentas.ResumeLayout(false);
            tabProductos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabSolProductos.ResumeLayout(false);
            tabOrdenRepo.ResumeLayout(false);
            tabRegFactura.ResumeLayout(false);
            tabConfig.ResumeLayout(false);
            tabReportes.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgMasvendido).EndInit();
            ((System.ComponentModel.ISupportInitialize)chVentasGastos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chVentasSemanales).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInicio;
        private Panel panel2;
        private TabPage tabVentas;
        private Panel panel1;
        private TabPage tabProductos;
        private TabPage tabSolProductos;
        private TabPage tabOrdenRepo;
        private TabPage tabReportes;
        private Panel panel6;
        private TabPage tabRegFactura;
        private TabPage tabConfig;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasSemanales;
        private DataGridView dgMasvendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasGastos;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel pnlLogin;
        private Label lblLoginTitle;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private Label lblPass;
        private Label lblUser;
        private Button btnGenerarGraficos;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox2;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Id_Producto;
        private DataGridViewTextBoxColumn Nombre_Producto;
        private DataGridViewTextBoxColumn Stock_Almacen;
        private TextBox textBox3;
        private Button btnMostrar;
    }
}
