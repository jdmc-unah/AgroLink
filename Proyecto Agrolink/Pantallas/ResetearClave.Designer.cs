namespace AgroLink.Pantallas
{
    partial class ResetearClave
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
            btnCancelar = new Button();
            btnRestablecer = new Button();
            txtConfirmarClaveRC = new TextBox();
            label4 = new Label();
            txtClaveRC = new TextBox();
            lbNombreRC = new Label();
            txtNombreRC = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            lbUsuarioRC = new Label();
            txtUsuarioRC = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(405, 410);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(243, 35);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRestablecer
            // 
            btnRestablecer.FlatStyle = FlatStyle.Flat;
            btnRestablecer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRestablecer.ForeColor = Color.White;
            btnRestablecer.Location = new Point(126, 410);
            btnRestablecer.Margin = new Padding(2);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(243, 35);
            btnRestablecer.TabIndex = 26;
            btnRestablecer.Text = "Restablecer";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // txtConfirmarClaveRC
            // 
            txtConfirmarClaveRC.Location = new Point(405, 320);
            txtConfirmarClaveRC.Margin = new Padding(2);
            txtConfirmarClaveRC.Name = "txtConfirmarClaveRC";
            txtConfirmarClaveRC.PasswordChar = '*';
            txtConfirmarClaveRC.Size = new Size(243, 31);
            txtConfirmarClaveRC.TabIndex = 25;
            txtConfirmarClaveRC.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(405, 288);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 24;
            label4.Text = "Confirma Contraseña";
            // 
            // txtClaveRC
            // 
            txtClaveRC.Location = new Point(126, 320);
            txtClaveRC.Margin = new Padding(2);
            txtClaveRC.Name = "txtClaveRC";
            txtClaveRC.PasswordChar = '*';
            txtClaveRC.Size = new Size(243, 31);
            txtClaveRC.TabIndex = 22;
            txtClaveRC.UseSystemPasswordChar = true;
            // 
            // lbNombreRC
            // 
            lbNombreRC.AutoSize = true;
            lbNombreRC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNombreRC.ForeColor = Color.White;
            lbNombreRC.Location = new Point(126, 151);
            lbNombreRC.Name = "lbNombreRC";
            lbNombreRC.Size = new Size(81, 25);
            lbNombreRC.TabIndex = 21;
            lbNombreRC.Text = "Nombre";
            // 
            // txtNombreRC
            // 
            txtNombreRC.Location = new Point(212, 148);
            txtNombreRC.Margin = new Padding(2);
            txtNombreRC.Name = "txtNombreRC";
            txtNombreRC.Size = new Size(436, 31);
            txtNombreRC.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 222, 89);
            label2.Location = new Point(232, 32);
            label2.Name = "label2";
            label2.Size = new Size(300, 54);
            label2.TabIndex = 18;
            label2.Text = "REESTABLECER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 86);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 16;
            label1.Text = "CONTRASEÑA";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(126, 288);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 32;
            label5.Text = "Nueva Contraseña";
            // 
            // lbUsuarioRC
            // 
            lbUsuarioRC.AutoSize = true;
            lbUsuarioRC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbUsuarioRC.ForeColor = Color.White;
            lbUsuarioRC.Location = new Point(126, 218);
            lbUsuarioRC.Name = "lbUsuarioRC";
            lbUsuarioRC.Size = new Size(77, 25);
            lbUsuarioRC.TabIndex = 34;
            lbUsuarioRC.Text = "Usuario";
            // 
            // txtUsuarioRC
            // 
            txtUsuarioRC.Location = new Point(212, 215);
            txtUsuarioRC.Margin = new Padding(2);
            txtUsuarioRC.Name = "txtUsuarioRC";
            txtUsuarioRC.Size = new Size(436, 31);
            txtUsuarioRC.TabIndex = 33;
            // 
            // ResetearClave
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(774, 500);
            Controls.Add(lbUsuarioRC);
            Controls.Add(txtUsuarioRC);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnRestablecer);
            Controls.Add(txtConfirmarClaveRC);
            Controls.Add(label4);
            Controls.Add(txtClaveRC);
            Controls.Add(lbNombreRC);
            Controls.Add(txtNombreRC);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ResetearClave";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private Button btnRestablecer;
        private TextBox txtConfirmarClaveRC;
        private Label label4;
        private TextBox txtClaveRC;
        private Label lbNombreRC;
        private TextBox txtNombreRC;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lbUsuarioRC;
        private TextBox txtUsuarioRC;
    }
}