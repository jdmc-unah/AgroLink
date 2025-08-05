namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class BodegaDetalle
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
            lblDireccion = new Label();
            label4 = new Label();
            lblCapacidad = new Label();
            label3 = new Label();
            lblNombreBodega = new Label();
            label2 = new Label();
            lblCodigoBodega = new Label();
            label1 = new Label();
            tablaBodegaDetalle = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Comprometido = new DataGridViewTextBoxColumn();
            TotalExistencias = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            panelBotones = new Panel();
            btnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaBodegaDetalle).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCapacidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNombreBodega);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCodigoBodega);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 188);
            panel1.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = SystemColors.Window;
            lblDireccion.Location = new Point(625, 112);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 25);
            lblDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(500, 112);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 6;
            label4.Text = "Dirección:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.ForeColor = SystemColors.Window;
            lblCapacidad.Location = new Point(625, 62);
            lblCapacidad.Margin = new Padding(4, 0, 4, 0);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(0, 25);
            lblCapacidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(500, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 4;
            label3.Text = "Capacidad:";
            // 
            // lblNombreBodega
            // 
            lblNombreBodega.AutoSize = true;
            lblNombreBodega.ForeColor = SystemColors.Window;
            lblNombreBodega.Location = new Point(188, 112);
            lblNombreBodega.Margin = new Padding(4, 0, 4, 0);
            lblNombreBodega.Name = "lblNombreBodega";
            lblNombreBodega.Size = new Size(0, 25);
            lblNombreBodega.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(62, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // lblCodigoBodega
            // 
            lblCodigoBodega.AutoSize = true;
            lblCodigoBodega.ForeColor = SystemColors.Window;
            lblCodigoBodega.Location = new Point(188, 62);
            lblCodigoBodega.Margin = new Padding(4, 0, 4, 0);
            lblCodigoBodega.Name = "lblCodigoBodega";
            lblCodigoBodega.Size = new Size(0, 25);
            lblCodigoBodega.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(62, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // tablaBodegaDetalle
            // 
            tablaBodegaDetalle.AllowUserToAddRows = false;
            tablaBodegaDetalle.AllowUserToDeleteRows = false;
            tablaBodegaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaBodegaDetalle.Columns.AddRange(new DataGridViewColumn[] { Producto, Proveedor, Comprometido, TotalExistencias, Disponible });
            tablaBodegaDetalle.Dock = DockStyle.Fill;
            tablaBodegaDetalle.Location = new Point(0, 188);
            tablaBodegaDetalle.Margin = new Padding(4);
            tablaBodegaDetalle.Name = "tablaBodegaDetalle";
            tablaBodegaDetalle.ReadOnly = true;
            tablaBodegaDetalle.RowHeadersWidth = 51;
            tablaBodegaDetalle.Size = new Size(1145, 486);
            tablaBodegaDetalle.TabIndex = 1;
            // 
            // Producto
            // 
            Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producto.DataPropertyName = "Producto";
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Proveedor
            // 
            Proveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Proveedor.DataPropertyName = "Proveedor";
            Proveedor.HeaderText = "Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            Proveedor.ReadOnly = true;
            // 
            // Comprometido
            // 
            Comprometido.DataPropertyName = "Comprometido";
            Comprometido.HeaderText = "Comprometido";
            Comprometido.MinimumWidth = 250;
            Comprometido.Name = "Comprometido";
            Comprometido.ReadOnly = true;
            Comprometido.Width = 250;
            // 
            // TotalExistencias
            // 
            TotalExistencias.DataPropertyName = "TotalExistencias";
            TotalExistencias.HeaderText = "Total Existencias";
            TotalExistencias.MinimumWidth = 250;
            TotalExistencias.Name = "TotalExistencias";
            TotalExistencias.ReadOnly = true;
            TotalExistencias.Width = 250;
            // 
            // Disponible
            // 
            Disponible.DataPropertyName = "Disponible";
            Disponible.HeaderText = "Disponible";
            Disponible.MinimumWidth = 250;
            Disponible.Name = "Disponible";
            Disponible.ReadOnly = true;
            Disponible.Width = 250;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(22, 48, 43);
            panelBotones.Controls.Add(btnVolver);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 579);
            panelBotones.Margin = new Padding(4);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1145, 95);
            panelBotones.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(21, 29);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(125, 38);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // BodegaDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panelBotones);
            Controls.Add(tablaBodegaDetalle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BodegaDetalle";
            Text = "Detalle de Bodega";
            Load += BodegaDetalle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaBodegaDetalle).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDireccion;
        private Label label4;
        private Label lblCapacidad;
        private Label label3;
        private Label lblNombreBodega;
        private Label label2;
        private Label lblCodigoBodega;
        private Label label1;
        private DataGridView tablaBodegaDetalle;
        private Panel panelBotones;
        private Button btnVolver;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Comprometido;
        private DataGridViewTextBoxColumn TotalExistencias;
        private DataGridViewTextBoxColumn Disponible;
    }
}
