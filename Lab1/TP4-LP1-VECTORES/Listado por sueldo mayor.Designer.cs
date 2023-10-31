namespace TP_LP1_VECTORES
{
    partial class Listado_por_sueldo_mayor
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxsueldo = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCantidadEmpleados = new System.Windows.Forms.Label();
            this.labelTotalSueldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sueldo Mayor a:";
            // 
            // textBoxsueldo
            // 
            this.textBoxsueldo.Location = new System.Drawing.Point(591, 29);
            this.textBoxsueldo.Name = "textBoxsueldo";
            this.textBoxsueldo.Size = new System.Drawing.Size(100, 20);
            this.textBoxsueldo.TabIndex = 19;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(591, 55);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(89, 23);
            this.buttonCargar.TabIndex = 18;
            this.buttonCargar.Text = "Buscar y cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad";
            // 
            // labelCantidadEmpleados
            // 
            this.labelCantidadEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCantidadEmpleados.Location = new System.Drawing.Point(101, 218);
            this.labelCantidadEmpleados.Name = "labelCantidadEmpleados";
            this.labelCantidadEmpleados.Size = new System.Drawing.Size(77, 23);
            this.labelCantidadEmpleados.TabIndex = 16;
            // 
            // labelTotalSueldo
            // 
            this.labelTotalSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalSueldo.Location = new System.Drawing.Point(101, 182);
            this.labelTotalSueldo.Name = "labelTotalSueldo";
            this.labelTotalSueldo.Size = new System.Drawing.Size(77, 23);
            this.labelTotalSueldo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Importe total:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Sueldo});
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView3.Location = new System.Drawing.Point(27, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(444, 150);
            this.dataGridView3.TabIndex = 13;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // Listado_por_sueldo_mayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxsueldo);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCantidadEmpleados);
            this.Controls.Add(this.labelTotalSueldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Listado_por_sueldo_mayor";
            this.Text = "Listado_por_sueldo_mayor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxsueldo;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantidadEmpleados;
        private System.Windows.Forms.Label labelTotalSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}