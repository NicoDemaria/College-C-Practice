namespace AdministracionContribuyentes
{
    partial class Consulta_de_datos_de_un_contribuyente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeldeu = new System.Windows.Forms.Label();
            this.labelCod = new System.Windows.Forms.Label();
            this.labeldeudaa = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labeldeu);
            this.groupBox1.Controls.Add(this.labelCod);
            this.groupBox1.Controls.Add(this.labeldeudaa);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Location = new System.Drawing.Point(252, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del contribuyente";
            // 
            // labeldeu
            // 
            this.labeldeu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeldeu.Location = new System.Drawing.Point(54, 66);
            this.labeldeu.Name = "labeldeu";
            this.labeldeu.Size = new System.Drawing.Size(100, 23);
            this.labeldeu.TabIndex = 7;
            // 
            // labelCod
            // 
            this.labelCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCod.Location = new System.Drawing.Point(54, 36);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(100, 23);
            this.labelCod.TabIndex = 6;
            // 
            // labeldeudaa
            // 
            this.labeldeudaa.AutoSize = true;
            this.labeldeudaa.Location = new System.Drawing.Point(6, 66);
            this.labeldeudaa.Name = "labeldeudaa";
            this.labeldeudaa.Size = new System.Drawing.Size(42, 13);
            this.labeldeudaa.TabIndex = 5;
            this.labeldeudaa.Text = "Deuda:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(6, 36);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 4;
            this.labelCodigo.Text = "Codigo:";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(477, 142);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 6;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del contribuyente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Consulta_de_datos_de_un_contribuyente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Consulta_de_datos_de_un_contribuyente";
            this.Text = "Consulta_de_datos_de_un_contribuyente";
            this.Load += new System.EventHandler(this.Consulta_de_datos_de_un_contribuyente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeldeu;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labeldeudaa;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}