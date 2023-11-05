namespace Debate_4._1.Bases_de_Datos_en_Access
{
    partial class Listado_todos_los_clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.kabelPromedio = new System.Windows.Forms.Label();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda,
            this.Ciudad,
            this.Limite});
            this.dataGridView1.Location = new System.Drawing.Point(110, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(480, 249);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 1;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(335, 249);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(75, 23);
            this.buttonReporte.TabIndex = 2;
            this.buttonReporte.Text = "Generar Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Location = new System.Drawing.Point(623, 270);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(141, 27);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // labelCantidad
            // 
            this.labelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidad.Location = new System.Drawing.Point(623, 310);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(141, 27);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad";
            // 
            // kabelPromedio
            // 
            this.kabelPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kabelPromedio.Location = new System.Drawing.Point(623, 351);
            this.kabelPromedio.Name = "kabelPromedio";
            this.kabelPromedio.Size = new System.Drawing.Size(141, 27);
            this.kabelPromedio.TabIndex = 5;
            this.kabelPromedio.Text = "label2";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Listado_todos_los_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kabelPromedio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listado_todos_los_clientes";
            this.Text = "Listado_todos_los_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label kabelPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
    }
}