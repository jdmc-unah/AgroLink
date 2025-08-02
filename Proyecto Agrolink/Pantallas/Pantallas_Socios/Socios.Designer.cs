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
            ((System.ComponentModel.ISupportInitialize)TablaSocio).BeginInit();
            SuspendLayout();
            // 
            // TablaSocio
            // 
            TablaSocio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaSocio.Location = new Point(2, 113);
            TablaSocio.Name = "TablaSocio";
            TablaSocio.RowHeadersWidth = 51;
            TablaSocio.Size = new Size(869, 326);
            TablaSocio.TabIndex = 0;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(12, 455);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(144, 54);
            btAgregar.TabIndex = 1;
            btAgregar.Text = "Agregar Socio";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Location = new Point(405, 35);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(133, 31);
            btnBuscarSocio.TabIndex = 2;
            btnBuscarSocio.Text = "Buscar";
            btnBuscarSocio.UseVisualStyleBackColor = true;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // tbBuscarSocio
            // 
            tbBuscarSocio.Location = new Point(12, 39);
            tbBuscarSocio.Name = "tbBuscarSocio";
            tbBuscarSocio.PlaceholderText = "Ingrese Nombre o codigo de Socio";
            tbBuscarSocio.Size = new Size(387, 27);
            tbBuscarSocio.TabIndex = 3;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(569, 35);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(100, 33);
            btnRecargar.TabIndex = 4;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 521);
            Controls.Add(btnRecargar);
            Controls.Add(tbBuscarSocio);
            Controls.Add(btnBuscarSocio);
            Controls.Add(btAgregar);
            Controls.Add(TablaSocio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Socios";
            Text = "Socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)TablaSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TablaSocio;
        private Button btAgregar;
        private Button btnBuscarSocio;
        private TextBox tbBuscarSocio;
        private Button btnRecargar;
    }
}