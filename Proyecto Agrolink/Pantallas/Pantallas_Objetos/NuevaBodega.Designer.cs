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
            panelTitulo.Margin = new Padding(2, 2, 2, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(923, 78);
            panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = SystemColors.Window;
            labelTitulo.Location = new Point(38, 23);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(239, 45);
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
            panelSuperior.Location = new Point(0, 78);
            panelSuperior.Margin = new Padding(2, 2, 2, 2);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(923, 234);
            panelSuperior.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(615, 39);
            txtCapacidad.Margin = new Padding(2, 2, 2, 2);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(232, 31);
            txtCapacidad.TabIndex = 1;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            // 
            // cmbDireccion
            // 
            cmbDireccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDireccion.FormattingEnabled = true;
            cmbDireccion.Location = new Point(154, 117);
            cmbDireccion.Margin = new Padding(2, 2, 2, 2);
            cmbDireccion.Name = "cmbDireccion";
            cmbDireccion.Size = new Size(693, 33);
            cmbDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 39);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 31);
            txtNombre.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(38, 117);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 3;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(462, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(38, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
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
            panelInferior.Location = new Point(0, 312);
            panelInferior.Margin = new Padding(2, 2, 2, 2);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(923, 79);
            panelInferior.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Window;
            btnVolver.Location = new Point(615, 20);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(115, 39);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(385, 20);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 39);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(255, 222, 89);
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Location = new Point(154, 20);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 39);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // NuevaBodega
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 391);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "NuevaBodega";
            Text = "NuevaBodega";
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
