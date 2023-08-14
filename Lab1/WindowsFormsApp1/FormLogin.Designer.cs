namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Contrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnAceptarLogin = new System.Windows.Forms.Button();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(196, 132);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // Contrasenia
            // 
            this.Contrasenia.AutoSize = true;
            this.Contrasenia.Location = new System.Drawing.Point(126, 194);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(61, 13);
            this.Contrasenia.TabIndex = 2;
            this.Contrasenia.Text = "Contraseña";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(196, 194);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtContrasenia.TabIndex = 3;
            // 
            // btnAceptarLogin
            // 
            this.btnAceptarLogin.Location = new System.Drawing.Point(129, 261);
            this.btnAceptarLogin.Name = "btnAceptarLogin";
            this.btnAceptarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarLogin.TabIndex = 4;
            this.btnAceptarLogin.Text = "Aceptar";
            this.btnAceptarLogin.UseVisualStyleBackColor = true;
            this.btnAceptarLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.Location = new System.Drawing.Point(221, 261);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLogin.TabIndex = 5;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.btnAceptarLogin);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Contrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnAceptarLogin;
        private System.Windows.Forms.Button btnCancelarLogin;
    }
}

