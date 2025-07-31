using System.Windows.Forms;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    partial class ListaPrecio : Form
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
            panel1 = new System.Windows.Forms.Panel();
            btnRecargar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            tbBuscar = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            tablaListaPrecio = new System.Windows.Forms.DataGridView();
            listaprecioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new System.Drawing.Point(600, 20);
            btnRecargar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new System.Drawing.Size(100, 40);
            btnRecargar.TabIndex = 2;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(480, 20);
            btnBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(100, 40);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new System.Drawing.Point(20, 20);
            tbBuscar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.PlaceholderText = "Buscar lista de precios...";
            tbBuscar.Size = new System.Drawing.Size(440, 23);
            tbBuscar.TabIndex = 0;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tablaListaPrecio);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 100);
            panel2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 350);
            panel2.TabIndex = 1;
            // 
            // tablaListaPrecio
            // 
            tablaListaPrecio.AllowUserToAddRows = false;
            tablaListaPrecio.AllowUserToDeleteRows = false;
            tablaListaPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaListaPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            listaprecioID,
            nombre,
            activo});
            tablaListaPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaListaPrecio.Location = new System.Drawing.Point(0, 0);
            tablaListaPrecio.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            tablaListaPrecio.MultiSelect = false;
            tablaListaPrecio.Name = "tablaListaPrecio";
            tablaListaPrecio.ReadOnly = true;
            tablaListaPrecio.RowHeadersWidth = 62;
            tablaListaPrecio.Size = new System.Drawing.Size(800, 350);
            tablaListaPrecio.TabIndex = 0;
            // 
            // listaprecioID
            // 
            listaprecioID.DataPropertyName = "listaprecioID";
            listaprecioID.HeaderText = "ID";
            listaprecioID.MinimumWidth = 8;
            listaprecioID.Name = "listaprecioID";
            listaprecioID.ReadOnly = true;
            listaprecioID.Visible = false;
            listaprecioID.Width = 150;
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
            activo.Width = 150;
            // 
            // ListaPrecio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ListaPrecio";
            Text = "ListaPrecio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(tablaListaPrecio)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablaListaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaprecioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
    }
}
