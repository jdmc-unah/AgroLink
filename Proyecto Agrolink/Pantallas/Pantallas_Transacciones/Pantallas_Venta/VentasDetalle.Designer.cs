namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Venta
{
    partial class VentasDetalle
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            comboTipoPago = new ComboBox();
            label5 = new Label();
            comboListaPrecio = new ComboBox();
            label4 = new Label();
            comboSocio = new ComboBox();
            label3 = new Label();
            tbCodigo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            comboEstado = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            btnVolver = new Button();
            tablaDetalle = new DataGridView();
            VentaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            btnNuevaSalProd = new Button();
            tbTotal = new TextBox();
            label8 = new Label();
            tbSubtotal = new TextBox();
            label7 = new Label();
            btnCrearFact = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboTipoPago
            // 
            comboTipoPago.Enabled = false;
            comboTipoPago.FormattingEnabled = true;
            comboTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            comboTipoPago.Location = new Point(2352, 260);
            comboTipoPago.Margin = new Padding(4);
            comboTipoPago.Name = "comboTipoPago";
            comboTipoPago.Size = new Size(438, 49);
            comboTipoPago.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2119, 264);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 41);
            label5.TabIndex = 19;
            label5.Text = "Tipo de Pago";
            // 
            // comboListaPrecio
            // 
            comboListaPrecio.Enabled = false;
            comboListaPrecio.FormattingEnabled = true;
            comboListaPrecio.Location = new Point(1363, 260);
            comboListaPrecio.Margin = new Padding(4);
            comboListaPrecio.Name = "comboListaPrecio";
            comboListaPrecio.Size = new Size(438, 49);
            comboListaPrecio.TabIndex = 18;
            comboListaPrecio.SelectionChangeCommitted += comboListaPrecio_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1121, 264);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 41);
            label4.TabIndex = 17;
            label4.Text = "Lista de Precios";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(226, 255);
            comboSocio.Margin = new Padding(4);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(633, 49);
            comboSocio.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 259);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 41);
            label3.TabIndex = 15;
            label3.Text = "Socio";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(203, 67);
            tbCodigo.Margin = new Padding(4);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(257, 47);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 41);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 41);
            label2.TabIndex = 14;
            label2.Text = "Estado";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(comboTipoPago);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboListaPrecio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboSocio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 0, 0, 0);
            panel1.Size = new Size(2916, 385);
            panel1.TabIndex = 21;
            // 
            // comboEstado
            // 
            comboEstado.Enabled = false;
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            comboEstado.Location = new Point(651, 66);
            comboEstado.Margin = new Padding(4);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(257, 49);
            comboEstado.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2441, 82);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 41);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(2542, 79);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 47);
            dateTimePicker1.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(2623, 248);
            btnCancelar.Margin = new Padding(8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(223, 68);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(76, 81);
            btnEditar.Margin = new Padding(8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(223, 68);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(2352, 248);
            btnAceptar.Margin = new Padding(8);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(223, 68);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(76, 248);
            btnVolver.Margin = new Padding(8);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(219, 68);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToDeleteRows = false;
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { VentaID, CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, Subtotal, ImpuestoID, Total });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(4);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(2916, 953);
            tablaDetalle.TabIndex = 1;
            tablaDetalle.CellEndEdit += tablaDetalle_CellEndEdit;
            tablaDetalle.DataError += tablaDetalle_DataError;
            // 
            // VentaID
            // 
            VentaID.DataPropertyName = "VentaID";
            dataGridViewCellStyle1.NullValue = "0";
            VentaID.DefaultCellStyle = dataGridViewCellStyle1;
            VentaID.HeaderText = "VentaID";
            VentaID.MinimumWidth = 12;
            VentaID.Name = "VentaID";
            VentaID.ReadOnly = true;
            VentaID.Visible = false;
            VentaID.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            dataGridViewCellStyle2.NullValue = "PRO";
            CodigoProducto.DefaultCellStyle = dataGridViewCellStyle2;
            CodigoProducto.HeaderText = "Codigo";
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
            // 
            // BodegaID
            // 
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "Bodega";
            BodegaID.MinimumWidth = 12;
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
            dataGridViewCellStyle4.NullValue = "0";
            Total.DefaultCellStyle = dataGridViewCellStyle4;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 385);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2916, 953);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNuevaSalProd);
            panel3.Controls.Add(tbTotal);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(tbSubtotal);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnCrearFact);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 1338);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(2916, 374);
            panel3.TabIndex = 28;
            // 
            // btnNuevaSalProd
            // 
            btnNuevaSalProd.Location = new Point(694, 81);
            btnNuevaSalProd.Margin = new Padding(8);
            btnNuevaSalProd.Name = "btnNuevaSalProd";
            btnNuevaSalProd.Size = new Size(416, 68);
            btnNuevaSalProd.TabIndex = 34;
            btnNuevaSalProd.Text = "Crear Salida de Producto";
            btnNuevaSalProd.UseVisualStyleBackColor = true;
            btnNuevaSalProd.Click += btnNuevaSalProd_Click;
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbTotal.Location = new Point(2526, 85);
            tbTotal.Margin = new Padding(4);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(320, 61);
            tbTotal.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(2401, 88);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 54);
            label8.TabIndex = 32;
            label8.Text = "Total";
            // 
            // tbSubtotal
            // 
            tbSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbSubtotal.Location = new Point(2134, 85);
            tbSubtotal.Margin = new Padding(2);
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.ReadOnly = true;
            tbSubtotal.Size = new Size(257, 61);
            tbSubtotal.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(1941, 88);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(183, 54);
            label7.TabIndex = 30;
            label7.Text = "Subtotal";
            // 
            // btnCrearFact
            // 
            btnCrearFact.Location = new Point(368, 81);
            btnCrearFact.Margin = new Padding(8);
            btnCrearFact.Name = "btnCrearFact";
            btnCrearFact.Size = new Size(257, 68);
            btnCrearFact.TabIndex = 28;
            btnCrearFact.Text = "Crear Factura";
            btnCrearFact.UseVisualStyleBackColor = true;
            btnCrearFact.Click += btnCrearFact_Click;
            // 
            // VentasDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VentasDetalle";
            Text = "VentasDetalle";
            Load += VentasDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboTipoPago;
        private Label label5;
        private ComboBox comboListaPrecio;
        private Label label4;
        private ComboBox comboSocio;
        private Label label3;
        private TextBox tbCodigo;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnAceptar;
        private Button btnVolver;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboEstado;
        private DataGridView tablaDetalle;
        private Panel panel2;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewComboBoxColumn BodegaID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewComboBoxColumn ImpuestoID;
        private DataGridViewTextBoxColumn Total;
        private Panel panel3;
        private Button btnCrearFact;
        private TextBox tbSubtotal;
        private Label label7;
        private TextBox tbTotal;
        private Label label8;
        private Button btnNuevaSalProd;
    }
}