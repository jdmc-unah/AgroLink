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
            ((System.ComponentModel.ISupportInitialize)TablaAgricultor).BeginInit();
            SuspendLayout();
            // 
            // TablaAgricultor
            // 
            TablaAgricultor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaAgricultor.Location = new Point(3, 135);
            TablaAgricultor.Name = "TablaAgricultor";
            TablaAgricultor.RowHeadersWidth = 51;
            TablaAgricultor.Size = new Size(706, 313);
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
            TbBuscar.Location = new Point(12, 43);
            TbBuscar.Name = "TbBuscar";
            TbBuscar.PlaceholderText = "Ingrese Codigo o Nombre de Agricultor";
            TbBuscar.Size = new Size(406, 27);
            TbBuscar.TabIndex = 2;
            TbBuscar.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(444, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 32);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(444, 94);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(131, 35);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar Pagina";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnAgregarFinca
            // 
            btnAgregarFinca.Location = new Point(12, 94);
            btnAgregarFinca.Name = "btnAgregarFinca";
            btnAgregarFinca.Size = new Size(117, 35);
            btnAgregarFinca.TabIndex = 5;
            btnAgregarFinca.Text = "Ver Lote";
            btnAgregarFinca.UseVisualStyleBackColor = true;
            btnAgregarFinca.Click += btnAgregarFinca_Click;
            // 
            // Agricultor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(btnAgregarFinca);
            Controls.Add(btnRecargar);
            Controls.Add(btnBuscar);
            Controls.Add(TbBuscar);
            Controls.Add(TablaAgricultor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agricultor";
            Text = "Agricultor";
            Load += Agricultor_Load;
            ((System.ComponentModel.ISupportInitialize)TablaAgricultor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TablaAgricultor;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox TbBuscar;
        private Button btnBuscar;
        private Button btnRecargar;
        private Button btnAgregarFinca;
    }
}