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
            btnVolver = new Button();
            tbNombre = new TextBox();
            btnCancelar = new Button();
            label3 = new Label();
            btnAgregar = new Button();
            label4 = new Label();
            label1 = new Label();
            comboUnidadMedida = new ComboBox();
            comboTipoProducto = new ComboBox();
            panelInferior = new Panel();
            panelTitulo.SuspendLayout();
            panelSuperior.SuspendLayout();
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
            panelTitulo.Size = new Size(1145, 78);
            panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.ForeColor = SystemColors.Window;
            labelTitulo.Location = new Point(38, 23);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(266, 45);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Nuevo Producto";
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(22, 48, 43);
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
            panelSuperior.Location = new Point(0, 78);
            panelSuperior.Margin = new Padding(2, 2, 2, 2);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1145, 329);
            panelSuperior.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 222, 89);
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Location = new Point(38, 255);
            btnVolver.Margin = new Padding(2, 2, 2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(115, 39);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(99, 87);
            tbNombre.Margin = new Padding(2, 2, 2, 2);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(344, 31);
            tbNombre.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(381, 255);
            btnCancelar.Margin = new Padding(2, 2, 2, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 39);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(38, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Window;
            btnAgregar.Location = new Point(201, 255);
            btnAgregar.Margin = new Padding(2, 2, 2, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 39);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(739, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 7;
            label4.Text = "Unidad de Medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(739, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 2;
            label1.Text = "Tipo de Producto";
            // 
            // comboUnidadMedida
            // 
            comboUnidadMedida.FormattingEnabled = true;
            comboUnidadMedida.Location = new Point(906, 234);
            comboUnidadMedida.Margin = new Padding(2, 2, 2, 2);
            comboUnidadMedida.Name = "comboUnidadMedida";
            comboUnidadMedida.Size = new Size(232, 33);
            comboUnidadMedida.TabIndex = 1;
            // 
            // comboTipoProducto
            // 
            comboTipoProducto.FormattingEnabled = true;
            comboTipoProducto.Location = new Point(906, 79);
            comboTipoProducto.Margin = new Padding(2, 2, 2, 2);
            comboTipoProducto.Name = "comboTipoProducto";
            comboTipoProducto.Size = new Size(232, 33);
            comboTipoProducto.TabIndex = 0;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(22, 48, 43);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 407);
            panelInferior.Margin = new Padding(2, 2, 2, 2);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1145, 267);
            panelInferior.TabIndex = 1;
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
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
