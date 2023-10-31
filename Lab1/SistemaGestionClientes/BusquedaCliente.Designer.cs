namespace SistemaGestionClientes
{
    partial class BusquedaCliente
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonConsultaBuscar = new System.Windows.Forms.Button();
            this.labelConsultaDeuda = new System.Windows.Forms.Label();
            this.labelConsultaNombre = new System.Windows.Forms.Label();
            this.labelDeuda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsultaCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConsultaBuscar
            // 
            this.buttonConsultaBuscar.Location = new System.Drawing.Point(473, 172);
            this.buttonConsultaBuscar.Name = "buttonConsultaBuscar";
            this.buttonConsultaBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultaBuscar.TabIndex = 13;
            this.buttonConsultaBuscar.Text = "Buscar";
            this.buttonConsultaBuscar.UseVisualStyleBackColor = true;
            this.buttonConsultaBuscar.Click += new System.EventHandler(this.buttonConsultaBuscar_Click);
            // 
            // labelConsultaDeuda
            // 
            this.labelConsultaDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConsultaDeuda.Location = new System.Drawing.Point(300, 254);
            this.labelConsultaDeuda.Name = "labelConsultaDeuda";
            this.labelConsultaDeuda.Size = new System.Drawing.Size(70, 25);
            this.labelConsultaDeuda.TabIndex = 12;
            // 
            // labelConsultaNombre
            // 
            this.labelConsultaNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConsultaNombre.Location = new System.Drawing.Point(305, 215);
            this.labelConsultaNombre.Name = "labelConsultaNombre";
            this.labelConsultaNombre.Size = new System.Drawing.Size(70, 25);
            this.labelConsultaNombre.TabIndex = 11;
            // 
            // labelDeuda
            // 
            this.labelDeuda.AutoSize = true;
            this.labelDeuda.Location = new System.Drawing.Point(252, 255);
            this.labelDeuda.Name = "labelDeuda";
            this.labelDeuda.Size = new System.Drawing.Size(42, 13);
            this.labelDeuda.TabIndex = 10;
            this.labelDeuda.Text = "Deuda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(252, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo del cliente:";
            // 
            // textBoxConsultaCodigo
            // 
            this.textBoxConsultaCodigo.Location = new System.Drawing.Point(367, 174);
            this.textBoxConsultaCodigo.Name = "textBoxConsultaCodigo";
            this.textBoxConsultaCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsultaCodigo.TabIndex = 7;
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConsultaBuscar);
            this.Controls.Add(this.labelConsultaDeuda);
            this.Controls.Add(this.labelConsultaNombre);
            this.Controls.Add(this.labelDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConsultaCodigo);
            this.Name = "BusquedaCliente";
            this.Text = "BusquedaCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonConsultaBuscar;
        private System.Windows.Forms.Label labelConsultaDeuda;
        private System.Windows.Forms.Label labelConsultaNombre;
        private System.Windows.Forms.Label labelDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConsultaCodigo;
    }
}