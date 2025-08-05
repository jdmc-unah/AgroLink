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
            panel1.BackColor = Color.FromArgb(22, 48, 43);
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
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 0, 0, 0);
            panel1.Size = new Size(1145, 313);
            panel1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(1364, 140);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 40;
            label7.Text = "Detalle";
            // 
            // tbColonia
            // 
            tbColonia.Location = new Point(1059, 252);
            tbColonia.Margin = new Padding(2);
            tbColonia.Name = "tbColonia";
            tbColonia.ReadOnly = true;
            tbColonia.Size = new Size(249, 31);
            tbColonia.TabIndex = 41;
            // 
            // tbDetalle
            // 
            tbDetalle.Location = new Point(1364, 174);
            tbDetalle.Margin = new Padding(2);
            tbDetalle.Name = "tbDetalle";
            tbDetalle.ReadOnly = true;
            tbDetalle.Size = new Size(290, 106);
            tbDetalle.TabIndex = 39;
            tbDetalle.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(58, 207);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 32;
            label2.Text = "Repartidor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(912, 254);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 38;
            label5.Text = "Colonia";
            // 
            // comboRepartidor
            // 
            comboRepartidor.Enabled = false;
            comboRepartidor.FormattingEnabled = true;
            comboRepartidor.Location = new Point(58, 249);
            comboRepartidor.Margin = new Padding(1);
            comboRepartidor.Name = "comboRepartidor";
            comboRepartidor.Size = new Size(374, 33);
            comboRepartidor.TabIndex = 33;
            // 
            // comboDep
            // 
            comboDep.Enabled = false;
            comboDep.FormattingEnabled = true;
            comboDep.Location = new Point(1059, 48);
            comboDep.Margin = new Padding(1);
            comboDep.Name = "comboDep";
            comboDep.Size = new Size(249, 33);
            comboDep.TabIndex = 37;
            comboDep.SelectionChangeCommitted += comboDep_SelectionChangeCommitted;
            // 
            // comboSalida
            // 
            comboSalida.Enabled = false;
            comboSalida.FormattingEnabled = true;
            comboSalida.Location = new Point(465, 44);
            comboSalida.Margin = new Padding(1);
            comboSalida.Name = "comboSalida";
            comboSalida.Size = new Size(153, 33);
            comboSalida.TabIndex = 31;
            comboSalida.SelectionChangeCommitted += comboVenta_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(912, 51);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 36;
            label4.Text = "Departamento";
            // 
            // labelVent
            // 
            labelVent.AutoSize = true;
            labelVent.ForeColor = SystemColors.Window;
            labelVent.Location = new Point(288, 48);
            labelVent.Margin = new Padding(1, 0, 1, 0);
            labelVent.Name = "labelVent";
            labelVent.Size = new Size(162, 25);
            labelVent.TabIndex = 30;
            labelVent.Text = "Salida de Producto";
            // 
            // comboMuni
            // 
            comboMuni.Enabled = false;
            comboMuni.FormattingEnabled = true;
            comboMuni.Location = new Point(1059, 151);
            comboMuni.Margin = new Padding(1);
            comboMuni.Name = "comboMuni";
            comboMuni.Size = new Size(249, 33);
            comboMuni.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(1364, 48);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 22;
            label6.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(912, 154);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 34;
            label3.Text = "Municipio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1423, 47);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(119, 48);
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
            label1.Location = new Point(45, 49);
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
            labelSocio.Location = new Point(58, 107);
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
            comboSocio.Location = new Point(58, 148);
            comboSocio.Margin = new Padding(1);
            comboSocio.Name = "comboSocio";
            comboSocio.Size = new Size(374, 33);
            comboSocio.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaDetalle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 313);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 623);
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
            tablaDetalle.Margin = new Padding(1);
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.ReadOnly = true;
            tablaDetalle.RowHeadersWidth = 102;
            tablaDetalle.Size = new Size(1145, 623);
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
            panel3.BackColor = Color.FromArgb(22, 48, 43);
            panel3.Controls.Add(btnBorrarEntr);
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAceptar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 936);
            panel3.Margin = new Padding(1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1145, 0);
            panel3.TabIndex = 31;
            // 
            // btnBorrarEntr
            // 
            btnBorrarEntr.BackColor = SystemColors.Window;
            btnBorrarEntr.Location = new Point(45, 39);
            btnBorrarEntr.Margin = new Padding(2);
            btnBorrarEntr.Name = "btnBorrarEntr";
            btnBorrarEntr.Size = new Size(149, 41);
            btnBorrarEntr.TabIndex = 29;
            btnBorrarEntr.Text = "Borrar Entrega";
            btnBorrarEntr.UseVisualStyleBackColor = false;
            btnBorrarEntr.Visible = false;
            btnBorrarEntr.Click += btnBorrarEntr_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(55, 39);
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
            btnCancelar.Location = new Point(1521, 39);
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
            btnEditar.Location = new Point(216, 39);
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
            btnAceptar.Location = new Point(1364, 39);
            btnAceptar.Margin = new Padding(2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 41);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Visible = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // EntregaDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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