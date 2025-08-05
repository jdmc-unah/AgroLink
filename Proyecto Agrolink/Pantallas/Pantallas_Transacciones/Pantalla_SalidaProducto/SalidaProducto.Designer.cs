namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantalla_SalidaProducto
{
    partial class SalidaProducto
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnRecargarSal = new Button();
            btnNuevaSalProd = new Button();
            btnBuscarSal = new Button();
            tbBuscarSal = new TextBox();
            btnRecargar = new Button();
            btnNuevaFactura = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            tablaSalida = new DataGridView();
            SalidaID = new DataGridViewTextBoxColumn();
            CodigoSalida = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            Venta = new DataGridViewTextBoxColumn();
            BodegaDestino = new DataGridViewTextBoxColumn();
            SocioID = new DataGridViewTextBoxColumn();
            VentaID = new DataGridViewTextBoxColumn();
            BodegaDestinoID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSalida).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnNuevaFactura);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 175);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 48, 43);
            panel2.Controls.Add(btnRecargarSal);
            panel2.Controls.Add(btnNuevaSalProd);
            panel2.Controls.Add(btnBuscarSal);
            panel2.Controls.Add(tbBuscarSal);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 175);
            panel2.TabIndex = 4;
            // 
            // btnRecargarSal
            // 
            btnRecargarSal.BackColor = SystemColors.Window;
            btnRecargarSal.Location = new Point(30, 104);
            btnRecargarSal.Margin = new Padding(2);
            btnRecargarSal.Name = "btnRecargarSal";
            btnRecargarSal.Size = new Size(114, 35);
            btnRecargarSal.TabIndex = 3;
            btnRecargarSal.Text = "Recargar";
            btnRecargarSal.UseVisualStyleBackColor = false;
            btnRecargarSal.Click += btnRecargarSal_Click;
            // 
            // btnNuevaSalProd
            // 
            btnNuevaSalProd.BackColor = SystemColors.Window;
            btnNuevaSalProd.Location = new Point(160, 104);
            btnNuevaSalProd.Margin = new Padding(2);
            btnNuevaSalProd.Name = "btnNuevaSalProd";
            btnNuevaSalProd.Size = new Size(238, 35);
            btnNuevaSalProd.TabIndex = 2;
            btnNuevaSalProd.Text = "Nueva Salida de Producto";
            btnNuevaSalProd.UseVisualStyleBackColor = false;
            btnNuevaSalProd.Click += btnNuevaSalProd_Click;
            // 
            // btnBuscarSal
            // 
            btnBuscarSal.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscarSal.FlatStyle = FlatStyle.Popup;
            btnBuscarSal.Location = new Point(411, 47);
            btnBuscarSal.Margin = new Padding(2);
            btnBuscarSal.Name = "btnBuscarSal";
            btnBuscarSal.Size = new Size(111, 35);
            btnBuscarSal.TabIndex = 1;
            btnBuscarSal.Text = "Buscar";
            btnBuscarSal.UseVisualStyleBackColor = false;
            btnBuscarSal.Click += btnBuscarSal_Click;
            // 
            // tbBuscarSal
            // 
            tbBuscarSal.Location = new Point(30, 49);
            tbBuscarSal.Margin = new Padding(2);
            tbBuscarSal.Name = "tbBuscarSal";
            tbBuscarSal.PlaceholderText = "Código de Salida o Nombre de Socio...";
            tbBuscarSal.Size = new Size(368, 31);
            tbBuscarSal.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(659, 76);
            btnRecargar.Margin = new Padding(2);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(172, 35);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Location = new Point(863, 76);
            btnNuevaFactura.Margin = new Padding(2);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(172, 35);
            btnNuevaFactura.TabIndex = 2;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(381, 78);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(30, 82);
            tbBuscar.Margin = new Padding(2);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Código de Factura o Nombre de Socio...";
            tbBuscar.Size = new Size(338, 31);
            tbBuscar.TabIndex = 0;
            // 
            // tablaSalida
            // 
            tablaSalida.AllowUserToAddRows = false;
            tablaSalida.AllowUserToDeleteRows = false;
            tablaSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSalida.Columns.AddRange(new DataGridViewColumn[] { SalidaID, CodigoSalida, Fecha, Socio, TipoSocio, Venta, BodegaDestino, SocioID, VentaID, BodegaDestinoID });
            tablaSalida.Dock = DockStyle.Fill;
            tablaSalida.Location = new Point(0, 175);
            tablaSalida.Margin = new Padding(2);
            tablaSalida.MultiSelect = false;
            tablaSalida.Name = "tablaSalida";
            tablaSalida.ReadOnly = true;
            tablaSalida.RowHeadersWidth = 102;
            tablaSalida.Size = new Size(1145, 499);
            tablaSalida.TabIndex = 3;
            tablaSalida.DoubleClick += tablaSalida_DoubleClick;
            // 
            // SalidaID
            // 
            SalidaID.DataPropertyName = "SalidaID";
            SalidaID.HeaderText = "ID";
            SalidaID.MinimumWidth = 12;
            SalidaID.Name = "SalidaID";
            SalidaID.ReadOnly = true;
            SalidaID.Visible = false;
            SalidaID.Width = 250;
            // 
            // CodigoSalida
            // 
            CodigoSalida.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoSalida.DataPropertyName = "CodigoSalida";
            CodigoSalida.HeaderText = "Código";
            CodigoSalida.MinimumWidth = 12;
            CodigoSalida.Name = "CodigoSalida";
            CodigoSalida.ReadOnly = true;
            CodigoSalida.Width = 107;
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
            // BodegaDestino
            // 
            BodegaDestino.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BodegaDestino.DataPropertyName = "BodegaDestino";
            BodegaDestino.HeaderText = "BodegaDestino";
            BodegaDestino.MinimumWidth = 12;
            BodegaDestino.Name = "BodegaDestino";
            BodegaDestino.ReadOnly = true;
            // 
            // SocioID
            // 
            SocioID.DataPropertyName = "SocioID";
            SocioID.HeaderText = "SocioID";
            SocioID.MinimumWidth = 12;
            SocioID.Name = "SocioID";
            SocioID.ReadOnly = true;
            SocioID.Visible = false;
            SocioID.Width = 250;
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
            // BodegaDestinoID
            // 
            BodegaDestinoID.DataPropertyName = "BodegaDestinoID";
            BodegaDestinoID.HeaderText = "BodegaDestinoID";
            BodegaDestinoID.MinimumWidth = 12;
            BodegaDestinoID.Name = "BodegaDestinoID";
            BodegaDestinoID.ReadOnly = true;
            BodegaDestinoID.Visible = false;
            BodegaDestinoID.Width = 250;
            // 
            // SalidaProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(tablaSalida);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SalidaProducto";
            Text = "SalidaProducto";
            Load += SalidaProducto_Load;
            VisibleChanged += SalidaProducto_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaSalida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnRecargarSal;
        private Button btnNuevaSalProd;
        private Button btnBuscarSal;
        private TextBox tbBuscarSal;
        private Button btnRecargar;
        private Button btnNuevaFactura;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private DataGridView tablaSalida;
        private DataGridViewTextBoxColumn SalidaID;
        private DataGridViewTextBoxColumn CodigoSalida;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn Venta;
        private DataGridViewTextBoxColumn BodegaDestino;
        private DataGridViewTextBoxColumn SocioID;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn BodegaDestinoID;
    }
}