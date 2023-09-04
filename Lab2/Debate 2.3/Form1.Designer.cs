namespace Debate_2._3
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
            this.CargaDatos = new System.Windows.Forms.GroupBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxLimCredito = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDeuda = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDeuda = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalDeuda = new System.Windows.Forms.Label();
            this.textBoxTotalDeuda = new System.Windows.Forms.TextBox();
            this.buttonListado = new System.Windows.Forms.Button();
            this.CargaDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CargaDatos
            // 
            this.CargaDatos.Controls.Add(this.buttonCargar);
            this.CargaDatos.Controls.Add(this.textBoxLimCredito);
            this.CargaDatos.Controls.Add(this.textBoxName);
            this.CargaDatos.Controls.Add(this.textBoxDeuda);
            this.CargaDatos.Controls.Add(this.textBoxCodigo);
            this.CargaDatos.Controls.Add(this.label4);
            this.CargaDatos.Controls.Add(this.label3);
            this.CargaDatos.Controls.Add(this.labelDeuda);
            this.CargaDatos.Controls.Add(this.labelCodigo);
            this.CargaDatos.Location = new System.Drawing.Point(98, 55);
            this.CargaDatos.Name = "CargaDatos";
            this.CargaDatos.Size = new System.Drawing.Size(448, 131);
            this.CargaDatos.TabIndex = 0;
            this.CargaDatos.TabStop = false;
            this.CargaDatos.Text = "Carga de datos";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(331, 105);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 8;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxLimCredito
            // 
            this.textBoxLimCredito.Location = new System.Drawing.Point(306, 79);
            this.textBoxLimCredito.Name = "textBoxLimCredito";
            this.textBoxLimCredito.Size = new System.Drawing.Size(100, 20);
            this.textBoxLimCredito.TabIndex = 7;
            this.textBoxLimCredito.TextChanged += new System.EventHandler(this.textBoxLimCredito_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(306, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxDeuda
            // 
            this.textBoxDeuda.Location = new System.Drawing.Point(99, 76);
            this.textBoxDeuda.Name = "textBoxDeuda";
            this.textBoxDeuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeuda.TabIndex = 5;
            this.textBoxDeuda.TextChanged += new System.EventHandler(this.textBoxDeuda_TextChanged);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(99, 32);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 4;
            this.textBoxCodigo.Text = "1";
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de credito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre y Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDeuda
            // 
            this.labelDeuda.AutoSize = true;
            this.labelDeuda.Location = new System.Drawing.Point(43, 79);
            this.labelDeuda.Name = "labelDeuda";
            this.labelDeuda.Size = new System.Drawing.Size(42, 13);
            this.labelDeuda.TabIndex = 1;
            this.labelDeuda.Text = "Deuda:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(42, 32);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(98, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grilla de datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.UserName,
            this.Credito,
            this.Deuda});
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre Y Apellido";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Limite Credito";
            this.Credito.Name = "Credito";
            this.Credito.ReadOnly = true;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.ReadOnly = true;
            // 
            // labelTotalDeuda
            // 
            this.labelTotalDeuda.AutoSize = true;
            this.labelTotalDeuda.Location = new System.Drawing.Point(374, 395);
            this.labelTotalDeuda.Name = "labelTotalDeuda";
            this.labelTotalDeuda.Size = new System.Drawing.Size(67, 13);
            this.labelTotalDeuda.TabIndex = 1;
            this.labelTotalDeuda.Text = "Total deuda:";
            // 
            // textBoxTotalDeuda
            // 
            this.textBoxTotalDeuda.Location = new System.Drawing.Point(447, 390);
            this.textBoxTotalDeuda.Name = "textBoxTotalDeuda";
            this.textBoxTotalDeuda.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalDeuda.TabIndex = 9;
            // 
            // buttonListado
            // 
            this.buttonListado.Location = new System.Drawing.Point(447, 418);
            this.buttonListado.Name = "buttonListado";
            this.buttonListado.Size = new System.Drawing.Size(105, 20);
            this.buttonListado.TabIndex = 10;
            this.buttonListado.Text = "Listar deudores";
            this.buttonListado.UseVisualStyleBackColor = true;
            this.buttonListado.Click += new System.EventHandler(this.buttonListado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.buttonListado);
            this.Controls.Add(this.textBoxTotalDeuda);
            this.Controls.Add(this.labelTotalDeuda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CargaDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CargaDatos.ResumeLayout(false);
            this.CargaDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CargaDatos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDeuda;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxLimCredito;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDeuda;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label labelTotalDeuda;
        private System.Windows.Forms.TextBox textBoxTotalDeuda;
        private System.Windows.Forms.Button buttonListado;
    }
}

