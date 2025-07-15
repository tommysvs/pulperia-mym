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
            pnlInicio = new Panel();
            lblInicioDesc = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabVentas = new TabPage();
            pnlVentas = new Panel();
            lblTituloVentas = new Label();
            tabProductos = new TabPage();
            pnlProductos = new Panel();
            lblTituloProductos = new Label();
            btnMostrarProducto = new Button();
            dgvProductos = new DataGridView();
            txtStockProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtNmbProducto = new TextBox();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnAgregarProducto = new Button();
            lblStockProducto = new Label();
            lblPrecioProducto = new Label();
            lblNmbProducto = new Label();
            tabSolProductos = new TabPage();
            pblSoliProd = new Panel();
            lblTituloSolProd = new Label();
            tabOrdenRepo = new TabPage();
            pnlOrdRepo = new Panel();
            lblTituloOrdRepo = new Label();
            tabRegFactura = new TabPage();
            pnlRegFact = new Panel();
            lblTituloRegistrarFact = new Label();
            tabConfig = new TabPage();
            pnlConfig = new Panel();
            lblNombreConfig = new Label();
            txtNombreConfig = new TextBox();
            lblRolConfig = new Label();
            txtRolConfig = new TextBox();
            btnEliminarUsuario = new Button();
            btnCamPassUsuario = new Button();
            lblTituloConfigUsuarios = new Label();
            dgvUsuarios = new DataGridView();
            btnMostrarUsuarios = new Button();
            btnAgregarUsuario = new Button();
            txtPasswordConfig = new TextBox();
            lblPasswordConfig = new Label();
            txtUsuarioConfig = new TextBox();
            lblUsuarioConfig = new Label();
            lblTituloConfig = new Label();
            tabReportes = new TabPage();
            pnlReportes = new Panel();
            lblTituloReportes = new Label();
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
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
            pnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabVentas.SuspendLayout();
            pnlVentas.SuspendLayout();
            tabProductos.SuspendLayout();
            pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabSolProductos.SuspendLayout();
            pblSoliProd.SuspendLayout();
            tabOrdenRepo.SuspendLayout();
            pnlOrdRepo.SuspendLayout();
            tabRegFactura.SuspendLayout();
            pnlRegFact.SuspendLayout();
            tabConfig.SuspendLayout();
            pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabReportes.SuspendLayout();
            pnlReportes.SuspendLayout();
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
            tabControl1.Location = new Point(-1, 19);
            tabControl1.Margin = new Padding(2, 4, 2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1119, 735);
            tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            tabInicio.Controls.Add(pnlInicio);
            tabInicio.Location = new Point(4, 34);
            tabInicio.Margin = new Padding(2, 4, 2, 4);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(2, 4, 2, 4);
            tabInicio.Size = new Size(1111, 697);
            tabInicio.TabIndex = 0;
            tabInicio.Text = "Inicio";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // pnlInicio
            // 
            pnlInicio.Controls.Add(lblInicioDesc);
            pnlInicio.Controls.Add(textBox1);
            pnlInicio.Controls.Add(pictureBox2);
            pnlInicio.Controls.Add(pictureBox1);
            pnlInicio.Location = new Point(6, 6);
            pnlInicio.Margin = new Padding(2, 4, 2, 4);
            pnlInicio.Name = "pnlInicio";
            pnlInicio.Size = new Size(1099, 685);
            pnlInicio.TabIndex = 2;
            // 
            // lblInicioDesc
            // 
            lblInicioDesc.AutoSize = true;
            lblInicioDesc.Location = new Point(158, 26);
            lblInicioDesc.Margin = new Padding(2, 0, 2, 0);
            lblInicioDesc.Name = "lblInicioDesc";
            lblInicioDesc.Size = new Size(149, 25);
            lblInicioDesc.TabIndex = 5;
            lblInicioDesc.Text = "descripcion MYM";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(964, 26);
            textBox1.Margin = new Padding(2, 4, 2, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "Buscar";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(29, 165);
            pictureBox2.Margin = new Padding(2, 4, 2, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1044, 329);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 26);
            pictureBox1.Margin = new Padding(2, 4, 2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabVentas
            // 
            tabVentas.Controls.Add(pnlVentas);
            tabVentas.Location = new Point(4, 34);
            tabVentas.Margin = new Padding(2, 4, 2, 4);
            tabVentas.Name = "tabVentas";
            tabVentas.Padding = new Padding(2, 4, 2, 4);
            tabVentas.Size = new Size(1111, 697);
            tabVentas.TabIndex = 1;
            tabVentas.Text = "Ventas";
            tabVentas.UseVisualStyleBackColor = true;
            // 
            // pnlVentas
            // 
            pnlVentas.Controls.Add(lblTituloVentas);
            pnlVentas.Location = new Point(6, 6);
            pnlVentas.Margin = new Padding(2, 4, 2, 4);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(1099, 689);
            pnlVentas.TabIndex = 1;
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.AutoSize = true;
            lblTituloVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVentas.Location = new Point(12, 11);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new Size(104, 38);
            lblTituloVentas.TabIndex = 1;
            lblTituloVentas.Text = "Ventas";
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(pnlProductos);
            tabProductos.Location = new Point(4, 34);
            tabProductos.Margin = new Padding(2, 4, 2, 4);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(2, 4, 2, 4);
            tabProductos.Size = new Size(1111, 697);
            tabProductos.TabIndex = 2;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // pnlProductos
            // 
            pnlProductos.Controls.Add(lblTituloProductos);
            pnlProductos.Controls.Add(btnMostrarProducto);
            pnlProductos.Controls.Add(dgvProductos);
            pnlProductos.Controls.Add(txtStockProducto);
            pnlProductos.Controls.Add(txtPrecioProducto);
            pnlProductos.Controls.Add(txtNmbProducto);
            pnlProductos.Controls.Add(btnEliminarProducto);
            pnlProductos.Controls.Add(btnModificarProducto);
            pnlProductos.Controls.Add(btnAgregarProducto);
            pnlProductos.Controls.Add(lblStockProducto);
            pnlProductos.Controls.Add(lblPrecioProducto);
            pnlProductos.Controls.Add(lblNmbProducto);
            pnlProductos.Location = new Point(6, 4);
            pnlProductos.Margin = new Padding(2, 4, 2, 4);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(1099, 689);
            pnlProductos.TabIndex = 2;
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProductos.Location = new Point(21, 17);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(149, 38);
            lblTituloProductos.TabIndex = 12;
            lblTituloProductos.Text = "Productos";
            // 
            // btnMostrarProducto
            // 
            btnMostrarProducto.Location = new Point(352, 591);
            btnMostrarProducto.Margin = new Padding(4, 5, 4, 5);
            btnMostrarProducto.Name = "btnMostrarProducto";
            btnMostrarProducto.Size = new Size(108, 39);
            btnMostrarProducto.TabIndex = 11;
            btnMostrarProducto.Text = "Mostrar";
            btnMostrarProducto.UseVisualStyleBackColor = true;
            btnMostrarProducto.Click += btnMostrarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(352, 90);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(700, 491);
            dgvProductos.TabIndex = 10;
            // 
            // txtStockProducto
            // 
            txtStockProducto.BackColor = SystemColors.ControlLight;
            txtStockProducto.Location = new Point(21, 303);
            txtStockProducto.Margin = new Padding(2, 4, 2, 4);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(105, 31);
            txtStockProducto.TabIndex = 9;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.BackColor = SystemColors.ControlLight;
            txtPrecioProducto.Location = new Point(21, 207);
            txtPrecioProducto.Margin = new Padding(2, 4, 2, 4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(105, 31);
            txtPrecioProducto.TabIndex = 8;
            // 
            // txtNmbProducto
            // 
            txtNmbProducto.BackColor = SystemColors.ControlLight;
            txtNmbProducto.Location = new Point(21, 119);
            txtNmbProducto.Margin = new Padding(2, 4, 2, 4);
            txtNmbProducto.Name = "txtNmbProducto";
            txtNmbProducto.Size = new Size(268, 31);
            txtNmbProducto.TabIndex = 6;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(944, 591);
            btnEliminarProducto.Margin = new Padding(4, 5, 4, 5);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(108, 39);
            btnEliminarProducto.TabIndex = 5;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(828, 591);
            btnModificarProducto.Margin = new Padding(4, 5, 4, 5);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(108, 39);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(21, 359);
            btnAgregarProducto.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(108, 39);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Location = new Point(21, 274);
            lblStockProducto.Margin = new Padding(4, 0, 4, 0);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(184, 25);
            lblStockProducto.TabIndex = 2;
            lblStockProducto.Text = "Unidades en almacen:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Location = new Point(21, 178);
            lblPrecioProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(64, 25);
            lblPrecioProducto.TabIndex = 1;
            lblPrecioProducto.Text = "Precio:";
            // 
            // lblNmbProducto
            // 
            lblNmbProducto.AutoSize = true;
            lblNmbProducto.Location = new Point(21, 90);
            lblNmbProducto.Margin = new Padding(4, 0, 4, 0);
            lblNmbProducto.Name = "lblNmbProducto";
            lblNmbProducto.Size = new Size(160, 25);
            lblNmbProducto.TabIndex = 0;
            lblNmbProducto.Text = "Nombre Producto:";
            // 
            // tabSolProductos
            // 
            tabSolProductos.Controls.Add(pblSoliProd);
            tabSolProductos.Location = new Point(4, 34);
            tabSolProductos.Margin = new Padding(2, 4, 2, 4);
            tabSolProductos.Name = "tabSolProductos";
            tabSolProductos.Padding = new Padding(2, 4, 2, 4);
            tabSolProductos.Size = new Size(1111, 697);
            tabSolProductos.TabIndex = 3;
            tabSolProductos.Text = "Solicitud de productos";
            tabSolProductos.UseVisualStyleBackColor = true;
            // 
            // pblSoliProd
            // 
            pblSoliProd.Controls.Add(lblTituloSolProd);
            pblSoliProd.Location = new Point(6, 4);
            pblSoliProd.Margin = new Padding(2, 4, 2, 4);
            pblSoliProd.Name = "pblSoliProd";
            pblSoliProd.Size = new Size(1099, 689);
            pblSoliProd.TabIndex = 3;
            // 
            // lblTituloSolProd
            // 
            lblTituloSolProd.AutoSize = true;
            lblTituloSolProd.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloSolProd.Location = new Point(12, 14);
            lblTituloSolProd.Name = "lblTituloSolProd";
            lblTituloSolProd.Size = new Size(312, 38);
            lblTituloSolProd.TabIndex = 13;
            lblTituloSolProd.Text = "Solicitud de productos";
            // 
            // tabOrdenRepo
            // 
            tabOrdenRepo.Controls.Add(pnlOrdRepo);
            tabOrdenRepo.Location = new Point(4, 34);
            tabOrdenRepo.Margin = new Padding(2, 4, 2, 4);
            tabOrdenRepo.Name = "tabOrdenRepo";
            tabOrdenRepo.Padding = new Padding(2, 4, 2, 4);
            tabOrdenRepo.Size = new Size(1111, 697);
            tabOrdenRepo.TabIndex = 4;
            tabOrdenRepo.Text = "Orden de reposición";
            tabOrdenRepo.UseVisualStyleBackColor = true;
            // 
            // pnlOrdRepo
            // 
            pnlOrdRepo.Controls.Add(lblTituloOrdRepo);
            pnlOrdRepo.Location = new Point(6, 4);
            pnlOrdRepo.Margin = new Padding(2, 4, 2, 4);
            pnlOrdRepo.Name = "pnlOrdRepo";
            pnlOrdRepo.Size = new Size(1099, 689);
            pnlOrdRepo.TabIndex = 3;
            // 
            // lblTituloOrdRepo
            // 
            lblTituloOrdRepo.AutoSize = true;
            lblTituloOrdRepo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOrdRepo.Location = new Point(14, 16);
            lblTituloOrdRepo.Name = "lblTituloOrdRepo";
            lblTituloOrdRepo.Size = new Size(281, 38);
            lblTituloOrdRepo.TabIndex = 13;
            lblTituloOrdRepo.Text = "Orden de reposición";
            // 
            // tabRegFactura
            // 
            tabRegFactura.Controls.Add(pnlRegFact);
            tabRegFactura.Location = new Point(4, 34);
            tabRegFactura.Margin = new Padding(2, 4, 2, 4);
            tabRegFactura.Name = "tabRegFactura";
            tabRegFactura.Padding = new Padding(2, 4, 2, 4);
            tabRegFactura.Size = new Size(1111, 697);
            tabRegFactura.TabIndex = 6;
            tabRegFactura.Text = "Registrar factura";
            tabRegFactura.UseVisualStyleBackColor = true;
            // 
            // pnlRegFact
            // 
            pnlRegFact.Controls.Add(lblTituloRegistrarFact);
            pnlRegFact.Location = new Point(6, 4);
            pnlRegFact.Margin = new Padding(2, 4, 2, 4);
            pnlRegFact.Name = "pnlRegFact";
            pnlRegFact.Size = new Size(1099, 689);
            pnlRegFact.TabIndex = 3;
            // 
            // lblTituloRegistrarFact
            // 
            lblTituloRegistrarFact.AutoSize = true;
            lblTituloRegistrarFact.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRegistrarFact.Location = new Point(15, 14);
            lblTituloRegistrarFact.Name = "lblTituloRegistrarFact";
            lblTituloRegistrarFact.Size = new Size(235, 38);
            lblTituloRegistrarFact.TabIndex = 13;
            lblTituloRegistrarFact.Text = "Registrar factura";
            // 
            // tabConfig
            // 
            tabConfig.Controls.Add(pnlConfig);
            tabConfig.Location = new Point(4, 34);
            tabConfig.Margin = new Padding(2, 4, 2, 4);
            tabConfig.Name = "tabConfig";
            tabConfig.Padding = new Padding(2, 4, 2, 4);
            tabConfig.Size = new Size(1111, 697);
            tabConfig.TabIndex = 7;
            tabConfig.Text = "Configuración";
            tabConfig.UseVisualStyleBackColor = true;
            // 
            // pnlConfig
            // 
            pnlConfig.Controls.Add(lblNombreConfig);
            pnlConfig.Controls.Add(txtNombreConfig);
            pnlConfig.Controls.Add(lblRolConfig);
            pnlConfig.Controls.Add(txtRolConfig);
            pnlConfig.Controls.Add(btnEliminarUsuario);
            pnlConfig.Controls.Add(btnCamPassUsuario);
            pnlConfig.Controls.Add(lblTituloConfigUsuarios);
            pnlConfig.Controls.Add(dgvUsuarios);
            pnlConfig.Controls.Add(btnMostrarUsuarios);
            pnlConfig.Controls.Add(btnAgregarUsuario);
            pnlConfig.Controls.Add(txtPasswordConfig);
            pnlConfig.Controls.Add(lblPasswordConfig);
            pnlConfig.Controls.Add(txtUsuarioConfig);
            pnlConfig.Controls.Add(lblUsuarioConfig);
            pnlConfig.Controls.Add(lblTituloConfig);
            pnlConfig.Location = new Point(6, 4);
            pnlConfig.Margin = new Padding(2, 4, 2, 4);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(1099, 689);
            pnlConfig.TabIndex = 3;
            // 
            // lblNombreConfig
            // 
            lblNombreConfig.AutoSize = true;
            lblNombreConfig.Location = new Point(48, 158);
            lblNombreConfig.Name = "lblNombreConfig";
            lblNombreConfig.Size = new Size(78, 25);
            lblNombreConfig.TabIndex = 14;
            lblNombreConfig.Text = "Nombre";
            // 
            // txtNombreConfig
            // 
            txtNombreConfig.Location = new Point(132, 155);
            txtNombreConfig.Name = "txtNombreConfig";
            txtNombreConfig.Size = new Size(168, 31);
            txtNombreConfig.TabIndex = 13;
            // 
            // lblRolConfig
            // 
            lblRolConfig.AutoSize = true;
            lblRolConfig.Location = new Point(89, 232);
            lblRolConfig.Name = "lblRolConfig";
            lblRolConfig.Size = new Size(37, 25);
            lblRolConfig.TabIndex = 12;
            lblRolConfig.Text = "Rol";
            // 
            // txtRolConfig
            // 
            txtRolConfig.Location = new Point(132, 232);
            txtRolConfig.Name = "txtRolConfig";
            txtRolConfig.Size = new Size(168, 31);
            txtRolConfig.TabIndex = 11;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(886, 272);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(189, 34);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCamPassUsuario
            // 
            btnCamPassUsuario.Location = new Point(886, 232);
            btnCamPassUsuario.Name = "btnCamPassUsuario";
            btnCamPassUsuario.Size = new Size(189, 34);
            btnCamPassUsuario.TabIndex = 9;
            btnCamPassUsuario.Text = "Cambiar contraseña";
            btnCamPassUsuario.UseVisualStyleBackColor = true;
            // 
            // lblTituloConfigUsuarios
            // 
            lblTituloConfigUsuarios.AutoSize = true;
            lblTituloConfigUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloConfigUsuarios.Location = new Point(22, 70);
            lblTituloConfigUsuarios.Name = "lblTituloConfigUsuarios";
            lblTituloConfigUsuarios.Size = new Size(104, 32);
            lblTituloConfigUsuarios.TabIndex = 8;
            lblTituloConfigUsuarios.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(319, 70);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(561, 233);
            dgvUsuarios.TabIndex = 7;
            // 
            // btnMostrarUsuarios
            // 
            btnMostrarUsuarios.Location = new Point(886, 71);
            btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            btnMostrarUsuarios.Size = new Size(189, 34);
            btnMostrarUsuarios.TabIndex = 6;
            btnMostrarUsuarios.Text = "Mostrar usuarios";
            btnMostrarUsuarios.UseVisualStyleBackColor = true;
            btnMostrarUsuarios.Click += btnMostrarUsuarios_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(132, 269);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(168, 34);
            btnAgregarUsuario.TabIndex = 5;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // txtPasswordConfig
            // 
            txtPasswordConfig.Location = new Point(132, 195);
            txtPasswordConfig.Name = "txtPasswordConfig";
            txtPasswordConfig.Size = new Size(168, 31);
            txtPasswordConfig.TabIndex = 4;
            txtPasswordConfig.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfig
            // 
            lblPasswordConfig.AutoSize = true;
            lblPasswordConfig.Location = new Point(25, 195);
            lblPasswordConfig.Name = "lblPasswordConfig";
            lblPasswordConfig.Size = new Size(101, 25);
            lblPasswordConfig.TabIndex = 3;
            lblPasswordConfig.Text = "Contraseña";
            // 
            // txtUsuarioConfig
            // 
            txtUsuarioConfig.Location = new Point(132, 118);
            txtUsuarioConfig.Name = "txtUsuarioConfig";
            txtUsuarioConfig.Size = new Size(168, 31);
            txtUsuarioConfig.TabIndex = 2;
            // 
            // lblUsuarioConfig
            // 
            lblUsuarioConfig.AutoSize = true;
            lblUsuarioConfig.Location = new Point(54, 118);
            lblUsuarioConfig.Name = "lblUsuarioConfig";
            lblUsuarioConfig.Size = new Size(72, 25);
            lblUsuarioConfig.TabIndex = 1;
            lblUsuarioConfig.Text = "Usuario";
            // 
            // lblTituloConfig
            // 
            lblTituloConfig.AutoSize = true;
            lblTituloConfig.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloConfig.Location = new Point(14, 14);
            lblTituloConfig.Name = "lblTituloConfig";
            lblTituloConfig.Size = new Size(202, 38);
            lblTituloConfig.TabIndex = 0;
            lblTituloConfig.Text = "Configuración";
            // 
            // tabReportes
            // 
            tabReportes.Controls.Add(pnlReportes);
            tabReportes.Location = new Point(4, 34);
            tabReportes.Margin = new Padding(2, 4, 2, 4);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(2, 4, 2, 4);
            tabReportes.Size = new Size(1111, 697);
            tabReportes.TabIndex = 5;
            tabReportes.Text = "Reportes";
            tabReportes.UseVisualStyleBackColor = true;
            // 
            // pnlReportes
            // 
            pnlReportes.Controls.Add(lblTituloReportes);
            pnlReportes.Controls.Add(btnGenerarGraficos);
            pnlReportes.Controls.Add(dgMasvendido);
            pnlReportes.Controls.Add(chVentasGastos);
            pnlReportes.Controls.Add(chVentasSemanales);
            pnlReportes.Location = new Point(2, 6);
            pnlReportes.Margin = new Padding(2, 4, 2, 4);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(1106, 689);
            pnlReportes.TabIndex = 2;
            // 
            // lblTituloReportes
            // 
            lblTituloReportes.AutoSize = true;
            lblTituloReportes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloReportes.Location = new Point(18, 11);
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Size = new Size(133, 38);
            lblTituloReportes.TabIndex = 13;
            lblTituloReportes.Text = "Reportes";
            // 
            // btnGenerarGraficos
            // 
            btnGenerarGraficos.Location = new Point(893, 27);
            btnGenerarGraficos.Margin = new Padding(4, 5, 4, 5);
            btnGenerarGraficos.Name = "btnGenerarGraficos";
            btnGenerarGraficos.Size = new Size(188, 39);
            btnGenerarGraficos.TabIndex = 4;
            btnGenerarGraficos.Text = "Generar Graficos";
            btnGenerarGraficos.UseVisualStyleBackColor = true;
            // 
            // dgMasvendido
            // 
            dgMasvendido.AllowUserToAddRows = false;
            dgMasvendido.AllowUserToDeleteRows = false;
            dgMasvendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMasvendido.Location = new Point(629, 114);
            dgMasvendido.Margin = new Padding(4, 5, 4, 5);
            dgMasvendido.Name = "dgMasvendido";
            dgMasvendido.ReadOnly = true;
            dgMasvendido.RowHeadersWidth = 62;
            dgMasvendido.Size = new Size(452, 546);
            dgMasvendido.TabIndex = 3;
            // 
            // chVentasGastos
            // 
            chartArea1.Name = "ChartArea1";
            chVentasGastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chVentasGastos.Legends.Add(legend1);
            chVentasGastos.Location = new Point(18, 350);
            chVentasGastos.Margin = new Padding(4, 5, 4, 5);
            chVentasGastos.Name = "chVentasGastos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chVentasGastos.Series.Add(series1);
            chVentasGastos.Size = new Size(452, 310);
            chVentasGastos.TabIndex = 1;
            chVentasGastos.Text = "Ventas y gastos diarios";
            // 
            // chVentasSemanales
            // 
            chartArea2.Name = "ChartArea1";
            chVentasSemanales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chVentasSemanales.Legends.Add(legend2);
            chVentasSemanales.Location = new Point(18, 71);
            chVentasSemanales.Margin = new Padding(4, 5, 4, 5);
            chVentasSemanales.Name = "chVentasSemanales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chVentasSemanales.Series.Add(series2);
            chVentasSemanales.Size = new Size(452, 256);
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
            pnlLogin.Location = new Point(-1, 0);
            pnlLogin.Margin = new Padding(2, 4, 2, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1119, 754);
            pnlLogin.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(419, 466);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 25);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(419, 391);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 25);
            lblUser.TabIndex = 5;
            lblUser.Text = "Usuario";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Logo;
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(469, 86);
            pictureBox3.Margin = new Padding(2, 4, 2, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 174);
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
            btnLogin.Location = new Point(469, 559);
            btnLogin.Margin = new Padding(2, 4, 2, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 51);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(419, 494);
            txtPass.Margin = new Padding(2, 4, 2, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(268, 31);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(419, 420);
            txtUser.Margin = new Padding(2, 4, 2, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(268, 31);
            txtUser.TabIndex = 1;
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.Location = new Point(456, 331);
            lblLoginTitle.Margin = new Padding(2, 0, 2, 0);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(187, 38);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Iniciar sesión";
            // 
            // FormPulperia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 749);
            Controls.Add(pnlLogin);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "FormPulperia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pulperia MYM";
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            pnlInicio.ResumeLayout(false);
            pnlInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabVentas.ResumeLayout(false);
            pnlVentas.ResumeLayout(false);
            pnlVentas.PerformLayout();
            tabProductos.ResumeLayout(false);
            pnlProductos.ResumeLayout(false);
            pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabSolProductos.ResumeLayout(false);
            pblSoliProd.ResumeLayout(false);
            pblSoliProd.PerformLayout();
            tabOrdenRepo.ResumeLayout(false);
            pnlOrdRepo.ResumeLayout(false);
            pnlOrdRepo.PerformLayout();
            tabRegFactura.ResumeLayout(false);
            pnlRegFact.ResumeLayout(false);
            pnlRegFact.PerformLayout();
            tabConfig.ResumeLayout(false);
            pnlConfig.ResumeLayout(false);
            pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabReportes.ResumeLayout(false);
            pnlReportes.ResumeLayout(false);
            pnlReportes.PerformLayout();
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
        private Panel pnlInicio;
        private TabPage tabVentas;
        private Panel pnlVentas;
        private TabPage tabProductos;
        private TabPage tabSolProductos;
        private TabPage tabOrdenRepo;
        private TabPage tabReportes;
        private Panel pnlReportes;
        private TabPage tabRegFactura;
        private TabPage tabConfig;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblInicioDesc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasSemanales;
        private DataGridView dgMasvendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chVentasGastos;
        private Panel pnlProductos;
        private Panel pblSoliProd;
        private Panel pnlOrdRepo;
        private Panel pnlRegFact;
        private Panel pnlConfig;
        private Panel pnlLogin;
        private Label lblLoginTitle;
        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private Label lblPass;
        private Label lblUser;
        private Button btnGenerarGraficos;
        private Label lblNmbProducto;
        private Label lblStockProducto;
        private Label lblPrecioProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtNmbProducto;
        private Button btnEliminarProducto;
        private Button btnModificarProducto;
        private Button btnAgregarProducto;
        private DataGridView dgvProductos;
        private TextBox txtStockProducto;
        private Button btnMostrarProducto;
        private Label lblTituloConfig;
        private Label lblTituloVentas;
        private Label lblTituloProductos;
        private Label lblTituloSolProd;
        private Label lblTituloOrdRepo;
        private Label lblTituloRegistrarFact;
        private Label lblTituloReportes;
        private Label lblPasswordConfig;
        private TextBox txtUsuarioConfig;
        private Label lblUsuarioConfig;
        private Button btnMostrarUsuarios;
        private Button btnAgregarUsuario;
        private TextBox txtPasswordConfig;
        private Label lblTituloConfigUsuarios;
        private DataGridView dgvUsuarios;
        private Button btnCamPassUsuario;
        private Button btnEliminarUsuario;
        private TextBox txtRolConfig;
        private Label lblRolConfig;
        private Label lblNombreConfig;
        private TextBox txtNombreConfig;
    }
}
