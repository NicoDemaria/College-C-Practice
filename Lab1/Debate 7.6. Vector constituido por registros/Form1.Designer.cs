namespace Debate_7._6.Vector_constituido_por_registros
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
            this.components = new System.ComponentModel.Container();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxLimite = new System.Windows.Forms.TextBox();
            this.textBoxDeuda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalDeuda = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(90, 71);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(196, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxLimite
            // 
            this.textBoxLimite.Location = new System.Drawing.Point(417, 71);
            this.textBoxLimite.Name = "textBoxLimite";
            this.textBoxLimite.Size = new System.Drawing.Size(100, 20);
            this.textBoxLimite.TabIndex = 3;
            this.textBoxLimite.TextChanged += new System.EventHandler(this.textBoxLimite_TextChanged);
            // 
            // textBoxDeuda
            // 
            this.textBoxDeuda.Location = new System.Drawing.Point(311, 71);
            this.textBoxDeuda.Name = "textBoxDeuda";
            this.textBoxDeuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeuda.TabIndex = 4;
            this.textBoxDeuda.TextChanged += new System.EventHandler(this.textBoxDeuda_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda,
            this.Limite});
            this.dataGridView1.Location = new System.Drawing.Point(90, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            // 
            // labelTotalDeuda
            // 
            this.labelTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalDeuda.Location = new System.Drawing.Point(90, 291);
            this.labelTotalDeuda.Name = "labelTotalDeuda";
            this.labelTotalDeuda.Size = new System.Drawing.Size(118, 26);
            this.labelTotalDeuda.TabIndex = 6;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(523, 69);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(108, 23);
            this.buttonCargar.TabIndex = 8;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Listar deudores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Listar todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelTotalDeuda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxDeuda);
            this.Controls.Add(this.textBoxLimite);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxLimite;
        private System.Windows.Forms.TextBox textBoxDeuda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.Label labelTotalDeuda;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

