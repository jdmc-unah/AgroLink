namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Entrega
{
    partial class Entrega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            btnRecargarEntrega = new Button();
            btnNuevaEntrega = new Button();
            btnBuscarEntrega = new Button();
            tbBuscarEntrega = new TextBox();
            tablaEntrega = new DataGridView();
            EntregaID = new DataGridViewTextBoxColumn();
            VentaID = new DataGridViewTextBoxColumn();
            CodigoEntrega = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaEntrega).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRecargarEntrega);
            panel2.Controls.Add(btnNuevaEntrega);
            panel2.Controls.Add(btnBuscarEntrega);
            panel2.Controls.Add(tbBuscarEntrega);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2629, 287);
            panel2.TabIndex = 5;
            // 
            // btnRecargarEntrega
            // 
            btnRecargarEntrega.Location = new Point(1121, 124);
            btnRecargarEntrega.Name = "btnRecargarEntrega";
            btnRecargarEntrega.Size = new Size(292, 57);
            btnRecargarEntrega.TabIndex = 3;
            btnRecargarEntrega.Text = "Recargar";
            btnRecargarEntrega.UseVisualStyleBackColor = true;
            btnRecargarEntrega.Click += btnRecargarEntrega_Click;
            // 
            // btnNuevaEntrega
            // 
            btnNuevaEntrega.Location = new Point(1467, 124);
            btnNuevaEntrega.Name = "btnNuevaEntrega";
            btnNuevaEntrega.Size = new Size(394, 57);
            btnNuevaEntrega.TabIndex = 2;
            btnNuevaEntrega.Text = "Nueva Entrega";
            btnNuevaEntrega.UseVisualStyleBackColor = true;
            btnNuevaEntrega.Click += btnNuevaEntrega_Click;
            // 
            // btnBuscarEntrega
            // 
            btnBuscarEntrega.Location = new Point(648, 128);
            btnBuscarEntrega.Name = "btnBuscarEntrega";
            btnBuscarEntrega.Size = new Size(189, 57);
            btnBuscarEntrega.TabIndex = 1;
            btnBuscarEntrega.Text = "Buscar";
            btnBuscarEntrega.UseVisualStyleBackColor = true;
            btnBuscarEntrega.Click += btnBuscarEntrega_Click;
            // 
            // tbBuscarEntrega
            // 
            tbBuscarEntrega.Location = new Point(51, 134);
            tbBuscarEntrega.Name = "tbBuscarEntrega";
            tbBuscarEntrega.PlaceholderText = "Código de Entrega o Nombre de Socio...";
            tbBuscarEntrega.Size = new Size(572, 47);
            tbBuscarEntrega.TabIndex = 0;
            // 
            // tablaEntrega
            // 
            tablaEntrega.AllowUserToAddRows = false;
            tablaEntrega.AllowUserToDeleteRows = false;
            tablaEntrega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEntrega.Columns.AddRange(new DataGridViewColumn[] { EntregaID, VentaID, CodigoEntrega, Fecha, Socio, TipoSocio, Venta, Repartidor });
            tablaEntrega.Dock = DockStyle.Fill;
            tablaEntrega.Location = new Point(0, 287);
            tablaEntrega.MultiSelect = false;
            tablaEntrega.Name = "tablaEntrega";
            tablaEntrega.ReadOnly = true;
            tablaEntrega.RowHeadersWidth = 102;
            tablaEntrega.Size = new Size(2629, 1167);
            tablaEntrega.TabIndex = 6;
            tablaEntrega.DoubleClick += tablaEntrega_DoubleClick;
            // 
            // EntregaID
            // 
            EntregaID.DataPropertyName = "EntregaID";
            EntregaID.HeaderText = "ID";
            EntregaID.MinimumWidth = 12;
            EntregaID.Name = "EntregaID";
            EntregaID.ReadOnly = true;
            EntregaID.Visible = false;
            EntregaID.Width = 250;
            // 
            // VentaID
            // 
            VentaID.DataPropertyName = "VentaID";
            VentaID.HeaderText = "VentaID";
            VentaID.MinimumWidth = 12;
            VentaID.Name = "VentaID";
            VentaID.ReadOnly = true;
            VentaID.Visible = false;
            VentaID.Width = 250;
            // 
            // CodigoEntrega
            // 
            CodigoEntrega.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoEntrega.DataPropertyName = "CodigoEntrega";
            CodigoEntrega.HeaderText = "Código";
            CodigoEntrega.MinimumWidth = 12;
            CodigoEntrega.Name = "CodigoEntrega";
            CodigoEntrega.ReadOnly = true;
            CodigoEntrega.Width = 170;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 12;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 250;
            // 
            // Socio
            // 
            Socio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Socio.DataPropertyName = "Socio";
            Socio.HeaderText = "Socio";
            Socio.MinimumWidth = 12;
            Socio.Name = "Socio";
            Socio.ReadOnly = true;
            // 
            // TipoSocio
            // 
            TipoSocio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoSocio.DataPropertyName = "TipoSocio";
            TipoSocio.HeaderText = "Tipo de Socio";
            TipoSocio.MinimumWidth = 12;
            TipoSocio.Name = "TipoSocio";
            TipoSocio.ReadOnly = true;
            // 
            // Venta
            // 
            Venta.DataPropertyName = "Venta";
            Venta.HeaderText = "Venta";
            Venta.MinimumWidth = 12;
            Venta.Name = "Venta";
            Venta.ReadOnly = true;
            Venta.Width = 250;
            // 
            // Repartidor
            // 
            Repartidor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Repartidor.DataPropertyName = "Repartidor";
            Repartidor.HeaderText = "Repartidor";
            Repartidor.MinimumWidth = 12;
            Repartidor.Name = "Repartidor";
            Repartidor.ReadOnly = true;
            // 
            // Entrega
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2629, 1454);
            Controls.Add(tablaEntrega);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Entrega";
            Text = "Entrega";
            Load += Entrega_Load;
            VisibleChanged += Entrega_VisibleChanged;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaEntrega).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnRecargarEntrega;
        private Button btnNuevaEntrega;
        private Button btnBuscarEntrega;
        private TextBox tbBuscarEntrega;
        private DataGridView tablaEntrega;
        private DataGridViewTextBoxColumn EntregaID;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn CodigoEntrega;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn Repartidor;
    }
}