namespace AgroLink.Pantallas
{
    partial class PantallaPrincipal
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
            panelMain = new Panel();
            button1 = new Button();
            panelSeparador = new Panel();
            panelSubMenuConfig = new Panel();
            subMenuEmpresa = new Button();
            menuConfig = new Button();
            panelSubMenuProductos = new Panel();
            subMenuAlmacenes = new Button();
            subMenuProductos = new Button();
            menuProductos = new Button();
            panelSubMenuSocios = new Panel();
            subMenuSocios = new Button();
            subMenuAgricultores = new Button();
            menuSocios = new Button();
            panelSubMenuTrans = new Panel();
            subMenuSalida = new Button();
            subMenuEntrada = new Button();
            subMenuRecibos = new Button();
            subMenuFacturas = new Button();
            subMenuCompras = new Button();
            subMenuVent = new Button();
            menuTrans = new Button();
            panelImage = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelMain.SuspendLayout();
            panelSubMenuConfig.SuspendLayout();
            panelSubMenuProductos.SuspendLayout();
            panelSubMenuSocios.SuspendLayout();
            panelSubMenuTrans.SuspendLayout();
            panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(22, 48, 43);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(panelSeparador);
            panelMain.Controls.Add(panelSubMenuConfig);
            panelMain.Controls.Add(menuConfig);
            panelMain.Controls.Add(panelSubMenuProductos);
            panelMain.Controls.Add(menuProductos);
            panelMain.Controls.Add(panelSubMenuSocios);
            panelMain.Controls.Add(menuSocios);
            panelMain.Controls.Add(panelSubMenuTrans);
            panelMain.Controls.Add(menuTrans);
            panelMain.Controls.Add(panelImage);
            panelMain.Dock = DockStyle.Left;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(500, 1424);
            panelMain.TabIndex = 1;
            panelMain.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 183, 157);
            button1.Location = new Point(75, 1384);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(299, 75);
            button1.TabIndex = 19;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.FromArgb(192, 229, 200);
            panelSeparador.Location = new Point(26, 1360);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(450, 2);
            panelSeparador.TabIndex = 18;
            // 
            // panelSubMenuConfig
            // 
            panelSubMenuConfig.Controls.Add(subMenuEmpresa);
            panelSubMenuConfig.Dock = DockStyle.Top;
            panelSubMenuConfig.Location = new Point(0, 1150);
            panelSubMenuConfig.Name = "panelSubMenuConfig";
            panelSubMenuConfig.Size = new Size(476, 66);
            panelSubMenuConfig.TabIndex = 17;
            panelSubMenuConfig.Visible = false;
            // 
            // subMenuEmpresa
            // 
            subMenuEmpresa.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEmpresa.Dock = DockStyle.Top;
            subMenuEmpresa.Location = new Point(0, 0);
            subMenuEmpresa.Name = "subMenuEmpresa";
            subMenuEmpresa.Padding = new Padding(31, 0, 0, 0);
            subMenuEmpresa.Size = new Size(476, 71);
            subMenuEmpresa.TabIndex = 1;
            subMenuEmpresa.Text = "Empresa";
            subMenuEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEmpresa.UseVisualStyleBackColor = false;
            subMenuEmpresa.Click += subMenuEmpresa_Click;
            // 
            // menuConfig
            // 
            menuConfig.BackColor = Color.FromArgb(133, 183, 157);
            menuConfig.Dock = DockStyle.Top;
            menuConfig.Location = new Point(0, 1075);
            menuConfig.Name = "menuConfig";
            menuConfig.Padding = new Padding(10, 0, 0, 0);
            menuConfig.Size = new Size(476, 75);
            menuConfig.TabIndex = 16;
            menuConfig.Text = "Configuración";
            menuConfig.TextAlign = ContentAlignment.MiddleLeft;
            menuConfig.UseVisualStyleBackColor = false;
            menuConfig.Click += menuConfig_Click_1;
            // 
            // panelSubMenuProductos
            // 
            panelSubMenuProductos.Controls.Add(subMenuAlmacenes);
            panelSubMenuProductos.Controls.Add(subMenuProductos);
            panelSubMenuProductos.Dock = DockStyle.Top;
            panelSubMenuProductos.Location = new Point(0, 937);
            panelSubMenuProductos.Name = "panelSubMenuProductos";
            panelSubMenuProductos.Size = new Size(476, 138);
            panelSubMenuProductos.TabIndex = 15;
            panelSubMenuProductos.Visible = false;
            // 
            // subMenuAlmacenes
            // 
            subMenuAlmacenes.BackColor = Color.FromArgb(192, 229, 200);
            subMenuAlmacenes.Dock = DockStyle.Top;
            subMenuAlmacenes.Location = new Point(0, 71);
            subMenuAlmacenes.Name = "subMenuAlmacenes";
            subMenuAlmacenes.Padding = new Padding(31, 0, 0, 0);
            subMenuAlmacenes.Size = new Size(476, 71);
            subMenuAlmacenes.TabIndex = 2;
            subMenuAlmacenes.Text = "Almacenes";
            subMenuAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            subMenuAlmacenes.UseVisualStyleBackColor = false;
            // 
            // subMenuProductos
            // 
            subMenuProductos.BackColor = Color.FromArgb(192, 229, 200);
            subMenuProductos.Dock = DockStyle.Top;
            subMenuProductos.Location = new Point(0, 0);
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Padding = new Padding(31, 0, 0, 0);
            subMenuProductos.Size = new Size(476, 71);
            subMenuProductos.TabIndex = 1;
            subMenuProductos.Text = "Productos";
            subMenuProductos.TextAlign = ContentAlignment.MiddleLeft;
            subMenuProductos.UseVisualStyleBackColor = false;
            subMenuProductos.Click += subMenuProductos_Click;
            // 
            // menuProductos
            // 
            menuProductos.BackColor = Color.FromArgb(133, 183, 157);
            menuProductos.Dock = DockStyle.Top;
            menuProductos.Location = new Point(0, 862);
            menuProductos.Name = "menuProductos";
            menuProductos.Padding = new Padding(10, 0, 0, 0);
            menuProductos.Size = new Size(476, 75);
            menuProductos.TabIndex = 14;
            menuProductos.Text = "Productos";
            menuProductos.TextAlign = ContentAlignment.MiddleLeft;
            menuProductos.UseVisualStyleBackColor = false;
            menuProductos.Click += menuProductos_Click;
            // 
            // panelSubMenuSocios
            // 
            panelSubMenuSocios.Controls.Add(subMenuSocios);
            panelSubMenuSocios.Controls.Add(subMenuAgricultores);
            panelSubMenuSocios.Dock = DockStyle.Top;
            panelSubMenuSocios.Location = new Point(0, 724);
            panelSubMenuSocios.Name = "panelSubMenuSocios";
            panelSubMenuSocios.Size = new Size(476, 138);
            panelSubMenuSocios.TabIndex = 13;
            panelSubMenuSocios.Visible = false;
            // 
            // subMenuSocios
            // 
            subMenuSocios.BackColor = Color.FromArgb(192, 229, 200);
            subMenuSocios.Dock = DockStyle.Top;
            subMenuSocios.Location = new Point(0, 71);
            subMenuSocios.Name = "subMenuSocios";
            subMenuSocios.Padding = new Padding(31, 0, 0, 0);
            subMenuSocios.Size = new Size(476, 71);
            subMenuSocios.TabIndex = 2;
            subMenuSocios.Text = "Socios";
            subMenuSocios.TextAlign = ContentAlignment.MiddleLeft;
            subMenuSocios.UseVisualStyleBackColor = false;
            // 
            // subMenuAgricultores
            // 
            subMenuAgricultores.BackColor = Color.FromArgb(192, 229, 200);
            subMenuAgricultores.Dock = DockStyle.Top;
            subMenuAgricultores.Location = new Point(0, 0);
            subMenuAgricultores.Name = "subMenuAgricultores";
            subMenuAgricultores.Padding = new Padding(31, 0, 0, 0);
            subMenuAgricultores.Size = new Size(476, 71);
            subMenuAgricultores.TabIndex = 1;
            subMenuAgricultores.Text = "Agricultores";
            subMenuAgricultores.TextAlign = ContentAlignment.MiddleLeft;
            subMenuAgricultores.UseVisualStyleBackColor = false;
            // 
            // menuSocios
            // 
            menuSocios.BackColor = Color.FromArgb(133, 183, 157);
            menuSocios.Dock = DockStyle.Top;
            menuSocios.Location = new Point(0, 649);
            menuSocios.Name = "menuSocios";
            menuSocios.Padding = new Padding(10, 0, 0, 0);
            menuSocios.Size = new Size(476, 75);
            menuSocios.TabIndex = 12;
            menuSocios.Text = "Socios";
            menuSocios.TextAlign = ContentAlignment.MiddleLeft;
            menuSocios.UseVisualStyleBackColor = false;
            menuSocios.Click += menuSocios_Click;
            // 
            // panelSubMenuTrans
            // 
            panelSubMenuTrans.Controls.Add(subMenuSalida);
            panelSubMenuTrans.Controls.Add(subMenuEntrada);
            panelSubMenuTrans.Controls.Add(subMenuRecibos);
            panelSubMenuTrans.Controls.Add(subMenuFacturas);
            panelSubMenuTrans.Controls.Add(subMenuCompras);
            panelSubMenuTrans.Controls.Add(subMenuVent);
            panelSubMenuTrans.Dock = DockStyle.Top;
            panelSubMenuTrans.Location = new Point(0, 288);
            panelSubMenuTrans.Name = "panelSubMenuTrans";
            panelSubMenuTrans.Size = new Size(476, 361);
            panelSubMenuTrans.TabIndex = 9;
            panelSubMenuTrans.Visible = false;
            // 
            // subMenuSalida
            // 
            subMenuSalida.Dock = DockStyle.Top;
            subMenuSalida.Location = new Point(0, 355);
            subMenuSalida.Name = "subMenuSalida";
            subMenuSalida.Padding = new Padding(31, 0, 0, 0);
            subMenuSalida.Size = new Size(476, 71);
            subMenuSalida.TabIndex = 9;
            subMenuSalida.Text = "Salida de Producto";
            subMenuSalida.TextAlign = ContentAlignment.MiddleLeft;
            subMenuSalida.UseVisualStyleBackColor = true;
            // 
            // subMenuEntrada
            // 
            subMenuEntrada.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEntrada.Dock = DockStyle.Top;
            subMenuEntrada.Location = new Point(0, 284);
            subMenuEntrada.Name = "subMenuEntrada";
            subMenuEntrada.Padding = new Padding(31, 0, 0, 0);
            subMenuEntrada.Size = new Size(476, 71);
            subMenuEntrada.TabIndex = 8;
            subMenuEntrada.Text = "Entrada de Producto";
            subMenuEntrada.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEntrada.UseVisualStyleBackColor = false;
            // 
            // subMenuRecibos
            // 
            subMenuRecibos.BackColor = Color.FromArgb(192, 229, 200);
            subMenuRecibos.Dock = DockStyle.Top;
            subMenuRecibos.Location = new Point(0, 213);
            subMenuRecibos.Name = "subMenuRecibos";
            subMenuRecibos.Padding = new Padding(31, 0, 0, 0);
            subMenuRecibos.Size = new Size(476, 71);
            subMenuRecibos.TabIndex = 7;
            subMenuRecibos.Text = "Recibos";
            subMenuRecibos.TextAlign = ContentAlignment.MiddleLeft;
            subMenuRecibos.UseVisualStyleBackColor = false;
            // 
            // subMenuFacturas
            // 
            subMenuFacturas.BackColor = Color.FromArgb(192, 229, 200);
            subMenuFacturas.Dock = DockStyle.Top;
            subMenuFacturas.Location = new Point(0, 142);
            subMenuFacturas.Name = "subMenuFacturas";
            subMenuFacturas.Padding = new Padding(31, 0, 0, 0);
            subMenuFacturas.Size = new Size(476, 71);
            subMenuFacturas.TabIndex = 6;
            subMenuFacturas.Text = "Facturas";
            subMenuFacturas.TextAlign = ContentAlignment.MiddleLeft;
            subMenuFacturas.UseVisualStyleBackColor = false;
            // 
            // subMenuCompras
            // 
            subMenuCompras.BackColor = Color.FromArgb(192, 229, 200);
            subMenuCompras.Dock = DockStyle.Top;
            subMenuCompras.Location = new Point(0, 71);
            subMenuCompras.Name = "subMenuCompras";
            subMenuCompras.Padding = new Padding(31, 0, 0, 0);
            subMenuCompras.Size = new Size(476, 71);
            subMenuCompras.TabIndex = 5;
            subMenuCompras.Text = "Compras";
            subMenuCompras.TextAlign = ContentAlignment.MiddleLeft;
            subMenuCompras.UseVisualStyleBackColor = false;
            // 
            // subMenuVent
            // 
            subMenuVent.BackColor = Color.FromArgb(192, 229, 200);
            subMenuVent.Dock = DockStyle.Top;
            subMenuVent.Location = new Point(0, 0);
            subMenuVent.Name = "subMenuVent";
            subMenuVent.Padding = new Padding(31, 0, 0, 0);
            subMenuVent.Size = new Size(476, 71);
            subMenuVent.TabIndex = 4;
            subMenuVent.Text = "Ventas";
            subMenuVent.TextAlign = ContentAlignment.MiddleLeft;
            subMenuVent.UseVisualStyleBackColor = false;
            subMenuVent.Click += subMenuVent_Click;
            // 
            // menuTrans
            // 
            menuTrans.BackColor = Color.FromArgb(133, 183, 157);
            menuTrans.Dock = DockStyle.Top;
            menuTrans.Location = new Point(0, 213);
            menuTrans.Name = "menuTrans";
            menuTrans.Padding = new Padding(10, 0, 0, 0);
            menuTrans.Size = new Size(476, 75);
            menuTrans.TabIndex = 3;
            menuTrans.Text = "Transacciones";
            menuTrans.TextAlign = ContentAlignment.MiddleLeft;
            menuTrans.UseVisualStyleBackColor = false;
            menuTrans.Click += menuTrans_Click;
            // 
            // panelImage
            // 
            panelImage.Controls.Add(pictureBox1);
            panelImage.Dock = DockStyle.Top;
            panelImage.Location = new Point(0, 0);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(476, 213);
            panelImage.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LogoCOPRAG;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(500, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(2236, 1424);
            panelChildForm.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2736, 1424);
            Controls.Add(panelChildForm);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(3293, 1579);
            MinimumSize = new Size(1910, 998);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelMain.ResumeLayout(false);
            panelSubMenuConfig.ResumeLayout(false);
            panelSubMenuProductos.ResumeLayout(false);
            panelSubMenuSocios.ResumeLayout(false);
            panelSubMenuTrans.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Button subMenuVent;
        private Button menuTrans;
        private Panel panelImage;
        private Panel panelSubMenuTrans;
        private PictureBox pictureBox1;
        private Panel panelChildForm;
        private Button subMenuSalida;
        private Button subMenuEntrada;
        private Button subMenuRecibos;
        private Button subMenuFacturas;
        private Button subMenuCompras;
        private Panel panelSubMenuProductos;
        private Button subMenuAlmacenes;
        private Button subMenuProductos;
        private Button menuProductos;
        private Panel panelSubMenuSocios;
        private Button subMenuSocios;
        private Button subMenuAgricultores;
        private Button menuSocios;
        private Panel panelSubMenuConfig;
        private Button subMenuEmpresa;
        private Button menuConfig;
        private Panel panelSeparador;
        private Button button1;
    }
}