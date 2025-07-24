namespace AgroLink
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            panelLogin = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(86, 228);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 31);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(86, 321);
            txtClave.Margin = new Padding(2);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(299, 31);
            txtClave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(95, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 41);
            label1.TabIndex = 2;
            label1.Text = "INICIO DE SESIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(160, 490);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(22, 48, 43);
            panelLogin.Controls.Add(linkLabel2);
            panelLogin.Controls.Add(linkLabel1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(txtClave);
            panelLogin.Location = new Point(261, 166);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(480, 652);
            panelLogin.TabIndex = 4;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(255, 222, 89);
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.Gray;
            linkLabel2.Location = new Point(114, 447);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(235, 28);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "¿Olvidaste tu contraseña?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(255, 222, 89);
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(130, 548);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(193, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Crear Nuevo Usuario";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 289);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 196);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 4;
            label2.Text = "Usuario";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.fondoInicioSesionCOPRAG;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1900, 1050);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 1050);
            Controls.Add(panelLogin);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            Resize += Login_Resize;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label1;
        private Button btnLogin;
        private Panel panelLogin;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
