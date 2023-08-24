namespace PictureBox
{
    partial class Imagenes
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
            this.SpiderMan = new System.Windows.Forms.RadioButton();
            this.Thor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHeroes = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.SpiderMan);
            this.groupBox1.Controls.Add(this.Thor);
            this.groupBox1.Location = new System.Drawing.Point(81, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heroes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SpiderMan
            // 
            this.SpiderMan.AutoSize = true;
            this.SpiderMan.Location = new System.Drawing.Point(70, 94);
            this.SpiderMan.Name = "SpiderMan";
            this.SpiderMan.Size = new System.Drawing.Size(76, 17);
            this.SpiderMan.TabIndex = 1;
            this.SpiderMan.TabStop = true;
            this.SpiderMan.Text = "SpiderMan";
            this.SpiderMan.UseVisualStyleBackColor = true;
            this.SpiderMan.CheckedChanged += new System.EventHandler(this.SpiderMan_CheckedChanged);
            // 
            // Thor
            // 
            this.Thor.AutoSize = true;
            this.Thor.Location = new System.Drawing.Point(70, 55);
            this.Thor.Name = "Thor";
            this.Thor.Size = new System.Drawing.Size(47, 17);
            this.Thor.TabIndex = 0;
            this.Thor.TabStop = true;
            this.Thor.Text = "Thor";
            this.Thor.UseVisualStyleBackColor = true;
            this.Thor.CheckedChanged += new System.EventHandler(this.Thor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(439, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 23);
            this.label1.TabIndex = 2;
            // 
            // pictureBoxHeroes
            // 
            this.pictureBoxHeroes.Image = global::PictureBox.Properties.Resources.rick_and_morty_1604562846;
            this.pictureBoxHeroes.Location = new System.Drawing.Point(439, 94);
            this.pictureBoxHeroes.Name = "pictureBoxHeroes";
            this.pictureBoxHeroes.Size = new System.Drawing.Size(279, 257);
            this.pictureBoxHeroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeroes.TabIndex = 0;
            this.pictureBoxHeroes.TabStop = false;
            this.pictureBoxHeroes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(70, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Rick";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Morty";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(70, 197);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Rick and Morty";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxHeroes);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.Imagenes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeroes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHeroes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SpiderMan;
        private System.Windows.Forms.RadioButton Thor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

