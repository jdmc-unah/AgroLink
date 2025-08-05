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
            panelTitulo = new Panel();
            labelTitulo = new Label();
            panelSuperior = new Panel();
            tbNombreTipo = new TextBox();
            labelNombreTipo = new Label();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            panelInferior = new Panel();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            panelTitulo.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(22, 48, 43);
            panelTitulo.Controls.Add(labelTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1322, 128);
            panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(255, 222, 89);
            labelTitulo.Location = new Point(65, 38);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(572, 72);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nuevo Tipo Producto";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(22, 48, 43);
            panelSuperior.Controls.Add(tbNombreTipo);
            panelSuperior.Controls.Add(labelNombreTipo);
            panelSuperior.Controls.Add(labelCategoria);
            panelSuperior.Controls.Add(comboCategoria);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 128);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1322, 256);
            panelSuperior.TabIndex = 0;
            // 
            // tbNombreTipo
            // 
            tbNombreTipo.Location = new Point(457, 64);
            tbNombreTipo.Name = "tbNombreTipo";
            tbNombreTipo.Size = new Size(392, 47);
            tbNombreTipo.TabIndex = 6;
            // 
            // labelNombreTipo
            // 
            labelNombreTipo.AutoSize = true;
            labelNombreTipo.ForeColor = SystemColors.Window;
            labelNombreTipo.Location = new Point(65, 64);
            labelNombreTipo.Name = "labelNombreTipo";
            labelNombreTipo.Size = new Size(325, 41);
            labelNombreTipo.TabIndex = 5;
            labelNombreTipo.Text = "Nombre Tipo Producto";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.ForeColor = SystemColors.Window;
            labelCategoria.Location = new Point(65, 154);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(146, 41);
            labelCategoria.TabIndex = 7;
            labelCategoria.Text = "Categoría";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(457, 154);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(392, 49);
            comboCategoria.TabIndex = 8;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(22, 48, 43);
            panelInferior.Controls.Add(btnVolver);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Controls.Add(btnAgregar);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 384);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1322, 142);
            panelInferior.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(22, 48, 43);
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(65, 31);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(196, 64);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(22, 48, 43);
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1087, 31);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(196, 64);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 222, 89);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(828, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 64);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // NuevoTipoProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 526);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NuevoTipoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NuevoTipoProducto_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ResumeLayout(false);
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
