namespace FormColores
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
            this.groupBoxLetras = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CambioColor = new System.Windows.Forms.GroupBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.letraVerde = new System.Windows.Forms.RadioButton();
            this.letraRoja = new System.Windows.Forms.RadioButton();
            this.letraAmarilla = new System.Windows.Forms.RadioButton();
            this.fondoVerde = new System.Windows.Forms.RadioButton();
            this.RojoFondo = new System.Windows.Forms.RadioButton();
            this.FondoAmarillo = new System.Windows.Forms.RadioButton();
            this.groupBoxLetras.SuspendLayout();
            this.CambioColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLetras
            // 
            this.groupBoxLetras.Controls.Add(this.letraAmarilla);
            this.groupBoxLetras.Controls.Add(this.letraRoja);
            this.groupBoxLetras.Controls.Add(this.letraVerde);
            this.groupBoxLetras.Location = new System.Drawing.Point(63, 210);
            this.groupBoxLetras.Name = "groupBoxLetras";
            this.groupBoxLetras.Size = new System.Drawing.Size(200, 213);
            this.groupBoxLetras.TabIndex = 0;
            this.groupBoxLetras.TabStop = false;
            this.groupBoxLetras.Text = "Cambiar Letras";
            this.groupBoxLetras.Enter += new System.EventHandler(this.groupBoxLetras_Enter);
            // 
            // CambioColor
            // 
            this.CambioColor.Controls.Add(this.FondoAmarillo);
            this.CambioColor.Controls.Add(this.RojoFondo);
            this.CambioColor.Controls.Add(this.fondoVerde);
            this.CambioColor.Location = new System.Drawing.Point(473, 210);
            this.CambioColor.Name = "CambioColor";
            this.CambioColor.Size = new System.Drawing.Size(200, 213);
            this.CambioColor.TabIndex = 1;
            this.CambioColor.TabStop = false;
            this.CambioColor.Text = "CambioColorFondo";
            this.CambioColor.Enter += new System.EventHandler(this.FondoRojo_Enter);
            // 
            // labelTest
            // 
            this.labelTest.Location = new System.Drawing.Point(54, 64);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(714, 88);
            this.labelTest.TabIndex = 0;
            this.labelTest.Text = "TEXTO EJEMPLO!";
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letraVerde
            // 
            this.letraVerde.AutoSize = true;
            this.letraVerde.Location = new System.Drawing.Point(28, 40);
            this.letraVerde.Name = "letraVerde";
            this.letraVerde.Size = new System.Drawing.Size(53, 17);
            this.letraVerde.TabIndex = 0;
            this.letraVerde.TabStop = true;
            this.letraVerde.Text = "Verde";
            this.letraVerde.UseVisualStyleBackColor = true;
            this.letraVerde.CheckedChanged += new System.EventHandler(this.letraVerde_CheckedChanged);
            // 
            // letraRoja
            // 
            this.letraRoja.AutoSize = true;
            this.letraRoja.Location = new System.Drawing.Point(28, 82);
            this.letraRoja.Name = "letraRoja";
            this.letraRoja.Size = new System.Drawing.Size(47, 17);
            this.letraRoja.TabIndex = 1;
            this.letraRoja.TabStop = true;
            this.letraRoja.Text = "Rojo";
            this.letraRoja.UseVisualStyleBackColor = true;
            this.letraRoja.CheckedChanged += new System.EventHandler(this.letraRoja_CheckedChanged);
            // 
            // letraAmarilla
            // 
            this.letraAmarilla.AutoSize = true;
            this.letraAmarilla.Location = new System.Drawing.Point(28, 117);
            this.letraAmarilla.Name = "letraAmarilla";
            this.letraAmarilla.Size = new System.Drawing.Size(61, 17);
            this.letraAmarilla.TabIndex = 2;
            this.letraAmarilla.TabStop = true;
            this.letraAmarilla.Text = "Amarillo";
            this.letraAmarilla.UseVisualStyleBackColor = true;
            this.letraAmarilla.CheckedChanged += new System.EventHandler(this.letraAmarilla_CheckedChanged);
            // 
            // fondoVerde
            // 
            this.fondoVerde.AutoSize = true;
            this.fondoVerde.Location = new System.Drawing.Point(37, 54);
            this.fondoVerde.Name = "fondoVerde";
            this.fondoVerde.Size = new System.Drawing.Size(83, 17);
            this.fondoVerde.TabIndex = 0;
            this.fondoVerde.TabStop = true;
            this.fondoVerde.Text = "FondoVerde";
            this.fondoVerde.UseVisualStyleBackColor = true;
            this.fondoVerde.CheckedChanged += new System.EventHandler(this.fondoVerde_CheckedChanged);
            // 
            // RojoFondo
            // 
            this.RojoFondo.AutoSize = true;
            this.RojoFondo.Location = new System.Drawing.Point(43, 98);
            this.RojoFondo.Name = "RojoFondo";
            this.RojoFondo.Size = new System.Drawing.Size(77, 17);
            this.RojoFondo.TabIndex = 1;
            this.RojoFondo.TabStop = true;
            this.RojoFondo.Text = "FondoRojo";
            this.RojoFondo.UseVisualStyleBackColor = true;
            this.RojoFondo.CheckedChanged += new System.EventHandler(this.RojoFondo_CheckedChanged);
            // 
            // FondoAmarillo
            // 
            this.FondoAmarillo.AutoSize = true;
            this.FondoAmarillo.Location = new System.Drawing.Point(44, 141);
            this.FondoAmarillo.Name = "FondoAmarillo";
            this.FondoAmarillo.Size = new System.Drawing.Size(91, 17);
            this.FondoAmarillo.TabIndex = 2;
            this.FondoAmarillo.TabStop = true;
            this.FondoAmarillo.Text = "FondoAmarillo";
            this.FondoAmarillo.UseVisualStyleBackColor = true;
            this.FondoAmarillo.CheckedChanged += new System.EventHandler(this.FondoAmarillo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.CambioColor);
            this.Controls.Add(this.groupBoxLetras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLetras.ResumeLayout(false);
            this.groupBoxLetras.PerformLayout();
            this.CambioColor.ResumeLayout(false);
            this.CambioColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLetras;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox CambioColor;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.RadioButton letraAmarilla;
        private System.Windows.Forms.RadioButton letraRoja;
        private System.Windows.Forms.RadioButton letraVerde;
        private System.Windows.Forms.RadioButton FondoAmarillo;
        private System.Windows.Forms.RadioButton RojoFondo;
        private System.Windows.Forms.RadioButton fondoVerde;
    }
}

