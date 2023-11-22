namespace SistemaGestionClientes
{
    partial class totalVentasSucursal
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
            this.labelPromedioCli = new System.Windows.Forms.Label();
            this.labelTotalCli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(510, 344);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 29;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // labelPromedioCli
            // 
            this.labelPromedioCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPromedioCli.Location = new System.Drawing.Point(622, 218);
            this.labelPromedioCli.Name = "labelPromedioCli";
            this.labelPromedioCli.Size = new System.Drawing.Size(100, 23);
            this.labelPromedioCli.TabIndex = 28;
            // 
            // labelTotalCli
            // 
            this.labelTotalCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCli.Location = new System.Drawing.Point(622, 187);
            this.labelTotalCli.Name = "labelTotalCli";
            this.labelTotalCli.Size = new System.Drawing.Size(100, 23);
            this.labelTotalCli.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Promedio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total venta:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(79, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 234);
            this.dataGridView1.TabIndex = 24;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Sucursal";
            this.Mes.Name = "Mes";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // totalVentasSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.labelPromedioCli);
            this.Controls.Add(this.labelTotalCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "totalVentasSucursal";
            this.Text = "totalVentasSucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Label labelPromedioCli;
        private System.Windows.Forms.Label labelTotalCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}