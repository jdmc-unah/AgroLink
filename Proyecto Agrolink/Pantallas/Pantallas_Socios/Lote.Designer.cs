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
            btnAgregarLote = new Button();
            label1 = new Label();
            comboBox_Finca = new ComboBox();
            comboBox_TipoSuelo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox_TipoRiego = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)LoteTabla).BeginInit();
            SuspendLayout();
            // 
            // LoteTabla
            // 
            LoteTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoteTabla.Location = new Point(2, 201);
            LoteTabla.Name = "LoteTabla";
            LoteTabla.RowHeadersWidth = 51;
            LoteTabla.Size = new Size(881, 296);
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
            btnRegrsar.Location = new Point(716, 512);
            btnRegrsar.Name = "btnRegrsar";
            btnRegrsar.Size = new Size(167, 35);
            btnRegrsar.TabIndex = 3;
            btnRegrsar.Text = "Regresar";
            btnRegrsar.UseVisualStyleBackColor = true;
            btnRegrsar.Click += btnRegrsar_Click;
            // 
            // btnAgregarLote
            // 
            btnAgregarLote.Location = new Point(561, 34);
            btnAgregarLote.Name = "btnAgregarLote";
            btnAgregarLote.Size = new Size(121, 27);
            btnAgregarLote.TabIndex = 4;
            btnAgregarLote.Text = "AgregarLote";
            btnAgregarLote.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Finca";
            // 
            // comboBox_Finca
            // 
            comboBox_Finca.FormattingEnabled = true;
            comboBox_Finca.Location = new Point(113, 96);
            comboBox_Finca.Name = "comboBox_Finca";
            comboBox_Finca.Size = new Size(133, 28);
            comboBox_Finca.TabIndex = 6;
            // 
            // comboBox_TipoSuelo
            // 
            comboBox_TipoSuelo.FormattingEnabled = true;
            comboBox_TipoSuelo.Location = new Point(387, 96);
            comboBox_TipoSuelo.Name = "comboBox_TipoSuelo";
            comboBox_TipoSuelo.Size = new Size(178, 28);
            comboBox_TipoSuelo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 99);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 8;
            label2.Text = "Tipo de suelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 104);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 9;
            label3.Text = "Tipo de Riego";
            // 
            // comboBox_TipoRiego
            // 
            comboBox_TipoRiego.FormattingEnabled = true;
            comboBox_TipoRiego.Location = new Point(705, 99);
            comboBox_TipoRiego.Name = "comboBox_TipoRiego";
            comboBox_TipoRiego.Size = new Size(178, 28);
            comboBox_TipoRiego.TabIndex = 10;
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 559);
            Controls.Add(comboBox_TipoRiego);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox_TipoSuelo);
            Controls.Add(comboBox_Finca);
            Controls.Add(label1);
            Controls.Add(btnAgregarLote);
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
        private Button btnAgregarLote;
        private Label label1;
        private ComboBox comboBox_Finca;
        private ComboBox comboBox_TipoSuelo;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_TipoRiego;
    }
}