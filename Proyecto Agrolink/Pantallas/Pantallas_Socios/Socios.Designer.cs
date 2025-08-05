namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class Socios
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
            TablaSocio = new DataGridView();
            btAgregar = new Button();
            btnBuscarSocio = new Button();
            tbBuscarSocio = new TextBox();
            btnRecargar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TablaSocio).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TablaSocio
            // 
            TablaSocio.AllowUserToAddRows = false;
            TablaSocio.AllowUserToDeleteRows = false;
            TablaSocio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaSocio.Dock = DockStyle.Fill;
            TablaSocio.Location = new Point(0, 164);
            TablaSocio.Margin = new Padding(4);
            TablaSocio.Name = "TablaSocio";
            TablaSocio.RowHeadersWidth = 51;
            TablaSocio.Size = new Size(1145, 510);
            TablaSocio.TabIndex = 0;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = SystemColors.Window;
            btAgregar.Location = new Point(192, 88);
            btAgregar.Margin = new Padding(4);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(125, 41);
            btAgregar.TabIndex = 1;
            btAgregar.Text = "Nuevo Socio";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscarSocio.FlatStyle = FlatStyle.Popup;
            btnBuscarSocio.Location = new Point(386, 39);
            btnBuscarSocio.Margin = new Padding(4);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(111, 35);
            btnBuscarSocio.TabIndex = 2;
            btnBuscarSocio.Text = "Buscar";
            btnBuscarSocio.UseVisualStyleBackColor = false;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // tbBuscarSocio
            // 
            tbBuscarSocio.Location = new Point(49, 41);
            tbBuscarSocio.Margin = new Padding(4);
            tbBuscarSocio.Name = "tbBuscarSocio";
            tbBuscarSocio.PlaceholderText = "Ingrese Nombre o Código de Socio...";
            tbBuscarSocio.Size = new Size(324, 31);
            tbBuscarSocio.TabIndex = 3;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(49, 88);
            btnRecargar.Margin = new Padding(4);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(125, 41);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(tbBuscarSocio);
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btAgregar);
            panel1.Controls.Add(btnBuscarSocio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 164);
            panel1.TabIndex = 5;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 674);
            Controls.Add(TablaSocio);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Socios";
            Text = "Socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)TablaSocio).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaSocio;
        private Button btAgregar;
        private Button btnBuscarSocio;
        private TextBox tbBuscarSocio;
        private Button btnRecargar;
        private Panel panel1;
    }
}