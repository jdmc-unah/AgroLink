namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class Agricultor
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
            components = new System.ComponentModel.Container();
            TablaAgricultor = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TbBuscar = new TextBox();
            btnBuscar = new Button();
            btnRecargar = new Button();
            btnAgregarFinca = new Button();
            btnAgregarFinca1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TablaAgricultor).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TablaAgricultor
            // 
            TablaAgricultor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaAgricultor.Dock = DockStyle.Fill;
            TablaAgricultor.Location = new Point(0, 292);
            TablaAgricultor.Margin = new Padding(6);
            TablaAgricultor.Name = "TablaAgricultor";
            TablaAgricultor.RowHeadersWidth = 51;
            TablaAgricultor.Size = new Size(2916, 1420);
            TablaAgricultor.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // TbBuscar
            // 
            TbBuscar.Location = new Point(80, 51);
            TbBuscar.Margin = new Padding(6);
            TbBuscar.Name = "TbBuscar";
            TbBuscar.PlaceholderText = "Ingrese Codigo o Nombre de Agricultor";
            TbBuscar.Size = new Size(858, 47);
            TbBuscar.TabIndex = 2;
            TbBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(950, 41);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(193, 66);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(1196, 41);
            btnRecargar.Margin = new Padding(6);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(305, 66);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar Pagina";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnAgregarFinca
            // 
            btnAgregarFinca.Location = new Point(80, 156);
            btnAgregarFinca.Margin = new Padding(6);
            btnAgregarFinca.Name = "btnAgregarFinca";
            btnAgregarFinca.Size = new Size(249, 72);
            btnAgregarFinca.TabIndex = 5;
            btnAgregarFinca.Text = "Ver Lotes";
            btnAgregarFinca.UseVisualStyleBackColor = true;
            btnAgregarFinca.Click += btnAgregarFinca_Click;
            // 
            // btnAgregarFinca1
            // 
            btnAgregarFinca1.Location = new Point(366, 156);
            btnAgregarFinca1.Margin = new Padding(6);
            btnAgregarFinca1.Name = "btnAgregarFinca1";
            btnAgregarFinca1.Size = new Size(372, 72);
            btnAgregarFinca1.TabIndex = 6;
            btnAgregarFinca1.Text = "Crear Nueva Finca";
            btnAgregarFinca1.UseVisualStyleBackColor = true;
            btnAgregarFinca1.Click += btnAgregarFinca1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(TbBuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregarFinca1);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnAgregarFinca);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2916, 292);
            panel1.TabIndex = 7;
            // 
            // Agricultor
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2916, 1712);
            Controls.Add(TablaAgricultor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Agricultor";
            Text = "Agricultor";
            Load += Agricultor_Load;
            ((System.ComponentModel.ISupportInitialize)TablaAgricultor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaAgricultor;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox TbBuscar;
        private Button btnBuscar;
        private Button btnRecargar;
        private Button btnAgregarFinca;
        private Button btnAgregarFinca1;
        private Panel panel1;
    }
}