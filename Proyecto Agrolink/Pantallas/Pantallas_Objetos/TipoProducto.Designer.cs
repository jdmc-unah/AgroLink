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
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnNuevoTipoProducto);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6, 11, 6, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 175);
            panel1.TabIndex = 0;
            // 
            // btnNuevoTipoProducto
            // 
            btnNuevoTipoProducto.BackColor = SystemColors.Window;
            btnNuevoTipoProducto.Location = new Point(176, 105);
            btnNuevoTipoProducto.Margin = new Padding(6, 11, 6, 11);
            btnNuevoTipoProducto.Name = "btnNuevoTipoProducto";
            btnNuevoTipoProducto.Size = new Size(257, 35);
            btnNuevoTipoProducto.TabIndex = 3;
            btnNuevoTipoProducto.Text = "Nuevo Tipo de Producto";
            btnNuevoTipoProducto.UseVisualStyleBackColor = false;
            btnNuevoTipoProducto.Click += btnNuevoTipoProducto_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(51, 105);
            btnRecargar.Margin = new Padding(6, 11, 6, 11);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(101, 35);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(626, 40);
            btnBuscar.Margin = new Padding(6, 11, 6, 11);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(51, 44);
            tbBuscar.Margin = new Padding(6, 11, 6, 11);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar Tipo de Producto...";
            tbBuscar.Size = new Size(549, 31);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaTipoProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 175);
            panel2.Margin = new Padding(6, 11, 6, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 499);
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
            tablaTipoProducto.Margin = new Padding(6, 11, 6, 11);
            tablaTipoProducto.MultiSelect = false;
            tablaTipoProducto.Name = "tablaTipoProducto";
            tablaTipoProducto.ReadOnly = true;
            tablaTipoProducto.RowHeadersWidth = 62;
            tablaTipoProducto.Size = new Size(1145, 499);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
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
