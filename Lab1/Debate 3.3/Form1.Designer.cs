namespace Debate_3._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRankine = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelResta = new System.Windows.Forms.Label();
            this.labelFahe = new System.Windows.Forms.Label();
            this.labelKelvin = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temp en C:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grados Rankine";
            // 
            // labelRankine
            // 
            this.labelRankine.BackColor = System.Drawing.SystemColors.Control;
            this.labelRankine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRankine.Location = new System.Drawing.Point(117, 27);
            this.labelRankine.Name = "labelRankine";
            this.labelRankine.Size = new System.Drawing.Size(128, 25);
            this.labelRankine.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKelvin);
            this.groupBox1.Controls.Add(this.labelProducto);
            this.groupBox1.Controls.Add(this.labelFahe);
            this.groupBox1.Controls.Add(this.LabelResta);
            this.groupBox1.Controls.Add(this.labelRankine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(166, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // LabelResta
            // 
            this.LabelResta.AutoSize = true;
            this.LabelResta.Location = new System.Drawing.Point(17, 75);
            this.LabelResta.Name = "LabelResta";
            this.LabelResta.Size = new System.Drawing.Size(94, 13);
            this.LabelResta.TabIndex = 4;
            this.LabelResta.Text = "Grados Fahrenheit";
            // 
            // labelFahe
            // 
            this.labelFahe.BackColor = System.Drawing.SystemColors.Control;
            this.labelFahe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFahe.Location = new System.Drawing.Point(117, 75);
            this.labelFahe.Name = "labelFahe";
            this.labelFahe.Size = new System.Drawing.Size(128, 25);
            this.labelFahe.TabIndex = 5;
            // 
            // labelKelvin
            // 
            this.labelKelvin.BackColor = System.Drawing.SystemColors.Control;
            this.labelKelvin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKelvin.Location = new System.Drawing.Point(117, 116);
            this.labelKelvin.Name = "labelKelvin";
            this.labelKelvin.Size = new System.Drawing.Size(128, 25);
            this.labelKelvin.TabIndex = 7;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(17, 117);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(73, 13);
            this.labelProducto.TabIndex = 6;
            this.labelProducto.Text = "Grados Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRankine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelKelvin;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelFahe;
        private System.Windows.Forms.Label LabelResta;
    }
}

