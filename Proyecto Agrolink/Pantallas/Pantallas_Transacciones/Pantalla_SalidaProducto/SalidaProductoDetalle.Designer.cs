namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantalla_SalidaProducto
{
    partial class SalidaProductoDetalle
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelBodDest = new Label();
            comboBodDestino = new ComboBox();
            groupTipoOperacion = new GroupBox();
            radioTransfInterna = new RadioButton();
            radioSalidaVenta = new RadioButton();
            comboVenta = new ComboBox();
            labelVent = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbCodigo = new TextBox();
            label1 = new Label();
            labelSocio = new Label();
            comboSocio = new ComboBox();
            panel2 = new Panel();
            tablaDetalle = new DataGridView();
            SalidaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            panel3 = new Panel();
            btnBorrarSalProd = new Button();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            panel1.SuspendLayout();
            groupTipoOperacion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(labelBodDest);
            panel1.Controls.Add(comboBodDestino);
            panel1.Controls.Add(groupTipoOperacion);
            panel1.Controls.Add(comboVenta);
            panel1.Controls.Add(labelVent);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tbCodigo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelSocio);
            panel1.Controls.Add(comboSocio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 0, 0, 0);
            panel1.Size = new Size(1145, 235);
            panel1.TabIndex = 23;
            // 
            // labelBodDest
            // 
            labelBodDest.AutoSize = true;
            labelBodDest.ForeColor = SystemColors.Window;
            labelBodDest.Location = new Point(52, 130);
            labelBodDest.Margin = new Padding(1, 0, 1, 0);
            labelBodDest.Name = "labelBodDest";
            labelBodDest.Size = new Size(139, 25);
            labelBodDest.TabIndex = 33;
            labelBodDest.Text = "Bodega Destino";
            labelBodDest.Visible = false;
            // 
            // comboBodDestino
            // 
            comboBodDestino.Enabled = false;
            comboBodDestino.FormattingEnabled = true;
            comboBodDestino.Location = new Point(52, 172);
            comboBodDestino.Margin = new Padding(1);
            comboBodDestino.Name = "comboBodDestino";
            comboBodDestino.Size = new Size(374, 33);
            comboBodDestino.TabIndex = 34;
            comboBodDestino.Visible = false;
            // 
            // groupTipoOperacion
            // 
            groupTipoOperacion.Controls.Add(radioTransfInterna);
            groupTipoOperacion.Controls.Add(radioSalidaVenta);
            groupTipoOperacion.ForeColor = SystemColors.Window;
            groupTipoOperacion.Location = new Point(1102, 118);
            groupTipoOperacion.Margin = new Padding(2);
            groupTipoOperacion.Name = "groupTipoOperacion";
            groupTipoOperacion.Padding = new Padding(2);
            groupTipoOperacion.Size = new Size(540, 90);
            groupTipoOperacion.TabIndex = 32;
            groupTipoOperacion.TabStop = false;
            groupTipoOperacion.Text = "Tipo de Operación";
            // 
            // radioTransfInterna
            // 
            radioTransfInterna.AutoSize = true;
            radioTransfInterna.ForeColor = SystemColors.Window;
            radioTransfInterna.Location = new Point(332, 45);
            radioTransfInterna.Margin = new Padding(2);
            radioTransfInterna.Name = "radioTransfInterna";
            radioTransfInterna.Size = new Size(198, 29);
            radioTransfInterna.TabIndex = 1;
            radioTransfInterna.Text = "Transferencia Interna";
            radioTransfInterna.UseVisualStyleBackColor = true;
            radioTransfInterna.CheckedChanged += radioTransfInterna_CheckedChanged;
            // 
            // radioSalidaVenta
            // 
            radioSalidaVenta.AutoSize = true;
            radioSalidaVenta.Checked = true;
            radioSalidaVenta.ForeColor = SystemColors.Window;
            radioSalidaVenta.Location = new Point(21, 45);
            radioSalidaVenta.Margin = new Padding(2);
            radioSalidaVenta.Name = "radioSalidaVenta";
            radioSalidaVenta.Size = new Size(218, 29);
            radioSalidaVenta.TabIndex = 0;
            radioSalidaVenta.TabStop = true;
            radioSalidaVenta.Text = "Salida Basada en Venta";
            radioSalidaVenta.UseVisualStyleBackColor = true;
            // 
            // comboVenta
            // 
            comboVenta.Enabled = false;
            comboVenta.FormattingEnabled = true;
            comboVenta.Location = new Point(364, 47);
            comboVenta.Margin = new Padding(1);
            comboVenta.Name = "comboVenta";
            comboVenta.Size = new Size(153, 33);
            comboVenta.TabIndex = 31;
            comboVenta.SelectionChangeCommitted += comboVenta_SelectionChangeCommitted;
            // 
            // labelVent
            // 
            labelVent.AutoSize = true;
            labelVent.ForeColor = SystemColors.Window;
            labelVent.Location = new Point(304, 49);
            labelVent.Margin = new Padding(1, 0, 1, 0);
            labelVent.Name = "labelVent";
            labelVent.Size = new Size(56, 25);
            labelVent.TabIndex = 30;
            labelVent.Text = "Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(1401, 37);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1462, 36);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(106, 48);
            tbCodigo.Margin = new Padding(1);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(153, 31);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(38, 49);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // labelSocio
            // 
            labelSocio.AutoSize = true;
            labelSocio.ForeColor = SystemColors.Window;
            labelSocio.Location = new Point(52, 130);
            labelSocio.Margin = new Padding(1, 0, 1, 0);
            labelSocio.Name = "labelSocio";
            labelSocio.Size = new Size(56, 25);
            labelSocio.TabIndex = 15;
            labelSocio.Text = "Socio";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(52, 172);
            comboSocio.Margin = new Padding(1);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(374, 33);
            comboSocio.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 235);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 671);
            panel2.TabIndex = 24;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToDeleteRows = false;
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { SalidaID, CodigoProducto, ProductoID, Cantidad, BodegaID });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(1);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(1145, 671);
            tablaDetalle.TabIndex = 1;
            tablaDetalle.CellBeginEdit += tablaDetalle_CellBeginEdit;
            tablaDetalle.DataError += tablaDetalle_DataError;
            tablaDetalle.UserDeletedRow += tablaDetalle_UserDeletedRow;
            // 
            // SalidaID
            // 
            SalidaID.DataPropertyName = "SalidaID";
            dataGridViewCellStyle3.NullValue = "0";
            SalidaID.DefaultCellStyle = dataGridViewCellStyle3;
            SalidaID.HeaderText = "ID";
            SalidaID.MinimumWidth = 12;
            SalidaID.Name = "SalidaID";
            SalidaID.ReadOnly = true;
            SalidaID.Visible = false;
            SalidaID.Width = 250;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            dataGridViewCellStyle4.NullValue = "PRO";
            CodigoProducto.DefaultCellStyle = dataGridViewCellStyle4;
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
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 12;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 250;
            // 
            // BodegaID
            // 
            BodegaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "Bodega Origen";
            BodegaID.MinimumWidth = 12;
            BodegaID.Name = "BodegaID";
            BodegaID.ReadOnly = true;
            BodegaID.Resizable = DataGridViewTriState.True;
            BodegaID.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 48, 43);
            panel3.Controls.Add(btnBorrarSalProd);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 906);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1145, 0);
            panel3.TabIndex = 30;
            // 
            // btnBorrarSalProd
            // 
            btnBorrarSalProd.BackColor = SystemColors.Window;
            btnBorrarSalProd.Location = new Point(45, 58);
            btnBorrarSalProd.Margin = new Padding(2);
            btnBorrarSalProd.Name = "btnBorrarSalProd";
            btnBorrarSalProd.Size = new Size(232, 41);
            btnBorrarSalProd.TabIndex = 28;
            btnBorrarSalProd.Text = "Borrar Salida de Producto";
            btnBorrarSalProd.UseVisualStyleBackColor = false;
            btnBorrarSalProd.Visible = false;
            btnBorrarSalProd.Click += btnBorrarSalProd_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(45, 58);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(129, 41);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(1511, 58);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Window;
            btnEditar.Location = new Point(286, 58);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 41);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 222, 89);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(1353, 58);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 41);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // SalidaProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SalidaProductoDetalle";
            Text = "SalidaProductoDetalle";
            Load += SalidaProductoDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupTipoOperacion.ResumeLayout(false);
            groupTipoOperacion.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboVenta;
        private Label labelVent;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox tbCodigo;
        private Label label1;
        private Label labelSocio;
        private ComboBox comboSocio;
        private Panel panel2;
        private DataGridView tablaDetalle;
        private Panel panel3;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnAceptar;
        private GroupBox groupTipoOperacion;
        private RadioButton radioTransfInterna;
        private RadioButton radioSalidaVenta;
        private Label labelBodDest;
        private ComboBox comboBodDestino;
        private DataGridViewTextBoxColumn SalidaID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewComboBoxColumn BodegaID;
        private Button btnBorrarSalProd;
    }
}