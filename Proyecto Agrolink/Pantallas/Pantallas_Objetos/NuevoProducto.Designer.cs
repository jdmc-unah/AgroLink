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
            panelTitulo.Controls.Add(labelTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(4);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1519, 141);
            panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(255, 222, 89);
            labelTitulo.Location = new Point(65, 38);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
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
            panelSuperior.Location = new Point(0, 141);
            panelSuperior.Margin = new Padding(4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1519, 531);
            panelSuperior.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(169, 142);
            tbNombre.Margin = new Padding(4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(582, 47);
            tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
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
            label4.Location = new Point(1041, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
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
            label1.Location = new Point(65, 298);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 41);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto";
            // 
            // comboUnidadMedida
            // 
            comboUnidadMedida.FormattingEnabled = true;
            comboUnidadMedida.Location = new Point(1001, 142);
            comboUnidadMedida.Margin = new Padding(4);
            comboUnidadMedida.Name = "comboUnidadMedida";
            comboUnidadMedida.Size = new Size(391, 49);
            comboUnidadMedida.TabIndex = 1;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(169, 368);
            comboTipoProducto.Margin = new Padding(4);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(572, 49);
            comboTipoProducto.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(65, 50);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(196, 64);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1282, 50);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(196, 64);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(1019, 50);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 64);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnGuardar_Click;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(btnVolver);
            panelInferior.Controls.Add(btnAgregar);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 672);
            panelInferior.Margin = new Padding(4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1519, 162);
            panelInferior.TabIndex = 1;
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(1519, 834);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
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
