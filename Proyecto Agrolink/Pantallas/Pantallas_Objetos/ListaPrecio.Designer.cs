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
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnNuevoPrecio);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 11, 6, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 181);
            panel1.TabIndex = 0;
            // 
            // btnNuevoPrecio
            // 
            btnNuevoPrecio.BackColor = SystemColors.Window;
            btnNuevoPrecio.Location = new Point(182, 103);
            btnNuevoPrecio.Margin = new Padding(6, 11, 6, 11);
            btnNuevoPrecio.Name = "btnNuevoPrecio";
            btnNuevoPrecio.Size = new Size(189, 35);
            btnNuevoPrecio.TabIndex = 3;
            btnNuevoPrecio.Text = "Nuevo Precio";
            btnNuevoPrecio.UseVisualStyleBackColor = false;
            btnNuevoPrecio.Click += btnNuevoPrecio_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(44, 103);
            btnRecargar.Margin = new Padding(6, 11, 6, 11);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(115, 35);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(604, 43);
            btnBuscar.Margin = new Padding(6, 11, 6, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(44, 46);
            tbBuscar.Margin = new Padding(6, 11, 6, 11);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar Lista de Precios...";
            tbBuscar.Size = new Size(549, 31);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaListaPrecio);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 181);
            panel2.Margin = new Padding(6, 11, 6, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 493);
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
            tablaListaPrecio.Margin = new Padding(6, 11, 6, 11);
            tablaListaPrecio.MultiSelect = false;
            tablaListaPrecio.Name = "tablaListaPrecio";
            tablaListaPrecio.ReadOnly = true;
            tablaListaPrecio.RowHeadersWidth = 62;
            tablaListaPrecio.Size = new Size(1145, 493);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
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
