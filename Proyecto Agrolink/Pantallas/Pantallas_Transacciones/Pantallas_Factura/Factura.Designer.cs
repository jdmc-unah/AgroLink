namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Factura
{
    partial class Factura
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
            btnRecargar = new Button();
            btnNuevaFactura = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            tablaFactura = new DataGridView();
            FacturaID = new DataGridViewTextBoxColumn();
            CodigoFactura = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            ListaPrecio = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            CAI = new DataGridViewTextBoxColumn();
            EmpleadoID = new DataGridViewTextBoxColumn();
            SocioID = new DataGridViewTextBoxColumn();
            ListaPreciosID = new DataGridViewTextBoxColumn();
            NumFiscalID = new DataGridViewTextBoxColumn();
            VentaID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaFactura).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnNuevaFactura);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2693, 287);
            panel1.TabIndex = 1;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1121, 124);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(292, 57);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Location = new Point(1467, 124);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(292, 57);
            btnNuevaFactura.TabIndex = 2;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            btnNuevaFactura.Click += btnNuevaFactura_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(648, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 57);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(51, 134);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Código de Venta o Nombre de Socio...";
            tbBuscar.Size = new Size(572, 47);
            tbBuscar.TabIndex = 0;
            // 
            // tablaFactura
            // 
            tablaFactura.AllowUserToAddRows = false;
            tablaFactura.AllowUserToDeleteRows = false;
            tablaFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaFactura.Columns.AddRange(new DataGridViewColumn[] { FacturaID, CodigoFactura, Fecha, Socio, TipoSocio, ListaPrecio, MetodoPago, Estado, Total, CAI, EmpleadoID, SocioID, ListaPreciosID, NumFiscalID, VentaID });
            tablaFactura.Dock = DockStyle.Fill;
            tablaFactura.Location = new Point(0, 287);
            tablaFactura.MultiSelect = false;
            tablaFactura.Name = "tablaFactura";
            tablaFactura.ReadOnly = true;
            tablaFactura.RowHeadersWidth = 102;
            tablaFactura.Size = new Size(2693, 1343);
            tablaFactura.TabIndex = 2;
            tablaFactura.DoubleClick += tablaFactura_DoubleClick;
            // 
            // FacturaID
            // 
            FacturaID.DataPropertyName = "FacturaID";
            FacturaID.HeaderText = "ID";
            FacturaID.MinimumWidth = 12;
            FacturaID.Name = "FacturaID";
            FacturaID.ReadOnly = true;
            FacturaID.Visible = false;
            FacturaID.Width = 250;
            // 
            // CodigoFactura
            // 
            CodigoFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoFactura.DataPropertyName = "CodigoFactura";
            CodigoFactura.HeaderText = "Código";
            CodigoFactura.MinimumWidth = 12;
            CodigoFactura.Name = "CodigoFactura";
            CodigoFactura.ReadOnly = true;
            CodigoFactura.Width = 170;
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
            TipoSocio.DataPropertyName = "TipoSocio";
            TipoSocio.HeaderText = "Tipo de Socio";
            TipoSocio.MinimumWidth = 12;
            TipoSocio.Name = "TipoSocio";
            TipoSocio.ReadOnly = true;
            TipoSocio.Width = 250;
            // 
            // ListaPrecio
            // 
            ListaPrecio.DataPropertyName = "ListaPrecio";
            ListaPrecio.HeaderText = "Lista de Precios";
            ListaPrecio.MinimumWidth = 12;
            ListaPrecio.Name = "ListaPrecio";
            ListaPrecio.ReadOnly = true;
            ListaPrecio.Width = 300;
            // 
            // MetodoPago
            // 
            MetodoPago.DataPropertyName = "MetodoPago";
            MetodoPago.HeaderText = "Metodo de Pago";
            MetodoPago.MinimumWidth = 12;
            MetodoPago.Name = "MetodoPago";
            MetodoPago.ReadOnly = true;
            MetodoPago.Width = 250;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 12;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 250;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // CAI
            // 
            CAI.DataPropertyName = "CAI";
            CAI.HeaderText = "CAI";
            CAI.MinimumWidth = 12;
            CAI.Name = "CAI";
            CAI.ReadOnly = true;
            CAI.Visible = false;
            CAI.Width = 250;
            // 
            // EmpleadoID
            // 
            EmpleadoID.DataPropertyName = "EmpleadoID";
            EmpleadoID.HeaderText = "EmpleadoID";
            EmpleadoID.MinimumWidth = 12;
            EmpleadoID.Name = "EmpleadoID";
            EmpleadoID.ReadOnly = true;
            EmpleadoID.Visible = false;
            EmpleadoID.Width = 250;
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
            // ListaPreciosID
            // 
            ListaPreciosID.DataPropertyName = "ListaPreciosID";
            ListaPreciosID.HeaderText = "ListaPreciosID";
            ListaPreciosID.MinimumWidth = 12;
            ListaPreciosID.Name = "ListaPreciosID";
            ListaPreciosID.ReadOnly = true;
            ListaPreciosID.Visible = false;
            ListaPreciosID.Width = 250;
            // 
            // NumFiscalID
            // 
            NumFiscalID.DataPropertyName = "NumFiscalID";
            NumFiscalID.HeaderText = "NumFiscalID";
            NumFiscalID.MinimumWidth = 12;
            NumFiscalID.Name = "NumFiscalID";
            NumFiscalID.ReadOnly = true;
            NumFiscalID.Visible = false;
            NumFiscalID.Width = 250;
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
            // Factura
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2693, 1630);
            Controls.Add(tablaFactura);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Text = "Factura";
            Load += Factura_Load;
            VisibleChanged += Factura_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnNuevaFactura;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private DataGridView tablaFactura;
        private DataGridViewTextBoxColumn FacturaID;
        private DataGridViewTextBoxColumn CodigoFactura;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn ListaPrecio;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn CAI;
        private DataGridViewTextBoxColumn EmpleadoID;
        private DataGridViewTextBoxColumn SocioID;
        private DataGridViewTextBoxColumn ListaPreciosID;
        private DataGridViewTextBoxColumn NumFiscalID;
        private DataGridViewTextBoxColumn VentaID;
    }
}