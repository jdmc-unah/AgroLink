namespace AgroLink.Pantallas.Pantallas_Socios
{
    partial class Finca
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
            dataGridView1 = new DataGridView();
            btnVolverAgricultor = new Button();
            tbBuscarFincas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 292);
            dataGridView1.TabIndex = 0;
            // 
            // btnVolverAgricultor
            // 
            btnVolverAgricultor.Location = new Point(680, 491);
            btnVolverAgricultor.Name = "btnVolverAgricultor";
            btnVolverAgricultor.Size = new Size(147, 44);
            btnVolverAgricultor.TabIndex = 1;
            btnVolverAgricultor.Text = "volver";
            btnVolverAgricultor.UseVisualStyleBackColor = true;
            btnVolverAgricultor.Click += btnVolverAgricultor_Click;
            // 
            // tbBuscarFincas
            // 
            tbBuscarFincas.Location = new Point(12, 75);
            tbBuscarFincas.Name = "tbBuscarFincas";
            tbBuscarFincas.PlaceholderText = "Ingres codigo de Finca o Nombre De Agricultor";
            tbBuscarFincas.Size = new Size(433, 27);
            tbBuscarFincas.TabIndex = 2;
            // 
            // Finca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 563);
            Controls.Add(tbBuscarFincas);
            Controls.Add(btnVolverAgricultor);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Finca";
            Text = "Finca";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnVolverAgricultor;
        private TextBox tbBuscarFincas;
    }
}