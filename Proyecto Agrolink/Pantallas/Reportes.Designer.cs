namespace AgroLink.Pantallas
{
    partial class Reportes
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
            tabControlReportes = new TabControl();
            tabUtilidad = new TabPage();
            panelPanelTopProductos = new Panel();
            panel1 = new Panel();
            tablaTopVenta = new DataGridView();
            panelTituloTopVenta = new Panel();
            label6 = new Label();
            panelContenidoTopProductos = new Panel();
            tablaTopCompra = new DataGridView();
            panelTituloTopCompra = new Panel();
            label8 = new Label();
            panelTotalesUtilidad = new Panel();
            lblTotUtilidad = new Label();
            label16 = new Label();
            lblTotGastos = new Label();
            label12 = new Label();
            lblTotIngresos = new Label();
            label4 = new Label();
            tabSaldo = new TabPage();
            tablaSaldo = new DataGridView();
            panelTituloSaldo = new Panel();
            btnRecargarSaldo = new Button();
            btnBuscarSaldo = new Button();
            tbBuscarSaldo = new TextBox();
            groupFiltroSaldo = new GroupBox();
            radioTodo = new RadioButton();
            radioSaldoAgricultor = new RadioButton();
            radioSaldoProveedor = new RadioButton();
            panelFooterSaldos = new Panel();
            label2 = new Label();
            lblSaldoTot = new Label();
            label11 = new Label();
            lblSaldoTotAgr = new Label();
            label13 = new Label();
            label14 = new Label();
            lblSaldoTotProv = new Label();
            tabInventario = new TabPage();
            tablaInventario = new DataGridView();
            panelTituloInventario = new Panel();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            groupReportesInventario = new GroupBox();
            radioInsumosxProducto = new RadioButton();
            radioProdxProducto = new RadioButton();
            panelFooterInventario = new Panel();
            label10 = new Label();
            lblTotalVentasInsumos = new Label();
            label9 = new Label();
            lblInsumosVendidos = new Label();
            label7 = new Label();
            lblComprasdelAño = new Label();
            label3 = new Label();
            label5 = new Label();
            lblTotalProdAdqu = new Label();
            panelTitulo = new Panel();
            lbBienvenida = new Label();
            panelContenido = new Panel();
            tabControlReportes.SuspendLayout();
            tabUtilidad.SuspendLayout();
            panelPanelTopProductos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaTopVenta).BeginInit();
            panelTituloTopVenta.SuspendLayout();
            panelContenidoTopProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaTopCompra).BeginInit();
            panelTituloTopCompra.SuspendLayout();
            panelTotalesUtilidad.SuspendLayout();
            tabSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSaldo).BeginInit();
            panelTituloSaldo.SuspendLayout();
            groupFiltroSaldo.SuspendLayout();
            panelFooterSaldos.SuspendLayout();
            tabInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).BeginInit();
            panelTituloInventario.SuspendLayout();
            groupReportesInventario.SuspendLayout();
            panelFooterInventario.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReportes
            // 
            tabControlReportes.Controls.Add(tabUtilidad);
            tabControlReportes.Controls.Add(tabSaldo);
            tabControlReportes.Controls.Add(tabInventario);
            tabControlReportes.Dock = DockStyle.Fill;
            tabControlReportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabControlReportes.Location = new Point(0, 0);
            tabControlReportes.Name = "tabControlReportes";
            tabControlReportes.SelectedIndex = 0;
            tabControlReportes.Size = new Size(2916, 1443);
            tabControlReportes.TabIndex = 2;
            // 
            // tabUtilidad
            // 
            tabUtilidad.Controls.Add(panelPanelTopProductos);
            tabUtilidad.Location = new Point(10, 58);
            tabUtilidad.Name = "tabUtilidad";
            tabUtilidad.Padding = new Padding(5);
            tabUtilidad.Size = new Size(2896, 1375);
            tabUtilidad.TabIndex = 2;
            tabUtilidad.Text = "Utilidad";
            tabUtilidad.UseVisualStyleBackColor = true;
            tabUtilidad.Enter += tabUtilidad_Enter;
            // 
            // panelPanelTopProductos
            // 
            panelPanelTopProductos.BackColor = Color.FromArgb(22, 48, 43);
            panelPanelTopProductos.Controls.Add(panel1);
            panelPanelTopProductos.Controls.Add(panelContenidoTopProductos);
            panelPanelTopProductos.Controls.Add(panelTotalesUtilidad);
            panelPanelTopProductos.Dock = DockStyle.Fill;
            panelPanelTopProductos.Location = new Point(5, 5);
            panelPanelTopProductos.Name = "panelPanelTopProductos";
            panelPanelTopProductos.Size = new Size(2886, 1365);
            panelPanelTopProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tablaTopVenta);
            panel1.Controls.Add(panelTituloTopVenta);
            panel1.Location = new Point(1466, 654);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 476);
            panel1.TabIndex = 6;
            // 
            // tablaTopVenta
            // 
            tablaTopVenta.BackgroundColor = Color.Silver;
            tablaTopVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTopVenta.Dock = DockStyle.Fill;
            tablaTopVenta.Location = new Point(0, 123);
            tablaTopVenta.Name = "tablaTopVenta";
            tablaTopVenta.RowHeadersWidth = 102;
            tablaTopVenta.Size = new Size(1376, 353);
            tablaTopVenta.TabIndex = 0;
            // 
            // panelTituloTopVenta
            // 
            panelTituloTopVenta.BackColor = Color.FromArgb(192, 229, 200);
            panelTituloTopVenta.Controls.Add(label6);
            panelTituloTopVenta.Dock = DockStyle.Top;
            panelTituloTopVenta.Location = new Point(0, 0);
            panelTituloTopVenta.Name = "panelTituloTopVenta";
            panelTituloTopVenta.Size = new Size(1376, 123);
            panelTituloTopVenta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label6.Location = new Point(351, 27);
            label6.Name = "label6";
            label6.Size = new Size(727, 76);
            label6.TabIndex = 2;
            label6.Text = "Top 3 Productos Vendidos";
            // 
            // panelContenidoTopProductos
            // 
            panelContenidoTopProductos.Controls.Add(tablaTopCompra);
            panelContenidoTopProductos.Controls.Add(panelTituloTopCompra);
            panelContenidoTopProductos.Location = new Point(52, 654);
            panelContenidoTopProductos.Name = "panelContenidoTopProductos";
            panelContenidoTopProductos.Size = new Size(1376, 476);
            panelContenidoTopProductos.TabIndex = 5;
            // 
            // tablaTopCompra
            // 
            tablaTopCompra.BackgroundColor = Color.Silver;
            tablaTopCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTopCompra.Dock = DockStyle.Fill;
            tablaTopCompra.Location = new Point(0, 123);
            tablaTopCompra.Name = "tablaTopCompra";
            tablaTopCompra.RowHeadersWidth = 102;
            tablaTopCompra.Size = new Size(1376, 353);
            tablaTopCompra.TabIndex = 0;
            // 
            // panelTituloTopCompra
            // 
            panelTituloTopCompra.BackColor = Color.FromArgb(192, 229, 200);
            panelTituloTopCompra.Controls.Add(label8);
            panelTituloTopCompra.Dock = DockStyle.Top;
            panelTituloTopCompra.Location = new Point(0, 0);
            panelTituloTopCompra.Name = "panelTituloTopCompra";
            panelTituloTopCompra.Size = new Size(1376, 123);
            panelTituloTopCompra.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label8.Location = new Point(297, 27);
            label8.Name = "label8";
            label8.Size = new Size(789, 76);
            label8.TabIndex = 3;
            label8.Text = "Top 3 Productos Comprados";
            // 
            // panelTotalesUtilidad
            // 
            panelTotalesUtilidad.BackColor = Color.FromArgb(22, 48, 43);
            panelTotalesUtilidad.BorderStyle = BorderStyle.Fixed3D;
            panelTotalesUtilidad.Controls.Add(lblTotUtilidad);
            panelTotalesUtilidad.Controls.Add(label16);
            panelTotalesUtilidad.Controls.Add(lblTotGastos);
            panelTotalesUtilidad.Controls.Add(label12);
            panelTotalesUtilidad.Controls.Add(lblTotIngresos);
            panelTotalesUtilidad.Controls.Add(label4);
            panelTotalesUtilidad.Dock = DockStyle.Top;
            panelTotalesUtilidad.Location = new Point(0, 0);
            panelTotalesUtilidad.Name = "panelTotalesUtilidad";
            panelTotalesUtilidad.Size = new Size(2886, 420);
            panelTotalesUtilidad.TabIndex = 0;
            // 
            // lblTotUtilidad
            // 
            lblTotUtilidad.AutoSize = true;
            lblTotUtilidad.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotUtilidad.ForeColor = Color.White;
            lblTotUtilidad.Location = new Point(402, 213);
            lblTotUtilidad.Name = "lblTotUtilidad";
            lblTotUtilidad.Size = new Size(344, 76);
            lblTotUtilidad.TabIndex = 6;
            lblTotUtilidad.Text = "0000000.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(255, 222, 89);
            label16.Location = new Point(402, 108);
            label16.Name = "label16";
            label16.Size = new Size(802, 76);
            label16.TabIndex = 5;
            label16.Text = "Total Utilidad Periodo Actual";
            // 
            // lblTotGastos
            // 
            lblTotGastos.AutoSize = true;
            lblTotGastos.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotGastos.ForeColor = Color.White;
            lblTotGastos.Location = new Point(2111, 210);
            lblTotGastos.Name = "lblTotGastos";
            lblTotGastos.Size = new Size(344, 76);
            lblTotGastos.TabIndex = 4;
            lblTotGastos.Text = "0000000.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(255, 222, 89);
            label12.Location = new Point(2111, 108);
            label12.Name = "label12";
            label12.Size = new Size(211, 76);
            label12.TabIndex = 3;
            label12.Text = "Gastos";
            // 
            // lblTotIngresos
            // 
            lblTotIngresos.AutoSize = true;
            lblTotIngresos.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotIngresos.ForeColor = Color.White;
            lblTotIngresos.Location = new Point(1375, 214);
            lblTotIngresos.Name = "lblTotIngresos";
            lblTotIngresos.Size = new Size(344, 76);
            lblTotIngresos.TabIndex = 2;
            lblTotIngresos.Text = "0000000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 222, 89);
            label4.Location = new Point(1375, 108);
            label4.Name = "label4";
            label4.Size = new Size(565, 76);
            label4.TabIndex = 1;
            label4.Text = "Ingresos Facturados";
            // 
            // tabSaldo
            // 
            tabSaldo.Controls.Add(tablaSaldo);
            tabSaldo.Controls.Add(panelTituloSaldo);
            tabSaldo.Controls.Add(panelFooterSaldos);
            tabSaldo.Location = new Point(10, 58);
            tabSaldo.Name = "tabSaldo";
            tabSaldo.Padding = new Padding(5);
            tabSaldo.Size = new Size(2896, 1375);
            tabSaldo.TabIndex = 1;
            tabSaldo.Text = "Saldo";
            tabSaldo.UseVisualStyleBackColor = true;
            tabSaldo.Enter += tabSaldo_Enter;
            // 
            // tablaSaldo
            // 
            tablaSaldo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSaldo.Dock = DockStyle.Fill;
            tablaSaldo.Location = new Point(743, 244);
            tablaSaldo.Name = "tablaSaldo";
            tablaSaldo.RowHeadersWidth = 102;
            tablaSaldo.Size = new Size(2148, 1126);
            tablaSaldo.TabIndex = 0;
            // 
            // panelTituloSaldo
            // 
            panelTituloSaldo.BackColor = Color.FromArgb(192, 229, 200);
            panelTituloSaldo.Controls.Add(btnRecargarSaldo);
            panelTituloSaldo.Controls.Add(btnBuscarSaldo);
            panelTituloSaldo.Controls.Add(tbBuscarSaldo);
            panelTituloSaldo.Controls.Add(groupFiltroSaldo);
            panelTituloSaldo.Dock = DockStyle.Top;
            panelTituloSaldo.Location = new Point(743, 5);
            panelTituloSaldo.Name = "panelTituloSaldo";
            panelTituloSaldo.Size = new Size(2148, 239);
            panelTituloSaldo.TabIndex = 2;
            // 
            // btnRecargarSaldo
            // 
            btnRecargarSaldo.Font = new Font("Segoe UI", 9F);
            btnRecargarSaldo.Location = new Point(600, 123);
            btnRecargarSaldo.Name = "btnRecargarSaldo";
            btnRecargarSaldo.Size = new Size(201, 57);
            btnRecargarSaldo.TabIndex = 9;
            btnRecargarSaldo.Text = "Recargar";
            btnRecargarSaldo.UseVisualStyleBackColor = true;
            btnRecargarSaldo.Click += btnRecargarSaldo_Click;
            // 
            // btnBuscarSaldo
            // 
            btnBuscarSaldo.Font = new Font("Segoe UI", 9F);
            btnBuscarSaldo.Location = new Point(119, 123);
            btnBuscarSaldo.Name = "btnBuscarSaldo";
            btnBuscarSaldo.Size = new Size(201, 57);
            btnBuscarSaldo.TabIndex = 7;
            btnBuscarSaldo.Text = "Buscar";
            btnBuscarSaldo.UseVisualStyleBackColor = true;
            btnBuscarSaldo.Click += btnBuscarSaldo_Click;
            // 
            // tbBuscarSaldo
            // 
            tbBuscarSaldo.Font = new Font("Segoe UI", 9F);
            tbBuscarSaldo.Location = new Point(119, 57);
            tbBuscarSaldo.Name = "tbBuscarSaldo";
            tbBuscarSaldo.PlaceholderText = "Buscar Agricultor o Proveedor...";
            tbBuscarSaldo.Size = new Size(682, 47);
            tbBuscarSaldo.TabIndex = 6;
            // 
            // groupFiltroSaldo
            // 
            groupFiltroSaldo.Controls.Add(radioTodo);
            groupFiltroSaldo.Controls.Add(radioSaldoAgricultor);
            groupFiltroSaldo.Controls.Add(radioSaldoProveedor);
            groupFiltroSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupFiltroSaldo.Location = new Point(950, 36);
            groupFiltroSaldo.Name = "groupFiltroSaldo";
            groupFiltroSaldo.Size = new Size(1130, 179);
            groupFiltroSaldo.TabIndex = 0;
            groupFiltroSaldo.TabStop = false;
            groupFiltroSaldo.Text = "Filtro";
            // 
            // radioTodo
            // 
            radioTodo.AutoSize = true;
            radioTodo.Font = new Font("Segoe UI", 9F);
            radioTodo.Location = new Point(901, 75);
            radioTodo.Name = "radioTodo";
            radioTodo.Size = new Size(122, 45);
            radioTodo.TabIndex = 2;
            radioTodo.TabStop = true;
            radioTodo.Text = "Todo";
            radioTodo.UseVisualStyleBackColor = true;
            radioTodo.CheckedChanged += radioTodo_CheckedChanged;
            // 
            // radioSaldoAgricultor
            // 
            radioSaldoAgricultor.AutoSize = true;
            radioSaldoAgricultor.Font = new Font("Segoe UI", 9F);
            radioSaldoAgricultor.Location = new Point(481, 75);
            radioSaldoAgricultor.Name = "radioSaldoAgricultor";
            radioSaldoAgricultor.Size = new Size(296, 45);
            radioSaldoAgricultor.TabIndex = 1;
            radioSaldoAgricultor.TabStop = true;
            radioSaldoAgricultor.Text = "Saldo Agricultores";
            radioSaldoAgricultor.UseVisualStyleBackColor = true;
            radioSaldoAgricultor.CheckedChanged += radioSaldoAgricultor_CheckedChanged;
            // 
            // radioSaldoProveedor
            // 
            radioSaldoProveedor.AutoSize = true;
            radioSaldoProveedor.Font = new Font("Segoe UI", 9F);
            radioSaldoProveedor.Location = new Point(54, 75);
            radioSaldoProveedor.Name = "radioSaldoProveedor";
            radioSaldoProveedor.Size = new Size(303, 45);
            radioSaldoProveedor.TabIndex = 0;
            radioSaldoProveedor.TabStop = true;
            radioSaldoProveedor.Text = "Saldo Proveedores";
            radioSaldoProveedor.UseVisualStyleBackColor = true;
            radioSaldoProveedor.CheckedChanged += radioSaldoProveedor_CheckedChanged;
            // 
            // panelFooterSaldos
            // 
            panelFooterSaldos.BackColor = Color.FromArgb(22, 48, 43);
            panelFooterSaldos.Controls.Add(label2);
            panelFooterSaldos.Controls.Add(lblSaldoTot);
            panelFooterSaldos.Controls.Add(label11);
            panelFooterSaldos.Controls.Add(lblSaldoTotAgr);
            panelFooterSaldos.Controls.Add(label13);
            panelFooterSaldos.Controls.Add(label14);
            panelFooterSaldos.Controls.Add(lblSaldoTotProv);
            panelFooterSaldos.Dock = DockStyle.Left;
            panelFooterSaldos.Location = new Point(5, 5);
            panelFooterSaldos.Name = "panelFooterSaldos";
            panelFooterSaldos.Size = new Size(738, 1365);
            panelFooterSaldos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.FromArgb(255, 222, 89);
            label2.Location = new Point(66, 69);
            label2.Name = "label2";
            label2.Size = new Size(600, 62);
            label2.TabIndex = 18;
            label2.Text = "Totales de Periodo Actual ";
            // 
            // lblSaldoTot
            // 
            lblSaldoTot.AutoSize = true;
            lblSaldoTot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSaldoTot.ForeColor = Color.White;
            lblSaldoTot.Location = new Point(90, 927);
            lblSaldoTot.Name = "lblSaldoTot";
            lblSaldoTot.Size = new Size(218, 54);
            lblSaldoTot.TabIndex = 15;
            lblSaldoTot.Text = "000000.00";
            lblSaldoTot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(66, 866);
            label11.Name = "label11";
            label11.Size = new Size(230, 54);
            label11.TabIndex = 14;
            label11.Text = "Saldo Total";
            // 
            // lblSaldoTotAgr
            // 
            lblSaldoTotAgr.AutoSize = true;
            lblSaldoTotAgr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaldoTotAgr.ForeColor = Color.White;
            lblSaldoTotAgr.Location = new Point(90, 631);
            lblSaldoTotAgr.Name = "lblSaldoTotAgr";
            lblSaldoTotAgr.Size = new Size(189, 46);
            lblSaldoTotAgr.TabIndex = 13;
            lblSaldoTotAgr.Text = "000000.00";
            lblSaldoTotAgr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(66, 572);
            label13.Name = "label13";
            label13.Size = new Size(368, 54);
            label13.TabIndex = 12;
            label13.Text = "Saldo Agricultores";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(66, 271);
            label14.Name = "label14";
            label14.Size = new Size(374, 54);
            label14.TabIndex = 5;
            label14.Text = "Saldo Proveedores";
            // 
            // lblSaldoTotProv
            // 
            lblSaldoTotProv.AutoSize = true;
            lblSaldoTotProv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaldoTotProv.ForeColor = Color.White;
            lblSaldoTotProv.Location = new Point(90, 341);
            lblSaldoTotProv.Name = "lblSaldoTotProv";
            lblSaldoTotProv.Size = new Size(189, 46);
            lblSaldoTotProv.TabIndex = 1;
            lblSaldoTotProv.Text = "000000.00";
            lblSaldoTotProv.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(tablaInventario);
            tabInventario.Controls.Add(panelTituloInventario);
            tabInventario.Controls.Add(panelFooterInventario);
            tabInventario.Location = new Point(10, 58);
            tabInventario.Name = "tabInventario";
            tabInventario.Padding = new Padding(5);
            tabInventario.Size = new Size(2896, 1375);
            tabInventario.TabIndex = 0;
            tabInventario.Text = "Inventario";
            tabInventario.UseVisualStyleBackColor = true;
            tabInventario.Enter += tabInventario_Enter;
            // 
            // tablaInventario
            // 
            tablaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaInventario.Dock = DockStyle.Fill;
            tablaInventario.Location = new Point(743, 244);
            tablaInventario.Name = "tablaInventario";
            tablaInventario.RowHeadersWidth = 102;
            tablaInventario.Size = new Size(2148, 1126);
            tablaInventario.TabIndex = 0;
            // 
            // panelTituloInventario
            // 
            panelTituloInventario.BackColor = Color.FromArgb(192, 229, 200);
            panelTituloInventario.Controls.Add(btnRecargar);
            panelTituloInventario.Controls.Add(btnBuscar);
            panelTituloInventario.Controls.Add(tbBuscar);
            panelTituloInventario.Controls.Add(groupReportesInventario);
            panelTituloInventario.Dock = DockStyle.Top;
            panelTituloInventario.Location = new Point(743, 5);
            panelTituloInventario.Name = "panelTituloInventario";
            panelTituloInventario.Size = new Size(2148, 239);
            panelTituloInventario.TabIndex = 1;
            // 
            // btnRecargar
            // 
            btnRecargar.Font = new Font("Segoe UI", 9F);
            btnRecargar.Location = new Point(602, 121);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(201, 57);
            btnRecargar.TabIndex = 9;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F);
            btnBuscar.Location = new Point(119, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(201, 57);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 9F);
            tbBuscar.Location = new Point(119, 57);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar Agricultor o Producto...";
            tbBuscar.Size = new Size(682, 47);
            tbBuscar.TabIndex = 6;
            // 
            // groupReportesInventario
            // 
            groupReportesInventario.Controls.Add(radioInsumosxProducto);
            groupReportesInventario.Controls.Add(radioProdxProducto);
            groupReportesInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupReportesInventario.Location = new Point(950, 36);
            groupReportesInventario.Name = "groupReportesInventario";
            groupReportesInventario.Size = new Size(1146, 161);
            groupReportesInventario.TabIndex = 0;
            groupReportesInventario.TabStop = false;
            groupReportesInventario.Text = "Elegir Reporte";
            // 
            // radioInsumosxProducto
            // 
            radioInsumosxProducto.AutoSize = true;
            radioInsumosxProducto.Font = new Font("Segoe UI", 9F);
            radioInsumosxProducto.Location = new Point(615, 75);
            radioInsumosxProducto.Name = "radioInsumosxProducto";
            radioInsumosxProducto.Size = new Size(519, 45);
            radioInsumosxProducto.TabIndex = 1;
            radioInsumosxProducto.TabStop = true;
            radioInsumosxProducto.Text = "Insumos Entregados por Productor";
            radioInsumosxProducto.UseVisualStyleBackColor = true;
            // 
            // radioProdxProducto
            // 
            radioProdxProducto.AutoSize = true;
            radioProdxProducto.Font = new Font("Segoe UI", 9F);
            radioProdxProducto.Location = new Point(51, 75);
            radioProdxProducto.Name = "radioProdxProducto";
            radioProdxProducto.Size = new Size(527, 45);
            radioProdxProducto.TabIndex = 0;
            radioProdxProducto.TabStop = true;
            radioProdxProducto.Text = "Produccion Recibida por Productor ";
            radioProdxProducto.UseVisualStyleBackColor = true;
            radioProdxProducto.CheckedChanged += radioProdxProducto_CheckedChanged;
            // 
            // panelFooterInventario
            // 
            panelFooterInventario.BackColor = Color.FromArgb(22, 48, 43);
            panelFooterInventario.Controls.Add(label10);
            panelFooterInventario.Controls.Add(lblTotalVentasInsumos);
            panelFooterInventario.Controls.Add(label9);
            panelFooterInventario.Controls.Add(lblInsumosVendidos);
            panelFooterInventario.Controls.Add(label7);
            panelFooterInventario.Controls.Add(lblComprasdelAño);
            panelFooterInventario.Controls.Add(label3);
            panelFooterInventario.Controls.Add(label5);
            panelFooterInventario.Controls.Add(lblTotalProdAdqu);
            panelFooterInventario.Dock = DockStyle.Left;
            panelFooterInventario.Location = new Point(5, 5);
            panelFooterInventario.Name = "panelFooterInventario";
            panelFooterInventario.Size = new Size(738, 1365);
            panelFooterInventario.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label10.ForeColor = Color.FromArgb(255, 222, 89);
            label10.Location = new Point(66, 69);
            label10.Name = "label10";
            label10.Size = new Size(600, 62);
            label10.TabIndex = 18;
            label10.Text = "Totales de Periodo Actual ";
            // 
            // lblTotalVentasInsumos
            // 
            lblTotalVentasInsumos.AutoSize = true;
            lblTotalVentasInsumos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalVentasInsumos.ForeColor = Color.White;
            lblTotalVentasInsumos.Location = new Point(85, 1155);
            lblTotalVentasInsumos.Name = "lblTotalVentasInsumos";
            lblTotalVentasInsumos.Size = new Size(209, 46);
            lblTotalVentasInsumos.TabIndex = 17;
            lblTotalVentasInsumos.Text = "0000000.00";
            lblTotalVentasInsumos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(66, 1084);
            label9.Name = "label9";
            label9.Size = new Size(421, 54);
            label9.TabIndex = 16;
            label9.Text = "Total Ventas Insumos";
            // 
            // lblInsumosVendidos
            // 
            lblInsumosVendidos.AutoSize = true;
            lblInsumosVendidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInsumosVendidos.ForeColor = Color.White;
            lblInsumosVendidos.Location = new Point(85, 881);
            lblInsumosVendidos.Name = "lblInsumosVendidos";
            lblInsumosVendidos.Size = new Size(209, 46);
            lblInsumosVendidos.TabIndex = 15;
            lblInsumosVendidos.Text = "0000000.00";
            lblInsumosVendidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(66, 813);
            label7.Name = "label7";
            label7.Size = new Size(365, 54);
            label7.TabIndex = 14;
            label7.Text = "Insumos Vendidos";
            // 
            // lblComprasdelAño
            // 
            lblComprasdelAño.AutoSize = true;
            lblComprasdelAño.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComprasdelAño.ForeColor = Color.White;
            lblComprasdelAño.Location = new Point(85, 608);
            lblComprasdelAño.Name = "lblComprasdelAño";
            lblComprasdelAño.Size = new Size(209, 46);
            lblComprasdelAño.TabIndex = 13;
            lblComprasdelAño.Text = "0000000.00";
            lblComprasdelAño.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 541);
            label3.Name = "label3";
            label3.Size = new Size(495, 54);
            label3.TabIndex = 12;
            label3.Text = "Total Compras Productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 271);
            label5.Name = "label5";
            label5.Size = new Size(432, 54);
            label5.TabIndex = 5;
            label5.Text = "Productos Adquiridos";
            // 
            // lblTotalProdAdqu
            // 
            lblTotalProdAdqu.AutoSize = true;
            lblTotalProdAdqu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalProdAdqu.ForeColor = Color.White;
            lblTotalProdAdqu.Location = new Point(85, 335);
            lblTotalProdAdqu.Name = "lblTotalProdAdqu";
            lblTotalProdAdqu.Size = new Size(209, 46);
            lblTotalProdAdqu.TabIndex = 1;
            lblTotalProdAdqu.Text = "0000000.00";
            lblTotalProdAdqu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(22, 48, 43);
            panelTitulo.Controls.Add(lbBienvenida);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(2916, 269);
            panelTitulo.TabIndex = 1;
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbBienvenida.ForeColor = Color.White;
            lbBienvenida.Location = new Point(168, 103);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(430, 89);
            lbBienvenida.TabIndex = 0;
            lbBienvenida.Text = "¡Bienvenido ";
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(tabControlReportes);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 269);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(2916, 1443);
            panelContenido.TabIndex = 2;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(panelContenido);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            tabControlReportes.ResumeLayout(false);
            tabUtilidad.ResumeLayout(false);
            panelPanelTopProductos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaTopVenta).EndInit();
            panelTituloTopVenta.ResumeLayout(false);
            panelTituloTopVenta.PerformLayout();
            panelContenidoTopProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaTopCompra).EndInit();
            panelTituloTopCompra.ResumeLayout(false);
            panelTituloTopCompra.PerformLayout();
            panelTotalesUtilidad.ResumeLayout(false);
            panelTotalesUtilidad.PerformLayout();
            tabSaldo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaSaldo).EndInit();
            panelTituloSaldo.ResumeLayout(false);
            panelTituloSaldo.PerformLayout();
            groupFiltroSaldo.ResumeLayout(false);
            groupFiltroSaldo.PerformLayout();
            panelFooterSaldos.ResumeLayout(false);
            panelFooterSaldos.PerformLayout();
            tabInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaInventario).EndInit();
            panelTituloInventario.ResumeLayout(false);
            panelTituloInventario.PerformLayout();
            groupReportesInventario.ResumeLayout(false);
            groupReportesInventario.PerformLayout();
            panelFooterInventario.ResumeLayout(false);
            panelFooterInventario.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlReportes;
        private TabPage tabInventario;
        private TabPage tabSaldo;
        private TabPage tabUtilidad;
        private Panel panelTitulo;
        private Label lbBienvenida;
        private Panel panelContenido;
        private DataGridView tablaInventario;
        private Panel panelTituloInventario;
        private Panel panelFooterInventario;
        private Label lblTotalProdAdqu;
        private GroupBox groupReportesInventario;
        private RadioButton radioInsumosxProducto;
        private RadioButton radioProdxProducto;
        private Label label5;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Button btnRecargar;
        private Label lblComprasdelAño;
        private Label label3;
        private Label lblInsumosVendidos;
        private Label label7;
        private Label label10;
        private Label lblTotalVentasInsumos;
        private Label label9;
        private Panel panelTituloSaldo;
        private Button btnRecargarSaldo;
        private Button btnBuscarSaldo;
        private TextBox tbBuscarSaldo;
        private GroupBox groupFiltroSaldo;
        private RadioButton radioSaldoAgricultor;
        private RadioButton radioSaldoProveedor;
        private Panel panelFooterSaldos;
        private Label label2;
        private Label lblSaldoTot;
        private Label label11;
        private Label lblSaldoTotAgr;
        private Label label13;
        private Label label14;
        private Label lblSaldoTotProv;
        private DataGridView tablaSaldo;
        private RadioButton radioTodo;
        private Panel panelPanelTopProductos;
        private Panel panelTotalesUtilidad;
        private Label lblTotIngresos;
        private Label label4;
        private Label lblTotUtilidad;
        private Label label16;
        private Label lblTotGastos;
        private Label label12;
        private DataGridView tablaTopVenta;
        private Panel panelTituloTopVenta;
        private DataGridView tablaTopCompra;
        private Panel panelTituloTopCompra;
        private Label label8;
        private Label label6;
        private Panel panelContenidoTopProductos;
        private Panel panel1;
    }
}