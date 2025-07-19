namespace AgroLink.Pantallas.Pantallas_Transacciones
{
    partial class Venta
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
            btnNuevaVenta = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaVenta = new DataGridView();
            VentaID = new DataGridViewTextBoxColumn();
            CodigoVenta = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            ListaPrecio = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaVenta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnNuevaVenta);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2768, 287);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1131, 147);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(293, 58);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(1131, 71);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(293, 58);
            btnNuevaVenta.TabIndex = 2;
            btnNuevaVenta.Text = "Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(647, 128);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(188, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(72, 134);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "VEN01.....";
            tbBuscar.Size = new Size(542, 47);
            tbBuscar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaVenta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(2768, 1225);
            panel2.TabIndex = 1;
            // 
            // tablaVenta
            // 
            tablaVenta.AllowUserToAddRows = false;
            tablaVenta.AllowUserToDeleteRows = false;
            tablaVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaVenta.Columns.AddRange(new DataGridViewColumn[] { VentaID, CodigoVenta, Fecha, Socio, TipoSocio, ListaPrecio, TipoPago, Estado, Total });
            tablaVenta.Dock = DockStyle.Fill;
            tablaVenta.Location = new Point(0, 0);
            tablaVenta.MultiSelect = false;
            tablaVenta.Name = "tablaVenta";
            tablaVenta.ReadOnly = true;
            tablaVenta.RowHeadersWidth = 102;
            tablaVenta.Size = new Size(2768, 1225);
            tablaVenta.TabIndex = 0;
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
            // Venta
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2768, 1512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Venta";
            Text = "Venta";
            Load += Venta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaVenta;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaVenta;
        private DataGridViewTextBoxColumn VentaID;
        private DataGridViewTextBoxColumn CodigoVenta;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn ListaPrecio;
        private DataGridViewTextBoxColumn TipoPago;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private Button btnRecargar;
    }
}