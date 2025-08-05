namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class NuevoProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTitulo = new Panel();
            labelTitulo = new Label();
            panelSuperior = new Panel();
            tbNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            comboUnidadMedida = new ComboBox();
            comboTipoProducto = new ComboBox();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            panelInferior = new Panel();
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
            panelTitulo.Margin = new Padding(7, 7, 7, 7);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1650, 217);
            panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(255, 222, 89);
            labelTitulo.Location = new Point(110, 62);
            labelTitulo.Margin = new Padding(7, 0, 7, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(444, 72);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nuevo Producto";
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(tbNombre);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(label4);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(comboUnidadMedida);
            panelSuperior.Controls.Add(comboTipoProducto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 217);
            panelSuperior.Margin = new Padding(7, 7, 7, 7);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1650, 496);
            panelSuperior.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(159, 123);
            tbNombre.Margin = new Padding(7, 7, 7, 7);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(521, 47);
            tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(105, 62);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 41);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1110, 50);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(280, 41);
            label4.TabIndex = 7;
            label4.Text = "Unidad de Medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 276);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 41);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto";
            // 
            // comboUnidadMedida
            // 
            comboUnidadMedida.FormattingEnabled = true;
            comboUnidadMedida.Location = new Point(1060, 150);
            comboUnidadMedida.Margin = new Padding(7, 7, 7, 7);
            comboUnidadMedida.Name = "comboUnidadMedida";
            comboUnidadMedida.Size = new Size(392, 49);
            comboUnidadMedida.TabIndex = 1;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(159, 339);
            comboTipoProducto.Margin = new Padding(7, 7, 7, 7);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(521, 49);
            comboTipoProducto.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(110, 82);
            btnVolver.Margin = new Padding(7, 7, 7, 7);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(252, 73);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(22, 48, 43);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1314, 82);
            btnCancelar.Margin = new Padding(7, 7, 7, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(252, 73);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(22, 48, 43);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(867, 82);
            btnAgregar.Margin = new Padding(7, 7, 7, 7);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(252, 73);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnGuardar_Click;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnVolver);
            panelInferior.Controls.Add(btnAgregar);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 713);
            panelInferior.Margin = new Padding(7, 7, 7, 7);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1650, 231);
            panelInferior.TabIndex = 1;
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(1650, 944);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(7, 7, 7, 7);
            Name = "NuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += NuevoProducto_Load;
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
        private TextBox tbNombre;
        private Label label3;
        private Label label1;
        private Label label4;
        private ComboBox comboUnidadMedida;
        private ComboBox comboTipoProducto;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnAgregar;
        private Panel panelInferior;
    }
}
