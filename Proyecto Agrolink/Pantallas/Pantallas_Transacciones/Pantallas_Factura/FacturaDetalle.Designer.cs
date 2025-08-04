namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura
{
    partial class FacturaDetalle
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboNumFiscalID = new ComboBox();
            label10 = new Label();
            comboVenta = new ComboBox();
            label8 = new Label();
            comboEmpleado = new ComboBox();
            label9 = new Label();
            tbCAI = new TextBox();
            label7 = new Label();
            comboEstado = new ComboBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbCodigo = new TextBox();
            comboMetodoPago = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            comboListaPrecio = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboSocio = new ComboBox();
            panel2 = new Panel();
            tablaDetalle = new DataGridView();
            FacturaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnNuevaSalProd = new Button();
            tbSubtotal = new TextBox();
            label12 = new Label();
            tbTotal = new TextBox();
            label11 = new Label();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboNumFiscalID);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboVenta);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboEmpleado);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbCAI);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboEstado);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(comboMetodoPago);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboListaPrecio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboSocio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 0, 0);
            panel1.Size = new Size(2916, 385);
            panel1.TabIndex = 22;
            // 
            // comboNumFiscalID
            // 
            comboNumFiscalID.Enabled = false;
            comboNumFiscalID.FormattingEnabled = true;
            comboNumFiscalID.Location = new Point(1962, 71);
            comboNumFiscalID.Margin = new Padding(2, 2, 2, 2);
            comboNumFiscalID.Name = "comboNumFiscalID";
            comboNumFiscalID.Size = new Size(147, 49);
            comboNumFiscalID.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1989, 25);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 41);
            label10.TabIndex = 32;
            label10.Text = "Serie ";
            // 
            // comboVenta
            // 
            comboVenta.Enabled = false;
            comboVenta.FormattingEnabled = true;
            comboVenta.Location = new Point(1096, 74);
            comboVenta.Margin = new Padding(2, 2, 2, 2);
            comboVenta.Name = "comboVenta";
            comboVenta.Size = new Size(257, 49);
            comboVenta.TabIndex = 31;
            comboVenta.SelectionChangeCommitted += comboVenta_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(984, 79);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 41);
            label8.TabIndex = 30;
            label8.Text = "Venta";
            // 
            // comboEmpleado
            // 
            comboEmpleado.Enabled = false;
            comboEmpleado.FormattingEnabled = true;
            comboEmpleado.Location = new Point(2285, 277);
            comboEmpleado.Margin = new Padding(2, 2, 2, 2);
            comboEmpleado.Name = "comboEmpleado";
            comboEmpleado.Size = new Size(438, 49);
            comboEmpleado.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2287, 210);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(151, 41);
            label9.TabIndex = 28;
            label9.Text = "Empleado";
            // 
            // tbCAI
            // 
            tbCAI.Location = new Point(1513, 72);
            tbCAI.Margin = new Padding(2, 2, 2, 2);
            tbCAI.Name = "tbCAI";
            tbCAI.ReadOnly = true;
            tbCAI.Size = new Size(443, 47);
            tbCAI.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1421, 74);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 41);
            label7.TabIndex = 25;
            label7.Text = "CAI";
            // 
            // comboEstado
            // 
            comboEstado.Enabled = false;
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            comboEstado.Location = new Point(626, 74);
            comboEstado.Margin = new Padding(2, 2, 2, 2);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(257, 49);
            comboEstado.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2373, 75);
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
            dateTimePicker1.Location = new Point(2486, 72);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 47);
            dateTimePicker1.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(180, 79);
            tbCodigo.Margin = new Padding(2, 2, 2, 2);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(257, 47);
            tbCodigo.TabIndex = 12;
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.Enabled = false;
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Cheque" });
            comboMetodoPago.Location = new Point(1631, 277);
            comboMetodoPago.Margin = new Padding(2, 2, 2, 2);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(438, 49);
            comboMetodoPago.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1631, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(242, 41);
            label5.TabIndex = 19;
            label5.Text = "Metodo de Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 41);
            label2.TabIndex = 14;
            label2.Text = "Estado";
            // 
            // comboListaPrecio
            // 
            comboListaPrecio.Enabled = false;
            comboListaPrecio.FormattingEnabled = true;
            comboListaPrecio.Location = new Point(977, 277);
            comboListaPrecio.Margin = new Padding(2, 2, 2, 2);
            comboListaPrecio.Name = "comboListaPrecio";
            comboListaPrecio.Size = new Size(438, 49);
            comboListaPrecio.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 41);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(977, 222);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 41);
            label4.TabIndex = 17;
            label4.Text = "Lista de Precios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 222);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 41);
            label3.TabIndex = 15;
            label3.Text = "Socio";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(128, 277);
            comboSocio.Margin = new Padding(2, 2, 2, 2);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(633, 49);
            comboSocio.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 385);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(2916, 998);
            panel2.TabIndex = 23;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToDeleteRows = false;
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { FacturaID, CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, Subtotal, ImpuestoID, Total });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(2, 2, 2, 2);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(2916, 998);
            tablaDetalle.TabIndex = 1;
            tablaDetalle.CellEndEdit += tablaDetalle_CellEndEdit;
            tablaDetalle.DataError += tablaDetalle_DataError;
            tablaDetalle.UserDeletedRow += tablaDetalle_UserDeletedRow;
            // 
            // FacturaID
            // 
            FacturaID.DataPropertyName = "FacturaID";
            FacturaID.HeaderText = "ID";
            FacturaID.MinimumWidth = 12;
            FacturaID.Name = "FacturaID";
            FacturaID.ReadOnly = true;
            FacturaID.Visible = false;
            FacturaID.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            dataGridViewCellStyle10.NullValue = "PRO";
            CodigoProducto.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.NullValue = "0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.NullValue = "0";
            Total.DefaultCellStyle = dataGridViewCellStyle12;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNuevaSalProd);
            panel3.Controls.Add(tbSubtotal);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(tbTotal);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 1383);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2916, 329);
            panel3.TabIndex = 29;
            // 
            // btnNuevaSalProd
            // 
            btnNuevaSalProd.Location = new Point(306, 76);
            btnNuevaSalProd.Name = "btnNuevaSalProd";
            btnNuevaSalProd.Size = new Size(371, 67);
            btnNuevaSalProd.TabIndex = 32;
            btnNuevaSalProd.Text = "Crear Salida de Producto";
            btnNuevaSalProd.UseVisualStyleBackColor = true;
            btnNuevaSalProd.Click += btnNuevaSalProd_Click;
            // 
            // tbSubtotal
            // 
            tbSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbSubtotal.Location = new Point(2139, 79);
            tbSubtotal.Margin = new Padding(2, 2, 2, 2);
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.ReadOnly = true;
            tbSubtotal.Size = new Size(257, 61);
            tbSubtotal.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(1937, 82);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(183, 54);
            label12.TabIndex = 31;
            label12.Text = "Subtotal";
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbTotal.Location = new Point(2549, 79);
            tbTotal.Margin = new Padding(2, 2, 2, 2);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(257, 61);
            tbTotal.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(2415, 82);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(115, 54);
            label11.TabIndex = 29;
            label11.Text = "Total";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(50, 213);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(219, 67);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(2584, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(223, 67);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(50, 76);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(223, 67);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(2317, 213);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(223, 67);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FacturaDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FacturaDetalle";
            Text = "FacturaDetalle";
            Load += FacturaDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboEstado;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox tbCodigo;
        private ComboBox comboMetodoPago;
        private Label label5;
        private Label label2;
        private ComboBox comboListaPrecio;
        private Label label1;
        private Label label4;
        private Label label3;
        private ComboBox comboSocio;
        private Panel panel2;
        private DataGridView tablaDetalle;
        private Panel panel3;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnAceptar;
        private TextBox tbCAI;
        private Label label7;
        private ComboBox comboEmpleado;
        private Label label9;
        private DataGridViewTextBoxColumn FacturaID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewComboBoxColumn BodegaID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewComboBoxColumn ImpuestoID;
        private DataGridViewTextBoxColumn Total;
        private ComboBox comboVenta;
        private Label label8;
        private ComboBox comboNumFiscalID;
        private Label label10;
        private TextBox tbSubtotal;
        private Label label12;
        private TextBox tbTotal;
        private Label label11;
        private Button btnNuevaSalProd;
    }
}