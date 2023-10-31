namespace TP_LP1_VECTORES
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDatosDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeUnEmpeladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.listadoGeneralDeEmpleadosToolStripMenuItem,
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem,
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem,
            this.consultaDatosDeUnEmpleadoToolStripMenuItem,
            this.busquedaDeUnEmpeladoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // listadoGeneralDeEmpleadosToolStripMenuItem
            // 
            this.listadoGeneralDeEmpleadosToolStripMenuItem.Name = "listadoGeneralDeEmpleadosToolStripMenuItem";
            this.listadoGeneralDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listadoGeneralDeEmpleadosToolStripMenuItem.Text = "Listado general de empleados";
            this.listadoGeneralDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeEmpleadosToolStripMenuItem_Click);
            // 
            // listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem
            // 
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem.Name = "listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem";
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem.Text = "Listado general de empleados por categoria";
            this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem_Click);
            // 
            // listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem
            // 
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem.Name = "listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem";
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem.Text = "Listado de empleados con sueldo mayor a...";
            this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem_Click);
            // 
            // consultaDatosDeUnEmpleadoToolStripMenuItem
            // 
            this.consultaDatosDeUnEmpleadoToolStripMenuItem.Name = "consultaDatosDeUnEmpleadoToolStripMenuItem";
            this.consultaDatosDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.consultaDatosDeUnEmpleadoToolStripMenuItem.Text = "Consulta datos de un empleado";
            this.consultaDatosDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultaDatosDeUnEmpleadoToolStripMenuItem_Click);
            // 
            // busquedaDeUnEmpeladoToolStripMenuItem
            // 
            this.busquedaDeUnEmpeladoToolStripMenuItem.Name = "busquedaDeUnEmpeladoToolStripMenuItem";
            this.busquedaDeUnEmpeladoToolStripMenuItem.Size = new System.Drawing.Size(305, 22);
            this.busquedaDeUnEmpeladoToolStripMenuItem.Text = "Busqueda de un empleado";
            this.busquedaDeUnEmpeladoToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeUnEmpeladoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeEmpleadosPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosPorCondicionSueldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDatosDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeUnEmpeladoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

