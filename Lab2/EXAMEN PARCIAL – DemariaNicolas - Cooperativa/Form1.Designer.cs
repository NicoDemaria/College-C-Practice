namespace EXAMEN_PARCIAL___DemariaNicolas___Cooperativa
{
    partial class Form1
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
            this.comboBoxSocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGenerarTXT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labe = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSocios
            // 
            this.comboBoxSocios.FormattingEnabled = true;
            this.comboBoxSocios.Location = new System.Drawing.Point(84, 39);
            this.comboBoxSocios.Name = "comboBoxSocios";
            this.comboBoxSocios.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSocios.TabIndex = 0;
            this.comboBoxSocios.SelectedIndexChanged += new System.EventHandler(this.comboBoxSocios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socios: ";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(22, 80);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(84, 23);
            this.buttonListar.TabIndex = 2;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFactura,
            this.Fecha,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(226, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 398);
            this.dataGridView1.TabIndex = 3;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.HeaderText = "Factura";
            this.NumeroFactura.Name = "NumeroFactura";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 200;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // buttonGenerarTXT
            // 
            this.buttonGenerarTXT.Location = new System.Drawing.Point(121, 80);
            this.buttonGenerarTXT.Name = "buttonGenerarTXT";
            this.buttonGenerarTXT.Size = new System.Drawing.Size(84, 23);
            this.buttonGenerarTXT.TabIndex = 4;
            this.buttonGenerarTXT.Text = "Generar TXT";
            this.buttonGenerarTXT.UseVisualStyleBackColor = true;
            this.buttonGenerarTXT.Click += new System.EventHandler(this.buttonGenerarTXT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Location = new System.Drawing.Point(77, 179);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(121, 23);
            this.labelTotal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidad.Location = new System.Drawing.Point(77, 143);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(121, 23);
            this.labelCantidad.TabIndex = 9;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(19, 223);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(54, 13);
            this.labe.TabIndex = 14;
            this.labe.Text = "Promedio:";
            // 
            // labelPromedio
            // 
            this.labelPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPromedio.Location = new System.Drawing.Point(77, 222);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(121, 23);
            this.labelPromedio.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.buttonGenerarTXT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSocios);
            this.Name = "Form1";
            this.Text = "Cooperativa Colonia Caroya";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button buttonGenerarTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labe;
        private System.Windows.Forms.Label labelPromedio;
    }
}

