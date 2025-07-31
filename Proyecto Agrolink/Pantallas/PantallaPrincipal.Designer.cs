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
            subMenuTipoProducto = new Button();
            subMenuListaPrecios = new Button();
            menuConfig = new Button();
            panelSubMenuProductos = new Panel();
            subMenuBodegas = new Button();
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
            subMenuEntrega = new Button();
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
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(553, 1319);
            panelMain.TabIndex = 1;
            panelMain.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 183, 157);
            button1.Location = new Point(128, 2269);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Padding = new Padding(11, 0, 0, 0);
            button1.Size = new Size(300, 76);
            button1.TabIndex = 19;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.FromArgb(192, 229, 200);
            panelSeparador.Location = new Point(45, 2230);
            panelSeparador.Margin = new Padding(2);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(450, 2);
            panelSeparador.TabIndex = 18;
            // 
            // panelSubMenuConfig
            // 
            panelSubMenuConfig.Controls.Add(subMenuListaPrecios);
            panelSubMenuConfig.Controls.Add(subMenuTipoProducto);
            panelSubMenuConfig.Controls.Add(subMenuEmpresa);
            panelSubMenuConfig.Dock = DockStyle.Top;
            panelSubMenuConfig.Location = new Point(0, 1305);
            panelSubMenuConfig.Margin = new Padding(2);
            panelSubMenuConfig.Name = "panelSubMenuConfig";
            panelSubMenuConfig.Size = new Size(510, 216);
            panelSubMenuConfig.TabIndex = 17;
            panelSubMenuConfig.Visible = false;
            // 
            // subMenuEmpresa
            // 
            subMenuEmpresa.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEmpresa.Dock = DockStyle.Top;
            subMenuEmpresa.Location = new Point(0, 144);
            subMenuEmpresa.Margin = new Padding(2);
            subMenuEmpresa.Name = "subMenuEmpresa";
            subMenuEmpresa.Padding = new Padding(32, 0, 0, 0);
            subMenuEmpresa.Size = new Size(510, 72);
            subMenuEmpresa.TabIndex = 1;
            subMenuEmpresa.Text = "Empresa";
            subMenuEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEmpresa.UseVisualStyleBackColor = false;
            subMenuEmpresa.Click += subMenuEmpresa_Click;
            // 
            // subMenuTipoProducto
            // 
            subMenuTipoProducto.BackColor = Color.FromArgb(192, 229, 200);
            subMenuTipoProducto.Dock = DockStyle.Top;
            subMenuTipoProducto.Location = new Point(0, 72);
            subMenuTipoProducto.Margin = new Padding(2);
            subMenuTipoProducto.Name = "subMenuTipoProducto";
            subMenuTipoProducto.Padding = new Padding(32, 0, 0, 0);
            subMenuTipoProducto.Size = new Size(510, 72);
            subMenuTipoProducto.TabIndex = 2;
            subMenuTipoProducto.Text = "Tipo de Producto";
            subMenuTipoProducto.TextAlign = ContentAlignment.MiddleLeft;
subMenuTipoProducto.UseVisualStyleBackColor = false;
subMenuTipoProducto.Click += subMenuTipoProducto_Click;
            // 
            // subMenuListaPrecios
            // 
            subMenuListaPrecios.BackColor = Color.FromArgb(192, 229, 200);
            subMenuListaPrecios.Dock = DockStyle.Top;
            subMenuListaPrecios.Location = new Point(0, 0);
            subMenuListaPrecios.Margin = new Padding(2);
            subMenuListaPrecios.Name = "subMenuListaPrecios";
            subMenuListaPrecios.Padding = new Padding(32, 0, 0, 0);
            subMenuListaPrecios.Size = new Size(510, 72);
            subMenuListaPrecios.TabIndex = 3;
            subMenuListaPrecios.Text = "Lista de precios";
            subMenuListaPrecios.TextAlign = ContentAlignment.MiddleLeft;
            subMenuListaPrecios.UseVisualStyleBackColor = false;
            // 
            // menuConfig
            // 
            menuConfig.BackColor = Color.FromArgb(133, 183, 157);
            menuConfig.Dock = DockStyle.Top;
            menuConfig.Location = new Point(0, 1229);
            menuConfig.Margin = new Padding(2);
            menuConfig.Name = "menuConfig";
            menuConfig.Padding = new Padding(11, 0, 0, 0);
            menuConfig.Size = new Size(510, 76);
            menuConfig.TabIndex = 16;
            menuConfig.Text = "Configuración";
            menuConfig.TextAlign = ContentAlignment.MiddleLeft;
            menuConfig.UseVisualStyleBackColor = false;
            menuConfig.Click += menuConfig_Click_1;
            // 
            // panelSubMenuProductos
            // 
            panelSubMenuProductos.Controls.Add(subMenuBodegas);
            panelSubMenuProductos.Controls.Add(subMenuProductos);
            panelSubMenuProductos.Dock = DockStyle.Top;
            panelSubMenuProductos.Location = new Point(0, 1092);
            panelSubMenuProductos.Margin = new Padding(2);
            panelSubMenuProductos.Name = "panelSubMenuProductos";
            panelSubMenuProductos.Size = new Size(510, 137);
            panelSubMenuProductos.TabIndex = 15;
            panelSubMenuProductos.Visible = false;
            // 
            // subMenuBodegas
            // 
            subMenuBodegas.BackColor = Color.FromArgb(192, 229, 200);
            subMenuBodegas.Dock = DockStyle.Top;
            subMenuBodegas.Location = new Point(0, 72);
            subMenuBodegas.Margin = new Padding(2);
            subMenuBodegas.Name = "subMenuBodegas";
            subMenuBodegas.Padding = new Padding(32, 0, 0, 0);
            subMenuBodegas.Size = new Size(510, 72);
            subMenuBodegas.TabIndex = 2;
            subMenuBodegas.Text = "Bodegas";
            subMenuBodegas.TextAlign = ContentAlignment.MiddleLeft;
            subMenuBodegas.UseVisualStyleBackColor = false;
            subMenuBodegas.Click += subMenuBodegas_Click;
            // 
            // subMenuProductos
            // 
            subMenuProductos.BackColor = Color.FromArgb(192, 229, 200);
            subMenuProductos.Dock = DockStyle.Top;
            subMenuProductos.Location = new Point(0, 0);
            subMenuProductos.Margin = new Padding(2);
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Padding = new Padding(32, 0, 0, 0);
            subMenuProductos.Size = new Size(510, 72);
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
            menuProductos.Location = new Point(0, 1016);
            menuProductos.Margin = new Padding(2);
            menuProductos.Name = "menuProductos";
            menuProductos.Padding = new Padding(11, 0, 0, 0);
            menuProductos.Size = new Size(510, 76);
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
            panelSubMenuSocios.Location = new Point(0, 879);
            panelSubMenuSocios.Margin = new Padding(2);
            panelSubMenuSocios.Name = "panelSubMenuSocios";
            panelSubMenuSocios.Size = new Size(510, 137);
            panelSubMenuSocios.TabIndex = 13;
            panelSubMenuSocios.Visible = false;
            // 
            // subMenuSocios
            // 
            subMenuSocios.BackColor = Color.FromArgb(192, 229, 200);
            subMenuSocios.Dock = DockStyle.Top;
            subMenuSocios.Location = new Point(0, 72);
            subMenuSocios.Margin = new Padding(2);
            subMenuSocios.Name = "subMenuSocios";
            subMenuSocios.Padding = new Padding(32, 0, 0, 0);
            subMenuSocios.Size = new Size(510, 72);
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
            subMenuAgricultores.Margin = new Padding(2);
            subMenuAgricultores.Name = "subMenuAgricultores";
            subMenuAgricultores.Padding = new Padding(32, 0, 0, 0);
            subMenuAgricultores.Size = new Size(510, 72);
            subMenuAgricultores.TabIndex = 1;
            subMenuAgricultores.Text = "Agricultores";
            subMenuAgricultores.TextAlign = ContentAlignment.MiddleLeft;
            subMenuAgricultores.UseVisualStyleBackColor = false;
            subMenuAgricultores.Click += subMenuAgricultores_Click;
            // 
            // menuSocios
            // 
            menuSocios.BackColor = Color.FromArgb(133, 183, 157);
            menuSocios.Dock = DockStyle.Top;
            menuSocios.Location = new Point(0, 803);
            menuSocios.Margin = new Padding(2);
            menuSocios.Name = "menuSocios";
            menuSocios.Padding = new Padding(11, 0, 0, 0);
            menuSocios.Size = new Size(510, 76);
            menuSocios.TabIndex = 12;
            menuSocios.Text = "Socios";
            menuSocios.TextAlign = ContentAlignment.MiddleLeft;
            menuSocios.UseVisualStyleBackColor = false;
            menuSocios.Click += menuSocios_Click;
            // 
            // panelSubMenuTrans
            // 
            panelSubMenuTrans.Controls.Add(subMenuEntrega);
            panelSubMenuTrans.Controls.Add(subMenuSalida);
            panelSubMenuTrans.Controls.Add(subMenuEntrada);
            panelSubMenuTrans.Controls.Add(subMenuRecibos);
            panelSubMenuTrans.Controls.Add(subMenuFacturas);
            panelSubMenuTrans.Controls.Add(subMenuCompras);
            panelSubMenuTrans.Controls.Add(subMenuVent);
            panelSubMenuTrans.Dock = DockStyle.Top;
            panelSubMenuTrans.Location = new Point(0, 289);
            panelSubMenuTrans.Margin = new Padding(2);
            panelSubMenuTrans.Name = "panelSubMenuTrans";
            panelSubMenuTrans.Size = new Size(510, 514);
            panelSubMenuTrans.TabIndex = 9;
            panelSubMenuTrans.Visible = false;
            // 
            // subMenuSalida
            // 
            subMenuSalida.BackColor = Color.FromArgb(192, 229, 200);
            subMenuSalida.Dock = DockStyle.Top;
            subMenuSalida.Location = new Point(0, 360);
            subMenuSalida.Margin = new Padding(2);
            subMenuSalida.Name = "subMenuSalida";
            subMenuSalida.Padding = new Padding(32, 0, 0, 0);
            subMenuSalida.Size = new Size(510, 77);
            subMenuSalida.TabIndex = 9;
            subMenuSalida.Text = "Salida de Producto";
            subMenuSalida.TextAlign = ContentAlignment.MiddleLeft;
            subMenuSalida.UseVisualStyleBackColor = false;
            subMenuSalida.Click += subMenuSalida_Click;
            // 
            // subMenuEntrada
            // 
            subMenuEntrada.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEntrada.Dock = DockStyle.Top;
            subMenuEntrada.Location = new Point(0, 288);
            subMenuEntrada.Margin = new Padding(2);
            subMenuEntrada.Name = "subMenuEntrada";
            subMenuEntrada.Padding = new Padding(32, 0, 0, 0);
            subMenuEntrada.Size = new Size(510, 72);
            subMenuEntrada.TabIndex = 8;
            subMenuEntrada.Text = "Entrada de Producto";
            subMenuEntrada.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEntrada.UseVisualStyleBackColor = false;
            // 
            // subMenuRecibos
            // 
            subMenuRecibos.BackColor = Color.FromArgb(192, 229, 200);
            subMenuRecibos.Dock = DockStyle.Top;
            subMenuRecibos.Location = new Point(0, 216);
            subMenuRecibos.Margin = new Padding(2);
            subMenuRecibos.Name = "subMenuRecibos";
            subMenuRecibos.Padding = new Padding(32, 0, 0, 0);
            subMenuRecibos.Size = new Size(510, 72);
            subMenuRecibos.TabIndex = 7;
            subMenuRecibos.Text = "Recibos";
            subMenuRecibos.TextAlign = ContentAlignment.MiddleLeft;
            subMenuRecibos.UseVisualStyleBackColor = false;
            // 
            // subMenuFacturas
            // 
            subMenuFacturas.BackColor = Color.FromArgb(192, 229, 200);
            subMenuFacturas.Dock = DockStyle.Top;
            subMenuFacturas.Location = new Point(0, 144);
            subMenuFacturas.Margin = new Padding(2);
            subMenuFacturas.Name = "subMenuFacturas";
            subMenuFacturas.Padding = new Padding(32, 0, 0, 0);
            subMenuFacturas.Size = new Size(510, 72);
            subMenuFacturas.TabIndex = 6;
            subMenuFacturas.Text = "Facturas";
            subMenuFacturas.TextAlign = ContentAlignment.MiddleLeft;
            subMenuFacturas.UseVisualStyleBackColor = false;
            subMenuFacturas.Click += subMenuFacturas_Click;
            // 
            // subMenuCompras
            // 
            subMenuCompras.BackColor = Color.FromArgb(192, 229, 200);
            subMenuCompras.Dock = DockStyle.Top;
            subMenuCompras.Location = new Point(0, 72);
            subMenuCompras.Margin = new Padding(2);
            subMenuCompras.Name = "subMenuCompras";
            subMenuCompras.Padding = new Padding(32, 0, 0, 0);
            subMenuCompras.Size = new Size(510, 72);
            subMenuCompras.TabIndex = 5;
            subMenuCompras.Text = "Compras";
            subMenuCompras.TextAlign = ContentAlignment.MiddleLeft;
            subMenuCompras.UseVisualStyleBackColor = false;
            subMenuCompras.Click += subMenuCompras_Click;
            // 
            // subMenuVent
            // 
            subMenuVent.BackColor = Color.FromArgb(192, 229, 200);
            subMenuVent.Dock = DockStyle.Top;
            subMenuVent.Location = new Point(0, 0);
            subMenuVent.Margin = new Padding(2);
            subMenuVent.Name = "subMenuVent";
            subMenuVent.Padding = new Padding(32, 0, 0, 0);
            subMenuVent.Size = new Size(510, 72);
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
            menuTrans.Margin = new Padding(2);
            menuTrans.Name = "menuTrans";
            menuTrans.Padding = new Padding(11, 0, 0, 0);
            menuTrans.Size = new Size(510, 76);
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
            panelImage.Margin = new Padding(2);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(510, 213);
            panelImage.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LogoCOPRAG;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(553, 0);
            panelChildForm.Margin = new Padding(2);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1573, 1319);
            panelChildForm.TabIndex = 2;
            // 
            // subMenuEntrega
            // 
            subMenuEntrega.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEntrega.Dock = DockStyle.Top;
            subMenuEntrega.Location = new Point(0, 437);
            subMenuEntrega.Margin = new Padding(2);
            subMenuEntrega.Name = "subMenuEntrega";
            subMenuEntrega.Padding = new Padding(32, 0, 0, 0);
            subMenuEntrega.Size = new Size(510, 77);
            subMenuEntrega.TabIndex = 10;
            subMenuEntrega.Text = "Entrega";
            subMenuEntrega.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEntrega.UseVisualStyleBackColor = false;
            subMenuEntrega.Click += subMenuEntrega_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2126, 1319);
            Controls.Add(panelChildForm);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MaximizeBox = false;
            MaximumSize = new Size(4660, 2359);
            MinimumSize = new Size(1876, 906);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
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
        private Button subMenuBodegas;
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
        private Button subMenuEntrega;
        private Button subMenuTipoProducto;
        private Button subMenuListaPrecios;
    }
}