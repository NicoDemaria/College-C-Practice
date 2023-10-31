namespace SistemaGestionClientes
{
    partial class ConsultaCliente
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDeuda = new System.Windows.Forms.Label();
            this.labelLimite = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del cliente";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(423, 60);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 2;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLimite);
            this.groupBox1.Controls.Add(this.labelDeuda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(198, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deuda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limite:";
            // 
            // labelDeuda
            // 
            this.labelDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDeuda.Location = new System.Drawing.Point(54, 36);
            this.labelDeuda.Name = "labelDeuda";
            this.labelDeuda.Size = new System.Drawing.Size(100, 23);
            this.labelDeuda.TabIndex = 6;
            // 
            // labelLimite
            // 
            this.labelLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLimite.Location = new System.Drawing.Point(54, 66);
            this.labelLimite.Name = "labelLimite";
            this.labelLimite.Size = new System.Drawing.Size(100, 23);
            this.labelLimite.TabIndex = 7;
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ConsultaCliente";
            this.Text = "Consultar cliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLimite;
        private System.Windows.Forms.Label labelDeuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}