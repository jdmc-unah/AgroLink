namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class Finca
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            comboBox_Socio = new ComboBox();
            comboBox_Municipio = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            tbColonia = new TextBox();
            tbDetalleUbicacion = new TextBox();
            comboBox_CapacidadAgua = new ComboBox();
            label6 = new Label();
            comboBox_Departamento = new ComboBox();
            label7 = new Label();
            tbNombreFinca = new TextBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(24, 376);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(190, 52);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(544, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(192, 52);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Socio";
            // 
            // comboBox_Socio
            // 
            comboBox_Socio.FormattingEnabled = true;
            comboBox_Socio.Location = new Point(91, 95);
            comboBox_Socio.Name = "comboBox_Socio";
            comboBox_Socio.Size = new Size(168, 28);
            comboBox_Socio.TabIndex = 5;
            // 
            // comboBox_Municipio
            // 
            comboBox_Municipio.FormattingEnabled = true;
            comboBox_Municipio.Location = new Point(91, 216);
            comboBox_Municipio.Name = "comboBox_Municipio";
            comboBox_Municipio.Size = new Size(199, 28);
            comboBox_Municipio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 224);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Municipio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 38);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Tag = "";
            label4.Text = "Colonia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(389, 89);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "Detalle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 38);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre de Finca";
            // 
            // tbColonia
            // 
            tbColonia.Location = new Point(466, 38);
            tbColonia.Name = "tbColonia";
            tbColonia.Size = new Size(270, 27);
            tbColonia.TabIndex = 11;
            // 
            // tbDetalleUbicacion
            // 
            tbDetalleUbicacion.Location = new Point(455, 95);
            tbDetalleUbicacion.Multiline = true;
            tbDetalleUbicacion.Name = "tbDetalleUbicacion";
            tbDetalleUbicacion.Size = new Size(317, 88);
            tbDetalleUbicacion.TabIndex = 12;
            // 
            // comboBox_CapacidadAgua
            // 
            comboBox_CapacidadAgua.FormattingEnabled = true;
            comboBox_CapacidadAgua.Location = new Point(474, 221);
            comboBox_CapacidadAgua.Name = "comboBox_CapacidadAgua";
            comboBox_CapacidadAgua.Size = new Size(210, 28);
            comboBox_CapacidadAgua.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 229);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 14;
            label6.Text = "Capacidad de Agua";
            // 
            // comboBox_Departamento
            // 
            comboBox_Departamento.FormattingEnabled = true;
            comboBox_Departamento.Location = new Point(122, 155);
            comboBox_Departamento.Name = "comboBox_Departamento";
            comboBox_Departamento.Size = new Size(208, 28);
            comboBox_Departamento.TabIndex = 15;
            comboBox_Departamento.SelectedIndexChanged += comboBox_Departamento_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 158);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 16;
            label7.Text = "Departamento";
            // 
            // tbNombreFinca
            // 
            tbNombreFinca.Location = new Point(130, 38);
            tbNombreFinca.Name = "tbNombreFinca";
            tbNombreFinca.Size = new Size(200, 27);
            tbNombreFinca.TabIndex = 17;
            // 
            // Finca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbNombreFinca);
            Controls.Add(label7);
            Controls.Add(comboBox_Departamento);
            Controls.Add(label6);
            Controls.Add(comboBox_CapacidadAgua);
            Controls.Add(tbDetalleUbicacion);
            Controls.Add(tbColonia);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Municipio);
            Controls.Add(comboBox_Socio);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finca";
            Text = "Finca";
            Load += Finca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label2;
        private ComboBox comboBox_Socio;
        private ComboBox comboBox_Municipio;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox tbColonia;
        private TextBox tbDetalleUbicacion;
        private ComboBox comboBox_CapacidadAgua;
        private Label label6;
        private ComboBox comboBox_Departamento;
        private Label label7;
        private TextBox tbNombreFinca;
    }
}