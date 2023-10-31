namespace SistemaGestionClientes
{
    partial class agregarCliente
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
            this.textBoxDeuda = new System.Windows.Forms.TextBox();
            this.labelDeu = new System.Windows.Forms.Label();
            this.ButtonCargar = new System.Windows.Forms.Button();
            this.textBoxLimite = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDeuda);
            this.groupBox1.Controls.Add(this.labelDeu);
            this.groupBox1.Controls.Add(this.ButtonCargar);
            this.groupBox1.Controls.Add(this.textBoxLimite);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(269, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // textBoxDeuda
            // 
            this.textBoxDeuda.Location = new System.Drawing.Point(109, 133);
            this.textBoxDeuda.Name = "textBoxDeuda";
            this.textBoxDeuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeuda.TabIndex = 8;
            this.textBoxDeuda.TextChanged += new System.EventHandler(this.textBoxDeuda_TextChanged);
            // 
            // labelDeu
            // 
            this.labelDeu.AutoSize = true;
            this.labelDeu.Location = new System.Drawing.Point(56, 136);
            this.labelDeu.Name = "labelDeu";
            this.labelDeu.Size = new System.Drawing.Size(39, 13);
            this.labelDeu.TabIndex = 7;
            this.labelDeu.Text = "Deuda";
            // 
            // ButtonCargar
            // 
            this.ButtonCargar.Location = new System.Drawing.Point(109, 199);
            this.ButtonCargar.Name = "ButtonCargar";
            this.ButtonCargar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCargar.TabIndex = 6;
            this.ButtonCargar.Text = "Cargar";
            this.ButtonCargar.UseVisualStyleBackColor = true;
            this.ButtonCargar.Click += new System.EventHandler(this.ButtonCargar_Click);
            // 
            // textBoxLimite
            // 
            this.textBoxLimite.Location = new System.Drawing.Point(109, 163);
            this.textBoxLimite.Name = "textBoxLimite";
            this.textBoxLimite.Size = new System.Drawing.Size(100, 20);
            this.textBoxLimite.TabIndex = 5;
            this.textBoxLimite.TextChanged += new System.EventHandler(this.textBoxLimite_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(109, 107);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(109, 81);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 3;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Limite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // agregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "agregarCliente";
            this.Text = "Agregar cliente";
            this.Load += new System.EventHandler(this.agregarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDeuda;
        private System.Windows.Forms.Label labelDeu;
        private System.Windows.Forms.Button ButtonCargar;
        private System.Windows.Forms.TextBox textBoxLimite;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}