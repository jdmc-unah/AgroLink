namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class NuevaBodega
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
            txtCapacidad = new TextBox();
            cmbDireccion = new ComboBox();
            txtNombre = new TextBox();
            label3 = new Label();
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
            panelTitulo.Size = new Size(1553, 128);
            panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(255, 222, 89);
            labelTitulo.Location = new Point(65, 38);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(399, 72);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nueva Bodega";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(22, 48, 43);
            panelSuperior.Controls.Add(txtCapacidad);
            panelSuperior.Controls.Add(cmbDireccion);
            panelSuperior.Controls.Add(txtNombre);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 128);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1553, 339);
            panelSuperior.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(1046, 64);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(392, 47);
            txtCapacidad.TabIndex = 1;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // cmbDireccion
            // 
            cmbDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDireccion.FormattingEnabled = true;
            cmbDireccion.Location = new Point(262, 192);
            cmbDireccion.Name = "cmbDireccion";
            cmbDireccion.Size = new Size(1175, 49);
            cmbDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(262, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 47);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(65, 192);
            label3.Name = "label3";
            label3.Size = new Size(142, 41);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(785, 64);
            label2.Name = "label2";
            label2.Size = new Size(157, 41);
            label2.TabIndex = 2;
            label2.Text = "Capacidad";
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
            panelInferior.Location = new Point(0, 467);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1553, 142);
            panelInferior.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(22, 48, 43);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.ButtonFace;
            btnVolver.Location = new Point(65, 41);
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
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(1304, 41);
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
            btnAgregar.Location = new Point(1002, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 64);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // NuevaBodega
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 609);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NuevaBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NuevaBodega_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}
