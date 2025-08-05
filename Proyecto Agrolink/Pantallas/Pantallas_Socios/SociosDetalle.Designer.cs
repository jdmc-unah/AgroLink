namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class SociosDetalle
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
            label1 = new Label();
            tbnombre = new TextBox();
            label2 = new Label();
            tbRTN = new TextBox();
            tbIdentidad = new TextBox();
            label3 = new Label();
            tbCorreo = new TextBox();
            label4 = new Label();
            textBox_telefono = new TextBox();
            tbNotas = new TextBox();
            tbsaldoInicial = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox_Departamento = new ComboBox();
            comboBox_Municipio = new ComboBox();
            tbColonia = new TextBox();
            tbDetalleUbicacion = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBox_tipo = new ComboBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(255, 222, 89);
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(2048, 1509);
            btnAceptar.Margin = new Padding(7, 7, 7, 7);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(245, 84);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.Location = new Point(2404, 1509);
            btnCancelar.Margin = new Padding(7, 7, 7, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(245, 84);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(212, 290);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 41);
            label1.TabIndex = 3;
            label1.Text = "Socio";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(347, 376);
            tbnombre.Margin = new Padding(7, 7, 7, 7);
            tbnombre.Name = "tbnombre";
            tbnombre.PlaceholderText = "Ingrese su Nombre";
            tbnombre.Size = new Size(398, 47);
            tbnombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(2060, 525);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 41);
            label2.TabIndex = 5;
            label2.Text = "RTN";
            label2.Click += label2_Click;
            // 
            // tbRTN
            // 
            tbRTN.Location = new Point(2190, 587);
            tbRTN.Margin = new Padding(7, 7, 7, 7);
            tbRTN.Name = "tbRTN";
            tbRTN.PlaceholderText = "Ingrese su RTN";
            tbRTN.Size = new Size(412, 47);
            tbRTN.TabIndex = 6;
            // 
            // tbIdentidad
            // 
            tbIdentidad.Location = new Point(347, 587);
            tbIdentidad.Margin = new Padding(7, 7, 7, 7);
            tbIdentidad.Name = "tbIdentidad";
            tbIdentidad.PlaceholderText = "Ingrese su DNI";
            tbIdentidad.Size = new Size(412, 47);
            tbIdentidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(212, 525);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 8;
            label3.Text = "Identidad";
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(2190, 822);
            tbCorreo.Margin = new Padding(7, 7, 7, 7);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.PlaceholderText = "Ingrese su correo";
            tbCorreo.Size = new Size(412, 47);
            tbCorreo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(2060, 759);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 41);
            label4.TabIndex = 10;
            label4.Text = " Correo";
            // 
            // textBox_telefono
            // 
            textBox_telefono.Location = new Point(2173, 376);
            textBox_telefono.Margin = new Padding(7, 7, 7, 7);
            textBox_telefono.Name = "textBox_telefono";
            textBox_telefono.PlaceholderText = "Ingrese su telefono";
            textBox_telefono.Size = new Size(412, 47);
            textBox_telefono.TabIndex = 11;
            // 
            // tbNotas
            // 
            tbNotas.Location = new Point(2190, 1082);
            tbNotas.Margin = new Padding(7, 7, 7, 7);
            tbNotas.Multiline = true;
            tbNotas.Name = "tbNotas";
            tbNotas.Size = new Size(488, 120);
            tbNotas.TabIndex = 12;
            // 
            // tbsaldoInicial
            // 
            tbsaldoInicial.Location = new Point(347, 1082);
            tbsaldoInicial.Margin = new Padding(7, 7, 7, 7);
            tbsaldoInicial.Name = "tbsaldoInicial";
            tbsaldoInicial.ReadOnly = true;
            tbsaldoInicial.Size = new Size(412, 47);
            tbsaldoInicial.TabIndex = 13;
            tbsaldoInicial.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(2060, 294);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 41);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(212, 1004);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 41);
            label6.TabIndex = 15;
            label6.Text = "Saldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(2060, 1009);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 41);
            label7.TabIndex = 16;
            label7.Text = "Notas";
            label7.Click += label7_Click;
            // 
            // comboBox_Departamento
            // 
            comboBox_Departamento.FormattingEnabled = true;
            comboBox_Departamento.Location = new Point(1238, 372);
            comboBox_Departamento.Margin = new Padding(7, 7, 7, 7);
            comboBox_Departamento.Name = "comboBox_Departamento";
            comboBox_Departamento.Size = new Size(488, 49);
            comboBox_Departamento.TabIndex = 17;
            comboBox_Departamento.SelectedIndexChanged += comboBox_Departamento_SelectedIndexChanged;
            // 
            // comboBox_Municipio
            // 
            comboBox_Municipio.FormattingEnabled = true;
            comboBox_Municipio.Location = new Point(1238, 587);
            comboBox_Municipio.Margin = new Padding(7, 7, 7, 7);
            comboBox_Municipio.Name = "comboBox_Municipio";
            comboBox_Municipio.Size = new Size(488, 49);
            comboBox_Municipio.TabIndex = 18;
            // 
            // tbColonia
            // 
            tbColonia.Location = new Point(1238, 815);
            tbColonia.Margin = new Padding(7, 7, 7, 7);
            tbColonia.Name = "tbColonia";
            tbColonia.PlaceholderText = "Ingrese donde reside";
            tbColonia.Size = new Size(488, 47);
            tbColonia.TabIndex = 19;
            // 
            // tbDetalleUbicacion
            // 
            tbDetalleUbicacion.Location = new Point(1238, 1081);
            tbDetalleUbicacion.Margin = new Padding(7, 7, 7, 7);
            tbDetalleUbicacion.Multiline = true;
            tbDetalleUbicacion.Name = "tbDetalleUbicacion";
            tbDetalleUbicacion.Size = new Size(488, 124);
            tbDetalleUbicacion.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(1071, 1004);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 41);
            label8.TabIndex = 21;
            label8.Text = " Ubicacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(1071, 763);
            label9.Margin = new Padding(7, 0, 7, 0);
            label9.Name = "label9";
            label9.Size = new Size(119, 41);
            label9.TabIndex = 22;
            label9.Text = "Colonia";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(1071, 290);
            label10.Margin = new Padding(7, 0, 7, 0);
            label10.Name = "label10";
            label10.Size = new Size(200, 41);
            label10.TabIndex = 23;
            label10.Text = "Depatamento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(1071, 525);
            label11.Margin = new Padding(7, 0, 7, 0);
            label11.Name = "label11";
            label11.Size = new Size(150, 41);
            label11.TabIndex = 24;
            label11.Text = "Municipio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(212, 759);
            label12.Margin = new Padding(7, 0, 7, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 41);
            label12.TabIndex = 25;
            label12.Text = "Tipo";
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Location = new Point(347, 822);
            comboBox_tipo.Margin = new Padding(7, 7, 7, 7);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(412, 49);
            comboBox_tipo.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(133, 82);
            label13.Name = "label13";
            label13.Size = new Size(423, 54);
            label13.TabIndex = 27;
            label13.Text = "Agregar Nuevo Socio";
            // 
            // SociosDetalle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(2035, 1408);
            Controls.Add(label13);
            Controls.Add(comboBox_tipo);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbDetalleUbicacion);
            Controls.Add(tbColonia);
            Controls.Add(comboBox_Municipio);
            Controls.Add(comboBox_Departamento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbsaldoInicial);
            Controls.Add(tbNotas);
            Controls.Add(textBox_telefono);
            Controls.Add(label4);
            Controls.Add(tbCorreo);
            Controls.Add(label3);
            Controls.Add(tbIdentidad);
            Controls.Add(tbRTN);
            Controls.Add(label2);
            Controls.Add(tbnombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 7, 7, 7);
            Name = "SociosDetalle";
            Text = "SociosDetalle";
            Load += SociosDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private TextBox tbnombre;
        private Label label2;
        private TextBox tbRTN;
        private TextBox tbIdentidad;
        private Label label3;
        private TextBox tbCorreo;
        private Label label4;
        private TextBox textBox_telefono;
        private TextBox tbNotas;
        private TextBox tbsaldoInicial;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox_Departamento;
        private ComboBox comboBox_Municipio;
        private TextBox tbColonia;
        private TextBox tbDetalleUbicacion;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboBox_tipo;
        private Label label13;
    }
}