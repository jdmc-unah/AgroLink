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
            btnNuevoTipoProducto = new Button();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaTipoProducto = new DataGridView();
            tipoID = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaTipoProducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevoTipoProducto);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(11, 18, 11, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(2916, 287);
            panel1.TabIndex = 0;
            // 
            // btnNuevoTipoProducto
            // 
            btnNuevoTipoProducto.Location = new Point(299, 173);
            btnNuevoTipoProducto.Margin = new Padding(11, 18, 11, 18);
            btnNuevoTipoProducto.Name = "btnNuevoTipoProducto";
            btnNuevoTipoProducto.Size = new Size(437, 58);
            btnNuevoTipoProducto.TabIndex = 3;
            btnNuevoTipoProducto.Text = "Nuevo Tipo de Producto";
            btnNuevoTipoProducto.UseVisualStyleBackColor = true;
            btnNuevoTipoProducto.Click += btnNuevoTipoProducto_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(86, 173);
            btnRecargar.Margin = new Padding(11, 18, 11, 18);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(171, 58);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1064, 66);
            btnBuscar.Margin = new Padding(11, 18, 11, 18);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(171, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(86, 72);
            tbBuscar.Margin = new Padding(11, 18, 11, 18);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar tipo de producto...";
            tbBuscar.Size = new Size(930, 47);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaTipoProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 287);
            panel2.Margin = new Padding(11, 18, 11, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(2916, 1425);
            panel2.TabIndex = 1;
            // 
            // tablaTipoProducto
            // 
            tablaTipoProducto.AllowUserToAddRows = false;
            tablaTipoProducto.AllowUserToDeleteRows = false;
            tablaTipoProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTipoProducto.Columns.AddRange(new DataGridViewColumn[] { tipoID, categoria });
            tablaTipoProducto.Dock = DockStyle.Fill;
            tablaTipoProducto.Location = new Point(0, 0);
            tablaTipoProducto.Margin = new Padding(11, 18, 11, 18);
            tablaTipoProducto.MultiSelect = false;
            tablaTipoProducto.Name = "tablaTipoProducto";
            tablaTipoProducto.ReadOnly = true;
            tablaTipoProducto.RowHeadersWidth = 62;
            tablaTipoProducto.Size = new Size(2916, 1425);
            tablaTipoProducto.TabIndex = 0;
            // 
            // tipoID
            // 
            tipoID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoID.DataPropertyName = "tipoID";
            tipoID.HeaderText = "ID";
            tipoID.MinimumWidth = 8;
            tipoID.Name = "tipoID";
            tipoID.ReadOnly = true;
            tipoID.Visible = false;
            // 
            // categoria
            // 
            categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoria.DataPropertyName = "Categoria";
            categoria.HeaderText = "Categoría";
            categoria.MinimumWidth = 8;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            // 
            // TipoProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 10, 8, 10);
            Name = "TipoProducto";
            Text = "TipoProducto";
            Load += TipoProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaTipoProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevoTipoProducto;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaTipoProducto;
        private DataGridViewTextBoxColumn tipoProducto;
        private DataGridViewTextBoxColumn tipoID;
        private DataGridViewTextBoxColumn categoria;
    }
}
