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
            panel1 = new System.Windows.Forms.Panel();
            btnRecargar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            tbBuscar = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            tablaBodega = new System.Windows.Forms.DataGridView();
            BodegaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CodigoBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DireccionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaBodega).BeginInit();
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
            panel1.Size = new System.Drawing.Size(2761, 266);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new System.Drawing.Point(1889, 62);
            btnRecargar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new System.Drawing.Size(189, 82);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(1134, 62);
            btnBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(189, 82);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new System.Drawing.Point(37, 62);
            tbBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "BOD...";
            tbBuscar.Size = new System.Drawing.Size(1036, 47);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaBodega);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 266);
            panel2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(2761, 1225);
            panel2.TabIndex = 1;
            // 
            // tablaBodega
            // 
            tablaBodega.AllowUserToAddRows = false;
            tablaBodega.AllowUserToDeleteRows = false;
            tablaBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { BodegaID, CodigoBodega, Nombre, Capacidad, DireccionID });
            tablaBodega.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaBodega.Location = new System.Drawing.Point(0, 0);
            tablaBodega.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tablaBodega.MultiSelect = false;
            tablaBodega.Name = "tablaBodega";
            tablaBodega.ReadOnly = true;
            tablaBodega.RowHeadersWidth = 62;
            tablaBodega.Size = new System.Drawing.Size(2761, 1225);
            tablaBodega.TabIndex = 0;
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
            // Bodega
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2761, 1491);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablaBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodegaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionID;
    }
}
