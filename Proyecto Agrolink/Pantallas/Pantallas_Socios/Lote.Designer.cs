namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class Lote
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
            LoteTabla = new DataGridView();
            tbBuscarLote = new TextBox();
            btnBuscarLote = new Button();
            btnRegrsar = new Button();
            ((System.ComponentModel.ISupportInitialize)LoteTabla).BeginInit();
            SuspendLayout();
            // 
            // LoteTabla
            // 
            LoteTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoteTabla.Location = new Point(2, 201);
            LoteTabla.Name = "LoteTabla";
            LoteTabla.RowHeadersWidth = 51;
            LoteTabla.Size = new Size(861, 296);
            LoteTabla.TabIndex = 0;
            LoteTabla.CellContentClick += LoteTabla_CellContentClick;
            // 
            // tbBuscarLote
            // 
            tbBuscarLote.Location = new Point(12, 34);
            tbBuscarLote.Name = "tbBuscarLote";
            tbBuscarLote.PlaceholderText = "Ingresar Codgo de Lote o codigo de Finca";
            tbBuscarLote.Size = new Size(401, 27);
            tbBuscarLote.TabIndex = 1;
            // 
            // btnBuscarLote
            // 
            btnBuscarLote.Location = new Point(428, 34);
            btnBuscarLote.Name = "btnBuscarLote";
            btnBuscarLote.Size = new Size(116, 27);
            btnBuscarLote.TabIndex = 2;
            btnBuscarLote.Text = "Buscar";
            btnBuscarLote.UseVisualStyleBackColor = true;
            btnBuscarLote.Click += btnBuscarLote_Click;
            // 
            // btnRegrsar
            // 
            btnRegrsar.Location = new Point(640, 503);
            btnRegrsar.Name = "btnRegrsar";
            btnRegrsar.Size = new Size(167, 44);
            btnRegrsar.TabIndex = 3;
            btnRegrsar.Text = "Regresar";
            btnRegrsar.UseVisualStyleBackColor = true;
            btnRegrsar.Click += btnRegrsar_Click;
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 559);
            Controls.Add(btnRegrsar);
            Controls.Add(btnBuscarLote);
            Controls.Add(tbBuscarLote);
            Controls.Add(LoteTabla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Lote";
            Text = "Lote";
            Load += Lote_Load;
            ((System.ComponentModel.ISupportInitialize)LoteTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LoteTabla;
        private TextBox tbBuscarLote;
        private Button btnBuscarLote;
        private Button btnRegrsar;
    }
}