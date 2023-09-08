namespace TP1_LP2_VECTORES_REGISTROS
{
    partial class listaVendedores
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
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalSueldo = new System.Windows.Forms.Label();
            this.labelTotalVendedores = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Sueldo"});
            this.comboBoxCampo.Location = new System.Drawing.Point(166, 73);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modo";
            // 
            // comboBoxModo
            // 
            this.comboBoxModo.FormattingEnabled = true;
            this.comboBoxModo.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.comboBoxModo.Location = new System.Drawing.Point(166, 117);
            this.comboBoxModo.Name = "comboBoxModo";
            this.comboBoxModo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnName,
            this.ColumnSueldo});
            this.dataGridView1.Location = new System.Drawing.Point(109, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSueldo
            // 
            this.ColumnSueldo.HeaderText = "Sueldo";
            this.ColumnSueldo.Name = "ColumnSueldo";
            this.ColumnSueldo.ReadOnly = true;
            // 
            // labelTotalSueldo
            // 
            this.labelTotalSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalSueldo.Location = new System.Drawing.Point(362, 315);
            this.labelTotalSueldo.Name = "labelTotalSueldo";
            this.labelTotalSueldo.Size = new System.Drawing.Size(79, 30);
            this.labelTotalSueldo.TabIndex = 5;
            // 
            // labelTotalVendedores
            // 
            this.labelTotalVendedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalVendedores.Location = new System.Drawing.Point(265, 315);
            this.labelTotalVendedores.Name = "labelTotalVendedores";
            this.labelTotalVendedores.Size = new System.Drawing.Size(79, 30);
            this.labelTotalVendedores.TabIndex = 6;
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(109, 322);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 7;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // listaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.buttonListar);
            this.Controls.Add(this.labelTotalVendedores);
            this.Controls.Add(this.labelTotalSueldo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxModo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCampo);
            this.Name = "listaVendedores";
            this.Text = "listaVendedores";
            this.Load += new System.EventHandler(this.listaVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSueldo;
        private System.Windows.Forms.Label labelTotalSueldo;
        private System.Windows.Forms.Label labelTotalVendedores;
        private System.Windows.Forms.Button buttonListar;
    }
}