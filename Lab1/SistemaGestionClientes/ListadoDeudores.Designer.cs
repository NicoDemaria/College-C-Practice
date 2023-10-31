namespace SistemaGestionClientes
{
    partial class ListadoDeudores
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
            this.labelCantidadCli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(510, 319);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 15;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // labelPromedioCli
            // 
            this.labelPromedioCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPromedioCli.Location = new System.Drawing.Point(622, 193);
            this.labelPromedioCli.Name = "labelPromedioCli";
            this.labelPromedioCli.Size = new System.Drawing.Size(100, 23);
            this.labelPromedioCli.TabIndex = 14;
            // 
            // labelTotalCli
            // 
            this.labelTotalCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalCli.Location = new System.Drawing.Point(622, 162);
            this.labelTotalCli.Name = "labelTotalCli";
            this.labelTotalCli.Size = new System.Drawing.Size(100, 23);
            this.labelTotalCli.TabIndex = 13;
            // 
            // labelCantidadCli
            // 
            this.labelCantidadCli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidadCli.Location = new System.Drawing.Point(622, 132);
            this.labelCantidadCli.Name = "labelCantidadCli";
            this.labelCantidadCli.Size = new System.Drawing.Size(100, 23);
            this.labelCantidadCli.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Promedio deuda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total deuda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad clientes:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda,
            this.Limite});
            this.dataGridView2.Location = new System.Drawing.Point(79, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(425, 234);
            this.dataGridView2.TabIndex = 8;
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
            // ListadoDeudores
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
            this.Controls.Add(this.dataGridView2);
            this.Name = "ListadoDeudores";
            this.Text = "ListadoDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Label labelPromedioCli;
        private System.Windows.Forms.Label labelTotalCli;
        private System.Windows.Forms.Label labelCantidadCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
    }
}