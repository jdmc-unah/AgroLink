namespace AgroLink.Pantallas.Pantallas_Transacciones.Pantallas_Recibo
{
    partial class Recibo
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
            btnNuevoRecibo = new Button();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            tablaRecibo = new DataGridView();
            ReciboID = new DataGridViewTextBoxColumn();
            CodigoRecibo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            ListaPrecio = new DataGridViewTextBoxColumn();
            MetodoPago = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            EmpleadoID = new DataGridViewTextBoxColumn();
            SocioID = new DataGridViewTextBoxColumn();
            ListaPreciosID = new DataGridViewTextBoxColumn();
            CompraID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaRecibo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnNuevoRecibo);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 175);
            panel1.TabIndex = 0;
            // 
            // btnNuevoRecibo
            // 
            btnNuevoRecibo.BackColor = SystemColors.Window;
            btnNuevoRecibo.Location = new Point(181, 103);
            btnNuevoRecibo.Name = "btnNuevoRecibo";
            btnNuevoRecibo.Size = new Size(187, 35);
            btnNuevoRecibo.TabIndex = 3;
            btnNuevoRecibo.Text = "Nuevo Recibo";
            btnNuevoRecibo.UseVisualStyleBackColor = false;
            btnNuevoRecibo.Click += btnNuevoRecibo_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(30, 103);
            btnRecargar.Margin = new Padding(2);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(125, 35);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.VisibleChanged += btnRecargar_VisibleChanged;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(381, 45);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 35);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(30, 48);
            tbBuscar.Margin = new Padding(2);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Código de Recibo o Nombre de Socio...";
            tbBuscar.Size = new Size(338, 31);
            tbBuscar.TabIndex = 0;
            // 
            // tablaRecibo
            // 
            tablaRecibo.AllowUserToAddRows = false;
            tablaRecibo.AllowUserToDeleteRows = false;
            tablaRecibo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaRecibo.Columns.AddRange(new DataGridViewColumn[] { ReciboID, CodigoRecibo, Fecha, Socio, TipoSocio, ListaPrecio, MetodoPago, Estado, Total, EmpleadoID, SocioID, ListaPreciosID, CompraID });
            tablaRecibo.Dock = DockStyle.Fill;
            tablaRecibo.Location = new Point(0, 175);
            tablaRecibo.Name = "tablaRecibo";
            tablaRecibo.ReadOnly = true;
            tablaRecibo.RowHeadersWidth = 62;
            tablaRecibo.Size = new Size(1145, 499);
            tablaRecibo.TabIndex = 1;
            tablaRecibo.CellDoubleClick += tablaRecibo_CellDoubleClick;
            // 
            // ReciboID
            // 
            ReciboID.DataPropertyName = "ReciboID";
            ReciboID.HeaderText = "ID";
            ReciboID.MinimumWidth = 12;
            ReciboID.Name = "ReciboID";
            ReciboID.ReadOnly = true;
            ReciboID.Visible = false;
            ReciboID.Width = 250;
            // 
            // CodigoRecibo
            // 
            CodigoRecibo.DataPropertyName = "CodigoRecibo";
            CodigoRecibo.HeaderText = "Código";
            CodigoRecibo.MinimumWidth = 12;
            CodigoRecibo.Name = "CodigoRecibo";
            CodigoRecibo.ReadOnly = true;
            CodigoRecibo.Width = 250;
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
            TipoSocio.MinimumWidth = 300;
            TipoSocio.Name = "TipoSocio";
            TipoSocio.ReadOnly = true;
            TipoSocio.Width = 300;
            // 
            // ListaPrecio
            // 
            ListaPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ListaPrecio.DataPropertyName = "ListaPrecio";
            ListaPrecio.HeaderText = "Lista de Precios";
            ListaPrecio.MinimumWidth = 12;
            ListaPrecio.Name = "ListaPrecio";
            ListaPrecio.ReadOnly = true;
            // 
            // MetodoPago
            // 
            MetodoPago.DataPropertyName = "MetodoPago";
            MetodoPago.HeaderText = "Metodo de Pago";
            MetodoPago.MinimumWidth = 300;
            MetodoPago.Name = "MetodoPago";
            MetodoPago.ReadOnly = true;
            MetodoPago.Width = 300;
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
            // CompraID
            // 
            CompraID.DataPropertyName = "CompraID";
            CompraID.HeaderText = "CompraID";
            CompraID.MinimumWidth = 12;
            CompraID.Name = "CompraID";
            CompraID.ReadOnly = true;
            CompraID.Visible = false;
            CompraID.Width = 250;
            // 
            // Recibo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(tablaRecibo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recibo";
            Text = "Recibo";
            Load += Recibo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaRecibo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbBuscar;
        private DataGridView tablaRecibo;
        private Button btnNuevoRecibo;
        private Button btnRecargar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn ReciboID;
        private DataGridViewTextBoxColumn CodigoRecibo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn ListaPrecio;
        private DataGridViewTextBoxColumn MetodoPago;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn EmpleadoID;
        private DataGridViewTextBoxColumn SocioID;
        private DataGridViewTextBoxColumn ListaPreciosID;
        private DataGridViewTextBoxColumn CompraID;
    }
}