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
            panel1 = new Panel();
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
            PrecioUnitario = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnVolver = new Button();
            btnEditarCompra = new Button();
            btnAceptarCompra = new Button();
            btnCancelarCompra = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompraDetalle).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Size = new Size(1584, 235);
            panel1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1225, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 19;
            label6.Text = "Tipo de Pago";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1412, 35);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // cbEstadoCompra
            // 
            cbEstadoCompra.DropDownWidth = 152;
            cbEstadoCompra.Enabled = false;
            cbEstadoCompra.FormattingEnabled = true;
            cbEstadoCompra.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            cbEstadoCompra.Location = new Point(371, 38);
            cbEstadoCompra.Margin = new Padding(2);
            cbEstadoCompra.Name = "cbEstadoCompra";
            cbEstadoCompra.Size = new Size(152, 33);
            cbEstadoCompra.TabIndex = 23;
            // 
            // cbTipoPagoCompra
            // 
            cbTipoPagoCompra.DropDownWidth = 259;
            cbTipoPagoCompra.Enabled = false;
            cbTipoPagoCompra.FormattingEnabled = true;
            cbTipoPagoCompra.Items.AddRange(new object[] { "Contado", "Credito" });
            cbTipoPagoCompra.Location = new Point(1219, 162);
            cbTipoPagoCompra.Margin = new Padding(2);
            cbTipoPagoCompra.Name = "cbTipoPagoCompra";
            cbTipoPagoCompra.Size = new Size(259, 33);
            cbTipoPagoCompra.TabIndex = 20;
            // 
            // cbListaPrecioCompra
            // 
            cbListaPrecioCompra.DropDownWidth = 259;
            cbListaPrecioCompra.Enabled = false;
            cbListaPrecioCompra.FormattingEnabled = true;
            cbListaPrecioCompra.Location = new Point(678, 162);
            cbListaPrecioCompra.Margin = new Padding(2);
            cbListaPrecioCompra.Name = "cbListaPrecioCompra";
            cbListaPrecioCompra.Size = new Size(259, 33);
            cbListaPrecioCompra.TabIndex = 18;
            // 
            // cbSocioCompra
            // 
            cbSocioCompra.DropDownWidth = 374;
            cbSocioCompra.Enabled = false;
            cbSocioCompra.FormattingEnabled = true;
            cbSocioCompra.Location = new Point(106, 162);
            cbSocioCompra.Margin = new Padding(2);
            cbSocioCompra.Name = "cbSocioCompra";
            cbSocioCompra.Size = new Size(374, 33);
            cbSocioCompra.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(684, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 17;
            label5.Text = "Lista de Precios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 15;
            label4.Text = "Socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1338, 37);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 22;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 14;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // tbCodigoCompra
            // 
            tbCodigoCompra.BackColor = SystemColors.Control;
            tbCodigoCompra.Location = new Point(106, 40);
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
            tablaCompraDetalle.Columns.AddRange(new DataGridViewColumn[] { CompraID, CodigoProducto, ProductoID, BodegaID, Cantidad, PrecioUnitario, ImpuestoID, Total });
            tablaCompraDetalle.Dock = DockStyle.Fill;
            tablaCompraDetalle.Location = new Point(0, 0);
            tablaCompraDetalle.Margin = new Padding(2);
            tablaCompraDetalle.Name = "tablaCompraDetalle";
            tablaCompraDetalle.ReadOnly = true;
            tablaCompraDetalle.RowHeadersWidth = 102;
            tablaCompraDetalle.Size = new Size(1584, 582);
            tablaCompraDetalle.TabIndex = 1;
            tablaCompraDetalle.CellContentClick += tablaCompraDetalle_CellContentClick;
            tablaCompraDetalle.CellEndEdit += tablaCompraDetalle_CellEndEdit;
            tablaCompraDetalle.DataError += tablaCompraDetalle_DataError;
            // 
            // CompraID
            // 
            CompraID.HeaderText = "CompraID";
            CompraID.MinimumWidth = 8;
            CompraID.Name = "CompraID";
            CompraID.ReadOnly = true;
            CompraID.Visible = false;
            CompraID.Width = 150;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            CodigoProducto.HeaderText = "Codigo";
            CodigoProducto.MinimumWidth = 8;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 250;
            // 
            // ProductoID
            // 
            ProductoID.DataPropertyName = "ProductoID";
            ProductoID.HeaderText = "Producto";
            ProductoID.MinimumWidth = 8;
            ProductoID.Name = "ProductoID";
            ProductoID.ReadOnly = true;
            ProductoID.Resizable = DataGridViewTriState.True;
            ProductoID.SortMode = DataGridViewColumnSortMode.Automatic;
            ProductoID.Width = 150;
            // 
            // BodegaID
            // 
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "Bodega";
            BodegaID.MinimumWidth = 8;
            BodegaID.Name = "BodegaID";
            BodegaID.ReadOnly = true;
            BodegaID.Resizable = DataGridViewTriState.True;
            BodegaID.SortMode = DataGridViewColumnSortMode.Automatic;
            BodegaID.Width = 250;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 250;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.DataPropertyName = "Precio";
            PrecioUnitario.HeaderText = "Precio";
            PrecioUnitario.MinimumWidth = 8;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.ReadOnly = true;
            PrecioUnitario.Width = 250;
            // 
            // ImpuestoID
            // 
            ImpuestoID.DataPropertyName = "ImpuestoID";
            ImpuestoID.HeaderText = "Impuesto";
            ImpuestoID.MinimumWidth = 8;
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
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(35, 845);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(128, 41);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.Location = new Point(186, 845);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(132, 41);
            btnEditarCompra.TabIndex = 24;
            btnEditarCompra.Text = "Editar";
            btnEditarCompra.UseVisualStyleBackColor = true;
            btnEditarCompra.Click += btnEditar_Click;
            // 
            // btnAceptarCompra
            // 
            btnAceptarCompra.Location = new Point(1290, 845);
            btnAceptarCompra.Name = "btnAceptarCompra";
            btnAceptarCompra.Size = new Size(132, 41);
            btnAceptarCompra.TabIndex = 23;
            btnAceptarCompra.Text = "Aceptar";
            btnAceptarCompra.UseVisualStyleBackColor = true;
            btnAceptarCompra.Visible = false;
            btnAceptarCompra.Click += btnAceptarCompra_Click;
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Location = new Point(1434, 845);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(132, 41);
            btnCancelarCompra.TabIndex = 25;
            btnCancelarCompra.Text = "Cancelar";
            btnCancelarCompra.UseVisualStyleBackColor = true;
            btnCancelarCompra.Click += btnCancelarCompra_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaCompraDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 235);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1584, 582);
            panel2.TabIndex = 22;
            // 
            // CompraDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 994);
            Controls.Add(panel2);
            Controls.Add(btnCancelarCompra);
            Controls.Add(btnAceptarCompra);
            Controls.Add(btnEditarCompra);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CompraDetalle";
            Text = "CompraDetalle";
            Load += CompraDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompraDetalle).EndInit();
            panel2.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn CompraID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewComboBoxColumn BodegaID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewComboBoxColumn ImpuestoID;
        private DataGridViewTextBoxColumn Total;
        private Panel panel2;
    }
}