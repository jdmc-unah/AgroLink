namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Compra
{
    partial class CompraDetalle
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAdministrarProducto = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbEstadoCompra = new ComboBox();
            cbTipoPagoCompra = new ComboBox();
            cbListaPrecioCompra = new ComboBox();
            cbSocioCompra = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbCodigoCompra = new TextBox();
            tablaCompraDetalle = new DataGridView();
            CompraID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            btnEditarCompra = new Button();
            btnAceptarCompra = new Button();
            btnCancelarCompra = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            tbTotal = new TextBox();
            tbSubtotal = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnCrearRecibo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompraDetalle).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnAdministrarProducto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbEstadoCompra);
            panel1.Controls.Add(cbTipoPagoCompra);
            panel1.Controls.Add(cbListaPrecioCompra);
            panel1.Controls.Add(cbSocioCompra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbCodigoCompra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 0, 0, 0);
            panel1.Size = new Size(1773, 235);
            panel1.TabIndex = 21;
            // 
            // btnAdministrarProducto
            // 
            btnAdministrarProducto.BackColor = Color.FromArgb(192, 229, 200);
            btnAdministrarProducto.FlatStyle = FlatStyle.Popup;
            btnAdministrarProducto.Location = new Point(1404, 143);
            btnAdministrarProducto.Name = "btnAdministrarProducto";
            btnAdministrarProducto.Size = new Size(244, 33);
            btnAdministrarProducto.TabIndex = 24;
            btnAdministrarProducto.Text = "Administrar Productos";
            btnAdministrarProducto.UseVisualStyleBackColor = false;
            btnAdministrarProducto.Click += btnAdministrarProducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(1090, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 19;
            label6.Text = "Tipo de Pago";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1465, 43);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // cbEstadoCompra
            // 
            cbEstadoCompra.DropDownWidth = 152;
            cbEstadoCompra.Enabled = false;
            cbEstadoCompra.FormattingEnabled = true;
            cbEstadoCompra.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            cbEstadoCompra.Location = new Point(417, 43);
            cbEstadoCompra.Margin = new Padding(2);
            cbEstadoCompra.Name = "cbEstadoCompra";
            cbEstadoCompra.Size = new Size(183, 33);
            cbEstadoCompra.TabIndex = 23;
            // 
            // cbTipoPagoCompra
            // 
            cbTipoPagoCompra.DropDownWidth = 259;
            cbTipoPagoCompra.Enabled = false;
            cbTipoPagoCompra.FormattingEnabled = true;
            cbTipoPagoCompra.Items.AddRange(new object[] { "Contado", "Credito" });
            cbTipoPagoCompra.Location = new Point(1089, 162);
            cbTipoPagoCompra.Margin = new Padding(2);
            cbTipoPagoCompra.Name = "cbTipoPagoCompra";
            cbTipoPagoCompra.Size = new Size(183, 33);
            cbTipoPagoCompra.TabIndex = 20;
            // 
            // cbListaPrecioCompra
            // 
            cbListaPrecioCompra.DropDownWidth = 259;
            cbListaPrecioCompra.Enabled = false;
            cbListaPrecioCompra.FormattingEnabled = true;
            cbListaPrecioCompra.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            cbListaPrecioCompra.Location = new Point(654, 162);
            cbListaPrecioCompra.Margin = new Padding(2);
            cbListaPrecioCompra.Name = "cbListaPrecioCompra";
            cbListaPrecioCompra.Size = new Size(259, 33);
            cbListaPrecioCompra.TabIndex = 18;
            cbListaPrecioCompra.SelectionChangeCommitted += cbListaPrecioCompra_SelectionChangeCommitted;
            // 
            // cbSocioCompra
            // 
            cbSocioCompra.DropDownWidth = 374;
            cbSocioCompra.Enabled = false;
            cbSocioCompra.FormattingEnabled = true;
            cbSocioCompra.Location = new Point(103, 162);
            cbSocioCompra.Margin = new Padding(2);
            cbSocioCompra.Name = "cbSocioCompra";
            cbSocioCompra.Size = new Size(374, 33);
            cbSocioCompra.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(654, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 17;
            label5.Text = "Lista de Precios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(109, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 15;
            label4.Text = "Socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(1404, 45);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 19;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(346, 47);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 14;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(54, 48);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // tbCodigoCompra
            // 
            tbCodigoCompra.BackColor = SystemColors.Control;
            tbCodigoCompra.Location = new Point(134, 46);
            tbCodigoCompra.Margin = new Padding(2);
            tbCodigoCompra.Name = "tbCodigoCompra";
            tbCodigoCompra.ReadOnly = true;
            tbCodigoCompra.Size = new Size(152, 31);
            tbCodigoCompra.TabIndex = 12;
            tbCodigoCompra.TextChanged += tbCodigoCompra_TextChanged;
            // 
            // tablaCompraDetalle
            // 
            tablaCompraDetalle.AllowUserToDeleteRows = false;
            tablaCompraDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCompraDetalle.Columns.AddRange(new DataGridViewColumn[] { CompraID, CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, Subtotal, ImpuestoID, Total });
            tablaCompraDetalle.Dock = DockStyle.Top;
            tablaCompraDetalle.Location = new Point(0, 0);
            tablaCompraDetalle.Margin = new Padding(2);
            tablaCompraDetalle.Name = "tablaCompraDetalle";
            tablaCompraDetalle.ReadOnly = true;
            tablaCompraDetalle.RowHeadersWidth = 102;
            tablaCompraDetalle.Size = new Size(1773, 582);
            tablaCompraDetalle.TabIndex = 1;
            tablaCompraDetalle.CellContentClick += tablaCompraDetalle_CellContentClick;
            tablaCompraDetalle.CellEndEdit += tablaCompraDetalle_CellEndEdit;
            tablaCompraDetalle.CellValueChanged += tablaCompraDetalle_CellValueChanged;
            tablaCompraDetalle.DataError += tablaCompraDetalle_DataError;
            tablaCompraDetalle.EditingControlShowing += tablaCompraDetalle_EditingControlShowing;
            // 
            // CompraID
            // 
            CompraID.DataPropertyName = "CompraID";
            dataGridViewCellStyle1.NullValue = "0";
            CompraID.DefaultCellStyle = dataGridViewCellStyle1;
            CompraID.HeaderText = "ID";
            CompraID.MinimumWidth = 12;
            CompraID.Name = "CompraID";
            CompraID.ReadOnly = true;
            CompraID.Visible = false;
            CompraID.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            dataGridViewCellStyle2.NullValue = "PRO";
            CodigoProducto.DefaultCellStyle = dataGridViewCellStyle2;
            CodigoProducto.HeaderText = "Código";
            CodigoProducto.MinimumWidth = 12;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 250;
            // 
            // ProductoID
            // 
            ProductoID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductoID.DataPropertyName = "ProductoID";
            ProductoID.HeaderText = "Producto";
            ProductoID.MinimumWidth = 12;
            ProductoID.Name = "ProductoID";
            ProductoID.ReadOnly = true;
            ProductoID.Resizable = DataGridViewTriState.True;
            ProductoID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BodegaID
            // 
            BodegaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "Bodega";
            BodegaID.MinimumWidth = 12;
            BodegaID.Name = "BodegaID";
            BodegaID.ReadOnly = true;
            BodegaID.Resizable = DataGridViewTriState.True;
            BodegaID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 12;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 250;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 12;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 250;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle3.NullValue = "0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle3;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 12;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 250;
            // 
            // ImpuestoID
            // 
            ImpuestoID.DataPropertyName = "ImpuestoID";
            ImpuestoID.HeaderText = "Impuesto";
            ImpuestoID.MinimumWidth = 12;
            ImpuestoID.Name = "ImpuestoID";
            ImpuestoID.ReadOnly = true;
            ImpuestoID.Resizable = DataGridViewTriState.True;
            ImpuestoID.SortMode = DataGridViewColumnSortMode.Automatic;
            ImpuestoID.Width = 250;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(51, 148);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(129, 41);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.BackColor = SystemColors.Window;
            btnEditarCompra.Location = new Point(48, 43);
            btnEditarCompra.Margin = new Padding(2);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(131, 41);
            btnEditarCompra.TabIndex = 24;
            btnEditarCompra.Text = "Editar";
            btnEditarCompra.UseVisualStyleBackColor = false;
            btnEditarCompra.Click += btnEditar_Click;
            // 
            // btnAceptarCompra
            // 
            btnAceptarCompra.BackColor = Color.FromArgb(255, 222, 89);
            btnAceptarCompra.FlatStyle = FlatStyle.Popup;
            btnAceptarCompra.Location = new Point(1356, 148);
            btnAceptarCompra.Margin = new Padding(2);
            btnAceptarCompra.Name = "btnAceptarCompra";
            btnAceptarCompra.Size = new Size(131, 41);
            btnAceptarCompra.TabIndex = 23;
            btnAceptarCompra.Text = "Aceptar";
            btnAceptarCompra.UseVisualStyleBackColor = false;
            btnAceptarCompra.Visible = false;
            btnAceptarCompra.Click += btnAceptarCompra_Click;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.BackColor = SystemColors.Window;
            btnCancelarCompra.Location = new Point(1517, 148);
            btnCancelarCompra.Margin = new Padding(2);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(131, 41);
            btnCancelarCompra.TabIndex = 25;
            btnCancelarCompra.Text = "Cancelar";
            btnCancelarCompra.UseVisualStyleBackColor = false;
            btnCancelarCompra.Visible = false;
            btnCancelarCompra.Click += btnCancelarCompra_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaCompraDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 235);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1773, 582);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 48, 43);
            panel3.Controls.Add(tbTotal);
            panel3.Controls.Add(tbSubtotal);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnCancelarCompra);
            panel3.Controls.Add(btnAceptarCompra);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCrearRecibo);
            panel3.Controls.Add(btnEditarCompra);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 817);
            panel3.Name = "panel3";
            panel3.Size = new Size(1773, 228);
            panel3.TabIndex = 28;
            panel3.Paint += panel3_Paint;
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbTotal.Location = new Point(1497, 45);
            tbTotal.Margin = new Padding(1);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(153, 39);
            tbTotal.TabIndex = 31;
            // 
            // tbSubtotal
            // 
            tbSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbSubtotal.Location = new Point(1243, 45);
            tbSubtotal.Margin = new Padding(1);
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.Size = new Size(153, 39);
            tbSubtotal.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(1412, 47);
            label8.Name = "label8";
            label8.Size = new Size(70, 32);
            label8.TabIndex = 30;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(1118, 47);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 30;
            label7.Text = "Subtotal";
            // 
            // btnCrearRecibo
            // 
            btnCrearRecibo.BackColor = SystemColors.Window;
            btnCrearRecibo.Location = new Point(215, 43);
            btnCrearRecibo.Margin = new Padding(2);
            btnCrearRecibo.Name = "btnCrearRecibo";
            btnCrearRecibo.Size = new Size(131, 41);
            btnCrearRecibo.TabIndex = 28;
            btnCrearRecibo.Text = "Crear Recibo";
            btnCrearRecibo.UseVisualStyleBackColor = false;
            btnCrearRecibo.Click += btnCrearRecibo_Click;
            // 
            // CompraDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 1045);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompraDetalle";
            Text = "CompraDetalle";
            Load += CompraDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompraDetalle).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView tablaCompraDetalle;
        private TextBox tbCodigoCompra;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbListaPrecioCompra;
        private ComboBox cbSocioCompra;
        private ComboBox cbEstadoCompra;
        private ComboBox cbTipoPagoCompra;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button btnVolver;
        private Button btnEditarCompra;
        private Button btnAceptarCompra;
        private Button btnCancelarCompra;
        private Panel panel2;
        private Panel panel3;
        private TextBox tbSubtotal;
        private Label label8;
        private Label label7;
        private Button btnCrearRecibo;
        private TextBox tbTotal;
        private Button btnAdministrarProducto;
        private DataGridViewTextBoxColumn CompraID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewComboBoxColumn BodegaID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewComboBoxColumn ImpuestoID;
        private DataGridViewTextBoxColumn Total;
    }
}