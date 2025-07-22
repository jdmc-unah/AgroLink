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
            panel2 = new Panel();
            tablaDetalle = new DataGridView();
            VentaID = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewTextBoxColumn();
            NomImpuesto = new DataGridViewTextBoxColumn();
            BodegaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Bodega = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnNuevo = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            btnVolver = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            SuspendLayout();
            // 
            // comboTipoPago
            // 
            comboTipoPago.Enabled = false;
            comboTipoPago.FormattingEnabled = true;
            comboTipoPago.Items.AddRange(new object[] { "Contado", "Credito" });
            comboTipoPago.Location = new Point(1219, 162);
            comboTipoPago.Margin = new Padding(2, 2, 2, 2);
            comboTipoPago.Name = "comboTipoPago";
            comboTipoPago.Size = new Size(259, 33);
            comboTipoPago.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1225, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 19;
            label5.Text = "Tipo de Pago";
            // 
            // comboListaPrecio
            // 
            comboListaPrecio.Enabled = false;
            comboListaPrecio.FormattingEnabled = true;
            comboListaPrecio.Location = new Point(678, 162);
            comboListaPrecio.Margin = new Padding(2, 2, 2, 2);
            comboListaPrecio.Name = "comboListaPrecio";
            comboListaPrecio.Size = new Size(259, 33);
            comboListaPrecio.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(684, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 17;
            label4.Text = "Lista de Precios";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(106, 162);
            comboSocio.Margin = new Padding(2, 2, 2, 2);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(374, 33);
            comboSocio.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 15;
            label3.Text = "Socio";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(106, 40);
            tbCodigo.Margin = new Padding(2, 2, 2, 2);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(152, 31);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 13;
            label1.Text = "Código";
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 0, 0, 0);
            panel1.Size = new Size(1145, 235);
            panel1.TabIndex = 21;
            // 
            // comboEstado
            // 
            comboEstado.Enabled = false;
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            comboEstado.Location = new Point(371, 38);
            comboEstado.Margin = new Padding(2, 2, 2, 2);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(152, 33);
            comboEstado.TabIndex = 23;
            comboEstado.SelectedIndexChanged += comboEstado_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1338, 37);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1412, 35);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 235);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 604);
            panel2.TabIndex = 22;
            // 
            // tablaDetalle
            // 
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { VentaID, ProductoID, ImpuestoID, NomImpuesto, BodegaID, CodigoProducto, Producto, Bodega, Cantidad, Precio, Impuesto, Subtotal, Total });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(2, 2, 2, 2);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(1145, 604);
            tablaDetalle.TabIndex = 0;
            tablaDetalle.DataError += tablaDetalle_DataError;
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
            // ProductoID
            // 
            ProductoID.DataPropertyName = "ProductoID";
            ProductoID.HeaderText = "ProductoID";
            ProductoID.MinimumWidth = 12;
            ProductoID.Name = "ProductoID";
            ProductoID.ReadOnly = true;
            ProductoID.Visible = false;
            ProductoID.Width = 250;
            // 
            // ImpuestoID
            // 
            ImpuestoID.DataPropertyName = "ImpuestoID";
            ImpuestoID.HeaderText = "ImpuestoID";
            ImpuestoID.MinimumWidth = 12;
            ImpuestoID.Name = "ImpuestoID";
            ImpuestoID.ReadOnly = true;
            ImpuestoID.Visible = false;
            ImpuestoID.Width = 250;
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
            // BodegaID
            // 
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "BodegaID";
            BodegaID.MinimumWidth = 12;
            BodegaID.Name = "BodegaID";
            BodegaID.ReadOnly = true;
            BodegaID.Visible = false;
            BodegaID.Width = 250;
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
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 12;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Bodega
            // 
            Bodega.DataPropertyName = "Bodega";
            Bodega.HeaderText = "Bodega";
            Bodega.MinimumWidth = 12;
            Bodega.Name = "Bodega";
            Bodega.ReadOnly = true;
            Bodega.Width = 300;
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
            // Impuesto
            // 
            Impuesto.DataPropertyName = "Impuesto";
            Impuesto.HeaderText = "Impuesto";
            Impuesto.MinimumWidth = 12;
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            Impuesto.Width = 250;
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
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(326, 862);
            btnNuevo.Margin = new Padding(2, 2, 2, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(185, 35);
            btnNuevo.TabIndex = 26;
            btnNuevo.Text = "Crear Nueva Venta";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1432, 862);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 35);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(188, 862);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 35);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1291, 862);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 35);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(51, 862);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(109, 35);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // VentasDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(btnVolver);
            Controls.Add(btnNuevo);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(btnAceptar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "VentasDetalle";
            Text = "VentasDetalle";
            Load += VentasDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
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
        private Panel panel2;
        private DataGridView tablaDetalle;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnAceptar;
        private Button btnVolver;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn ProductoID;
        private DataGridViewTextBoxColumn ImpuestoID;
        private DataGridViewTextBoxColumn NomImpuesto;
        private DataGridViewTextBoxColumn BodegaID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Bodega;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Impuesto;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Total;
        private ComboBox comboEstado;
    }
}