namespace sp4Ejercicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BebidaNoAlchohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BebidaAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidarDatos = new System.Windows.Forms.Button();
            this.btnMozoDia = new System.Windows.Forms.Button();
            this.MozoDia = new System.Windows.Forms.TextBox();
            this.btnTotales = new System.Windows.Forms.Button();
            this.TotalDia = new System.Windows.Forms.Label();
            this.TotalComida = new System.Windows.Forms.Label();
            this.TotalBebidaNoAlcohol = new System.Windows.Forms.Label();
            this.TotalBebidaAlcohol = new System.Windows.Forms.Label();
            this.TotalPostre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.textBoxNombreMozo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Comidas,
            this.BebidaNoAlchohol,
            this.BebidaAlcohol,
            this.Postre});
            this.dataGridView1.Location = new System.Drawing.Point(82, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Names
            // 
            this.Names.HeaderText = "Names";
            this.Names.Name = "Names";
            // 
            // Comidas
            // 
            this.Comidas.HeaderText = "Comidas";
            this.Comidas.Name = "Comidas";
            // 
            // BebidaNoAlchohol
            // 
            this.BebidaNoAlchohol.HeaderText = "BebidaNoAlchohol";
            this.BebidaNoAlchohol.Name = "BebidaNoAlchohol";
            // 
            // BebidaAlcohol
            // 
            this.BebidaAlcohol.HeaderText = "BebidaAlcohol";
            this.BebidaAlcohol.Name = "BebidaAlcohol";
            // 
            // Postre
            // 
            this.Postre.HeaderText = "Postre";
            this.Postre.Name = "Postre";
            // 
            // btnValidarDatos
            // 
            this.btnValidarDatos.Location = new System.Drawing.Point(643, 149);
            this.btnValidarDatos.Name = "btnValidarDatos";
            this.btnValidarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnValidarDatos.TabIndex = 1;
            this.btnValidarDatos.Text = "Validar Datos";
            this.btnValidarDatos.UseVisualStyleBackColor = true;
            this.btnValidarDatos.Click += new System.EventHandler(this.btnValidarDatos_Click);
            // 
            // btnMozoDia
            // 
            this.btnMozoDia.Location = new System.Drawing.Point(15, 308);
            this.btnMozoDia.Name = "btnMozoDia";
            this.btnMozoDia.Size = new System.Drawing.Size(80, 23);
            this.btnMozoDia.TabIndex = 2;
            this.btnMozoDia.Text = "Mozo del Dia";
            this.btnMozoDia.UseVisualStyleBackColor = true;
            this.btnMozoDia.Click += new System.EventHandler(this.btnMozoDia_Click);
            // 
            // MozoDia
            // 
            this.MozoDia.Location = new System.Drawing.Point(101, 292);
            this.MozoDia.Name = "MozoDia";
            this.MozoDia.Size = new System.Drawing.Size(100, 20);
            this.MozoDia.TabIndex = 4;
            this.MozoDia.Tag = "";
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(15, 342);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(80, 23);
            this.btnTotales.TabIndex = 5;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // TotalDia
            // 
            this.TotalDia.AutoSize = true;
            this.TotalDia.Location = new System.Drawing.Point(12, 380);
            this.TotalDia.Name = "TotalDia";
            this.TotalDia.Size = new System.Drawing.Size(34, 13);
            this.TotalDia.TabIndex = 6;
            this.TotalDia.Text = "Total ";
            this.TotalDia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalComida
            // 
            this.TotalComida.AutoSize = true;
            this.TotalComida.Location = new System.Drawing.Point(220, 292);
            this.TotalComida.Name = "TotalComida";
            this.TotalComida.Size = new System.Drawing.Size(69, 13);
            this.TotalComida.TabIndex = 7;
            this.TotalComida.Text = "Total Comida";
            this.TotalComida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalBebidaNoAlcohol
            // 
            this.TotalBebidaNoAlcohol.AutoSize = true;
            this.TotalBebidaNoAlcohol.Location = new System.Drawing.Point(306, 292);
            this.TotalBebidaNoAlcohol.Name = "TotalBebidaNoAlcohol";
            this.TotalBebidaNoAlcohol.Size = new System.Drawing.Size(119, 13);
            this.TotalBebidaNoAlcohol.TabIndex = 8;
            this.TotalBebidaNoAlcohol.Text = "Total  BebidaNoAlcohol";
            this.TotalBebidaNoAlcohol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalBebidaAlcohol
            // 
            this.TotalBebidaAlcohol.AutoSize = true;
            this.TotalBebidaAlcohol.Location = new System.Drawing.Point(421, 292);
            this.TotalBebidaAlcohol.Name = "TotalBebidaAlcohol";
            this.TotalBebidaAlcohol.Size = new System.Drawing.Size(105, 13);
            this.TotalBebidaAlcohol.TabIndex = 9;
            this.TotalBebidaAlcohol.Text = "Total  BebidaAlcohol";
            this.TotalBebidaAlcohol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalPostre
            // 
            this.TotalPostre.AutoSize = true;
            this.TotalPostre.Location = new System.Drawing.Point(532, 292);
            this.TotalPostre.Name = "TotalPostre";
            this.TotalPostre.Size = new System.Drawing.Size(67, 13);
            this.TotalPostre.TabIndex = 10;
            this.TotalPostre.Text = "Total  Postre";
            this.TotalPostre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TotalPostre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(699, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // textBoxNombreMozo
            // 
            this.textBoxNombreMozo.Location = new System.Drawing.Point(101, 318);
            this.textBoxNombreMozo.Name = "textBoxNombreMozo";
            this.textBoxNombreMozo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreMozo.TabIndex = 12;
            this.textBoxNombreMozo.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNombreMozo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.TotalPostre);
            this.Controls.Add(this.TotalBebidaAlcohol);
            this.Controls.Add(this.TotalBebidaNoAlcohol);
            this.Controls.Add(this.TotalComida);
            this.Controls.Add(this.TotalDia);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.MozoDia);
            this.Controls.Add(this.btnMozoDia);
            this.Controls.Add(this.btnValidarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BebidaNoAlchohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BebidaAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postre;
        private System.Windows.Forms.Button btnValidarDatos;
        private System.Windows.Forms.Button btnMozoDia;
        private System.Windows.Forms.TextBox MozoDia;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Label TotalDia;
        private System.Windows.Forms.Label TotalComida;
        private System.Windows.Forms.Label TotalBebidaNoAlcohol;
        private System.Windows.Forms.Label TotalBebidaAlcohol;
        private System.Windows.Forms.Label TotalPostre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox textBoxNombreMozo;
    }
}

