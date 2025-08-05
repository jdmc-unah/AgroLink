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
            tabUtilidad = new TabPage();
            panelPanelTopProductos = new Panel();
            panelTablaTopCompra = new Panel();
            tablaTopCompra = new DataGridView();
            panelTituloTopCompra = new Panel();
            label8 = new Label();
            panelTablaTopVenta = new Panel();
            tablaTopVenta = new DataGridView();
            panelTituloTopVenta = new Panel();
            label6 = new Label();
            panelTotalesUtilidad = new Panel();
            lblTotUtilidad = new Label();
            label16 = new Label();
            lblTotGastos = new Label();
            label12 = new Label();
            lblTotIngresos = new Label();
            label4 = new Label();
            panelTitulo = new Panel();
            lbBienvenida = new Label();
            panelContenido = new Panel();
            tabControlReportes.SuspendLayout();
            tabInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).BeginInit();
            panelTituloInventario.SuspendLayout();
            groupReportesInventario.SuspendLayout();
            panelFooterInventario.SuspendLayout();
            tabSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSaldo).BeginInit();
            panelTituloSaldo.SuspendLayout();
            groupFiltroSaldo.SuspendLayout();
            panelFooterSaldos.SuspendLayout();
            tabUtilidad.SuspendLayout();
            panelPanelTopProductos.SuspendLayout();
            panelTablaTopCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaTopCompra).BeginInit();
            panelTituloTopCompra.SuspendLayout();
            panelTablaTopVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaTopVenta).BeginInit();
            panelTituloTopVenta.SuspendLayout();
            panelTotalesUtilidad.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlReportes
            // 
            tabControlReportes.Controls.Add(tabInventario);
            tabControlReportes.Controls.Add(tabSaldo);
            tabControlReportes.Controls.Add(tabUtilidad);
            tabControlReportes.Dock = DockStyle.Fill;
            tabControlReportes.Location = new Point(0, 0);
            tabControlReportes.Margin = new Padding(2);
            tabControlReportes.Name = "tabControlReportes";
            tabControlReportes.SelectedIndex = 0;
            tabControlReportes.Size = new Size(1145, 510);
            tabControlReportes.TabIndex = 0;
            // 
            // tabInventario
            // 
            tabInventario.Controls.Add(tablaInventario);
            tabInventario.Controls.Add(panelTituloInventario);
            tabInventario.Controls.Add(panelFooterInventario);
            tabInventario.Location = new Point(4, 34);
            tabInventario.Margin = new Padding(2);
            tabInventario.Name = "tabInventario";
            tabInventario.Padding = new Padding(2);
            tabInventario.Size = new Size(1137, 472);
            tabInventario.TabIndex = 0;
            tabInventario.Text = "Inventario";
            tabInventario.UseVisualStyleBackColor = true;
            // 
            // tablaInventario
            // 
            tablaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaInventario.Dock = DockStyle.Fill;
            tablaInventario.Location = new Point(436, 148);
            tablaInventario.Margin = new Padding(2);
            tablaInventario.Name = "tablaInventario";
            tablaInventario.RowHeadersWidth = 102;
            tablaInventario.Size = new Size(699, 322);
            tablaInventario.TabIndex = 0;
            // 
            // panelTituloInventario
            // 
            panelTituloInventario.Controls.Add(btnRecargar);
            panelTituloInventario.Controls.Add(btnBuscar);
            panelTituloInventario.Controls.Add(tbBuscar);
            panelTituloInventario.Controls.Add(groupReportesInventario);
            panelTituloInventario.Dock = DockStyle.Top;
            panelTituloInventario.Location = new Point(436, 2);
            panelTituloInventario.Margin = new Padding(2);
            panelTituloInventario.Name = "panelTituloInventario";
            panelTituloInventario.Size = new Size(699, 146);
            panelTituloInventario.TabIndex = 1;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(354, 74);
            btnRecargar.Margin = new Padding(2);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(118, 35);
            btnRecargar.TabIndex = 9;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(70, 77);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 35);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(70, 35);
            tbBuscar.Margin = new Padding(2);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar Agricultor o Producto...";
            tbBuscar.Size = new Size(403, 31);
            tbBuscar.TabIndex = 6;
            // 
            // groupReportesInventario
            // 
            groupReportesInventario.Controls.Add(radioInsumosxProducto);
            groupReportesInventario.Controls.Add(radioProdxProducto);
            groupReportesInventario.Font = new Font("Segoe UI", 9F);
            groupReportesInventario.Location = new Point(559, 22);
            groupReportesInventario.Margin = new Padding(2);
            groupReportesInventario.Name = "groupReportesInventario";
            groupReportesInventario.Padding = new Padding(2);
            groupReportesInventario.Size = new Size(674, 98);
            groupReportesInventario.TabIndex = 0;
            groupReportesInventario.TabStop = false;
            groupReportesInventario.Text = "Elegir Reporte";
            // 
            // radioInsumosxProducto
            // 
            radioInsumosxProducto.AutoSize = true;
            radioInsumosxProducto.Location = new Point(362, 46);
            radioInsumosxProducto.Margin = new Padding(2);
            radioInsumosxProducto.Name = "radioInsumosxProducto";
            radioInsumosxProducto.Size = new Size(317, 29);
            radioInsumosxProducto.TabIndex = 1;
            radioInsumosxProducto.TabStop = true;
            radioInsumosxProducto.Text = "Insumos Entregados por Productor";
            radioInsumosxProducto.UseVisualStyleBackColor = true;
            // 
            // radioProdxProducto
            // 
            radioProdxProducto.AutoSize = true;
            radioProdxProducto.Location = new Point(30, 46);
            radioProdxProducto.Margin = new Padding(2);
            radioProdxProducto.Name = "radioProdxProducto";
            radioProdxProducto.Size = new Size(319, 29);
            radioProdxProducto.TabIndex = 0;
            radioProdxProducto.TabStop = true;
            radioProdxProducto.Text = "Produccion Recibida por Productor ";
            radioProdxProducto.UseVisualStyleBackColor = true;
            radioProdxProducto.CheckedChanged += radioProdxProducto_CheckedChanged;
            // 
            // panelFooterInventario
            // 
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
            panelFooterInventario.Location = new Point(2, 2);
            panelFooterInventario.Margin = new Padding(2);
            panelFooterInventario.Name = "panelFooterInventario";
            panelFooterInventario.Size = new Size(434, 468);
            panelFooterInventario.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label10.Location = new Point(39, 42);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(357, 38);
            label10.TabIndex = 18;
            label10.Text = "Totales de Periodo Actual ";
            // 
            // lblTotalVentasInsumos
            // 
            lblTotalVentasInsumos.AutoSize = true;
            lblTotalVentasInsumos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalVentasInsumos.Location = new Point(50, 704);
            lblTotalVentasInsumos.Margin = new Padding(2, 0, 2, 0);
            lblTotalVentasInsumos.Name = "lblTotalVentasInsumos";
            lblTotalVentasInsumos.Size = new Size(125, 28);
            lblTotalVentasInsumos.TabIndex = 17;
            lblTotalVentasInsumos.Text = "0000000.00";
            lblTotalVentasInsumos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(39, 661);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(256, 32);
            label9.TabIndex = 16;
            label9.Text = "Total Ventas Insumos";
            // 
            // lblInsumosVendidos
            // 
            lblInsumosVendidos.AutoSize = true;
            lblInsumosVendidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInsumosVendidos.Location = new Point(50, 537);
            lblInsumosVendidos.Margin = new Padding(2, 0, 2, 0);
            lblInsumosVendidos.Name = "lblInsumosVendidos";
            lblInsumosVendidos.Size = new Size(125, 28);
            lblInsumosVendidos.TabIndex = 15;
            lblInsumosVendidos.Text = "0000000.00";
            lblInsumosVendidos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(39, 496);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(223, 32);
            label7.TabIndex = 14;
            label7.Text = "Insumos Vendidos";
            // 
            // lblComprasdelAño
            // 
            lblComprasdelAño.AutoSize = true;
            lblComprasdelAño.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblComprasdelAño.Location = new Point(50, 371);
            lblComprasdelAño.Margin = new Padding(2, 0, 2, 0);
            lblComprasdelAño.Name = "lblComprasdelAño";
            lblComprasdelAño.Size = new Size(125, 28);
            lblComprasdelAño.TabIndex = 13;
            lblComprasdelAño.Text = "0000000.00";
            lblComprasdelAño.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(39, 330);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 32);
            label3.TabIndex = 12;
            label3.Text = "Total Compras Productos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(39, 165);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(265, 32);
            label5.TabIndex = 5;
            label5.Text = "Productos Adquiridos";
            // 
            // lblTotalProdAdqu
            // 
            lblTotalProdAdqu.AutoSize = true;
            lblTotalProdAdqu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalProdAdqu.Location = new Point(50, 204);
            lblTotalProdAdqu.Margin = new Padding(2, 0, 2, 0);
            lblTotalProdAdqu.Name = "lblTotalProdAdqu";
            lblTotalProdAdqu.Size = new Size(125, 28);
            lblTotalProdAdqu.TabIndex = 1;
            lblTotalProdAdqu.Text = "0000000.00";
            lblTotalProdAdqu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabSaldo
            // 
            tabSaldo.Controls.Add(tablaSaldo);
            tabSaldo.Controls.Add(panelTituloSaldo);
            tabSaldo.Controls.Add(panelFooterSaldos);
            tabSaldo.Location = new Point(4, 34);
            tabSaldo.Margin = new Padding(2);
            tabSaldo.Name = "tabSaldo";
            tabSaldo.Padding = new Padding(2);
            tabSaldo.Size = new Size(1137, 472);
            tabSaldo.TabIndex = 1;
            tabSaldo.Text = "Saldo";
            tabSaldo.UseVisualStyleBackColor = true;
            tabSaldo.Enter += tabSaldo_Enter;
            // 
            // tablaSaldo
            // 
            tablaSaldo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSaldo.Dock = DockStyle.Fill;
            tablaSaldo.Location = new Point(419, 148);
            tablaSaldo.Margin = new Padding(2);
            tablaSaldo.Name = "tablaSaldo";
            tablaSaldo.RowHeadersWidth = 102;
            tablaSaldo.Size = new Size(716, 322);
            tablaSaldo.TabIndex = 0;
            // 
            // panelTituloSaldo
            // 
            panelTituloSaldo.Controls.Add(btnRecargarSaldo);
            panelTituloSaldo.Controls.Add(btnBuscarSaldo);
            panelTituloSaldo.Controls.Add(tbBuscarSaldo);
            panelTituloSaldo.Controls.Add(groupFiltroSaldo);
            panelTituloSaldo.Dock = DockStyle.Top;
            panelTituloSaldo.Location = new Point(419, 2);
            panelTituloSaldo.Margin = new Padding(2);
            panelTituloSaldo.Name = "panelTituloSaldo";
            panelTituloSaldo.Size = new Size(716, 146);
            panelTituloSaldo.TabIndex = 2;
            // 
            // btnRecargarSaldo
            // 
            btnRecargarSaldo.Location = new Point(312, 85);
            btnRecargarSaldo.Margin = new Padding(2);
            btnRecargarSaldo.Name = "btnRecargarSaldo";
            btnRecargarSaldo.Size = new Size(118, 35);
            btnRecargarSaldo.TabIndex = 9;
            btnRecargarSaldo.Text = "Recargar";
            btnRecargarSaldo.UseVisualStyleBackColor = true;
            btnRecargarSaldo.Click += btnRecargarSaldo_Click;
            // 
            // btnBuscarSaldo
            // 
            btnBuscarSaldo.Location = new Point(28, 87);
            btnBuscarSaldo.Margin = new Padding(2);
            btnBuscarSaldo.Name = "btnBuscarSaldo";
            btnBuscarSaldo.Size = new Size(118, 35);
            btnBuscarSaldo.TabIndex = 7;
            btnBuscarSaldo.Text = "Buscar";
            btnBuscarSaldo.UseVisualStyleBackColor = true;
            btnBuscarSaldo.Click += btnBuscarSaldo_Click;
            // 
            // tbBuscarSaldo
            // 
            tbBuscarSaldo.Location = new Point(28, 46);
            tbBuscarSaldo.Margin = new Padding(2);
            tbBuscarSaldo.Name = "tbBuscarSaldo";
            tbBuscarSaldo.PlaceholderText = "Buscar Agricultor o Proveedor...";
            tbBuscarSaldo.Size = new Size(403, 31);
            tbBuscarSaldo.TabIndex = 6;
            // 
            // groupFiltroSaldo
            // 
            groupFiltroSaldo.Controls.Add(radioTodo);
            groupFiltroSaldo.Controls.Add(radioSaldoAgricultor);
            groupFiltroSaldo.Controls.Add(radioSaldoProveedor);
            groupFiltroSaldo.Font = new Font("Segoe UI", 9F);
            groupFiltroSaldo.Location = new Point(673, 27);
            groupFiltroSaldo.Margin = new Padding(2);
            groupFiltroSaldo.Name = "groupFiltroSaldo";
            groupFiltroSaldo.Padding = new Padding(2);
            groupFiltroSaldo.Size = new Size(577, 109);
            groupFiltroSaldo.TabIndex = 0;
            groupFiltroSaldo.TabStop = false;
            groupFiltroSaldo.Text = "Filtro";
            // 
            // radioTodo
            // 
            radioTodo.AutoSize = true;
            radioTodo.Location = new Point(459, 48);
            radioTodo.Margin = new Padding(2);
            radioTodo.Name = "radioTodo";
            radioTodo.Size = new Size(77, 29);
            radioTodo.TabIndex = 2;
            radioTodo.TabStop = true;
            radioTodo.Text = "Todo";
            radioTodo.UseVisualStyleBackColor = true;
            radioTodo.CheckedChanged += radioTodo_CheckedChanged;
            // 
            // radioSaldoAgricultor
            // 
            radioSaldoAgricultor.AutoSize = true;
            radioSaldoAgricultor.Location = new Point(248, 47);
            radioSaldoAgricultor.Margin = new Padding(2);
            radioSaldoAgricultor.Name = "radioSaldoAgricultor";
            radioSaldoAgricultor.Size = new Size(182, 29);
            radioSaldoAgricultor.TabIndex = 1;
            radioSaldoAgricultor.TabStop = true;
            radioSaldoAgricultor.Text = "Saldo Agricultores";
            radioSaldoAgricultor.UseVisualStyleBackColor = true;
            radioSaldoAgricultor.CheckedChanged += radioSaldoAgricultor_CheckedChanged;
            // 
            // radioSaldoProveedor
            // 
            radioSaldoProveedor.AutoSize = true;
            radioSaldoProveedor.Location = new Point(32, 46);
            radioSaldoProveedor.Margin = new Padding(2);
            radioSaldoProveedor.Name = "radioSaldoProveedor";
            radioSaldoProveedor.Size = new Size(186, 29);
            radioSaldoProveedor.TabIndex = 0;
            radioSaldoProveedor.TabStop = true;
            radioSaldoProveedor.Text = "Saldo Proveedores";
            radioSaldoProveedor.UseVisualStyleBackColor = true;
            radioSaldoProveedor.CheckedChanged += radioSaldoProveedor_CheckedChanged;
            // 
            // panelFooterSaldos
            // 
            panelFooterSaldos.Controls.Add(label2);
            panelFooterSaldos.Controls.Add(lblSaldoTot);
            panelFooterSaldos.Controls.Add(label11);
            panelFooterSaldos.Controls.Add(lblSaldoTotAgr);
            panelFooterSaldos.Controls.Add(label13);
            panelFooterSaldos.Controls.Add(label14);
            panelFooterSaldos.Controls.Add(lblSaldoTotProv);
            panelFooterSaldos.Dock = DockStyle.Left;
            panelFooterSaldos.Location = new Point(2, 2);
            panelFooterSaldos.Margin = new Padding(2);
            panelFooterSaldos.Name = "panelFooterSaldos";
            panelFooterSaldos.Size = new Size(417, 468);
            panelFooterSaldos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(28, 36);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(357, 38);
            label2.TabIndex = 18;
            label2.Text = "Totales de Periodo Actual ";
            // 
            // lblSaldoTot
            // 
            lblSaldoTot.AutoSize = true;
            lblSaldoTot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSaldoTot.Location = new Point(62, 565);
            lblSaldoTot.Margin = new Padding(2, 0, 2, 0);
            lblSaldoTot.Name = "lblSaldoTot";
            lblSaldoTot.Size = new Size(133, 32);
            lblSaldoTot.TabIndex = 15;
            lblSaldoTot.Text = "000000.00";
            lblSaldoTot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(37, 528);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(140, 32);
            label11.TabIndex = 14;
            label11.Text = "Saldo Total";
            // 
            // lblSaldoTotAgr
            // 
            lblSaldoTotAgr.AutoSize = true;
            lblSaldoTotAgr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaldoTotAgr.Location = new Point(53, 385);
            lblSaldoTotAgr.Margin = new Padding(2, 0, 2, 0);
            lblSaldoTotAgr.Name = "lblSaldoTotAgr";
            lblSaldoTotAgr.Size = new Size(113, 28);
            lblSaldoTotAgr.TabIndex = 13;
            lblSaldoTotAgr.Text = "000000.00";
            lblSaldoTotAgr.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(28, 349);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(225, 32);
            label13.TabIndex = 12;
            label13.Text = "Saldo Agricultores";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(28, 171);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(227, 32);
            label14.TabIndex = 5;
            label14.Text = "Saldo Proveedores";
            // 
            // lblSaldoTotProv
            // 
            lblSaldoTotProv.AutoSize = true;
            lblSaldoTotProv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSaldoTotProv.Location = new Point(53, 208);
            lblSaldoTotProv.Margin = new Padding(2, 0, 2, 0);
            lblSaldoTotProv.Name = "lblSaldoTotProv";
            lblSaldoTotProv.Size = new Size(113, 28);
            lblSaldoTotProv.TabIndex = 1;
            lblSaldoTotProv.Text = "000000.00";
            lblSaldoTotProv.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabUtilidad
            // 
            tabUtilidad.Controls.Add(panelPanelTopProductos);
            tabUtilidad.Controls.Add(panelTotalesUtilidad);
            tabUtilidad.Location = new Point(4, 34);
            tabUtilidad.Margin = new Padding(2);
            tabUtilidad.Name = "tabUtilidad";
            tabUtilidad.Padding = new Padding(2);
            tabUtilidad.Size = new Size(1137, 472);
            tabUtilidad.TabIndex = 2;
            tabUtilidad.Text = "Utilidad";
            tabUtilidad.UseVisualStyleBackColor = true;
            tabUtilidad.Enter += tabUtilidad_Enter;
            // 
            // panelPanelTopProductos
            // 
            panelPanelTopProductos.Controls.Add(panelTablaTopCompra);
            panelPanelTopProductos.Controls.Add(panelTituloTopCompra);
            panelPanelTopProductos.Controls.Add(panelTablaTopVenta);
            panelPanelTopProductos.Controls.Add(panelTituloTopVenta);
            panelPanelTopProductos.Dock = DockStyle.Fill;
            panelPanelTopProductos.Location = new Point(716, 2);
            panelPanelTopProductos.Margin = new Padding(2);
            panelPanelTopProductos.Name = "panelPanelTopProductos";
            panelPanelTopProductos.Size = new Size(419, 468);
            panelPanelTopProductos.TabIndex = 1;
            // 
            // panelTablaTopCompra
            // 
            panelTablaTopCompra.Controls.Add(tablaTopCompra);
            panelTablaTopCompra.Dock = DockStyle.Top;
            panelTablaTopCompra.Location = new Point(0, 486);
            panelTablaTopCompra.Margin = new Padding(2);
            panelTablaTopCompra.Name = "panelTablaTopCompra";
            panelTablaTopCompra.Size = new Size(419, 349);
            panelTablaTopCompra.TabIndex = 4;
            // 
            // tablaTopCompra
            // 
            tablaTopCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTopCompra.Dock = DockStyle.Fill;
            tablaTopCompra.Location = new Point(0, 0);
            tablaTopCompra.Margin = new Padding(2);
            tablaTopCompra.Name = "tablaTopCompra";
            tablaTopCompra.RowHeadersWidth = 102;
            tablaTopCompra.Size = new Size(419, 349);
            tablaTopCompra.TabIndex = 0;
            // 
            // panelTituloTopCompra
            // 
            panelTituloTopCompra.Controls.Add(label8);
            panelTituloTopCompra.Dock = DockStyle.Top;
            panelTituloTopCompra.Location = new Point(0, 411);
            panelTituloTopCompra.Margin = new Padding(2);
            panelTituloTopCompra.Name = "panelTituloTopCompra";
            panelTituloTopCompra.Size = new Size(419, 75);
            panelTituloTopCompra.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label8.Location = new Point(294, 20);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(472, 46);
            label8.TabIndex = 3;
            label8.Text = "Top 3 Productos Comprados";
            // 
            // panelTablaTopVenta
            // 
            panelTablaTopVenta.Controls.Add(tablaTopVenta);
            panelTablaTopVenta.Dock = DockStyle.Top;
            panelTablaTopVenta.Location = new Point(0, 75);
            panelTablaTopVenta.Margin = new Padding(2);
            panelTablaTopVenta.Name = "panelTablaTopVenta";
            panelTablaTopVenta.Size = new Size(419, 336);
            panelTablaTopVenta.TabIndex = 2;
            // 
            // tablaTopVenta
            // 
            tablaTopVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTopVenta.Dock = DockStyle.Fill;
            tablaTopVenta.Location = new Point(0, 0);
            tablaTopVenta.Margin = new Padding(2);
            tablaTopVenta.Name = "tablaTopVenta";
            tablaTopVenta.RowHeadersWidth = 102;
            tablaTopVenta.Size = new Size(419, 336);
            tablaTopVenta.TabIndex = 0;
            // 
            // panelTituloTopVenta
            // 
            panelTituloTopVenta.Controls.Add(label6);
            panelTituloTopVenta.Dock = DockStyle.Top;
            panelTituloTopVenta.Location = new Point(0, 0);
            panelTituloTopVenta.Margin = new Padding(2);
            panelTituloTopVenta.Name = "panelTituloTopVenta";
            panelTituloTopVenta.Size = new Size(419, 75);
            panelTituloTopVenta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label6.Location = new Point(312, 20);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(437, 46);
            label6.TabIndex = 2;
            label6.Text = "Top 3 Productos Vendidos";
            // 
            // panelTotalesUtilidad
            // 
            panelTotalesUtilidad.Controls.Add(lblTotUtilidad);
            panelTotalesUtilidad.Controls.Add(label16);
            panelTotalesUtilidad.Controls.Add(lblTotGastos);
            panelTotalesUtilidad.Controls.Add(label12);
            panelTotalesUtilidad.Controls.Add(lblTotIngresos);
            panelTotalesUtilidad.Controls.Add(label4);
            panelTotalesUtilidad.Dock = DockStyle.Left;
            panelTotalesUtilidad.Location = new Point(2, 2);
            panelTotalesUtilidad.Margin = new Padding(2);
            panelTotalesUtilidad.Name = "panelTotalesUtilidad";
            panelTotalesUtilidad.Size = new Size(714, 468);
            panelTotalesUtilidad.TabIndex = 0;
            // 
            // lblTotUtilidad
            // 
            lblTotUtilidad.AutoSize = true;
            lblTotUtilidad.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotUtilidad.Location = new Point(87, 661);
            lblTotUtilidad.Margin = new Padding(2, 0, 2, 0);
            lblTotUtilidad.Name = "lblTotUtilidad";
            lblTotUtilidad.Size = new Size(209, 46);
            lblTotUtilidad.TabIndex = 6;
            lblTotUtilidad.Text = "0000000.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label16.Location = new Point(64, 601);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(481, 46);
            label16.TabIndex = 5;
            label16.Text = "Total Utilidad Periodo Actual";
            // 
            // lblTotGastos
            // 
            lblTotGastos.AutoSize = true;
            lblTotGastos.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotGastos.Location = new Point(87, 401);
            lblTotGastos.Margin = new Padding(2, 0, 2, 0);
            lblTotGastos.Name = "lblTotGastos";
            lblTotGastos.Size = new Size(209, 46);
            lblTotGastos.TabIndex = 4;
            lblTotGastos.Text = "0000000.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label12.Location = new Point(64, 343);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(262, 46);
            label12.TabIndex = 3;
            label12.Text = "Total de Gastos";
            // 
            // lblTotIngresos
            // 
            lblTotIngresos.AutoSize = true;
            lblTotIngresos.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTotIngresos.Location = new Point(87, 162);
            lblTotIngresos.Margin = new Padding(2, 0, 2, 0);
            lblTotIngresos.Name = "lblTotIngresos";
            lblTotIngresos.Size = new Size(209, 46);
            lblTotIngresos.TabIndex = 2;
            lblTotIngresos.Text = "0000000.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label4.Location = new Point(64, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(475, 46);
            label4.TabIndex = 1;
            label4.Text = "Total de Ingresos Facturados";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(22, 48, 43);
            panelTitulo.Controls.Add(lbBienvenida);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1145, 164);
            panelTitulo.TabIndex = 1;
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbBienvenida.ForeColor = Color.White;
            lbBienvenida.Location = new Point(99, 63);
            lbBienvenida.Margin = new Padding(2, 0, 2, 0);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(258, 54);
            lbBienvenida.TabIndex = 0;
            lbBienvenida.Text = "¡Bienvenido ";
            // 
            // panelContenido
            // 
            panelContenido.Controls.Add(tabControlReportes);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 164);
            panelContenido.Margin = new Padding(2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1145, 510);
            panelContenido.TabIndex = 2;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panelContenido);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            tabControlReportes.ResumeLayout(false);
            tabInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaInventario).EndInit();
            panelTituloInventario.ResumeLayout(false);
            panelTituloInventario.PerformLayout();
            groupReportesInventario.ResumeLayout(false);
            groupReportesInventario.PerformLayout();
            panelFooterInventario.ResumeLayout(false);
            panelFooterInventario.PerformLayout();
            tabSaldo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaSaldo).EndInit();
            panelTituloSaldo.ResumeLayout(false);
            panelTituloSaldo.PerformLayout();
            groupFiltroSaldo.ResumeLayout(false);
            groupFiltroSaldo.PerformLayout();
            panelFooterSaldos.ResumeLayout(false);
            panelFooterSaldos.PerformLayout();
            tabUtilidad.ResumeLayout(false);
            panelPanelTopProductos.ResumeLayout(false);
            panelTablaTopCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaTopCompra).EndInit();
            panelTituloTopCompra.ResumeLayout(false);
            panelTituloTopCompra.PerformLayout();
            panelTablaTopVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaTopVenta).EndInit();
            panelTituloTopVenta.ResumeLayout(false);
            panelTituloTopVenta.PerformLayout();
            panelTotalesUtilidad.ResumeLayout(false);
            panelTotalesUtilidad.PerformLayout();
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
        private Panel panelTablaTopVenta;
        private DataGridView tablaTopVenta;
        private Panel panelTituloTopVenta;
        private Panel panelTablaTopCompra;
        private DataGridView tablaTopCompra;
        private Panel panelTituloTopCompra;
        private Label label8;
        private Label label6;
    }
}