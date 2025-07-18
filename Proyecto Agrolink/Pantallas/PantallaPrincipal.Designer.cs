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
            panel1 = new Panel();
            panelSubMenuConfig = new Panel();
            subMenuEmp = new Button();
            menuConfig = new Button();
            panelSubMenuTrans = new Panel();
            subMenuVent = new Button();
            menuTrans = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelSubMenuConfig.SuspendLayout();
            panelSubMenuTrans.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panelSubMenuConfig);
            panel1.Controls.Add(menuConfig);
            panel1.Controls.Add(panelSubMenuTrans);
            panel1.Controls.Add(menuTrans);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 1252);
            panel1.TabIndex = 1;
            // 
            // panelSubMenuConfig
            // 
            panelSubMenuConfig.Controls.Add(subMenuEmp);
            panelSubMenuConfig.Dock = DockStyle.Top;
            panelSubMenuConfig.Location = new Point(0, 514);
            panelSubMenuConfig.Name = "panelSubMenuConfig";
            panelSubMenuConfig.Size = new Size(500, 161);
            panelSubMenuConfig.TabIndex = 11;
            panelSubMenuConfig.Visible = false;
            // 
            // subMenuEmp
            // 
            subMenuEmp.Dock = DockStyle.Top;
            subMenuEmp.Location = new Point(0, 0);
            subMenuEmp.Name = "subMenuEmp";
            subMenuEmp.Padding = new Padding(30, 0, 0, 0);
            subMenuEmp.Size = new Size(500, 70);
            subMenuEmp.TabIndex = 0;
            subMenuEmp.Text = "Empresa";
            subMenuEmp.TextAlign = ContentAlignment.MiddleLeft;
            subMenuEmp.UseVisualStyleBackColor = true;
            // 
            // menuConfig
            // 
            menuConfig.Dock = DockStyle.Top;
            menuConfig.Location = new Point(0, 439);
            menuConfig.Name = "menuConfig";
            menuConfig.Padding = new Padding(10, 0, 0, 0);
            menuConfig.Size = new Size(500, 75);
            menuConfig.TabIndex = 10;
            menuConfig.Text = "Configuracion";
            menuConfig.TextAlign = ContentAlignment.MiddleLeft;
            menuConfig.UseVisualStyleBackColor = true;
            menuConfig.Click += menuConfig_Click;
            // 
            // panelSubMenuTrans
            // 
            panelSubMenuTrans.Controls.Add(subMenuVent);
            panelSubMenuTrans.Dock = DockStyle.Top;
            panelSubMenuTrans.Location = new Point(0, 289);
            panelSubMenuTrans.Name = "panelSubMenuTrans";
            panelSubMenuTrans.Size = new Size(500, 150);
            panelSubMenuTrans.TabIndex = 9;
            panelSubMenuTrans.Visible = false;
            // 
            // subMenuVent
            // 
            subMenuVent.Dock = DockStyle.Top;
            subMenuVent.Location = new Point(0, 0);
            subMenuVent.Name = "subMenuVent";
            subMenuVent.Padding = new Padding(30, 0, 0, 0);
            subMenuVent.Size = new Size(500, 70);
            subMenuVent.TabIndex = 4;
            subMenuVent.Text = "Ventas";
            subMenuVent.TextAlign = ContentAlignment.MiddleLeft;
            subMenuVent.UseVisualStyleBackColor = true;
            subMenuVent.Click += subMenuVent_Click;
            // 
            // menuTrans
            // 
            menuTrans.Dock = DockStyle.Top;
            menuTrans.Location = new Point(0, 214);
            menuTrans.Name = "menuTrans";
            menuTrans.Padding = new Padding(10, 0, 0, 0);
            menuTrans.Size = new Size(500, 75);
            menuTrans.TabIndex = 3;
            menuTrans.Text = "Transacciones";
            menuTrans.TextAlign = ContentAlignment.MiddleLeft;
            menuTrans.UseVisualStyleBackColor = true;
            menuTrans.Click += menuTrans_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 214);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LogoAgrolinkTest;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2219, 1252);
            Controls.Add(panel1);
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            panel1.ResumeLayout(false);
            panelSubMenuConfig.ResumeLayout(false);
            panelSubMenuTrans.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button subMenuVent;
        private Button menuTrans;
        private Panel panel2;
        private Panel panelSubMenuConfig;
        private Button subMenuEmp;
        private Button menuConfig;
        private Panel panelSubMenuTrans;
        private PictureBox pictureBox1;
    }
}