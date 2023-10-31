namespace SistemaGestionClientes
{
    partial class ListadoClientes
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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCantidadCli = new System.Windows.Forms.Label();
            this.labelTotalCli = new System.Windows.Forms.Label();
            this.labelPromedioCli = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
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
            this.Limite});
            this.dataGridView1.Location = new System.Drawing.Point(90, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 234);
            this.dataGridView1.TabIndex = 0;
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
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total deuda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio deuda:";
            // 
            // labelCantidadCli
            // 
            this.labelCantidadCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidadCli.Location = new System.Drawing.Point(633, 119);
            this.labelCantidadCli.Name = "labelCantidadCli";
            this.labelCantidadCli.Size = new System.Drawing.Size(100, 23);
            this.labelCantidadCli.TabIndex = 4;
            // 
            // labelTotalCli
            // 
            this.labelTotalCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCli.Location = new System.Drawing.Point(633, 149);
            this.labelTotalCli.Name = "labelTotalCli";
            this.labelTotalCli.Size = new System.Drawing.Size(100, 23);
            this.labelTotalCli.TabIndex = 5;
            // 
            // labelPromedioCli
            // 
            this.labelPromedioCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPromedioCli.Location = new System.Drawing.Point(633, 180);
            this.labelPromedioCli.Name = "labelPromedioCli";
            this.labelPromedioCli.Size = new System.Drawing.Size(100, 23);
            this.labelPromedioCli.TabIndex = 6;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(521, 306);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 7;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.labelPromedioCli);
            this.Controls.Add(this.labelTotalCli);
            this.Controls.Add(this.labelCantidadCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoClientes";
            this.Text = "ListadoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCantidadCli;
        private System.Windows.Forms.Label labelTotalCli;
        private System.Windows.Forms.Label labelPromedioCli;
        private System.Windows.Forms.Button buttonListar;
    }
}