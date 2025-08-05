namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class Bodega
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
            btnNuevaBodega = new Button();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaBodega = new DataGridView();
            BodegaID = new DataGridViewTextBoxColumn();
            CodigoBodega = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Capacidad = new DataGridViewTextBoxColumn();
            DireccionID = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaBodega).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnNuevaBodega);
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
            // btnNuevaBodega
            // 
            btnNuevaBodega.BackColor = SystemColors.Window;
            btnNuevaBodega.Location = new Point(185, 91);
            btnNuevaBodega.Margin = new Padding(3, 4, 3, 4);
            btnNuevaBodega.Name = "btnNuevaBodega";
            btnNuevaBodega.Size = new Size(223, 41);
            btnNuevaBodega.TabIndex = 4;
            btnNuevaBodega.Text = "Nueva Bodega";
            btnNuevaBodega.UseVisualStyleBackColor = false;
            btnNuevaBodega.Click += btnNuevaBodega_Click;
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
            btnBuscar.Location = new Point(565, 35);
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
            tbBuscar.PlaceholderText = "Código de bodega...";
            tbBuscar.Size = new Size(503, 31);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaBodega);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 162);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 512);
            panel2.TabIndex = 1;
            // 
            // tablaBodega
            // 
            tablaBodega.AllowUserToAddRows = false;
            tablaBodega.AllowUserToDeleteRows = false;
            tablaBodega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaBodega.Columns.AddRange(new DataGridViewColumn[] { BodegaID, CodigoBodega, Nombre, Capacidad, DireccionID, Direccion });
            tablaBodega.Dock = DockStyle.Fill;
            tablaBodega.Location = new Point(0, 0);
            tablaBodega.Margin = new Padding(3, 4, 3, 4);
            tablaBodega.MultiSelect = false;
            tablaBodega.Name = "tablaBodega";
            tablaBodega.ReadOnly = true;
            tablaBodega.RowHeadersWidth = 62;
            tablaBodega.Size = new Size(1145, 512);
            tablaBodega.TabIndex = 0;
            tablaBodega.CellDoubleClick += tablaBodega_CellDoubleClick;
            // 
            // BodegaID
            // 
            BodegaID.DataPropertyName = "BodegaID";
            BodegaID.HeaderText = "ID";
            BodegaID.MinimumWidth = 8;
            BodegaID.Name = "BodegaID";
            BodegaID.ReadOnly = true;
            BodegaID.Visible = false;
            BodegaID.Width = 150;
            // 
            // CodigoBodega
            // 
            CodigoBodega.DataPropertyName = "CodigoBodega";
            CodigoBodega.HeaderText = "Código";
            CodigoBodega.MinimumWidth = 8;
            CodigoBodega.Name = "CodigoBodega";
            CodigoBodega.ReadOnly = true;
            CodigoBodega.Width = 150;
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
            // Capacidad
            // 
            Capacidad.DataPropertyName = "Capacidad";
            Capacidad.HeaderText = "Capacidad";
            Capacidad.MinimumWidth = 200;
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            Capacidad.Width = 200;
            // 
            // DireccionID
            // 
            DireccionID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DireccionID.DataPropertyName = "DireccionID";
            DireccionID.HeaderText = "DireccionID";
            DireccionID.MinimumWidth = 8;
            DireccionID.Name = "DireccionID";
            DireccionID.ReadOnly = true;
            DireccionID.Width = 200;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Bodega
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bodega";
            Text = "Bodega";
            Load += Bodega_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaBodega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaBodega;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaBodega;
        private DataGridViewTextBoxColumn BodegaID;
        private DataGridViewTextBoxColumn CodigoBodega;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewTextBoxColumn DireccionID;
        private DataGridViewTextBoxColumn Direccion;
    }
}
