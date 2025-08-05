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
            TablaAgricultor.Location = new Point(0, 312);
            TablaAgricultor.Margin = new Padding(7, 7, 7, 7);
            TablaAgricultor.Name = "TablaAgricultor";
            TablaAgricultor.ReadOnly = true;
            TablaAgricultor.RowHeadersWidth = 51;
            TablaAgricultor.Size = new Size(1946, 793);
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
            TbBuscar.Location = new Point(80, 75);
            TbBuscar.Margin = new Padding(7, 7, 7, 7);
            TbBuscar.Name = "TbBuscar";
            TbBuscar.PlaceholderText = "Ingrese Código o Nombre de Agricultor...";
            TbBuscar.Size = new Size(857, 47);
            TbBuscar.TabIndex = 2;
            TbBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(962, 72);
            btnBuscar.Margin = new Padding(7, 7, 7, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 57);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(1171, 72);
            btnRecargar.Margin = new Padding(7, 7, 7, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(357, 57);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar Pagina";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnAgregarFinca
            // 
            btnAgregarFinca.BackColor = SystemColors.Window;
            btnAgregarFinca.Location = new Point(80, 156);
            btnAgregarFinca.Margin = new Padding(7, 7, 7, 7);
            btnAgregarFinca.Name = "btnAgregarFinca";
            btnAgregarFinca.Size = new Size(212, 67);
            btnAgregarFinca.TabIndex = 5;
            btnAgregarFinca.Text = "Ver Lotes";
            btnAgregarFinca.UseVisualStyleBackColor = false;
            btnAgregarFinca.Click += btnAgregarFinca_Click;
            // 
            // btnAgregarFinca1
            // 
            btnAgregarFinca1.BackColor = SystemColors.Window;
            btnAgregarFinca1.Location = new Point(313, 156);
            btnAgregarFinca1.Margin = new Padding(7, 7, 7, 7);
            btnAgregarFinca1.Name = "btnAgregarFinca1";
            btnAgregarFinca1.Size = new Size(333, 67);
            btnAgregarFinca1.TabIndex = 6;
            btnAgregarFinca1.Text = "Crear Nueva Finca";
            btnAgregarFinca1.UseVisualStyleBackColor = false;
            btnAgregarFinca1.Click += btnAgregarFinca1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(TbBuscar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnAgregarFinca1);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnAgregarFinca);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1946, 312);
            panel1.TabIndex = 7;
            // 
            // Agricultor
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1946, 1105);
            Controls.Add(TablaAgricultor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 7, 7, 7);
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