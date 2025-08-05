namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class Producto
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnNuevoProducto = new Button();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaProducto = new DataGridView();
            ProductoID = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoProducto = new DataGridViewTextBoxColumn();
            UnidadMedida = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 162);
            panel1.TabIndex = 0;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.BackColor = SystemColors.Window;
            btnNuevoProducto.Location = new Point(184, 91);
            btnNuevoProducto.Margin = new Padding(3, 4, 3, 4);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(223, 41);
            btnNuevoProducto.TabIndex = 4;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(49, 91);
            btnRecargar.Margin = new Padding(3, 4, 3, 4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(125, 41);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(538, 36);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(49, 38);
            tbBuscar.Margin = new Padding(3, 4, 3, 4);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Código de producto...";
            tbBuscar.Size = new Size(476, 31);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 162);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 512);
            panel2.TabIndex = 1;
            // 
            // tablaProducto
            // 
            tablaProducto.AllowUserToAddRows = false;
            tablaProducto.AllowUserToDeleteRows = false;
            tablaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProducto.Columns.AddRange(new DataGridViewColumn[] { ProductoID, CodigoProducto, Nombre, TipoProducto, UnidadMedida });
            tablaProducto.Dock = DockStyle.Fill;
            tablaProducto.Location = new Point(0, 0);
            tablaProducto.Margin = new Padding(3, 4, 3, 4);
            tablaProducto.MultiSelect = false;
            tablaProducto.Name = "tablaProducto";
            tablaProducto.ReadOnly = true;
            tablaProducto.RowHeadersWidth = 62;
            tablaProducto.Size = new Size(1145, 512);
            tablaProducto.TabIndex = 0;
            // 
            // ProductoID
            // 
            ProductoID.DataPropertyName = "ProductoID";
            ProductoID.HeaderText = "ID";
            ProductoID.MinimumWidth = 8;
            ProductoID.Name = "ProductoID";
            ProductoID.ReadOnly = true;
            ProductoID.Visible = false;
            ProductoID.Width = 150;
            // 
            // CodigoProducto
            // 
            CodigoProducto.DataPropertyName = "CodigoProducto";
            CodigoProducto.HeaderText = "Código";
            CodigoProducto.MinimumWidth = 8;
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            CodigoProducto.Width = 150;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // TipoProducto
            // 
            TipoProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoProducto.DataPropertyName = "TipoProducto";
            TipoProducto.HeaderText = "Tipo Producto";
            TipoProducto.MinimumWidth = 8;
            TipoProducto.Name = "TipoProducto";
            TipoProducto.ReadOnly = true;
            // 
            // UnidadMedida
            // 
            UnidadMedida.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnidadMedida.DataPropertyName = "UnidadMedida";
            UnidadMedida.HeaderText = "Unidad Medida";
            UnidadMedida.MinimumWidth = 8;
            UnidadMedida.Name = "UnidadMedida";
            UnidadMedida.ReadOnly = true;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaProducto).EndInit();
            ResumeLayout(false);
        }

        private System.ComponentModel.IContainer components = null;
        private Panel panel1;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Button btnNuevoProducto;
        private Panel panel2;
        private DataGridView tablaProducto;
        private DataGridViewTextBoxColumn ProductoID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn UnidadMedida;
    }
}
