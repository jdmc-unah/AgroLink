using System;
using System.Windows.Forms;
using AgroLink.Pantallas.Pantallas_Transacciones;

namespace AgroLink.Pantallas.Pantallas_Objetos
{
    public partial class NuevoProductoForm : Form
    {
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTipoProducto;
        private ComboBox cmbTipoProducto;
        private Label lblUnidadMedida;
        private ComboBox cmbUnidadMedida;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnCerrar;
        private Button btnAgregar;

        Recursos.Recursos_SQL recSQL = new Recursos.Recursos_SQL();

        public NuevoProductoForm()
        {
            InitializeComponent();
            LoadTipoProducto();
            LoadUnidadMedida();
        }

        private void LoadTipoProducto()
        {
            var dt = recSQL.EjecutarVista("Pruebas.TipoProducto");
            cmbTipoProducto.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                cmbTipoProducto.Items.Add(row["NombreTipo"].ToString());
            }
        }

        private void LoadUnidadMedida()
        {
            var dt = recSQL.EjecutarVista("Pruebas.UnidadMedida");
            cmbUnidadMedida.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                cmbUnidadMedida.Items.Add(row["Nombre"].ToString());
            }
        }

        private void InitializeComponent()
        {
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblTipoProducto = new Label();
            this.cmbTipoProducto = new ComboBox();
            this.lblUnidadMedida = new Label();
            this.cmbUnidadMedida = new ComboBox();
            this.lblPrecio = new Label();
            this.txtPrecio = new TextBox();
            this.btnCerrar = new Button();
            this.btnAgregar = new Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(50, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(150, 30);
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(220, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 30);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(50, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(150, 30);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 30);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.Location = new System.Drawing.Point(50, 130);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(150, 30);
            this.lblTipoProducto.Text = "Tipo Producto:";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.Location = new System.Drawing.Point(220, 130);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(200, 30);
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.Location = new System.Drawing.Point(50, 180);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(150, 30);
            this.lblUnidadMedida.Text = "Unidad Medida:";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Location = new System.Drawing.Point(220, 180);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(200, 30);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(50, 230);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(150, 30);
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(220, 230);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 30);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(700, 400);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(600, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
            // 
            // NuevoProductoForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.cmbTipoProducto);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "NuevoProductoForm";
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Return to Producto form
            Pantallas.PantallaPrincipal.instanciaPantPrincipal.OpenChildForm(new Producto());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to save new product data to database
            MessageBox.Show("");
        }
    }
}
