namespace AgroLink.Pantallas.Pantallas_Transacciones
{
    partial class Producto
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
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(2761, 266);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1889, 62);
            btnRecargar.Margin = new Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(189, 82);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1134, 62);
            btnBuscar.Margin = new Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 82);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(37, 62);
            tbBuscar.Margin = new Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "PRO...";
            tbBuscar.Size = new Size(1036, 47);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 266);
            panel2.Margin = new Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(2761, 1225);
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
            tablaProducto.Margin = new Padding(5, 7, 5, 7);
            tablaProducto.MultiSelect = false;
            tablaProducto.Name = "tablaProducto";
            tablaProducto.ReadOnly = true;
            tablaProducto.RowHeadersWidth = 62;
            tablaProducto.Size = new Size(2761, 1225);
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
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // TipoProducto
            // 
            TipoProducto.DataPropertyName = "TipoProducto";
            TipoProducto.HeaderText = "Tipo Producto";
            TipoProducto.MinimumWidth = 8;
            TipoProducto.Name = "TipoProducto";
            TipoProducto.ReadOnly = true;
            TipoProducto.Width = 200;
            // 
            // UnidadMedida
            // 
            UnidadMedida.DataPropertyName = "UnidadMedida";
            UnidadMedida.HeaderText = "Unidad Medida";
            UnidadMedida.MinimumWidth = 8;
            UnidadMedida.Name = "UnidadMedida";
            UnidadMedida.ReadOnly = true;
            UnidadMedida.Width = 150;
            // 
            // Precio
            // 
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2761, 1491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 7, 5, 7);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaProducto;
        private DataGridViewTextBoxColumn ProductoID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn UnidadMedida;

    }
}
