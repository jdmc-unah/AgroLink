namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Compra
{
    partial class Compra
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
            tbBuscarCompra = new TextBox();
            btnRecargarCompra = new Button();
            btnBuscarCompra = new Button();
            btnNuevaCompra = new Button();
            tablaCompra = new DataGridView();
            CompraID = new DataGridViewTextBoxColumn();
            SocioID = new DataGridViewTextBoxColumn();
            ListaPreciosID = new DataGridViewTextBoxColumn();
            CodigoCompra = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            ListaPrecio = new DataGridViewTextBoxColumn();
            TipoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompra).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbBuscarCompra);
            panel1.Controls.Add(btnRecargarCompra);
            panel1.Controls.Add(btnBuscarCompra);
            panel1.Controls.Add(btnNuevaCompra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1584, 175);
            panel1.TabIndex = 0;
            // 
            // tbBuscarCompra
            // 
            tbBuscarCompra.Location = new Point(30, 82);
            tbBuscarCompra.Margin = new Padding(2);
            tbBuscarCompra.Name = "tbBuscarCompra";
            tbBuscarCompra.PlaceholderText = "Código de Compra o Nombre de Socio...";
            tbBuscarCompra.Size = new Size(338, 31);
            tbBuscarCompra.TabIndex = 0;
            // 
            // btnRecargarCompra
            // 
            btnRecargarCompra.Location = new Point(665, 90);
            btnRecargarCompra.Margin = new Padding(2);
            btnRecargarCompra.Name = "btnRecargarCompra";
            btnRecargarCompra.Size = new Size(172, 35);
            btnRecargarCompra.TabIndex = 3;
            btnRecargarCompra.Text = "Recargar";
            btnRecargarCompra.UseVisualStyleBackColor = true;
            btnRecargarCompra.Click += btnRecargarCompra_Click;
            // 
            // btnBuscarCompra
            // 
            btnBuscarCompra.Location = new Point(381, 78);
            btnBuscarCompra.Margin = new Padding(2);
            btnBuscarCompra.Name = "btnBuscarCompra";
            btnBuscarCompra.Size = new Size(111, 35);
            btnBuscarCompra.TabIndex = 1;
            btnBuscarCompra.Text = "Buscar";
            btnBuscarCompra.UseVisualStyleBackColor = true;
            btnBuscarCompra.Click += btnBuscarCompra_Click;
            // 
            // btnNuevaCompra
            // 
            btnNuevaCompra.Location = new Point(665, 43);
            btnNuevaCompra.Margin = new Padding(2);
            btnNuevaCompra.Name = "btnNuevaCompra";
            btnNuevaCompra.Size = new Size(172, 35);
            btnNuevaCompra.TabIndex = 2;
            btnNuevaCompra.Text = "Nueva Compra";
            btnNuevaCompra.UseVisualStyleBackColor = true;
            // 
            // tablaCompra
            // 
            tablaCompra.AllowUserToAddRows = false;
            tablaCompra.AllowUserToDeleteRows = false;
            tablaCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaCompra.Columns.AddRange(new DataGridViewColumn[] { CompraID, SocioID, ListaPreciosID, CodigoCompra, Fecha, Socio, TipoSocio, ListaPrecio, TipoPago, Estado, Total });
            tablaCompra.Dock = DockStyle.Fill;
            tablaCompra.Location = new Point(0, 175);
            tablaCompra.Margin = new Padding(2);
            tablaCompra.MultiSelect = false;
            tablaCompra.Name = "tablaCompra";
            tablaCompra.ReadOnly = true;
            tablaCompra.RowHeadersWidth = 102;
            tablaCompra.Size = new Size(1584, 819);
            tablaCompra.TabIndex = 0;
            tablaCompra.CellDoubleClick += tablaCompra_CellDoubleClick;
            // 
            // CompraID
            // 
            CompraID.HeaderText = "ID";
            CompraID.MinimumWidth = 12;
            CompraID.Name = "CompraID";
            CompraID.ReadOnly = true;
            CompraID.Visible = false;
            CompraID.Width = 250;
            // 
            // SocioID
            // 
            SocioID.HeaderText = "SocioID";
            SocioID.MinimumWidth = 12;
            SocioID.Name = "SocioID";
            SocioID.ReadOnly = true;
            SocioID.Visible = false;
            SocioID.Width = 150;
            // 
            // ListaPreciosID
            // 
            ListaPreciosID.HeaderText = "ListaPreciosID";
            ListaPreciosID.MinimumWidth = 12;
            ListaPreciosID.Name = "ListaPreciosID";
            ListaPreciosID.ReadOnly = true;
            ListaPreciosID.Visible = false;
            ListaPreciosID.Width = 250;
            // 
            // CodigoCompra
            // 
            CodigoCompra.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoCompra.HeaderText = "Código";
            CodigoCompra.MinimumWidth = 12;
            CodigoCompra.Name = "CodigoCompra";
            CodigoCompra.ReadOnly = true;
            CodigoCompra.Width = 107;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 12;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 250;
            // 
            // Socio
            // 
            Socio.HeaderText = "Socio";
            Socio.MinimumWidth = 150;
            Socio.Name = "Socio";
            Socio.ReadOnly = true;
            Socio.Width = 150;
            // 
            // TipoSocio
            // 
            TipoSocio.HeaderText = "Tipo de Socio";
            TipoSocio.MinimumWidth = 12;
            TipoSocio.Name = "TipoSocio";
            TipoSocio.ReadOnly = true;
            TipoSocio.Width = 250;
            // 
            // ListaPrecio
            // 
            ListaPrecio.HeaderText = "Lista de Precios";
            ListaPrecio.MinimumWidth = 12;
            ListaPrecio.Name = "ListaPrecio";
            ListaPrecio.ReadOnly = true;
            ListaPrecio.Width = 300;
            // 
            // TipoPago
            // 
            TipoPago.HeaderText = "Tipo de Pago";
            TipoPago.MinimumWidth = 12;
            TipoPago.Name = "TipoPago";
            TipoPago.ReadOnly = true;
            TipoPago.Width = 250;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 12;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 250;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 12;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 250;
            // 
            // Compra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 994);
            Controls.Add(tablaCompra);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compra";
            Text = "Compra";
            Load += Compra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCompra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView tablaCompra;
        private Button btnNuevaCompra;
        private Button btnRecargarCompra;
        private Button btnBuscarCompra;
        private TextBox tbBuscarCompra;
        private DataGridViewTextBoxColumn CompraID;
        private DataGridViewTextBoxColumn SocioID;
        private DataGridViewTextBoxColumn ListaPreciosID;
        private DataGridViewTextBoxColumn CodigoCompra;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn ListaPrecio;
        private DataGridViewTextBoxColumn TipoPago;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
    }
}