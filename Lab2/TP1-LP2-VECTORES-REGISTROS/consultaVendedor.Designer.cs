namespace TP1_LP2_VECTORES_REGISTROS
{
    partial class consultaVendedor
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
            this.textBoxConsultaCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConsultaNombre = new System.Windows.Forms.Label();
            this.labelConsultaSueldo = new System.Windows.Forms.Label();
            this.buttonConsultaBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConsultaCodigo
            // 
            this.textBoxConsultaCodigo.Location = new System.Drawing.Point(189, 37);
            this.textBoxConsultaCodigo.Name = "textBoxConsultaCodigo";
            this.textBoxConsultaCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsultaCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo del vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sueldo:";
            // 
            // labelConsultaNombre
            // 
            this.labelConsultaNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConsultaNombre.Location = new System.Drawing.Point(127, 78);
            this.labelConsultaNombre.Name = "labelConsultaNombre";
            this.labelConsultaNombre.Size = new System.Drawing.Size(70, 25);
            this.labelConsultaNombre.TabIndex = 4;
            // 
            // labelConsultaSueldo
            // 
            this.labelConsultaSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConsultaSueldo.Location = new System.Drawing.Point(127, 117);
            this.labelConsultaSueldo.Name = "labelConsultaSueldo";
            this.labelConsultaSueldo.Size = new System.Drawing.Size(70, 25);
            this.labelConsultaSueldo.TabIndex = 5;
            // 
            // buttonConsultaBuscar
            // 
            this.buttonConsultaBuscar.Location = new System.Drawing.Point(295, 35);
            this.buttonConsultaBuscar.Name = "buttonConsultaBuscar";
            this.buttonConsultaBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultaBuscar.TabIndex = 6;
            this.buttonConsultaBuscar.Text = "Buscar";
            this.buttonConsultaBuscar.UseVisualStyleBackColor = true;
            this.buttonConsultaBuscar.Click += new System.EventHandler(this.buttonConsultaBuscar_Click);
            // 
            // consultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 174);
            this.Controls.Add(this.buttonConsultaBuscar);
            this.Controls.Add(this.labelConsultaSueldo);
            this.Controls.Add(this.labelConsultaNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConsultaCodigo);
            this.Name = "consultaVendedor";
            this.Text = "consultaVendedor";
            this.Load += new System.EventHandler(this.consultaVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsultaCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelConsultaNombre;
        private System.Windows.Forms.Label labelConsultaSueldo;
        private System.Windows.Forms.Button buttonConsultaBuscar;
    }
}