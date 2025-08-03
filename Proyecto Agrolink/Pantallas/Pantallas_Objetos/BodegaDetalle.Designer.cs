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
            this.panel1 = new Panel();
            this.lblDireccion = new Label();
            this.label4 = new Label();
            this.lblCapacidad = new Label();
            this.label3 = new Label();
            this.lblNombreBodega = new Label();
            this.label2 = new Label();
            this.lblCodigoBodega = new Label();
            this.label1 = new Label();
            this.tablaBodegaDetalle = new DataGridView();
            this.Producto = new DataGridViewTextBoxColumn();
            this.Proveedor = new DataGridViewTextBoxColumn();
            this.Comprometido = new DataGridViewTextBoxColumn();
            this.TotalExistencias = new DataGridViewTextBoxColumn();
            this.Disponible = new DataGridViewTextBoxColumn();
            this.panelBotones = new Panel();
            this.btnVolver = new Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBodegaDetalle)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCapacidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNombreBodega);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCodigoBodega);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(800, 150);
            this.panel1.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new Point(500, 90);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new Size(0, 20);
            this.lblDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new Point(400, 90);
            this.label4.Name = "label4";
            this.label4.Size = new Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new Point(500, 50);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new Size(0, 20);
            this.lblCapacidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(400, 50);
            this.label3.Name = "label3";
            this.label3.Size = new Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacidad:";
            // 
            // lblNombreBodega
            // 
            this.lblNombreBodega.AutoSize = true;
            this.lblNombreBodega.Location = new Point(150, 90);
            this.lblNombreBodega.Name = "lblNombreBodega";
            this.lblNombreBodega.Size = new Size(0, 20);
            this.lblNombreBodega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // lblCodigoBodega
            // 
            this.lblCodigoBodega.AutoSize = true;
            this.lblCodigoBodega.Location = new Point(150, 50);
            this.lblCodigoBodega.Name = "lblCodigoBodega";
            this.lblCodigoBodega.Size = new Size(0, 20);
            this.lblCodigoBodega.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tablaBodegaDetalle
            // 
            this.tablaBodegaDetalle.AllowUserToAddRows = false;
            this.tablaBodegaDetalle.AllowUserToDeleteRows = false;
            this.tablaBodegaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaBodegaDetalle.Columns.AddRange(new DataGridViewColumn[] {
            this.Producto,
            this.Proveedor,
            this.Comprometido,
            this.TotalExistencias,
            this.Disponible});
            this.tablaBodegaDetalle.Dock = DockStyle.Fill;
            this.tablaBodegaDetalle.Location = new Point(0, 150);
            this.tablaBodegaDetalle.Name = "tablaBodegaDetalle";
            this.tablaBodegaDetalle.ReadOnly = true;
            this.tablaBodegaDetalle.RowHeadersWidth = 51;
            this.tablaBodegaDetalle.Size = new Size(800, 250);
            this.tablaBodegaDetalle.TabIndex = 1;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 180;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "Proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 150;
            // 
            // Comprometido
            // 
            this.Comprometido.DataPropertyName = "Comprometido";
            this.Comprometido.HeaderText = "Comprometido";
            this.Comprometido.MinimumWidth = 6;
            this.Comprometido.Name = "Comprometido";
            this.Comprometido.ReadOnly = true;
            this.Comprometido.Width = 125;
            // 
            // TotalExistencias
            // 
            this.TotalExistencias.DataPropertyName = "TotalExistencias";
            this.TotalExistencias.HeaderText = "Total Existencias";
            this.TotalExistencias.MinimumWidth = 6;
            this.TotalExistencias.Name = "TotalExistencias";
            this.TotalExistencias.ReadOnly = true;
            this.TotalExistencias.Width = 125;
            // 
            // Disponible
            // 
            this.Disponible.DataPropertyName = "Disponible";
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.MinimumWidth = 6;
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            this.Disponible.Width = 125;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnVolver);
            this.panelBotones.Dock = DockStyle.Bottom;
            this.panelBotones.Location = new Point(0, 400);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new Size(800, 300);
            this.panelBotones.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new Point(10, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new Size(100, 30);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new EventHandler(this.btnVolver_Click);
            // 
            // BodegaDetalle
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.tablaBodegaDetalle);
            this.Controls.Add(this.panel1);
            this.Name = "BodegaDetalle";
            this.Text = "Detalle de Bodega";
            this.Load += new EventHandler(this.BodegaDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaBodegaDetalle)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Comprometido;
        private DataGridViewTextBoxColumn TotalExistencias;
        private DataGridViewTextBoxColumn Disponible;
        private Panel panelBotones;
        private Button btnVolver;
    }
}
