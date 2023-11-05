namespace Debate_4._2.ConexiónBaseDatos
{
    partial class listaVendedores
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
            this.buttonListar = new System.Windows.Forms.Button();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalDeuda = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(498, 343);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // Grilla
            // 
            this.Grilla.AllowUserToAddRows = false;
            this.Grilla.AllowUserToDeleteRows = false;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Deuda});
            this.Grilla.Location = new System.Drawing.Point(74, 60);
            this.Grilla.Name = "Grilla";
            this.Grilla.ReadOnly = true;
            this.Grilla.Size = new System.Drawing.Size(499, 268);
            this.Grilla.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID Cliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.ReadOnly = true;
            // 
            // labelTotalDeuda
            // 
            this.labelTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalDeuda.Location = new System.Drawing.Point(74, 364);
            this.labelTotalDeuda.Name = "labelTotalDeuda";
            this.labelTotalDeuda.Size = new System.Drawing.Size(111, 23);
            this.labelTotalDeuda.TabIndex = 17;
            // 
            // labelCantidad
            // 
            this.labelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidad.Location = new System.Drawing.Point(74, 331);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(111, 23);
            this.labelCantidad.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(74, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 18;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(480, 372);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(102, 23);
            this.buttonReporte.TabIndex = 19;
            this.buttonReporte.Text = "Crear reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // listaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelTotalDeuda);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.Grilla);
            this.Name = "listaVendedores";
            this.Text = "listaVendedores";
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label labelTotalDeuda;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReporte;
    }
}