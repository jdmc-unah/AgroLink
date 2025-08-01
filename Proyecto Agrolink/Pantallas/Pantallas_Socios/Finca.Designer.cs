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
            button1 = new Button();
            btnCancelar = new Button();
            tbCodigoFinca = new TextBox();
            label2 = new Label();
            comboBox_Socio = new ComboBox();
            comboBox_Direccion = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            tbColonia = new TextBox();
            tbDetalleUbicacion = new TextBox();
            comboBox_CapacidadAgua = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 395);
            button1.Name = "button1";
            button1.Size = new Size(181, 33);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(555, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(181, 33);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbCodigoFinca
            // 
            tbCodigoFinca.Location = new Point(76, 31);
            tbCodigoFinca.Name = "tbCodigoFinca";
            tbCodigoFinca.Size = new Size(168, 27);
            tbCodigoFinca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Socio";
            // 
            // comboBox_Socio
            // 
            comboBox_Socio.FormattingEnabled = true;
            comboBox_Socio.Location = new Point(76, 89);
            comboBox_Socio.Name = "comboBox_Socio";
            comboBox_Socio.Size = new Size(168, 28);
            comboBox_Socio.TabIndex = 5;
            // 
            // comboBox_Direccion
            // 
            comboBox_Direccion.FormattingEnabled = true;
            comboBox_Direccion.Location = new Point(90, 155);
            comboBox_Direccion.Name = "comboBox_Direccion";
            comboBox_Direccion.Size = new Size(168, 28);
            comboBox_Direccion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Direccion";
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
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 10;
            label1.Text = "Codigo";
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
            comboBox_CapacidadAgua.Location = new Point(526, 221);
            comboBox_CapacidadAgua.Name = "comboBox_CapacidadAgua";
            comboBox_CapacidadAgua.Size = new Size(210, 28);
            comboBox_CapacidadAgua.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 229);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 14;
            label6.Text = "Capacidad de Agua";
            // 
            // Finca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(comboBox_CapacidadAgua);
            Controls.Add(tbDetalleUbicacion);
            Controls.Add(tbColonia);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Direccion);
            Controls.Add(comboBox_Socio);
            Controls.Add(label2);
            Controls.Add(tbCodigoFinca);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finca";
            Text = "Finca";
            Load += Finca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancelar;
        private TextBox tbCodigoFinca;
        private Label label2;
        private ComboBox comboBox_Socio;
        private ComboBox comboBox_Direccion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox tbColonia;
        private TextBox tbDetalleUbicacion;
        private ComboBox comboBox_CapacidadAgua;
        private Label label6;
    }
}