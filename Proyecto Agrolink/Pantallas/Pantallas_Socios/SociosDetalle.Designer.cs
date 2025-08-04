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
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(52, 387);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(159, 51);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(461, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(156, 51);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(86, 36);
            tbnombre.Name = "tbnombre";
            tbnombre.PlaceholderText = "Ingrese su Nombre";
            tbnombre.Size = new Size(190, 27);
            tbnombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 217);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "RTN";
            label2.Click += label2_Click;
            // 
            // tbRTN
            // 
            tbRTN.Location = new Point(80, 217);
            tbRTN.Name = "tbRTN";
            tbRTN.PlaceholderText = "Ingrese su RTN";
            tbRTN.Size = new Size(196, 27);
            tbRTN.TabIndex = 6;
            // 
            // tbIdentidad
            // 
            tbIdentidad.Location = new Point(86, 99);
            tbIdentidad.Name = "tbIdentidad";
            tbIdentidad.Size = new Size(196, 27);
            tbIdentidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 106);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Identidad";
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(80, 265);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(196, 27);
            tbCorreo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 265);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 10;
            label4.Text = " Correo";
            // 
            // textBox_telefono
            // 
            textBox_telefono.Location = new Point(80, 316);
            textBox_telefono.Name = "textBox_telefono";
            textBox_telefono.Size = new Size(196, 27);
            textBox_telefono.TabIndex = 11;
            // 
            // tbNotas
            // 
            tbNotas.Location = new Point(449, 243);
            tbNotas.Multiline = true;
            tbNotas.Name = "tbNotas";
            tbNotas.Size = new Size(232, 61);
            tbNotas.TabIndex = 12;
            // 
            // tbsaldoInicial
            // 
            tbsaldoInicial.Location = new Point(449, 323);
            tbsaldoInicial.Name = "tbsaldoInicial";
            tbsaldoInicial.ReadOnly = true;
            tbsaldoInicial.Size = new Size(232, 27);
            tbsaldoInicial.TabIndex = 13;
            tbsaldoInicial.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 319);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 323);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 15;
            label6.Text = "Saldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 265);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 16;
            label7.Text = "Notas";
            label7.Click += label7_Click;
            // 
            // comboBox_Departamento
            // 
            comboBox_Departamento.FormattingEnabled = true;
            comboBox_Departamento.Location = new Point(449, 26);
            comboBox_Departamento.Name = "comboBox_Departamento";
            comboBox_Departamento.Size = new Size(232, 28);
            comboBox_Departamento.TabIndex = 17;
            comboBox_Departamento.SelectedIndexChanged += comboBox_Departamento_SelectedIndexChanged;
            // 
            // comboBox_Municipio
            // 
            comboBox_Municipio.FormattingEnabled = true;
            comboBox_Municipio.Location = new Point(449, 78);
            comboBox_Municipio.Name = "comboBox_Municipio";
            comboBox_Municipio.Size = new Size(232, 28);
            comboBox_Municipio.TabIndex = 18;
            // 
            // tbColonia
            // 
            tbColonia.Location = new Point(449, 129);
            tbColonia.Name = "tbColonia";
            tbColonia.Size = new Size(232, 27);
            tbColonia.TabIndex = 19;
            // 
            // tbDetalleUbicacion
            // 
            tbDetalleUbicacion.Location = new Point(449, 175);
            tbDetalleUbicacion.Multiline = true;
            tbDetalleUbicacion.Name = "tbDetalleUbicacion";
            tbDetalleUbicacion.Size = new Size(232, 62);
            tbDetalleUbicacion.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(297, 199);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 21;
            label8.Text = "detalle de Ubicacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 132);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 22;
            label9.Text = "Colonia";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 29);
            label10.Name = "label10";
            label10.Size = new Size(101, 20);
            label10.TabIndex = 23;
            label10.Text = "Depatamento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(367, 86);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 24;
            label11.Text = "Municipio";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 154);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 25;
            label12.Text = "Tipo";
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Location = new Point(80, 154);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(196, 28);
            comboBox_tipo.TabIndex = 26;
            // 
            // SociosDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
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
    }
}