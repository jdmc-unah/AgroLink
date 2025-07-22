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
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            btnVolver = new Button();
            tablaDetalle = new DataGridView();
            VentaID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            NomImpuesto = new DataGridViewTextBoxColumn();
            Bodega = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboTipoPago
            // 
            comboTipoPago.Enabled = false;
            comboTipoPago.FormattingEnabled = true;
            comboTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            comboTipoPago.Location = new Point(2072, 266);
            comboTipoPago.Name = "comboTipoPago";
            comboTipoPago.Size = new Size(438, 49);
            comboTipoPago.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2082, 200);
            label5.Name = "label5";
            label5.Size = new Size(194, 41);
            label5.TabIndex = 19;
            label5.Text = "Tipo de Pago";
            // 
            // comboListaPrecio
            // 
            comboListaPrecio.Enabled = false;
            comboListaPrecio.FormattingEnabled = true;
            comboListaPrecio.Location = new Point(1153, 265);
            comboListaPrecio.Name = "comboListaPrecio";
            comboListaPrecio.Size = new Size(438, 49);
            comboListaPrecio.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1163, 200);
            label4.Name = "label4";
            label4.Size = new Size(222, 41);
            label4.TabIndex = 17;
            label4.Text = "Lista de Precios";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(180, 266);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(633, 49);
            comboSocio.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 200);
            label3.Name = "label3";
            label3.Size = new Size(91, 41);
            label3.TabIndex = 15;
            label3.Text = "Socio";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(180, 66);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(256, 47);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 69);
            label1.Name = "label1";
            label1.Size = new Size(116, 41);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 66);
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
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 0, 0);
            panel1.Size = new Size(2768, 385);
            panel1.TabIndex = 21;
            // 
            // comboEstado
            // 
            comboEstado.Enabled = false;
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            comboEstado.Location = new Point(631, 62);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(256, 49);
            comboEstado.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2275, 61);
            label6.Name = "label6";
            label6.Size = new Size(95, 41);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(2400, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 47);
            dateTimePicker1.TabIndex = 21;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(580, 1396);
            btnNuevo.Margin = new Padding(5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(356, 67);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Crear Nueva Venta";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(2438, 1396);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(224, 67);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(317, 1396);
            btnEditar.Margin = new Padding(5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(224, 67);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(2193, 1396);
            btnAceptar.Margin = new Padding(5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(224, 67);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(60, 1396);
            btnVolver.Margin = new Padding(5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(218, 67);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // tablaDetalle
            // 
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { VentaID, Producto, NomImpuesto, Bodega, Impuesto, CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, Subtotal, ImpuestoID, Total });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(2768, 955);
            tablaDetalle.TabIndex = 1;
            // 
            // VentaID
            // 
            VentaID.DataPropertyName = "VentaID";
            VentaID.HeaderText = "VentaID";
            VentaID.MinimumWidth = 12;
            VentaID.Name = "VentaID";
            VentaID.ReadOnly = true;
            VentaID.Visible = false;
            VentaID.Width = 250;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "NomProducto";
            Producto.MinimumWidth = 12;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Visible = false;
            Producto.Width = 250;
            // 
            // NomImpuesto
            // 
            NomImpuesto.DataPropertyName = "NomImpuesto";
            NomImpuesto.HeaderText = "NomImpuesto";
            NomImpuesto.MinimumWidth = 12;
            NomImpuesto.Name = "NomImpuesto";
            NomImpuesto.ReadOnly = true;
            NomImpuesto.Visible = false;
            NomImpuesto.Width = 250;
            // 
            // Bodega
            // 
            Bodega.DataPropertyName = "Bodega";
            Bodega.HeaderText = "NomBodega";
            Bodega.MinimumWidth = 12;
            Bodega.Name = "Bodega";
            Bodega.ReadOnly = true;
            Bodega.Visible = false;
            Bodega.Width = 250;
            // 
            // Impuesto
            // 
            Impuesto.DataPropertyName = "Impuesto";
            Impuesto.HeaderText = "Impuesto";
            Impuesto.MinimumWidth = 12;
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            Impuesto.Visible = false;
            Impuesto.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
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
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(2768, 955);
            panel2.TabIndex = 22;
            // 
            // VentasDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2768, 1512);
            Controls.Add(btnVolver);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnAceptar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentasDetalle";
            Text = "VentasDetalle";
            Load += VentasDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            panel2.ResumeLayout(false);
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
        private Button btnNuevo;
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
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn NomImpuesto;
        private DataGridViewTextBoxColumn Bodega;
        private DataGridViewTextBoxColumn Impuesto;
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