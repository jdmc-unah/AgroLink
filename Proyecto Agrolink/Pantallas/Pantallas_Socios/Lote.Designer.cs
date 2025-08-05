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
            label8 = new Label();
            comboBox_productocosecha = new ComboBox();
            btnRecargar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)LoteTabla).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LoteTabla
            // 
            LoteTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoteTabla.Dock = DockStyle.Top;
            LoteTabla.Location = new Point(0, 553);
            LoteTabla.Margin = new Padding(7, 7, 7, 7);
            LoteTabla.Name = "LoteTabla";
            LoteTabla.ReadOnly = true;
            LoteTabla.RowHeadersWidth = 51;
            LoteTabla.Size = new Size(2912, 951);
            LoteTabla.TabIndex = 0;
            LoteTabla.CellContentClick += LoteTabla_CellContentClick;
            // 
            // tbBuscarLote
            // 
            tbBuscarLote.Location = new Point(530, 41);
            tbBuscarLote.Margin = new Padding(7, 7, 7, 7);
            tbBuscarLote.Name = "tbBuscarLote";
            tbBuscarLote.PlaceholderText = "Ingresar Codgo de Lote o Codigo de Finca";
            tbBuscarLote.Size = new Size(847, 47);
            tbBuscarLote.TabIndex = 1;
            // 
            // btnBuscarLote
            // 
            btnBuscarLote.BackColor = Color.FromArgb(255, 222, 89);
            btnBuscarLote.FlatStyle = FlatStyle.Popup;
            btnBuscarLote.Location = new Point(1423, 33);
            btnBuscarLote.Margin = new Padding(7, 7, 7, 7);
            btnBuscarLote.Name = "btnBuscarLote";
            btnBuscarLote.Size = new Size(291, 64);
            btnBuscarLote.TabIndex = 2;
            btnBuscarLote.Text = "Buscar";
            btnBuscarLote.UseVisualStyleBackColor = false;
            btnBuscarLote.Click += btnBuscarLote_Click;
            // 
            // btnRegrsar
            // 
            btnRegrsar.BackColor = Color.FromArgb(255, 222, 89);
            btnRegrsar.FlatStyle = FlatStyle.Popup;
            btnRegrsar.Location = new Point(44, 66);
            btnRegrsar.Margin = new Padding(7, 7, 7, 7);
            btnRegrsar.Name = "btnRegrsar";
            btnRegrsar.Size = new Size(287, 64);
            btnRegrsar.TabIndex = 3;
            btnRegrsar.Text = "Volver";
            btnRegrsar.UseVisualStyleBackColor = false;
            btnRegrsar.Click += btnRegrsar_Click;
            // 
            // btnAgregarLote
            // 
            btnAgregarLote.BackColor = Color.FromArgb(192, 229, 200);
            btnAgregarLote.FlatStyle = FlatStyle.Popup;
            btnAgregarLote.Location = new Point(2579, 326);
            btnAgregarLote.Margin = new Padding(7, 7, 7, 7);
            btnAgregarLote.Name = "btnAgregarLote";
            btnAgregarLote.Size = new Size(287, 64);
            btnAgregarLote.TabIndex = 4;
            btnAgregarLote.Text = "Agregar Lote";
            btnAgregarLote.UseVisualStyleBackColor = false;
            btnAgregarLote.Click += btnAgregarLote_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(95, 157);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 41);
            label1.TabIndex = 5;
            label1.Text = "Finca";
            // 
            // comboBox_Finca
            // 
            comboBox_Finca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Finca.FormattingEnabled = true;
            comboBox_Finca.Location = new Point(211, 156);
            comboBox_Finca.Margin = new Padding(7, 7, 7, 7);
            comboBox_Finca.Name = "comboBox_Finca";
            comboBox_Finca.Size = new Size(303, 49);
            comboBox_Finca.TabIndex = 6;
            // 
            // comboBox_TipoSuelo
            // 
            comboBox_TipoSuelo.FormattingEnabled = true;
            comboBox_TipoSuelo.Location = new Point(1316, 130);
            comboBox_TipoSuelo.Margin = new Padding(7, 7, 7, 7);
            comboBox_TipoSuelo.Name = "comboBox_TipoSuelo";
            comboBox_TipoSuelo.Size = new Size(375, 49);
            comboBox_TipoSuelo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(1064, 138);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 41);
            label2.TabIndex = 8;
            label2.Text = "Tipo de suelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(1056, 320);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 41);
            label3.TabIndex = 9;
            label3.Text = "Tipo de Riego";
            // 
            // comboBox_TipoRiego
            // 
            comboBox_TipoRiego.FormattingEnabled = true;
            comboBox_TipoRiego.Location = new Point(1316, 315);
            comboBox_TipoRiego.Margin = new Padding(7, 7, 7, 7);
            comboBox_TipoRiego.Name = "comboBox_TipoRiego";
            comboBox_TipoRiego.Size = new Size(375, 49);
            comboBox_TipoRiego.TabIndex = 10;
            comboBox_TipoRiego.SelectedIndexChanged += comboBox_TipoRiego_SelectedIndexChanged;
            // 
            // dateTimePicker_siembra
            // 
            dateTimePicker_siembra.Format = DateTimePickerFormat.Short;
            dateTimePicker_siembra.Location = new Point(1878, 157);
            dateTimePicker_siembra.Margin = new Padding(7, 7, 7, 7);
            dateTimePicker_siembra.Name = "dateTimePicker_siembra";
            dateTimePicker_siembra.Size = new Size(303, 47);
            dateTimePicker_siembra.TabIndex = 11;
            // 
            // dateTimePicker_cosecha
            // 
            dateTimePicker_cosecha.Format = DateTimePickerFormat.Short;
            dateTimePicker_cosecha.Location = new Point(2394, 157);
            dateTimePicker_cosecha.Margin = new Padding(7, 7, 7, 7);
            dateTimePicker_cosecha.Name = "dateTimePicker_cosecha";
            dateTimePicker_cosecha.Size = new Size(303, 47);
            dateTimePicker_cosecha.TabIndex = 12;
            // 
            // tbExtencion
            // 
            tbExtencion.Location = new Point(474, 317);
            tbExtencion.Margin = new Padding(7, 7, 7, 7);
            tbExtencion.Name = "tbExtencion";
            tbExtencion.Size = new Size(385, 47);
            tbExtencion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(1906, 89);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 41);
            label4.TabIndex = 14;
            label4.Text = "Fecha de siembra";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(2336, 89);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(420, 41);
            label5.TabIndex = 15;
            label5.Text = "Fecha Aproximada de cosecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(95, 317);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(298, 41);
            label6.TabIndex = 16;
            label6.Text = "Extension De Terreno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(2014, 271);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(288, 41);
            label8.TabIndex = 19;
            label8.Text = "Producto a cosechar";
            // 
            // comboBox_productocosecha
            // 
            comboBox_productocosecha.FormattingEnabled = true;
            comboBox_productocosecha.Location = new Point(1970, 336);
            comboBox_productocosecha.Margin = new Padding(7, 7, 7, 7);
            comboBox_productocosecha.Name = "comboBox_productocosecha";
            comboBox_productocosecha.Size = new Size(375, 49);
            comboBox_productocosecha.TabIndex = 20;
            // 
            // btnRecargar
            // 
            btnRecargar.BackColor = SystemColors.Window;
            btnRecargar.Location = new Point(1771, 33);
            btnRecargar.Margin = new Padding(7, 7, 7, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(287, 64);
            btnRecargar.TabIndex = 22;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = false;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 48, 43);
            panel1.Controls.Add(btnAgregarLote);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox_productocosecha);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox_Finca);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_TipoSuelo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbExtencion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker_cosecha);
            panel1.Controls.Add(comboBox_TipoRiego);
            panel1.Controls.Add(dateTimePicker_siembra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2912, 430);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(82, 30);
            label7.Name = "label7";
            label7.Size = new Size(374, 50);
            label7.TabIndex = 23;
            label7.Text = "Agregar Nuevo Lote";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 48, 43);
            panel2.Controls.Add(btnRegrsar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 1504);
            panel2.Name = "panel2";
            panel2.Size = new Size(2912, 249);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 48, 43);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnRecargar);
            panel3.Controls.Add(tbBuscarLote);
            panel3.Controls.Add(btnBuscarLote);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(2912, 123);
            panel3.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(82, 41);
            label9.Name = "label9";
            label9.Size = new Size(270, 50);
            label9.TabIndex = 24;
            label9.Text = "Tabla de Lotes";
            // 
            // Lote
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2912, 1271);
            Controls.Add(panel2);
            Controls.Add(LoteTabla);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 7, 7, 7);
            Name = "Lote";
            Text = "Lote";
            Load += Lote_Load;
            ((System.ComponentModel.ISupportInitialize)LoteTabla).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Label label8;
        private ComboBox comboBox_productocosecha;
        private Button btnRecargar;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private Label label9;
    }
}