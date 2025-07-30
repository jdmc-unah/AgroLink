namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Entrega
{
    partial class EntregaDetalle
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
            label7 = new Label();
            tbColonia = new TextBox();
            tbDetalle = new RichTextBox();
            label2 = new Label();
            label5 = new Label();
            comboRepartidor = new ComboBox();
            comboDep = new ComboBox();
            comboSalida = new ComboBox();
            label4 = new Label();
            labelVent = new Label();
            comboMuni = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbCodigo = new TextBox();
            label1 = new Label();
            labelSocio = new Label();
            comboSocio = new ComboBox();
            panel2 = new Panel();
            tablaDetalle = new DataGridView();
            EntregaID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            ProductoID = new DataGridViewComboBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnBorrarEntr = new Button();
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbColonia);
            panel1.Controls.Add(tbDetalle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboRepartidor);
            panel1.Controls.Add(comboDep);
            panel1.Controls.Add(comboSalida);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelVent);
            panel1.Controls.Add(comboMuni);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
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
            panel1.Size = new Size(2597, 505);
            panel1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2215, 225);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 41);
            label7.TabIndex = 40;
            label7.Text = "Detalle";
            // 
            // tbColonia
            // 
            tbColonia.Location = new Point(1697, 408);
            tbColonia.Name = "tbColonia";
            tbColonia.ReadOnly = true;
            tbColonia.Size = new Size(421, 47);
            tbColonia.TabIndex = 41;
            // 
            // tbDetalle
            // 
            tbDetalle.Location = new Point(2215, 281);
            tbDetalle.Name = "tbDetalle";
            tbDetalle.ReadOnly = true;
            tbDetalle.Size = new Size(491, 171);
            tbDetalle.TabIndex = 39;
            tbDetalle.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 340);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 32;
            label2.Text = "Repartidor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1448, 411);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 41);
            label5.TabIndex = 38;
            label5.Text = "Colonia";
            // 
            // comboRepartidor
            // 
            comboRepartidor.Enabled = false;
            comboRepartidor.FormattingEnabled = true;
            comboRepartidor.Location = new Point(76, 408);
            comboRepartidor.Margin = new Padding(2);
            comboRepartidor.Name = "comboRepartidor";
            comboRepartidor.Size = new Size(633, 49);
            comboRepartidor.TabIndex = 33;
            // 
            // comboDep
            // 
            comboDep.Enabled = false;
            comboDep.FormattingEnabled = true;
            comboDep.Location = new Point(1697, 74);
            comboDep.Margin = new Padding(2);
            comboDep.Name = "comboDep";
            comboDep.Size = new Size(421, 49);
            comboDep.TabIndex = 37;
            comboDep.SelectionChangeCommitted += comboDep_SelectionChangeCommitted;
            // 
            // comboSalida
            // 
            comboSalida.Enabled = false;
            comboSalida.FormattingEnabled = true;
            comboSalida.Location = new Point(790, 72);
            comboSalida.Margin = new Padding(2);
            comboSalida.Name = "comboSalida";
            comboSalida.Size = new Size(257, 49);
            comboSalida.TabIndex = 31;
            comboSalida.SelectionChangeCommitted += comboVenta_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1448, 78);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 41);
            label4.TabIndex = 36;
            label4.Text = "Departamento";
            // 
            // labelVent
            // 
            labelVent.AutoSize = true;
            labelVent.Location = new Point(490, 78);
            labelVent.Margin = new Padding(2, 0, 2, 0);
            labelVent.Name = "labelVent";
            labelVent.Size = new Size(268, 41);
            labelVent.TabIndex = 30;
            labelVent.Text = "Salida de Producto";
            // 
            // comboMuni
            // 
            comboMuni.Enabled = false;
            comboMuni.FormattingEnabled = true;
            comboMuni.Location = new Point(1697, 243);
            comboMuni.Margin = new Padding(2);
            comboMuni.Name = "comboMuni";
            comboMuni.Size = new Size(421, 49);
            comboMuni.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2215, 74);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(95, 41);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1448, 247);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 41);
            label3.TabIndex = 34;
            label3.Text = "Municipio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(2316, 72);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(321, 47);
            dateTimePicker1.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(202, 78);
            tbCodigo.Margin = new Padding(2);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.ReadOnly = true;
            tbCodigo.Size = new Size(257, 47);
            tbCodigo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 80);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 41);
            label1.TabIndex = 13;
            label1.Text = "Código";
            // 
            // labelSocio
            // 
            labelSocio.AutoSize = true;
            labelSocio.Location = new Point(76, 175);
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
            comboSocio.Location = new Point(76, 243);
            comboSocio.Margin = new Padding(2);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(633, 49);
            comboSocio.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 505);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(2597, 947);
            panel2.TabIndex = 25;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToAddRows = false;
            tablaDetalle.AllowUserToDeleteRows = false;
            tablaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDetalle.Columns.AddRange(new DataGridViewColumn[] { EntregaID, CodigoProducto, ProductoID, Cantidad });
            tablaDetalle.Dock = DockStyle.Fill;
            tablaDetalle.Location = new Point(0, 0);
            tablaDetalle.Margin = new Padding(2);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(2597, 947);
            tablaDetalle.TabIndex = 1;
            tablaDetalle.DataError += tablaDetalle_DataError;
            tablaDetalle.UserDeletedRow += tablaDetalle_UserDeletedRow;
            // 
            // EntregaID
            // 
            EntregaID.DataPropertyName = "EntregaID";
            dataGridViewCellStyle1.NullValue = "0";
            EntregaID.DefaultCellStyle = dataGridViewCellStyle1;
            EntregaID.HeaderText = "ID";
            EntregaID.MinimumWidth = 12;
            EntregaID.Name = "EntregaID";
            EntregaID.ReadOnly = true;
            EntregaID.Visible = false;
            EntregaID.Width = 250;
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
            // panel3
            // 
            panel3.Controls.Add(btnBorrarEntr);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 1452);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2597, 150);
            panel3.TabIndex = 31;
            // 
            // btnBorrarEntr
            // 
            btnBorrarEntr.Location = new Point(33, 86);
            btnBorrarEntr.Margin = new Padding(4);
            btnBorrarEntr.Name = "btnBorrarEntr";
            btnBorrarEntr.Size = new Size(253, 68);
            btnBorrarEntr.TabIndex = 29;
            btnBorrarEntr.Text = "Borrar Entrega";
            btnBorrarEntr.UseVisualStyleBackColor = true;
            btnBorrarEntr.Visible = false;
            btnBorrarEntr.Click += btnBorrarEntr_Click;
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
            // EntregaDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2597, 1602);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EntregaDetalle";
            Text = "EntregaDetalle";
            Load += EntregaDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboSalida;
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
        private Label label2;
        private ComboBox comboRepartidor;
        private TextBox tbColonia;
        private Label label7;
        private RichTextBox tbDetalle;
        private Label label5;
        private ComboBox comboDep;
        private Label label4;
        private ComboBox comboMuni;
        private Label label3;
        private DataGridViewTextBoxColumn EntregaID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewComboBoxColumn ProductoID;
        private DataGridViewTextBoxColumn Cantidad;
        private Button btnBorrarEntr;
    }
}