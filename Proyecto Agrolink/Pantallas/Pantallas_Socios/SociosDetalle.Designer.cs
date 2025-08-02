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
            textBox1 = new TextBox();
            label2 = new Label();
            tbRTN = new TextBox();
            tbIdentidad = new TextBox();
            label3 = new Label();
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
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(528, 387);
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
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 56);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese su Nombre";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "RTN";
            label2.Click += label2_Click;
            // 
            // tbRTN
            // 
            tbRTN.Location = new Point(80, 117);
            tbRTN.Name = "tbRTN";
            tbRTN.PlaceholderText = "Ingrese Numero de Identidad";
            tbRTN.Size = new Size(202, 27);
            tbRTN.TabIndex = 6;
            // 
            // tbIdentidad
            // 
            tbIdentidad.Location = new Point(86, 181);
            tbIdentidad.Name = "tbIdentidad";
            tbIdentidad.Size = new Size(196, 27);
            tbIdentidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 184);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Identidad";
            // 
            // SociosDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tbIdentidad);
            Controls.Add(tbRTN);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SociosDetalle";
            Text = "SociosDetalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox tbRTN;
        private TextBox tbIdentidad;
        private Label label3;
    }
}