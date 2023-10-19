namespace Debate_4._2.ConexiónBaseDatos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.vendedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoVendedorToolStripMenuItem,
            this.listaVendedoresToolStripMenuItem,
            this.consultaDeVendedorToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // agregarNuevoVendedorToolStripMenuItem
            // 
            this.agregarNuevoVendedorToolStripMenuItem.Name = "agregarNuevoVendedorToolStripMenuItem";
            this.agregarNuevoVendedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.agregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor";
            // 
            // listaVendedoresToolStripMenuItem
            // 
            this.listaVendedoresToolStripMenuItem.Name = "listaVendedoresToolStripMenuItem";
            this.listaVendedoresToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.listaVendedoresToolStripMenuItem.Text = "Lista vendedores";
            this.listaVendedoresToolStripMenuItem.Click += new System.EventHandler(this.listaVendedoresToolStripMenuItem_Click);
            // 
            // consultaDeVendedorToolStripMenuItem
            // 
            this.consultaDeVendedorToolStripMenuItem.Name = "consultaDeVendedorToolStripMenuItem";
            this.consultaDeVendedorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.consultaDeVendedorToolStripMenuItem.Text = "Consulta de vendedor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVendedorToolStripMenuItem;
    }
}

