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
            panelBotones = new Panel();
            btnVolver = new Button();
            Producto = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Comprometido = new DataGridViewTextBoxColumn();
            TotalExistencias = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaBodegaDetalle).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1700, 308);
            panel1.TabIndex = 0;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(1062, 184);
            lblDireccion.Margin = new Padding(6, 0, 6, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(0, 41);
            lblDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(850, 184);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 41);
            label4.TabIndex = 6;
            label4.Text = "Dirección:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(1062, 102);
            lblCapacidad.Margin = new Padding(6, 0, 6, 0);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(0, 41);
            lblCapacidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(850, 102);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 41);
            label3.TabIndex = 4;
            label3.Text = "Capacidad:";
            // 
            // lblNombreBodega
            // 
            lblNombreBodega.AutoSize = true;
            lblNombreBodega.Location = new Point(319, 184);
            lblNombreBodega.Margin = new Padding(6, 0, 6, 0);
            lblNombreBodega.Name = "lblNombreBodega";
            lblNombreBodega.Size = new Size(0, 41);
            lblNombreBodega.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 184);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // lblCodigoBodega
            // 
            lblCodigoBodega.AutoSize = true;
            lblCodigoBodega.Location = new Point(319, 102);
            lblCodigoBodega.Margin = new Padding(6, 0, 6, 0);
            lblCodigoBodega.Name = "lblCodigoBodega";
            lblCodigoBodega.Size = new Size(0, 41);
            lblCodigoBodega.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 102);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
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
            tablaBodegaDetalle.Location = new Point(0, 308);
            tablaBodegaDetalle.Margin = new Padding(6);
            tablaBodegaDetalle.Name = "tablaBodegaDetalle";
            tablaBodegaDetalle.ReadOnly = true;
            tablaBodegaDetalle.RowHeadersWidth = 51;
            tablaBodegaDetalle.Size = new Size(1700, 614);
            tablaBodegaDetalle.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnVolver);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 767);
            panelBotones.Margin = new Padding(6);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1700, 155);
            panelBotones.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(36, 47);
            btnVolver.Margin = new Padding(6);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(212, 62);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
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
            // BodegaDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 922);
            Controls.Add(panelBotones);
            Controls.Add(tablaBodegaDetalle);
            Controls.Add(panel1);
            Margin = new Padding(6);
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
