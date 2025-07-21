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
            this.panel1 = new Panel();
            this.btnRecargar = new Button();
            this.btnNuevoProducto = new Button();
            this.btnBuscar = new Button();
            this.tbBuscar = new TextBox();
            this.panel2 = new Panel();
            this.tablaProducto = new DataGridView();
            this.ProductoID = new DataGridViewTextBoxColumn();
            this.CodigoProducto = new DataGridViewTextBoxColumn();
            this.Nombre = new DataGridViewTextBoxColumn();
            this.TipoProducto = new DataGridViewTextBoxColumn();
            this.UnidadMedida = new DataGridViewTextBoxColumn();
            this.Precio = new DataGridViewTextBoxColumn();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).BeginInit();
            this.SuspendLayout();

            // panel1

            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnRecargar);
            this.panel1.Controls.Add(this.btnNuevoProducto);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1200, 130);
            this.panel1.TabIndex = 0;

            // btnEliminar
            this.btnEliminar = new Button();
            this.btnEliminar.Location = new Point(780, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(100, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += btnEliminar_Click;

            // btnRecargar
            this.btnRecargar.Location = new Point(1000, 30);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new Size(100, 40);
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += btnRecargar_Click;

            // btnNuevoProducto
            this.btnNuevoProducto.Location = new Point(780, 30);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new Size(180, 40);
            this.btnNuevoProducto.TabIndex = 2;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new Point(600, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(100, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += btnBuscar_Click;

            // tbBuscar
            this.tbBuscar.Location = new Point(20, 30);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new Size(550, 31);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.PlaceholderText = "PRO...";

            // panel2
            this.panel2.Controls.Add(this.tablaProducto);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(1200, 400);
            this.panel2.TabIndex = 1;

            // tablaProducto
            this.tablaProducto.AllowUserToAddRows = false;
            this.tablaProducto.AllowUserToDeleteRows = false;
            this.tablaProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProducto.Columns.AddRange(new DataGridViewColumn[] {
                this.ProductoID,
                this.CodigoProducto,
                this.Nombre,
                this.TipoProducto,
                this.UnidadMedida,
                this.Precio});
            this.tablaProducto.Dock = DockStyle.Fill;
            this.tablaProducto.Location = new Point(0, 0);
            this.tablaProducto.MultiSelect = false;
            this.tablaProducto.Name = "tablaProducto";
            this.tablaProducto.ReadOnly = true;
            this.tablaProducto.RowHeadersWidth = 62;
            this.tablaProducto.RowTemplate.Height = 33;
            this.tablaProducto.Size = new Size(1200, 400);
            this.tablaProducto.TabIndex = 0;

            // ProductoID
            this.ProductoID.DataPropertyName = "ProductoID";
            this.ProductoID.HeaderText = "ID";
            this.ProductoID.MinimumWidth = 8;
            this.ProductoID.Name = "ProductoID";
            this.ProductoID.ReadOnly = true;
            this.ProductoID.Visible = false;
            this.ProductoID.Width = 150;

            // CodigoProducto
            this.CodigoProducto.DataPropertyName = "CodigoProducto";
            this.CodigoProducto.HeaderText = "Código";
            this.CodigoProducto.MinimumWidth = 8;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 150;

            // Nombre
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;

            // TipoProducto
            this.TipoProducto.DataPropertyName = "TipoProducto";
            this.TipoProducto.HeaderText = "Tipo Producto";
            this.TipoProducto.MinimumWidth = 8;
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            this.TipoProducto.Width = 200;

            // UnidadMedida
            this.UnidadMedida.DataPropertyName = "UnidadMedida";
            this.UnidadMedida.HeaderText = "Unidad Medida";
            this.UnidadMedida.MinimumWidth = 8;
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            this.UnidadMedida.Width = 150;

            // Precio
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 8;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;

            // Producto Form
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += Producto_Load;

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProducto)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnNuevoProducto;
        private Button btnBuscar;
        private Button btnEliminar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaProducto;
        private DataGridViewTextBoxColumn ProductoID;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn UnidadMedida;
        private DataGridViewTextBoxColumn Precio;
    }
}
