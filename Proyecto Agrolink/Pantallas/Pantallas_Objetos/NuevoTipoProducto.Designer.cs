namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class NuevoTipoProducto
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
            this.panelTitulo = new Panel();
            this.labelTitulo = new Label();
            this.panelSuperior = new Panel();
            this.tbNombreTipo = new TextBox();
            this.labelNombreTipo = new Label();
            this.labelCategoria = new Label();
            this.comboCategoria = new ComboBox();
            this.panelInferior = new Panel();
            this.btnVolver = new Button();
            this.btnCancelar = new Button();
            this.btnAgregar = new Button();
            this.panelTitulo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = DockStyle.Top;
            this.panelTitulo.Location = new Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new Size(800, 100);
            this.panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitulo.Location = new Point(50, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new Size(310, 45);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nuevo Tipo Producto";
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.tbNombreTipo);
            this.panelSuperior.Controls.Add(this.labelNombreTipo);
            this.panelSuperior.Controls.Add(this.labelCategoria);
            this.panelSuperior.Controls.Add(this.comboCategoria);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 100);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(800, 200);
            this.panelSuperior.TabIndex = 0;
            // 
            // tbNombreTipo
            // 
            this.tbNombreTipo.Location = new Point(350, 50);
            this.tbNombreTipo.Name = "tbNombreTipo";
            this.tbNombreTipo.Size = new Size(300, 39);
            this.tbNombreTipo.TabIndex = 6;
            // 
            // labelNombreTipo
            // 
            this.labelNombreTipo.AutoSize = true;
            this.labelNombreTipo.Location = new Point(50, 50);
            this.labelNombreTipo.Name = "labelNombreTipo";
            this.labelNombreTipo.Size = new Size(194, 32);
            this.labelNombreTipo.TabIndex = 5;
            this.labelNombreTipo.Text = "Nombre Tipo Producto";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new Point(50, 120);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new Size(112, 32);
            this.labelCategoria.TabIndex = 7;
            this.labelCategoria.Text = "Categoría";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new Point(250, 120);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new Size(300, 40);
            this.comboCategoria.TabIndex = 8;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnVolver);
            this.panelInferior.Controls.Add(this.btnCancelar);
            this.panelInferior.Controls.Add(this.btnAgregar);
            this.panelInferior.Dock = DockStyle.Fill;
            this.panelInferior.Location = new Point(0, 300);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new Size(800, 100);
            this.panelInferior.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new Point(800, 50);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new Size(150, 50);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new EventHandler(this.btnVolver_Click);
            // 
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new Point(500, 50);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(150, 50);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new Point(200, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new Size(150, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            // 
            // NuevoTipoProducto
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(800, 400);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "NuevoTipoProducto";
            this.Text = "NuevoTipoProducto";
            this.Load += new System.EventHandler(this.NuevoTipoProducto_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitulo;
        private Label labelTitulo;
        private Panel panelSuperior;
        private TextBox tbNombreTipo;
        private Label labelNombreTipo;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        private Panel panelInferior;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}
