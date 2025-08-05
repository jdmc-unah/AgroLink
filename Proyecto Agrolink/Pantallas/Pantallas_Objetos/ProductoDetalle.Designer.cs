namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class ProductoDetalle
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
            lbNombreRC = new Label();
            numericPrecio = new NumericUpDown();
            label1 = new Label();
            comboListaPrecios = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            tablaPrecios = new DataGridView();
            Lista = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelTitulo = new Panel();
            panelAgregarPrecio = new Panel();
            lblProducto = new Label();
            btnAddUpdtPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaPrecios).BeginInit();
            panelTitulo.SuspendLayout();
            panelAgregarPrecio.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombreRC
            // 
            lbNombreRC.AutoSize = true;
            lbNombreRC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNombreRC.ForeColor = Color.White;
            lbNombreRC.Location = new Point(54, 133);
            lbNombreRC.Margin = new Padding(5, 0, 5, 0);
            lbNombreRC.Name = "lbNombreRC";
            lbNombreRC.Size = new Size(105, 41);
            lbNombreRC.TabIndex = 23;
            lbNombreRC.Text = "Precio";
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Font = new Font("Segoe UI", 9F);
            numericPrecio.Location = new Point(351, 130);
            numericPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(300, 47);
            numericPrecio.TabIndex = 24;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 25;
            label1.Text = "Lista de Precios";
            // 
            // comboListaPrecios
            // 
            comboListaPrecios.Font = new Font("Segoe UI", 9F);
            comboListaPrecios.FormattingEnabled = true;
            comboListaPrecios.Location = new Point(351, 40);
            comboListaPrecios.Name = "comboListaPrecios";
            comboListaPrecios.Size = new Size(495, 49);
            comboListaPrecios.TabIndex = 26;
            comboListaPrecios.SelectionChangeCommitted += comboListaPrecios_SelectionChangeCommitted;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(1196, 30);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(251, 57);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1196, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(251, 57);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tablaPrecios
            // 
            tablaPrecios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaPrecios.Columns.AddRange(new DataGridViewColumn[] { Lista, Precio, Estado });
            tablaPrecios.Dock = DockStyle.Fill;
            tablaPrecios.Location = new Point(0, 378);
            tablaPrecios.Name = "tablaPrecios";
            tablaPrecios.RowHeadersWidth = 102;
            tablaPrecios.Size = new Size(1539, 554);
            tablaPrecios.TabIndex = 29;
            // 
            // Lista
            // 
            Lista.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lista.DataPropertyName = "Lista";
            Lista.HeaderText = "Lista";
            Lista.MinimumWidth = 12;
            Lista.Name = "Lista";
            // 
            // Precio
            // 
            Precio.DataPropertyName = "Precio";
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 300;
            Precio.Name = "Precio";
            Precio.Width = 300;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 350;
            Estado.Name = "Estado";
            Estado.Width = 350;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(panelAgregarPrecio);
            panelTitulo.Controls.Add(lblProducto);
            panelTitulo.Controls.Add(btnAddUpdtPrecio);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Font = new Font("Segoe UI", 12F);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1539, 378);
            panelTitulo.TabIndex = 30;
            // 
            // panelAgregarPrecio
            // 
            panelAgregarPrecio.Controls.Add(comboListaPrecios);
            panelAgregarPrecio.Controls.Add(label1);
            panelAgregarPrecio.Controls.Add(lbNombreRC);
            panelAgregarPrecio.Controls.Add(btnAceptar);
            panelAgregarPrecio.Controls.Add(btnCancelar);
            panelAgregarPrecio.Controls.Add(numericPrecio);
            panelAgregarPrecio.Location = new Point(12, 137);
            panelAgregarPrecio.Name = "panelAgregarPrecio";
            panelAgregarPrecio.Size = new Size(1513, 201);
            panelAgregarPrecio.TabIndex = 29;
            panelAgregarPrecio.Visible = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblProducto.ForeColor = Color.FromArgb(255, 222, 89);
            lblProducto.Location = new Point(30, 42);
            lblProducto.Margin = new Padding(5, 0, 5, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(570, 67);
            lblProducto.TabIndex = 31;
            lblProducto.Text = "Nombre de Producto 1";
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddUpdtPrecio
            // 
            btnAddUpdtPrecio.FlatStyle = FlatStyle.Flat;
            btnAddUpdtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddUpdtPrecio.ForeColor = Color.White;
            btnAddUpdtPrecio.Location = new Point(445, 186);
            btnAddUpdtPrecio.Name = "btnAddUpdtPrecio";
            btnAddUpdtPrecio.Size = new Size(696, 92);
            btnAddUpdtPrecio.TabIndex = 27;
            btnAddUpdtPrecio.Text = "Agregar o Editar Precio Existente";
            btnAddUpdtPrecio.UseVisualStyleBackColor = true;
            btnAddUpdtPrecio.Click += btnAddUpdtPrecio_Click;
            // 
            // ProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(1539, 932);
            Controls.Add(tablaPrecios);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductoDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ProductoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaPrecios).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelAgregarPrecio.ResumeLayout(false);
            panelAgregarPrecio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbNombreRC;
        private NumericUpDown numericPrecio;
        private Label label1;
        private ComboBox comboListaPrecios;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridView tablaPrecios;
        private Panel panelTitulo;
        private Panel panelAgregarPrecio;
        private Button btnAddUpdtPrecio;
        private Label lblProducto;
        private DataGridViewTextBoxColumn Lista;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Estado;
    }
}