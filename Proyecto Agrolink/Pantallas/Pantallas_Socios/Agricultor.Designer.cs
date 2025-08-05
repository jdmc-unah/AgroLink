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
            TablaAgricultor.Location = new Point(0, 190);
            TablaAgricultor.Margin = new Padding(4);
            TablaAgricultor.Name = "TablaAgricultor";
            TablaAgricultor.RowHeadersWidth = 51;
            TablaAgricultor.Size = new Size(1145, 484);
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
            TbBuscar.Location = new Point(47, 46);
            TbBuscar.Margin = new Padding(4);
            TbBuscar.Name = "TbBuscar";
            TbBuscar.PlaceholderText = "Ingrese Código o Nombre de Agricultor...";
            TbBuscar.Size = new Size(506, 31);
            TbBuscar.TabIndex = 2;
            TbBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Location = new Point(566, 44);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(689, 44);
            btnRecargar.Margin = new Padding(4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(210, 35);
            btnRecargar.TabIndex = 3;
            btnRecargar.Text = "Recargar Pagina";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnAgregarFinca
            // 
            btnAgregarFinca.BackColor = SystemColors.Window;
            btnAgregarFinca.Location = new Point(47, 95);
            btnAgregarFinca.Margin = new Padding(4);
            btnAgregarFinca.Name = "btnAgregarFinca";
            btnAgregarFinca.Size = new Size(125, 41);
            btnAgregarFinca.TabIndex = 5;
            btnAgregarFinca.Text = "Ver Lotes";
            btnAgregarFinca.UseVisualStyleBackColor = false;
            btnAgregarFinca.Click += btnAgregarFinca_Click;
            // 
            // btnAgregarFinca1
            // 
            btnAgregarFinca1.BackColor = SystemColors.Window;
            btnAgregarFinca1.Location = new Point(184, 95);
            btnAgregarFinca1.Margin = new Padding(4);
            btnAgregarFinca1.Name = "btnAgregarFinca1";
            btnAgregarFinca1.Size = new Size(196, 41);
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 190);
            panel1.TabIndex = 7;
            // 
            // Agricultor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(TablaAgricultor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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