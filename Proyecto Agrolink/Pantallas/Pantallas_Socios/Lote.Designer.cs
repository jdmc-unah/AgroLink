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
            dateTimePicker_siembra = new DateTimePicker();
            dateTimePicker_cosecha = new DateTimePicker();
            tbExtencion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCodigo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)LoteTabla).BeginInit();
            SuspendLayout();
            // 
            // LoteTabla
            // 
            LoteTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoteTabla.Location = new Point(2, 201);
            LoteTabla.Name = "LoteTabla";
            LoteTabla.RowHeadersWidth = 51;
            LoteTabla.Size = new Size(911, 281);
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
            btnBuscarLote.Location = new Point(419, 34);
            btnBuscarLote.Name = "btnBuscarLote";
            btnBuscarLote.Size = new Size(137, 31);
            btnBuscarLote.TabIndex = 2;
            btnBuscarLote.Text = "Buscar";
            btnBuscarLote.UseVisualStyleBackColor = true;
            btnBuscarLote.Click += btnBuscarLote_Click;
            // 
            // btnRegrsar
            // 
            btnRegrsar.Location = new Point(716, 508);
            btnRegrsar.Name = "btnRegrsar";
            btnRegrsar.Size = new Size(174, 39);
            btnRegrsar.TabIndex = 3;
            btnRegrsar.Text = "Regresar";
            btnRegrsar.UseVisualStyleBackColor = true;
            btnRegrsar.Click += btnRegrsar_Click;
            // 
            // btnAgregarLote
            // 
            btnAgregarLote.Location = new Point(562, 32);
            btnAgregarLote.Name = "btnAgregarLote";
            btnAgregarLote.Size = new Size(135, 31);
            btnAgregarLote.TabIndex = 4;
            btnAgregarLote.Text = "AgregarLote";
            btnAgregarLote.UseVisualStyleBackColor = true;
            btnAgregarLote.Click += btnAgregarLote_Click;
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
            comboBox_Finca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Finca.FormattingEnabled = true;
            comboBox_Finca.Location = new Point(113, 96);
            comboBox_Finca.Name = "comboBox_Finca";
            comboBox_Finca.Size = new Size(145, 28);
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
            comboBox_TipoRiego.Location = new Point(735, 101);
            comboBox_TipoRiego.Name = "comboBox_TipoRiego";
            comboBox_TipoRiego.Size = new Size(178, 28);
            comboBox_TipoRiego.TabIndex = 10;
            // 
            // dateTimePicker_siembra
            // 
            dateTimePicker_siembra.Format = DateTimePickerFormat.Short;
            dateTimePicker_siembra.Location = new Point(136, 154);
            dateTimePicker_siembra.Name = "dateTimePicker_siembra";
            dateTimePicker_siembra.Size = new Size(145, 27);
            dateTimePicker_siembra.TabIndex = 11;
            // 
            // dateTimePicker_cosecha
            // 
            dateTimePicker_cosecha.Format = DateTimePickerFormat.Short;
            dateTimePicker_cosecha.Location = new Point(462, 152);
            dateTimePicker_cosecha.Name = "dateTimePicker_cosecha";
            dateTimePicker_cosecha.Size = new Size(172, 27);
            dateTimePicker_cosecha.TabIndex = 12;
            // 
            // tbExtencion
            // 
            tbExtencion.Location = new Point(800, 157);
            tbExtencion.Name = "tbExtencion";
            tbExtencion.Size = new Size(162, 27);
            tbExtencion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 157);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 14;
            label4.Text = "Fecha de siembra";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 157);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 15;
            label5.Text = "Fecha Aprox de cosecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(649, 159);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 16;
            label6.Text = "extension de terreno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(716, 41);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 17;
            label7.Text = "codigo ";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(791, 41);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(136, 27);
            tbCodigo.TabIndex = 18;
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 559);
            Controls.Add(tbCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbExtencion);
            Controls.Add(dateTimePicker_cosecha);
            Controls.Add(dateTimePicker_siembra);
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
        private DateTimePicker dateTimePicker_siembra;
        private DateTimePicker dateTimePicker_cosecha;
        private TextBox tbExtencion;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCodigo;
    }
}