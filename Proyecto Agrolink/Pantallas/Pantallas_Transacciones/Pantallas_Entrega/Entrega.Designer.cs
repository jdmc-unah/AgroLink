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
            SalidaID = new DataGridViewTextBoxColumn();
            CodigoEntrega = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Socio = new DataGridViewTextBoxColumn();
            TipoSocio = new DataGridViewTextBoxColumn();
            Salida = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaEntrega).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 48, 43);
            panel2.Controls.Add(btnRecargarEntrega);
            panel2.Controls.Add(btnNuevaEntrega);
            panel2.Controls.Add(btnBuscarEntrega);
            panel2.Controls.Add(tbBuscarEntrega);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1145, 175);
            panel2.TabIndex = 5;
            // 
            // btnRecargarEntrega
            // 
            btnRecargarEntrega.BackColor = SystemColors.Window;
            btnRecargarEntrega.Location = new Point(34, 106);
            btnRecargarEntrega.Margin = new Padding(2);
            btnRecargarEntrega.Name = "btnRecargarEntrega";
            btnRecargarEntrega.Size = new Size(116, 35);
            btnRecargarEntrega.TabIndex = 3;
            btnRecargarEntrega.Text = "Recargar";
            btnRecargarEntrega.UseVisualStyleBackColor = false;
            btnRecargarEntrega.Click += btnRecargarEntrega_Click;
            // 
            // btnNuevaEntrega
            // 
            btnNuevaEntrega.BackColor = SystemColors.Window;
            btnNuevaEntrega.Location = new Point(165, 106);
            btnNuevaEntrega.Margin = new Padding(2);
            btnNuevaEntrega.Name = "btnNuevaEntrega";
            btnNuevaEntrega.Size = new Size(207, 35);
            btnNuevaEntrega.TabIndex = 2;
            btnNuevaEntrega.Text = "Nueva Entrega";
            btnNuevaEntrega.UseVisualStyleBackColor = false;
            btnNuevaEntrega.Click += btnNuevaEntrega_Click;
            // 
            // btnBuscarEntrega
            // 
            btnBuscarEntrega.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscarEntrega.FlatStyle = FlatStyle.Popup;
            btnBuscarEntrega.Location = new Point(385, 50);
            btnBuscarEntrega.Margin = new Padding(2);
            btnBuscarEntrega.Name = "btnBuscarEntrega";
            btnBuscarEntrega.Size = new Size(111, 35);
            btnBuscarEntrega.TabIndex = 1;
            btnBuscarEntrega.Text = "Buscar";
            btnBuscarEntrega.UseVisualStyleBackColor = false;
            btnBuscarEntrega.Click += btnBuscarEntrega_Click;
            // 
            // tbBuscarEntrega
            // 
            tbBuscarEntrega.Location = new Point(34, 52);
            tbBuscarEntrega.Margin = new Padding(2);
            tbBuscarEntrega.Name = "tbBuscarEntrega";
            tbBuscarEntrega.PlaceholderText = "Código de Entrega o Nombre de Socio...";
            tbBuscarEntrega.Size = new Size(338, 31);
            tbBuscarEntrega.TabIndex = 0;
            // 
            // tablaEntrega
            // 
            tablaEntrega.AllowUserToAddRows = false;
            tablaEntrega.AllowUserToDeleteRows = false;
            tablaEntrega.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEntrega.Columns.AddRange(new DataGridViewColumn[] { EntregaID, SalidaID, CodigoEntrega, Fecha, Socio, TipoSocio, Salida, Repartidor });
            tablaEntrega.Dock = DockStyle.Fill;
            tablaEntrega.Location = new Point(0, 175);
            tablaEntrega.Margin = new Padding(2);
            tablaEntrega.MultiSelect = false;
            tablaEntrega.Name = "tablaEntrega";
            tablaEntrega.ReadOnly = true;
            tablaEntrega.RowHeadersWidth = 102;
            tablaEntrega.Size = new Size(1145, 499);
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
            // SalidaID
            // 
            SalidaID.DataPropertyName = "SalidaID";
            SalidaID.HeaderText = "SalidaID";
            SalidaID.MinimumWidth = 12;
            SalidaID.Name = "SalidaID";
            SalidaID.ReadOnly = true;
            SalidaID.Visible = false;
            SalidaID.Width = 250;
            // 
            // CodigoEntrega
            // 
            CodigoEntrega.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CodigoEntrega.DataPropertyName = "CodigoEntrega";
            CodigoEntrega.HeaderText = "Código";
            CodigoEntrega.MinimumWidth = 12;
            CodigoEntrega.Name = "CodigoEntrega";
            CodigoEntrega.ReadOnly = true;
            CodigoEntrega.Width = 107;
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
            // Salida
            // 
            Salida.DataPropertyName = "Salida";
            Salida.HeaderText = "Salida";
            Salida.MinimumWidth = 12;
            Salida.Name = "Salida";
            Salida.ReadOnly = true;
            Salida.Width = 250;
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(tablaEntrega);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private DataGridViewTextBoxColumn SalidaID;
        private DataGridViewTextBoxColumn CodigoEntrega;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Socio;
        private DataGridViewTextBoxColumn TipoSocio;
        private DataGridViewTextBoxColumn Salida;
        private DataGridViewTextBoxColumn Repartidor;
    }
}