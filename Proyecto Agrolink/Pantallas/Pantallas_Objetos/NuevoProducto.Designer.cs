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
            panelInferior = new Panel();
            btnVolver = new Button();
            btnCancelar = new Button();
            btnAgregar = new Button();
            panelTitulo.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(labelTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(4, 4, 4, 4);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(2273, 128);
            panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(65, 38);
            labelTitulo.Margin = new Padding(4, 0, 4, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(444, 72);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nuevo Producto";
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(btnVolver);
            panelSuperior.Controls.Add(tbNombre);
            panelSuperior.Controls.Add(btnCancelar);
            panelSuperior.Controls.Add(label3);
            panelSuperior.Controls.Add(btnAgregar);
            panelSuperior.Controls.Add(label4);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(comboUnidadMedida);
            panelSuperior.Controls.Add(comboTipoProducto);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 128);
            panelSuperior.Margin = new Padding(4, 4, 4, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(2273, 540);
            panelSuperior.TabIndex = 0;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(169, 142);
            tbNombre.Margin = new Padding(4, 4, 4, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(582, 47);
            tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1256, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(265, 41);
            label4.TabIndex = 7;
            label4.Text = "Unidad de Medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1256, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 41);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto";
            // 
            // comboUnidadMedida
            // 
            comboUnidadMedida.FormattingEnabled = true;
            comboUnidadMedida.Location = new Point(1541, 384);
            comboUnidadMedida.Margin = new Padding(4, 4, 4, 4);
            comboUnidadMedida.Name = "comboUnidadMedida";
            comboUnidadMedida.Size = new Size(391, 49);
            comboUnidadMedida.TabIndex = 1;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(1541, 129);
            comboTipoProducto.Margin = new Padding(4, 4, 4, 4);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(391, 49);
            comboTipoProducto.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 668);
            panelInferior.Margin = new Padding(4, 4, 4, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(2273, 602);
            panelInferior.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(65, 418);
            btnVolver.Margin = new Padding(4, 4, 4, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(196, 64);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(648, 418);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(196, 64);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(341, 418);
            btnAgregar.Margin = new Padding(4, 4, 4, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(196, 64);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnGuardar_Click;
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2273, 1270);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "NuevoProducto";
            Text = "NuevoProducto";
            Load += NuevoProducto_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
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
        private Panel panelInferior;
        private Button btnVolver;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}
