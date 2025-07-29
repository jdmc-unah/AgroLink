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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel3 = new Panel();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            btnAceptar = new Button();
            SalidaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            BodegaID = new DataGridViewComboBoxColumn();
            panel1.SuspendLayout();
            groupTipoOperacion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 0, 0, 0);
            panel1.Size = new Size(2629, 385);
            panel1.TabIndex = 23;
            // 
            // labelBodDest
            // 
            labelBodDest.AutoSize = true;
            labelBodDest.Location = new Point(66, 211);
            labelBodDest.Margin = new Padding(2, 0, 2, 0);
            labelBodDest.Name = "labelBodDest";
            labelBodDest.Size = new Size(230, 41);
            labelBodDest.TabIndex = 33;
            labelBodDest.Text = "Bodega Destino";
            labelBodDest.Visible = false;
            // 
            // comboBodDestino
            // 
            comboBodDestino.Enabled = false;
            comboBodDestino.FormattingEnabled = true;
            comboBodDestino.Location = new Point(55, 279);
            comboBodDestino.Margin = new Padding(2);
            comboBodDestino.Name = "comboBodDestino";
            comboBodDestino.Size = new Size(633, 49);
            comboBodDestino.TabIndex = 34;
            comboBodDestino.Visible = false;
            // 
            // groupTipoOperacion
            // 
            groupTipoOperacion.Controls.Add(radioTransfInterna);
            groupTipoOperacion.Controls.Add(radioSalidaVenta);
            groupTipoOperacion.Location = new Point(1648, 211);
            groupTipoOperacion.Name = "groupTipoOperacion";
            groupTipoOperacion.Size = new Size(918, 147);
            groupTipoOperacion.TabIndex = 32;
            groupTipoOperacion.TabStop = false;
            groupTipoOperacion.Text = "Tipo de Operación";
            // 
            // radioTransfInterna
            // 
            radioTransfInterna.AutoSize = true;
            radioTransfInterna.Location = new Point(564, 73);
            radioTransfInterna.Name = "radioTransfInterna";
            radioTransfInterna.Size = new Size(328, 45);
            radioTransfInterna.TabIndex = 1;
            radioTransfInterna.Text = "Transferencia Interna";
            radioTransfInterna.UseVisualStyleBackColor = true;
            radioTransfInterna.CheckedChanged += radioTransfInterna_CheckedChanged;
            // 
            // radioSalidaVenta
            // 
            radioSalidaVenta.AutoSize = true;
            radioSalidaVenta.Checked = true;
            radioSalidaVenta.Location = new Point(36, 73);
            radioSalidaVenta.Name = "radioSalidaVenta";
            radioSalidaVenta.Size = new Size(358, 45);
            radioSalidaVenta.TabIndex = 0;
            radioSalidaVenta.TabStop = true;
            radioSalidaVenta.Text = "Salida Basada en Venta";
            radioSalidaVenta.UseVisualStyleBackColor = true;
            // 
            // comboVenta
            // 
            comboVenta.Enabled = false;
            comboVenta.FormattingEnabled = true;
            comboVenta.Location = new Point(618, 77);
            comboVenta.Margin = new Padding(2);
            comboVenta.Name = "comboVenta";
            comboVenta.Size = new Size(257, 49);
            comboVenta.TabIndex = 31;
            comboVenta.SelectionChangeCommitted += comboVenta_SelectionChangeCommitted;
            // 
            // labelVent
            // 
            labelVent.AutoSize = true;
            labelVent.Location = new Point(517, 81);
            labelVent.Margin = new Padding(2, 0, 2, 0);
            labelVent.Name = "labelVent";
            labelVent.Size = new Size(93, 41);
            labelVent.TabIndex = 30;
            labelVent.Text = "Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2157, 78);
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
            dateTimePicker1.Location = new Point(2261, 76);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 47);
            dateTimePicker1.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(181, 78);
            tbCodigo.Margin = new Padding(2);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(257, 47);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 41);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // labelSocio
            // 
            labelSocio.AutoSize = true;
            labelSocio.Location = new Point(66, 211);
            labelSocio.Margin = new Padding(2, 0, 2, 0);
            labelSocio.Name = "labelSocio";
            labelSocio.Size = new Size(91, 41);
            labelSocio.TabIndex = 15;
            labelSocio.Text = "Socio";
            // 
            // comboSocio
            // 
            comboSocio.Enabled = false;
            comboSocio.FormattingEnabled = true;
            comboSocio.Location = new Point(55, 279);
            comboSocio.Margin = new Padding(2);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(633, 49);
            comboSocio.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 385);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(2629, 947);
            panel2.TabIndex = 24;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToDeleteRows = false;
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { SalidaID, CodigoProducto, ProductoID, Cantidad, BodegaID });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(2);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(2629, 947);
            tablaDetalle.TabIndex = 1;
            tablaDetalle.DataError += tablaDetalle_DataError;
            tablaDetalle.UserDeletedRow += tablaDetalle_UserDeletedRow;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 1332);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2629, 358);
            panel3.TabIndex = 30;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(51, 86);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(219, 68);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(2284, 86);
            btnCancelar.Margin = new Padding(4);
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
            btnEditar.Location = new Point(325, 86);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(223, 68);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(2016, 86);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(223, 68);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // SalidaID
            // 
            SalidaID.DataPropertyName = "SalidaID";
            dataGridViewCellStyle1.NullValue = "0";
            SalidaID.DefaultCellStyle = dataGridViewCellStyle1;
            SalidaID.HeaderText = "ID";
            SalidaID.MinimumWidth = 12;
            SalidaID.Name = "SalidaID";
            SalidaID.ReadOnly = true;
            SalidaID.Width = 250;
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
            // SalidaProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2629, 1690);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}