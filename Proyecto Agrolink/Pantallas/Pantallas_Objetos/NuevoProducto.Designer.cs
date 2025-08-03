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
            this.panelTitulo = new Panel();
            this.labelTitulo = new Label();
            this.panelSuperior = new Panel();
            this.tbNombre = new TextBox();
            this.label3 = new Label();;
            this.label1 = new Label();
            this.label4 = new Label();
            this.comboUnidadMedida = new ComboBox();
            this.comboTipoProducto = new ComboBox();
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
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new Size(1200, 100);
            this.panelTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelTitulo.Location = new Point(50, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new Size(255, 45);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Nuevo Producto";
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.tbNombre);
            this.panelSuperior.Controls.Add(this.label3);
            this.panelSuperior.Controls.Add(this.label4);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Controls.Add(this.comboUnidadMedida);
            this.panelSuperior.Controls.Add(this.comboTipoProducto);
            this.panelSuperior.Dock = DockStyle.Top;
            this.panelSuperior.Location = new Point(0, 100);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new Size(1200, 300);
            this.panelSuperior.TabIndex = 0;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new Point(200, 150);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new Size(300, 39);
            this.tbNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new Size(101, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(600, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(202, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(600, 150);
            this.label4.Name = "label4";
            this.label4.Size = new Size(203, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidad de Medida";
            // 
            // comboUnidadMedida
            // 
            this.comboUnidadMedida.FormattingEnabled = true;
            this.comboUnidadMedida.Location = new Point(850, 150);
            this.comboUnidadMedida.Name = "comboUnidadMedida";
            this.comboUnidadMedida.Size = new Size(300, 40);
            this.comboUnidadMedida.TabIndex = 1;
            // 
            // comboTipoProducto
            // 
            this.comboTipoProducto.FormattingEnabled = true;
            this.comboTipoProducto.Location = new Point(850, 50);
            this.comboTipoProducto.Name = "comboTipoProducto";
            this.comboTipoProducto.Size = new Size(300, 40);
            this.comboTipoProducto.TabIndex = 0;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.btnVolver);
            this.panelInferior.Controls.Add(this.btnCancelar);
            this.panelInferior.Controls.Add(this.btnAgregar);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInferior.Location = new Point(0, 400);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new Size(1200, 100);
            this.panelInferior.TabIndex = 1;
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
            this.btnAgregar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new SizeF(13F, 32F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 500);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.Text = "NuevoProducto";
            this.Load += new EventHandler(this.NuevoProducto_Load);
            this.panelTitulo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.ResumeLayout(false);

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
