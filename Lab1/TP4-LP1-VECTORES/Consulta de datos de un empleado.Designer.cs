namespace TP_LP1_VECTORES
{
    partial class Consulta_de_datos_de_un_empleado
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // labelCodigo
            // 
            this.labelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCodigo.Location = new System.Drawing.Point(292, 100);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(77, 23);
            this.labelCodigo.TabIndex = 24;
            // 
            // labelCategoria
            // 
            this.labelCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategoria.Location = new System.Drawing.Point(292, 137);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(77, 23);
            this.labelCategoria.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo";
            // 
            // labelSueldo
            // 
            this.labelSueldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSueldo.Location = new System.Drawing.Point(292, 170);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(77, 23);
            this.labelSueldo.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Sueldo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consulta_de_datos_de_un_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSueldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Consulta_de_datos_de_un_empleado";
            this.Text = "Consulta_de_datos_de_un_empleado";
            this.Load += new System.EventHandler(this.Consulta_de_datos_de_un_empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}