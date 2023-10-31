namespace TP_LP1_VECTORES
{
    partial class Busqueda_de_Empleado
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
            this.textBoxCodigoBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCodigoBuscar
            // 
            this.textBoxCodigoBuscar.Location = new System.Drawing.Point(303, 102);
            this.textBoxCodigoBuscar.Name = "textBoxCodigoBuscar";
            this.textBoxCodigoBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoBuscar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar codigo:";
            // 
            // labelCategoria
            // 
            this.labelCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCategoria.Location = new System.Drawing.Point(303, 202);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(77, 23);
            this.labelCategoria.TabIndex = 16;
            // 
            // labelCodigo
            // 
            this.labelCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCodigo.Location = new System.Drawing.Point(303, 165);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(77, 23);
            this.labelCodigo.TabIndex = 17;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(409, 99);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 18;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nombre:";
            // 
            // labelNombre
            // 
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Location = new System.Drawing.Point(303, 133);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 23);
            this.labelNombre.TabIndex = 20;
            // 
            // Busqueda_de_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoBuscar);
            this.Name = "Busqueda_de_Empleado";
            this.Text = "Busqueda_de_Empleado";
            this.Load += new System.EventHandler(this.Busqueda_de_Empleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigoBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNombre;
    }
}