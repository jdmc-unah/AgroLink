namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class RegistroUsuario
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
            label1 = new Label();
            label2 = new Label();
            txtNombreRegistro = new Label();
            txtNombreNuevo = new TextBox();
            txtUsuarioRegistro = new Label();
            txtUsuarioNuevo = new TextBox();
            label3 = new Label();
            txtClaveNuevo = new TextBox();
            label4 = new Label();
            txtConfirmarClaveNuevo = new TextBox();
            btnRegistro = new Button();
            btnCancelar = new Button();
            txtTipoUsuario = new Label();
            cmbTipoUsuario = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(260, 86);
            label1.Name = "label1";
            label1.Size = new Size(241, 25);
            label1.TabIndex = 0;
            label1.Text = "CREAR UN USUARIO NUEVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 222, 89);
            label2.Location = new Point(279, 32);
            label2.Name = "label2";
            label2.Size = new Size(212, 54);
            label2.TabIndex = 1;
            label2.Text = "REGISTRO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // txtNombreRegistro
            // 
            txtNombreRegistro.AutoSize = true;
            txtNombreRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombreRegistro.ForeColor = Color.White;
            txtNombreRegistro.Location = new Point(125, 148);
            txtNombreRegistro.Name = "txtNombreRegistro";
            txtNombreRegistro.Size = new Size(81, 25);
            txtNombreRegistro.TabIndex = 4;
            txtNombreRegistro.Text = "Nombre";
            // 
            // txtNombreNuevo
            // 
            txtNombreNuevo.Location = new Point(211, 145);
            txtNombreNuevo.Margin = new Padding(2);
            txtNombreNuevo.Name = "txtNombreNuevo";
            txtNombreNuevo.Size = new Size(249, 31);
            txtNombreNuevo.TabIndex = 0;
            // 
            // txtUsuarioRegistro
            // 
            txtUsuarioRegistro.AutoSize = true;
            txtUsuarioRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtUsuarioRegistro.ForeColor = Color.White;
            txtUsuarioRegistro.Location = new Point(125, 205);
            txtUsuarioRegistro.Name = "txtUsuarioRegistro";
            txtUsuarioRegistro.Size = new Size(77, 25);
            txtUsuarioRegistro.TabIndex = 6;
            txtUsuarioRegistro.Text = "Usuario";
            // 
            // txtUsuarioNuevo
            // 
            txtUsuarioNuevo.Location = new Point(211, 202);
            txtUsuarioNuevo.Margin = new Padding(2);
            txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            txtUsuarioNuevo.Size = new Size(249, 31);
            txtUsuarioNuevo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(125, 288);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // txtClaveNuevo
            // 
            txtClaveNuevo.Location = new Point(125, 320);
            txtClaveNuevo.Margin = new Padding(2);
            txtClaveNuevo.Name = "txtClaveNuevo";
            txtClaveNuevo.Size = new Size(243, 31);
            txtClaveNuevo.TabIndex = 7;
            txtClaveNuevo.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(404, 288);
            label4.Name = "label4";
            label4.Size = new Size(191, 25);
            label4.TabIndex = 10;
            label4.Text = "Confirma Contraseña";
            // 
            // txtConfirmarClaveNuevo
            // 
            txtConfirmarClaveNuevo.Location = new Point(404, 320);
            txtConfirmarClaveNuevo.Margin = new Padding(2);
            txtConfirmarClaveNuevo.Name = "txtConfirmarClaveNuevo";
            txtConfirmarClaveNuevo.Size = new Size(243, 31);
            txtConfirmarClaveNuevo.TabIndex = 11;
            txtConfirmarClaveNuevo.UseSystemPasswordChar = true;
            // 
            // btnRegistro
            // 
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistro.ForeColor = Color.White;
            btnRegistro.Location = new Point(125, 410);
            btnRegistro.Margin = new Padding(2);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(243, 35);
            btnRegistro.TabIndex = 12;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(404, 410);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(243, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTipoUsuario
            // 
            txtTipoUsuario.AutoSize = true;
            txtTipoUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTipoUsuario.ForeColor = Color.White;
            txtTipoUsuario.Location = new Point(494, 148);
            txtTipoUsuario.Name = "txtTipoUsuario";
            txtTipoUsuario.Size = new Size(144, 25);
            txtTipoUsuario.TabIndex = 14;
            txtTipoUsuario.Text = "Tipo de usuario";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(483, 202);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(164, 33);
            cmbTipoUsuario.TabIndex = 15;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 43);
            ClientSize = new Size(774, 500);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(txtTipoUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistro);
            Controls.Add(txtConfirmarClaveNuevo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtClaveNuevo);
            Controls.Add(txtUsuarioRegistro);
            Controls.Add(txtUsuarioNuevo);
            Controls.Add(label2);
            Controls.Add(txtNombreRegistro);
            Controls.Add(label1);
            Controls.Add(txtNombreNuevo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Load += RegistroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label txtNombreRegistro;
        private Label label5;
        private Button btnLogin;
        private TextBox txtNombreNuevo;
        private Label txtUsuarioRegistro;
        private TextBox txtUsuarioNuevo;
        private Label label3;
        private TextBox txtClaveNuevo;
        private Label label4;
        private TextBox txtConfirmarClaveNuevo;
        private Button btnRegistro;
        private Button btnCancelar;
        private Label txtTipoUsuario;
        private ComboBox cmbTipoUsuario;
        private TextBox txtClaveRegistro;
    }
}