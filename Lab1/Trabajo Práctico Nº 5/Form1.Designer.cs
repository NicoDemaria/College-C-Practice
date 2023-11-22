namespace Trabajo_Práctico_Nº_5
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDatosAutomaticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.produccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1,
            this.cargaDatosAutomaticamenteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.acercaDeToolStripMenuItem.Text = "Sistema";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click_1);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // cargaDatosAutomaticamenteToolStripMenuItem
            // 
            this.cargaDatosAutomaticamenteToolStripMenuItem.Name = "cargaDatosAutomaticamenteToolStripMenuItem";
            this.cargaDatosAutomaticamenteToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.cargaDatosAutomaticamenteToolStripMenuItem.Text = "Carga datos automaticamente";
            this.cargaDatosAutomaticamenteToolStripMenuItem.Click += new System.EventHandler(this.cargaDatosAutomaticamenteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem,
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem});
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem
            // 
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Name = "consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem";
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Text = "Consultar cantidad producida por un empleado";
            this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem_Click);
            // 
            // listarTotalProducidaEnCadaMaquinaToolStripMenuItem
            // 
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem.Name = "listarTotalProducidaEnCadaMaquinaToolStripMenuItem";
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem.Text = "Listar total producida en cada maquina";
            this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem.Click += new System.EventHandler(this.listarTotalProducidaEnCadaMaquinaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cargaDatosAutomaticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCantidadProducidaPorUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTotalProducidaEnCadaMaquinaToolStripMenuItem;
    }
}

