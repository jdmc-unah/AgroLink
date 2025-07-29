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
            panel1.Name = "panel1";
            panel1.Size = new Size(2661, 287);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRecargarSal);
            panel2.Controls.Add(btnNuevaSalProd);
            panel2.Controls.Add(btnBuscarSal);
            panel2.Controls.Add(tbBuscarSal);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2661, 287);
            panel2.TabIndex = 4;
            // 
            // btnRecargarSal
            // 
            btnRecargarSal.Location = new Point(1121, 124);
            btnRecargarSal.Name = "btnRecargarSal";
            btnRecargarSal.Size = new Size(292, 57);
            btnRecargarSal.TabIndex = 3;
            btnRecargarSal.Text = "Recargar";
            btnRecargarSal.UseVisualStyleBackColor = true;
            // 
            // btnNuevaSalProd
            // 
            btnNuevaSalProd.Location = new Point(1467, 124);
            btnNuevaSalProd.Name = "btnNuevaSalProd";
            btnNuevaSalProd.Size = new Size(394, 57);
            btnNuevaSalProd.TabIndex = 2;
            btnNuevaSalProd.Text = "Nueva Salida de Producto";
            btnNuevaSalProd.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSal
            // 
            btnBuscarSal.Location = new Point(648, 128);
            btnBuscarSal.Name = "btnBuscarSal";
            btnBuscarSal.Size = new Size(189, 57);
            btnBuscarSal.TabIndex = 1;
            btnBuscarSal.Text = "Buscar";
            btnBuscarSal.UseVisualStyleBackColor = true;
            // 
            // tbBuscarSal
            // 
            tbBuscarSal.Location = new Point(51, 134);
            tbBuscarSal.Name = "tbBuscarSal";
            tbBuscarSal.PlaceholderText = "Código de Factura o Nombre de Socio...";
            tbBuscarSal.Size = new Size(572, 47);
            tbBuscarSal.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1121, 124);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(292, 57);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Location = new Point(1467, 124);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(292, 57);
            btnNuevaFactura.TabIndex = 2;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(648, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 57);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(51, 134);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Código de Factura o Nombre de Socio...";
            tbBuscar.Size = new Size(572, 47);
            tbBuscar.TabIndex = 0;
            // 
            // tablaSalida
            // 
            tablaSalida.AllowUserToAddRows = false;
            tablaSalida.AllowUserToDeleteRows = false;
            tablaSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaSalida.Columns.AddRange(new DataGridViewColumn[] { FacturaID, CodigoFactura, Fecha, Socio, TipoSocio, ListaPrecio, MetodoPago, Estado, Total, CAI, EmpleadoID, SocioID, ListaPreciosID, NumFiscalID, VentaID });
            tablaSalida.Dock = DockStyle.Fill;
            tablaSalida.Location = new Point(0, 287);
            tablaSalida.MultiSelect = false;
            tablaSalida.Name = "tablaSalida";
            tablaSalida.ReadOnly = true;
            tablaSalida.RowHeadersWidth = 102;
            tablaSalida.Size = new Size(2661, 1255);
            tablaSalida.TabIndex = 3;
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
            // SalidaProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2661, 1542);
            Controls.Add(tablaSalida);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalidaProducto";
            Text = "SalidaProducto";
            Load += SalidaProducto_Load;
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