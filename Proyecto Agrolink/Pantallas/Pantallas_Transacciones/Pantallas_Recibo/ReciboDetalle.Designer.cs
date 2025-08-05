namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Recibo
{
    partial class ReciboDetalle
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
            tbCodigo = new TextBox();
            cbEmpleado = new ComboBox();
            cbMetodoPago = new ComboBox();
            cbListaPrecio = new ComboBox();
            cbCompra = new ComboBox();
            cbEstado = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            cbSocio = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tablaReciboDetalle = new DataGridView();
            ReciboID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            ImpuestoID = new DataGridViewComboBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            tbTotal = new TextBox();
            tbSubtotal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            btnEditar = new Button();
            btnVolver = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaReciboDetalle).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(cbEmpleado);
            panel1.Controls.Add(cbMetodoPago);
            panel1.Controls.Add(cbListaPrecio);
            panel1.Controls.Add(cbCompra);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbSocio);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 0, 0, 0);
            panel1.Size = new Size(1145, 235);
            panel1.TabIndex = 0;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(106, 48);
            tbCodigo.Margin = new Padding(1, 1, 1, 1);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(153, 31);
            tbCodigo.TabIndex = 12;
            // 
            // cbEmpleado
            // 
            cbEmpleado.Enabled = false;
            cbEmpleado.FormattingEnabled = true;
            cbEmpleado.Location = new Point(1333, 169);
            cbEmpleado.Margin = new Padding(1, 1, 1, 1);
            cbEmpleado.Name = "cbEmpleado";
            cbEmpleado.Size = new Size(259, 33);
            cbEmpleado.TabIndex = 29;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.Enabled = false;
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Cheque" });
            cbMetodoPago.Location = new Point(962, 169);
            cbMetodoPago.Margin = new Padding(1, 1, 1, 1);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(259, 33);
            cbMetodoPago.TabIndex = 20;
            // 
            // cbListaPrecio
            // 
            cbListaPrecio.Enabled = false;
            cbListaPrecio.FormattingEnabled = true;
            cbListaPrecio.Location = new Point(591, 169);
            cbListaPrecio.Margin = new Padding(1, 1, 1, 1);
            cbListaPrecio.Name = "cbListaPrecio";
            cbListaPrecio.Size = new Size(259, 33);
            cbListaPrecio.TabIndex = 18;
            // 
            // cbCompra
            // 
            cbCompra.DropDownWidth = 153;
            cbCompra.Enabled = false;
            cbCompra.FormattingEnabled = true;
            cbCompra.Location = new Point(658, 45);
            cbCompra.Margin = new Padding(1, 1, 1, 1);
            cbCompra.Name = "cbCompra";
            cbCompra.Size = new Size(153, 33);
            cbCompra.TabIndex = 31;
            cbCompra.SelectionChangeCommitted += cbCompra_SelectionChangeCommitted;
            // 
            // cbEstado
            // 
            cbEstado.Enabled = false;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Cancelado" });
            cbEstado.Location = new Point(368, 45);
            cbEstado.Margin = new Padding(1, 1, 1, 1);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(153, 33);
            cbEstado.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1471, 46);
            dateTimePicker1.Margin = new Padding(1, 1, 1, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // cbSocio
            // 
            cbSocio.Enabled = false;
            cbSocio.FormattingEnabled = true;
            cbSocio.Location = new Point(108, 169);
            cbSocio.Margin = new Padding(1, 1, 1, 1);
            cbSocio.Name = "cbSocio";
            cbSocio.Size = new Size(374, 33);
            cbSocio.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(1333, 128);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 28;
            label8.Text = "Empleado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(962, 128);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(146, 25);
            label7.TabIndex = 19;
            label7.Text = "Metodo de Pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(591, 128);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 17;
            label6.Text = "Lista de Precios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(108, 138);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 15;
            label5.Text = "Socio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(1402, 48);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 22;
            label4.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(579, 48);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 30;
            label3.Text = "Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(301, 49);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(36, 49);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaReciboDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 235);
            panel2.Margin = new Padding(1, 1, 1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 613);
            panel2.TabIndex = 23;
            // 
            // tablaReciboDetalle
            // 
            tablaReciboDetalle.AllowUserToDeleteRows = false;
            tablaReciboDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaReciboDetalle.Columns.AddRange(new DataGridViewColumn[] { ReciboID, CodigoProducto, ProductoID, BodegaID, Cantidad, Precio, Subtotal, ImpuestoID, Total });
            tablaReciboDetalle.Dock = DockStyle.Fill;
            tablaReciboDetalle.Location = new Point(0, 0);
            tablaReciboDetalle.Name = "tablaReciboDetalle";
            tablaReciboDetalle.RowHeadersWidth = 62;
            tablaReciboDetalle.Size = new Size(1145, 613);
            tablaReciboDetalle.TabIndex = 0;
            tablaReciboDetalle.CellEndEdit += tablaReciboDetalle_CellEndEdit;
            tablaReciboDetalle.DataError += tablaReciboDetalle_DataError;
            tablaReciboDetalle.DefaultValuesNeeded += tablaReciboDetalle_DefaultValuesNeeded;
            tablaReciboDetalle.UserDeletedRow += tablaReciboDetalle_UserDeletedRow;
            // 
            // ReciboID
            // 
            ReciboID.DataPropertyName = "ReciboID";
            ReciboID.HeaderText = "ID";
            ReciboID.MinimumWidth = 12;
            ReciboID.Name = "ReciboID";
            ReciboID.Visible = false;
            ReciboID.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            dataGridViewCellStyle1.NullValue = "PRO";
            CodigoProducto.DefaultCellStyle = dataGridViewCellStyle1;
            CodigoProducto.HeaderText = "Código";
            CodigoProducto.MinimumWidth = 12;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.Width = 250;
            // 
            // ProductoID
            // 
            ProductoID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductoID.DataPropertyName = "ProductoID";
            ProductoID.HeaderText = "Producto";
            ProductoID.MinimumWidth = 12;
            ProductoID.Name = "ProductoID";
            // 
            // BodegaID
            // 
            BodegaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "Bodega";
            BodegaID.MinimumWidth = 12;
            BodegaID.Name = "BodegaID";
            BodegaID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 12;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 250;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 12;
            Precio.Name = "Precio";
            Precio.Width = 250;
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle2.NullValue = "0";
            Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 12;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 250;
            // 
            // ImpuestoID
            // 
            ImpuestoID.DataPropertyName = "ImpuestoID";
            ImpuestoID.HeaderText = "Impuesto";
            ImpuestoID.MinimumWidth = 12;
            ImpuestoID.Name = "ImpuestoID";
            ImpuestoID.Resizable = DataGridViewTriState.True;
            ImpuestoID.SortMode = DataGridViewColumnSortMode.Automatic;
            ImpuestoID.Width = 250;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            dataGridViewCellStyle3.NullValue = "0";
            Total.DefaultCellStyle = dataGridViewCellStyle3;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.Width = 250;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 48, 43);
            panel3.Controls.Add(tbTotal);
            panel3.Controls.Add(tbSubtotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnAceptar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnVolver);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 848);
            panel3.Name = "panel3";
            panel3.Size = new Size(1145, 0);
            panel3.TabIndex = 29;
            // 
            // tbTotal
            // 
            tbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbTotal.Location = new Point(1506, 40);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(150, 39);
            tbTotal.TabIndex = 33;
            // 
            // tbSubtotal
            // 
            tbSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbSubtotal.Location = new Point(1273, 40);
            tbSubtotal.Margin = new Padding(1, 1, 1, 1);
            tbSubtotal.Name = "tbSubtotal";
            tbSubtotal.ReadOnly = true;
            tbSubtotal.Size = new Size(153, 39);
            tbSubtotal.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(1431, 42);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 32);
            label10.TabIndex = 29;
            label10.Text = "Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(1158, 42);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(110, 32);
            label9.TabIndex = 31;
            label9.Text = "Subtotal";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(1523, 123);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 222, 89);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(1368, 123);
            btnAceptar.Margin = new Padding(2, 2, 2, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 41);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Window;
            btnEditar.Location = new Point(32, 38);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 41);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(35, 116);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(129, 41);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ReciboDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReciboDetalle";
            Text = "ReciboDetalle";
            Load += ReciboDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaReciboDetalle).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private ComboBox cbSocio;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbListaPrecio;
        private ComboBox cbCompra;
        private ComboBox cbEstado;
        private ComboBox cbEmpleado;
        private ComboBox cbMetodoPago;
        private Button btnCancelar;
        private Button btnAceptar;
        private Button btnEditar;
        private Button btnVolver;
        private Label label10;
        private Label label9;
        private DataGridView tablaReciboDetalle;
        private TextBox tbTotal;
        private TextBox tbSubtotal;
        private TextBox tbCodigo;
        private DataGridViewTextBoxColumn ReciboID;
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