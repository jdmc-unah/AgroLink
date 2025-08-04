namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class ListaPrecio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnNuevoPrecio = new Button();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaListaPrecio = new DataGridView();
            listaPreciosID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaListaPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevoPrecio);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(11, 18, 11, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(2916, 297);
            panel1.TabIndex = 0;
            // 
            // btnNuevoPrecio
            // 
            btnNuevoPrecio.Location = new Point(309, 169);
            btnNuevoPrecio.Margin = new Padding(11, 18, 11, 18);
            btnNuevoPrecio.Name = "btnNuevoPrecio";
            btnNuevoPrecio.Size = new Size(321, 57);
            btnNuevoPrecio.TabIndex = 3;
            btnNuevoPrecio.Text = "Nuevo Precio";
            btnNuevoPrecio.UseVisualStyleBackColor = true;
            btnNuevoPrecio.Click += btnNuevoPrecio_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(75, 169);
            btnRecargar.Margin = new Padding(11, 18, 11, 18);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(195, 57);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1027, 71);
            btnBuscar.Margin = new Padding(11, 18, 11, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(195, 57);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(75, 76);
            tbBuscar.Margin = new Padding(11, 18, 11, 18);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar lista de precios...";
            tbBuscar.Size = new Size(930, 47);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaListaPrecio);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 297);
            panel2.Margin = new Padding(11, 18, 11, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(2916, 1415);
            panel2.TabIndex = 1;
            // 
            // tablaListaPrecio
            // 
            tablaListaPrecio.AllowUserToAddRows = false;
            tablaListaPrecio.AllowUserToDeleteRows = false;
            tablaListaPrecio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaListaPrecio.Columns.AddRange(new DataGridViewColumn[] { listaPreciosID, nombre, activo });
            tablaListaPrecio.Dock = DockStyle.Fill;
            tablaListaPrecio.Location = new Point(0, 0);
            tablaListaPrecio.Margin = new Padding(11, 18, 11, 18);
            tablaListaPrecio.MultiSelect = false;
            tablaListaPrecio.Name = "tablaListaPrecio";
            tablaListaPrecio.ReadOnly = true;
            tablaListaPrecio.RowHeadersWidth = 62;
            tablaListaPrecio.Size = new Size(2916, 1415);
            tablaListaPrecio.TabIndex = 0;
            // 
            // listaPreciosID
            // 
            listaPreciosID.DataPropertyName = "ID";
            listaPreciosID.HeaderText = "ID";
            listaPreciosID.MinimumWidth = 8;
            listaPreciosID.Name = "listaPreciosID";
            listaPreciosID.ReadOnly = true;
            listaPreciosID.Visible = false;
            listaPreciosID.Width = 150;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // activo
            // 
            activo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            activo.DataPropertyName = "Activo";
            activo.HeaderText = "Activo";
            activo.MinimumWidth = 8;
            activo.Name = "activo";
            activo.ReadOnly = true;
            // 
            // ListaPrecio
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 10, 8, 10);
            Name = "ListaPrecio";
            Text = "ListaPrecio";
            Load += ListaPrecio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaListaPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoPrecio;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaListaPrecio;
        private DataGridViewTextBoxColumn listaPreciosID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn activo;
    }
}
