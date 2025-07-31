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
            panel1 = new System.Windows.Forms.Panel();
            btnRecargar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            tbBuscar = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            tablaTipoProducto = new System.Windows.Forms.DataGridView();
            tipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new System.Drawing.Point(600, 20);
            btnRecargar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new System.Drawing.Size(100, 40);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(480, 20);
            btnBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(100, 40);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new System.Drawing.Point(20, 20);
            tbBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar tipo de producto...";
            tbBuscar.Size = new System.Drawing.Size(440, 23);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaTipoProducto);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 350);
            panel2.TabIndex = 1;
            // 
            // tablaTipoProducto
            // 
            tablaTipoProducto.AllowUserToAddRows = false;
            tablaTipoProducto.AllowUserToDeleteRows = false;
            tablaTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaTipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            tipoID,
            tipoProducto,
            categoria});
            tablaTipoProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaTipoProducto.Location = new System.Drawing.Point(0, 0);
            tablaTipoProducto.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tablaTipoProducto.MultiSelect = false;
            tablaTipoProducto.Name = "tablaTipoProducto";
            tablaTipoProducto.ReadOnly = true;
            tablaTipoProducto.RowHeadersWidth = 62;
            tablaTipoProducto.Size = new System.Drawing.Size(800, 350);
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
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablaTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}
