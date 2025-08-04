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
            panel1.Controls.Add(btnNuevaBodega);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(2761, 266);
            panel1.TabIndex = 0;
            //
            // btnNuevaBodega
            //
            btnNuevaBodega.Location = new Point(1700, 62);
            btnNuevaBodega.Margin = new Padding(5, 7, 5, 7);
            btnNuevaBodega.Name = "btnNuevaBodega";
            btnNuevaBodega.Size = new Size(378, 82);
            btnNuevaBodega.TabIndex = 4;
            btnNuevaBodega.Text = "Nueva Bodega";
            btnNuevaBodega.UseVisualStyleBackColor = true;
            btnNuevaBodega.Click += btnNuevaBodega_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1500, 62);
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
            tbBuscar.PlaceholderText = "BOD...";
            tbBuscar.Size = new Size(1036, 47);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaBodega);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new Point(0, 266);
            panel2.Margin = new Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(2761, 1225);
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
            tablaBodega.Margin = new Padding(5, 7, 5, 7);
            tablaBodega.MultiSelect = false;
            tablaBodega.Name = "tablaBodega";
            tablaBodega.ReadOnly = true;
            tablaBodega.RowHeadersWidth = 62;
            tablaBodega.Size = new Size(2761, 1225);
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
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Capacidad
            // 
            Capacidad.DataPropertyName = "Capacidad";
            Capacidad.HeaderText = "Capacidad";
            Capacidad.MinimumWidth = 8;
            Capacidad.Name = "Capacidad";
            Capacidad.ReadOnly = true;
            Capacidad.Width = 150;
            // 
            // DireccionID
            // 
            DireccionID.DataPropertyName = "DireccionID";
            DireccionID.HeaderText = "DireccionID";
            DireccionID.MinimumWidth = 8;
            DireccionID.Name = "DireccionID";
            DireccionID.ReadOnly = true;
            DireccionID.Width = 200;
            //
            // Direccion
            //
            Direccion.DataPropertyName = "Direccion";
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 8;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 400;
            // 
            // Bodega
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2761, 1491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 7, 5, 7);
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
