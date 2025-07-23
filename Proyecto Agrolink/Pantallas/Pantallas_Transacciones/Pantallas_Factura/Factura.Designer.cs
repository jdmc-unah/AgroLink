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
            tablaVenta = new DataGridView();
            VentaID = new DataGridViewTextBoxColumn();
            SocioID = new DataGridViewTextBoxColumn();
            ListaPreciosID = new DataGridViewTextBoxColumn();
            CodigoVenta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            ListaPrecio = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaVenta).BeginInit();
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
            tbBuscar.PlaceholderText = "Código de Venta o Nombre de Socio...";
            tbBuscar.Size = new Size(572, 47);
            tbBuscar.TabIndex = 0;
            // 
            // tablaVenta
            // 
            tablaVenta.AllowUserToAddRows = false;
            tablaVenta.AllowUserToDeleteRows = false;
            tablaVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaVenta.Columns.AddRange(new DataGridViewColumn[] { VentaID, SocioID, ListaPreciosID, CodigoVenta, Fecha, Socio, TipoSocio, ListaPrecio, TipoPago, Estado, Total });
            tablaVenta.Dock = DockStyle.Fill;
            tablaVenta.Location = new Point(0, 287);
            tablaVenta.MultiSelect = false;
            tablaVenta.Name = "tablaVenta";
            tablaVenta.ReadOnly = true;
            tablaVenta.RowHeadersWidth = 102;
            tablaVenta.Size = new Size(2693, 1343);
            tablaVenta.TabIndex = 2;
            // 
            // VentaID
            // 
            VentaID.DataPropertyName = "VentaID";
            VentaID.HeaderText = "ID";
            VentaID.MinimumWidth = 12;
            VentaID.Name = "VentaID";
            VentaID.ReadOnly = true;
            VentaID.Visible = false;
            VentaID.Width = 250;
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
            // CodigoVenta
            // 
            CodigoVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoVenta.DataPropertyName = "CodigoVenta";
            CodigoVenta.HeaderText = "Código";
            CodigoVenta.MinimumWidth = 12;
            CodigoVenta.Name = "CodigoVenta";
            CodigoVenta.ReadOnly = true;
            CodigoVenta.Width = 170;
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
            // TipoPago
            // 
            TipoPago.DataPropertyName = "TipoPago";
            TipoPago.HeaderText = "Tipo de Pago";
            TipoPago.MinimumWidth = 12;
            TipoPago.Name = "TipoPago";
            TipoPago.ReadOnly = true;
            TipoPago.Width = 250;
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
            // Factura
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2693, 1630);
            Controls.Add(tablaVenta);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Text = "Factura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnNuevaFactura;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private DataGridView tablaVenta;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn SocioID;
        private DataGridViewTextBoxColumn ListaPreciosID;
        private DataGridViewTextBoxColumn CodigoVenta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn ListaPrecio;
        private DataGridViewTextBoxColumn TipoPago;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
    }
}