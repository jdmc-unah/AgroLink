namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class TipoProducto
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
            tablaTipoProducto = new DataGridView();
            tipoID = new DataGridViewTextBoxColumn();
            tipoProducto = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(tablaTipoProducto)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(600, 20);
            btnRecargar.Margin = new Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(100, 40);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(480, 20);
            btnBuscar.Margin = new Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 40);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(20, 20);
            tbBuscar.Margin = new Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar tipo de producto...";
            tbBuscar.Size = new Size(440, 23);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaTipoProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 1;
            // 
            // tablaTipoProducto
            // 
            tablaTipoProducto.AllowUserToAddRows = false;
            tablaTipoProducto.AllowUserToDeleteRows = false;
            tablaTipoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTipoProducto.Columns.AddRange(new DataGridViewColumn[] {
            tipoID,
            tipoProducto,
            categoria});
            tablaTipoProducto.Dock = DockStyle.Fill;
            tablaTipoProducto.Location = new Point(0, 0);
            tablaTipoProducto.Margin = new Padding(5, 7, 5, 7);
            tablaTipoProducto.MultiSelect = false;
            tablaTipoProducto.Name = "tablaTipoProducto";
            tablaTipoProducto.ReadOnly = true;
            tablaTipoProducto.RowHeadersWidth = 62;
            tablaTipoProducto.Size = new Size(800, 350);
            tablaTipoProducto.TabIndex = 0;
            // 
            // tipoID
            // 
            tipoID.DataPropertyName = "tipoID";
            tipoID.HeaderText = "ID";
            tipoID.MinimumWidth = 8;
            tipoID.Name = "tipoID";
            tipoID.ReadOnly = true;
            tipoID.Visible = false;
            tipoID.Width = 150;
            // 
            // tipoProducto
            // 
            tipoProducto.DataPropertyName = "TipoProducto";
            tipoProducto.HeaderText = "Tipo de Producto";
            tipoProducto.MinimumWidth = 8;
            tipoProducto.Name = "tipoProducto";
            tipoProducto.ReadOnly = true;
            tipoProducto.Width = 250;
            // 
            // categoria
            // 
            categoria.DataPropertyName = "Categoria";
            categoria.HeaderText = "Categoría";
            categoria.MinimumWidth = 8;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 200;
            // 
            // TipoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TipoProducto";
            Text = "TipoProducto";
            Load += TipoProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(tablaTipoProducto)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaTipoProducto;
        private DataGridViewTextBoxColumn tipoID;
        private DataGridViewTextBoxColumn tipoProducto;
        private DataGridViewTextBoxColumn categoria;
    }
}
