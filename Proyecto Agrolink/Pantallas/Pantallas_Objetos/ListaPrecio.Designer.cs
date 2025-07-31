namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class ListaPrecio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRecargar = new Button();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            panel2 = new Panel();
            tablaListaPrecio = new DataGridView();
            listaPreciosID = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(tablaListaPrecio)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRecargar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(tbBuscar);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(600, 20);
            btnRecargar.Margin = new Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(100, 40);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(480, 20);
            btnBuscar.Margin = new Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 40);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(20, 20);
            tbBuscar.Margin = new Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar lista de precios...";
            tbBuscar.Size = new Size(440, 23);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaListaPrecio);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 1;
            // 
            // tablaListaPrecio
            // 
            tablaListaPrecio.AllowUserToAddRows = false;
            tablaListaPrecio.AllowUserToDeleteRows = false;
            tablaListaPrecio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaListaPrecio.Columns.AddRange(new DataGridViewColumn[] {
            listaPreciosID,
            nombre,
            activo});
            tablaListaPrecio.Dock = DockStyle.Fill;
            tablaListaPrecio.Location = new Point(0, 0);
            tablaListaPrecio.Margin = new Padding(5, 7, 5, 7);
            tablaListaPrecio.MultiSelect = false;
            tablaListaPrecio.Name = "tablaListaPrecio";
            tablaListaPrecio.ReadOnly = true;
            tablaListaPrecio.RowHeadersWidth = 62;
            tablaListaPrecio.Size = new Size(800, 350);
            tablaListaPrecio.TabIndex = 0;
            // 
            // listaPreciosID
            // 
            listaPreciosID.DataPropertyName = "ID";
            listaPreciosID.HeaderText = "ID";
            listaPreciosID.MinimumWidth = 8;
            listaPreciosID.Name = "listaPreciosID";
            listaPreciosID.ReadOnly = true;
            listaPreciosID.Visible = false;
            listaPreciosID.Width = 150;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 250;
            // 
            // activo
            // 
            activo.DataPropertyName = "Activo";
            activo.HeaderText = "Activo";
            activo.MinimumWidth = 8;
            activo.Name = "activo";
            activo.ReadOnly = true;
            activo.Width = 200;
            // 
            // ListaPrecio
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ListaPrecio";
            Text = "ListaPrecio";
            Load += ListaPrecio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(tablaListaPrecio)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnRecargar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Panel panel2;
        private DataGridView tablaListaPrecio;
        private DataGridViewTextBoxColumn listaPreciosID;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn activo;
    }
}
