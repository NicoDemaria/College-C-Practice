namespace FormSaludo
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
            this.ButtonSaludar = new System.Windows.Forms.Button();
            this.ButtonBorrar = new System.Windows.Forms.Button();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSaludar
            // 
            this.ButtonSaludar.Location = new System.Drawing.Point(8, 328);
            this.ButtonSaludar.Name = "ButtonSaludar";
            this.ButtonSaludar.Size = new System.Drawing.Size(394, 110);
            this.ButtonSaludar.TabIndex = 0;
            this.ButtonSaludar.Text = "Saludar";
            this.ButtonSaludar.UseVisualStyleBackColor = true;
            this.ButtonSaludar.Click += new System.EventHandler(this.ButtonSaludar_Click);
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.Location = new System.Drawing.Point(408, 328);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(380, 110);
            this.ButtonBorrar.TabIndex = 1;
            this.ButtonBorrar.Text = "Button Borrar";
            this.ButtonBorrar.UseVisualStyleBackColor = true;
            this.ButtonBorrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelSaludo
            // 
            this.labelSaludo.Location = new System.Drawing.Point(212, 113);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(365, 87);
            this.labelSaludo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.ButtonBorrar);
            this.Controls.Add(this.ButtonSaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSaludar;
        private System.Windows.Forms.Button ButtonBorrar;
        private System.Windows.Forms.Label labelSaludo;
    }
}

