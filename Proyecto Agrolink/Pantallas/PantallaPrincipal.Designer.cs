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
            btnInicio = new Button();
            button1 = new Button();
            panelSeparador = new Panel();
            panelSubMenuConfig = new Panel();
            subMenuListaPrecios = new Button();
            subMenuTipoProducto = new Button();
            subMenuEmpresa = new Button();
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
            subMenuEntrega = new Button();
            subMenuSalida = new Button();
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
            panelMain.Controls.Add(btnInicio);
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
            panelMain.Margin = new Padding(1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(325, 640);
            panelMain.TabIndex = 1;
            panelMain.Visible = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(133, 183, 157);
            btnInicio.Location = new Point(66, 907);
            btnInicio.Margin = new Padding(1);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(6, 0, 0, 0);
            btnInicio.Size = new Size(176, 46);
            btnInicio.TabIndex = 20;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 183, 157);
            button1.Location = new Point(66, 990);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Padding = new Padding(6, 0, 0, 0);
            button1.Size = new Size(176, 46);
            button1.TabIndex = 19;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.FromArgb(192, 229, 200);
            panelSeparador.Location = new Point(22, 973);
            panelSeparador.Margin = new Padding(1);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(265, 1);
            panelSeparador.TabIndex = 18;
            // 
            // panelSubMenuConfig
            // 
            panelSubMenuConfig.Controls.Add(subMenuListaPrecios);
            panelSubMenuConfig.Controls.Add(subMenuTipoProducto);
            panelSubMenuConfig.Controls.Add(subMenuEmpresa);
            panelSubMenuConfig.Dock = DockStyle.Top;
            panelSubMenuConfig.Location = new Point(0, 752);
            panelSubMenuConfig.Margin = new Padding(1);
            panelSubMenuConfig.Name = "panelSubMenuConfig";
            panelSubMenuConfig.Size = new Size(299, 131);
            panelSubMenuConfig.TabIndex = 17;
            panelSubMenuConfig.Visible = false;
            // 
            // subMenuListaPrecios
            // 
            subMenuListaPrecios.BackColor = Color.FromArgb(192, 229, 200);
            subMenuListaPrecios.Dock = DockStyle.Top;
            subMenuListaPrecios.Location = new Point(0, 88);
            subMenuListaPrecios.Margin = new Padding(1);
            subMenuListaPrecios.Name = "subMenuListaPrecios";
            subMenuListaPrecios.Padding = new Padding(19, 0, 0, 0);
            subMenuListaPrecios.Size = new Size(299, 44);
            subMenuListaPrecios.TabIndex = 3;
            subMenuListaPrecios.Text = "Lista de precios";
            subMenuListaPrecios.TextAlign = ContentAlignment.MiddleLeft;
            subMenuListaPrecios.UseVisualStyleBackColor = false;
            subMenuListaPrecios.Click += subMenuListaPrecio_Click;
            // 
            // subMenuTipoProducto
            // 
            subMenuTipoProducto.BackColor = Color.FromArgb(192, 229, 200);
            subMenuTipoProducto.Dock = DockStyle.Top;
            subMenuTipoProducto.Location = new Point(0, 44);
            subMenuTipoProducto.Margin = new Padding(1);
            subMenuTipoProducto.Name = "subMenuTipoProducto";
            subMenuTipoProducto.Padding = new Padding(19, 0, 0, 0);
            subMenuTipoProducto.Size = new Size(299, 44);
            subMenuTipoProducto.TabIndex = 2;
            subMenuTipoProducto.Text = "Tipo de Producto";
            subMenuTipoProducto.TextAlign = ContentAlignment.MiddleLeft;
            subMenuTipoProducto.UseVisualStyleBackColor = false;
            subMenuTipoProducto.Click += subMenuTipoProducto_Click;
            // 
            // subMenuEmpresa
            // 
            subMenuEmpresa.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEmpresa.Dock = DockStyle.Top;
            subMenuEmpresa.Location = new Point(0, 0);
            subMenuEmpresa.Margin = new Padding(1);
            subMenuEmpresa.Name = "subMenuEmpresa";
            subMenuEmpresa.Padding = new Padding(19, 0, 0, 0);
            subMenuEmpresa.Size = new Size(299, 44);
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
            menuConfig.Location = new Point(0, 706);
            menuConfig.Margin = new Padding(1);
            menuConfig.Name = "menuConfig";
            menuConfig.Padding = new Padding(6, 0, 0, 0);
            menuConfig.Size = new Size(299, 46);
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
            panelSubMenuProductos.Location = new Point(0, 622);
            panelSubMenuProductos.Margin = new Padding(1);
            panelSubMenuProductos.Name = "panelSubMenuProductos";
            panelSubMenuProductos.Size = new Size(299, 84);
            panelSubMenuProductos.TabIndex = 15;
            panelSubMenuProductos.Visible = false;
            // 
            // subMenuBodegas
            // 
            subMenuBodegas.BackColor = Color.FromArgb(192, 229, 200);
            subMenuBodegas.Dock = DockStyle.Top;
            subMenuBodegas.Location = new Point(0, 44);
            subMenuBodegas.Margin = new Padding(1);
            subMenuBodegas.Name = "subMenuBodegas";
            subMenuBodegas.Padding = new Padding(19, 0, 0, 0);
            subMenuBodegas.Size = new Size(299, 44);
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
            subMenuProductos.Margin = new Padding(1);
            subMenuProductos.Name = "subMenuProductos";
            subMenuProductos.Padding = new Padding(19, 0, 0, 0);
            subMenuProductos.Size = new Size(299, 44);
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
            menuProductos.Location = new Point(0, 576);
            menuProductos.Margin = new Padding(1);
            menuProductos.Name = "menuProductos";
            menuProductos.Padding = new Padding(6, 0, 0, 0);
            menuProductos.Size = new Size(299, 46);
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
            panelSubMenuSocios.Location = new Point(0, 492);
            panelSubMenuSocios.Margin = new Padding(1);
            panelSubMenuSocios.Name = "panelSubMenuSocios";
            panelSubMenuSocios.Size = new Size(299, 84);
            panelSubMenuSocios.TabIndex = 13;
            panelSubMenuSocios.Visible = false;
            // 
            // subMenuSocios
            // 
            subMenuSocios.BackColor = Color.FromArgb(192, 229, 200);
            subMenuSocios.Dock = DockStyle.Top;
            subMenuSocios.Location = new Point(0, 44);
            subMenuSocios.Margin = new Padding(1);
            subMenuSocios.Name = "subMenuSocios";
            subMenuSocios.Padding = new Padding(19, 0, 0, 0);
            subMenuSocios.Size = new Size(299, 44);
            subMenuSocios.TabIndex = 2;
            subMenuSocios.Text = "Socios";
            subMenuSocios.TextAlign = ContentAlignment.MiddleLeft;
            subMenuSocios.UseVisualStyleBackColor = false;
            subMenuSocios.Click += subMenuSocios_Click;
            // 
            // subMenuAgricultores
            // 
            subMenuAgricultores.BackColor = Color.FromArgb(192, 229, 200);
            subMenuAgricultores.Dock = DockStyle.Top;
            subMenuAgricultores.Location = new Point(0, 0);
            subMenuAgricultores.Margin = new Padding(1);
            subMenuAgricultores.Name = "subMenuAgricultores";
            subMenuAgricultores.Padding = new Padding(19, 0, 0, 0);
            subMenuAgricultores.Size = new Size(299, 44);
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
            menuSocios.Location = new Point(0, 446);
            menuSocios.Margin = new Padding(1);
            menuSocios.Name = "menuSocios";
            menuSocios.Padding = new Padding(6, 0, 0, 0);
            menuSocios.Size = new Size(299, 46);
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
            panelSubMenuTrans.Controls.Add(subMenuRecibos);
            panelSubMenuTrans.Controls.Add(subMenuFacturas);
            panelSubMenuTrans.Controls.Add(subMenuCompras);
            panelSubMenuTrans.Controls.Add(subMenuVent);
            panelSubMenuTrans.Dock = DockStyle.Top;
            panelSubMenuTrans.Location = new Point(0, 176);
            panelSubMenuTrans.Margin = new Padding(1);
            panelSubMenuTrans.Name = "panelSubMenuTrans";
            panelSubMenuTrans.Size = new Size(299, 270);
            panelSubMenuTrans.TabIndex = 9;
            panelSubMenuTrans.Visible = false;
            // 
            // subMenuEntrega
            // 
            subMenuEntrega.BackColor = Color.FromArgb(192, 229, 200);
            subMenuEntrega.Dock = DockStyle.Top;
            subMenuEntrega.Location = new Point(0, 224);
            subMenuEntrega.Margin = new Padding(1);
            subMenuEntrega.Name = "subMenuEntrega";
            subMenuEntrega.Padding = new Padding(19, 0, 0, 0);
            subMenuEntrega.Size = new Size(299, 48);
            subMenuEntrega.TabIndex = 10;
            subMenuEntrega.Text = "Entrega";
            subMenuEntrega.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEntrega.UseVisualStyleBackColor = false;
            subMenuEntrega.Click += subMenuEntrega_Click;
            // 
            // subMenuSalida
            // 
            subMenuSalida.BackColor = Color.FromArgb(192, 229, 200);
            subMenuSalida.Dock = DockStyle.Top;
            subMenuSalida.Location = new Point(0, 176);
            subMenuSalida.Margin = new Padding(1);
            subMenuSalida.Name = "subMenuSalida";
            subMenuSalida.Padding = new Padding(19, 0, 0, 0);
            subMenuSalida.Size = new Size(299, 48);
            subMenuSalida.TabIndex = 9;
            subMenuSalida.Text = "Salida de Producto";
            subMenuSalida.TextAlign = ContentAlignment.MiddleLeft;
            subMenuSalida.UseVisualStyleBackColor = false;
            subMenuSalida.Click += subMenuSalida_Click;
            // 
            // subMenuRecibos
            // 
            subMenuRecibos.BackColor = Color.FromArgb(192, 229, 200);
            subMenuRecibos.Dock = DockStyle.Top;
            subMenuRecibos.Location = new Point(0, 132);
            subMenuRecibos.Margin = new Padding(1);
            subMenuRecibos.Name = "subMenuRecibos";
            subMenuRecibos.Padding = new Padding(19, 0, 0, 0);
            subMenuRecibos.Size = new Size(299, 44);
            subMenuRecibos.TabIndex = 7;
            subMenuRecibos.Text = "Recibos";
            subMenuRecibos.TextAlign = ContentAlignment.MiddleLeft;
            subMenuRecibos.UseVisualStyleBackColor = false;
            subMenuRecibos.Click += subMenuRecibos_Click;
            // 
            // subMenuFacturas
            // 
            subMenuFacturas.BackColor = Color.FromArgb(192, 229, 200);
            subMenuFacturas.Dock = DockStyle.Top;
            subMenuFacturas.Location = new Point(0, 88);
            subMenuFacturas.Margin = new Padding(1);
            subMenuFacturas.Name = "subMenuFacturas";
            subMenuFacturas.Padding = new Padding(19, 0, 0, 0);
            subMenuFacturas.Size = new Size(299, 44);
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
            subMenuCompras.Location = new Point(0, 44);
            subMenuCompras.Margin = new Padding(1);
            subMenuCompras.Name = "subMenuCompras";
            subMenuCompras.Padding = new Padding(19, 0, 0, 0);
            subMenuCompras.Size = new Size(299, 44);
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
            subMenuVent.Margin = new Padding(1);
            subMenuVent.Name = "subMenuVent";
            subMenuVent.Padding = new Padding(19, 0, 0, 0);
            subMenuVent.Size = new Size(299, 44);
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
            menuTrans.Location = new Point(0, 130);
            menuTrans.Margin = new Padding(1);
            menuTrans.Name = "menuTrans";
            menuTrans.Padding = new Padding(6, 0, 0, 0);
            menuTrans.Size = new Size(299, 46);
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
            panelImage.Margin = new Padding(1);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(299, 130);
            panelImage.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LogoCOPRAG;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(325, 0);
            panelChildForm.Margin = new Padding(1);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(807, 640);
            panelChildForm.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1132, 640);
            Controls.Add(panelChildForm);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(1);
            MaximizeBox = false;
            MaximumSize = new Size(2736, 1421);
            MinimumSize = new Size(1099, 535);
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PantallaPrincipal_Load;
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
        private Button btnInicio;
    }
}