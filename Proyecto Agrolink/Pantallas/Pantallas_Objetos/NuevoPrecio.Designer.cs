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
            panelTitulo = new Panel();
            labelTitulo = new Label();
            panelSuperior = new Panel();
            cmbActivo = new ComboBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            panelTitulo.Size = new Size(1113, 128);
            panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(255, 222, 89);
            labelTitulo.Location = new Point(65, 38);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(597, 72);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nueva Lista de Precios";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(22, 48, 43);
            panelSuperior.Controls.Add(cmbActivo);
            panelSuperior.Controls.Add(txtNombre);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 128);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1113, 265);
            panelSuperior.TabIndex = 1;
            // 
            // cmbActivo
            // 
            cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivo.FormattingEnabled = true;
            cmbActivo.Location = new Point(262, 167);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(194, 49);
            cmbActivo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(262, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 47);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(65, 167);
            label2.Name = "label2";
            label2.Size = new Size(100, 41);
            label2.TabIndex = 2;
            label2.Text = "Activo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(65, 64);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(22, 48, 43);
            panelInferior.Controls.Add(btnVolver);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Controls.Add(btnAgregar);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 393);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1113, 182);
            panelInferior.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(22, 48, 43);
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(60, 59);
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
            btnCancelar.Location = new Point(849, 59);
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
            btnAgregar.Location = new Point(595, 59);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 64);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // NuevoPrecio
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 575);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NuevoPrecio";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NuevoPrecio_Load;
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
