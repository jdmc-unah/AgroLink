namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class NuevoPrecio
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
            this.txtNombre = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.cmbActivo = new ComboBox();
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
            this.panelTitulo.Size = new Size(1200, 100);
            this.panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.labelTitulo.Location = new Point(50, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new Size(238, 45);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nuevo Precio";
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.cmbActivo);
            this.panelSuperior.Controls.Add(this.txtNombre);
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 100);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(1200, 300);
            this.panelSuperior.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new Point(200, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(300, 39);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(101, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(600, 50);
            this.label2.Name = "label2";
            this.label2.Size = new Size(76, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Activo";
            // 
            // cmbActivo
            // 
            this.cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Location = new Point(750, 50);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new Size(150, 40);
            this.cmbActivo.TabIndex = 1;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnVolver);
            this.panelInferior.Controls.Add(this.btnCancelar);
            this.panelInferior.Controls.Add(this.btnAgregar);
            this.panelInferior.Dock = DockStyle.Fill;
            this.panelInferior.Location = new Point(0, 400);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new Size(1200, 100);
            this.panelInferior.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new Point(800, 25);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new Size(150, 50);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new Point(500, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new Size(150, 50);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new Point(200, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new Size(150, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            // 
            // NuevoPrecio
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 500);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "NuevoPrecio";
            this.Text = "NuevoPrecio";
            this.Load += new EventHandler(this.NuevoPrecio_Load);
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
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private ComboBox cmbActivo;
        private Panel panelInferior;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}
