namespace FinalLP1
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
            this.cargaAutomaticaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralDeGénerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosDeUnGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVisualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVisualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizacionesDeUnMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionesDeUnGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.génerosToolStripMenuItem,
            this.visualizacionesToolStripMenuItem});
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
            this.cargaAutomaticaDeDatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de:";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // cargaAutomaticaDeDatosToolStripMenuItem
            // 
            this.cargaAutomaticaDeDatosToolStripMenuItem.Name = "cargaAutomaticaDeDatosToolStripMenuItem";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cargaAutomaticaDeDatosToolStripMenuItem.Text = "Carga automatica de datos...";
            this.cargaAutomaticaDeDatosToolStripMenuItem.Click += new System.EventHandler(this.cargaAutomaticaDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // génerosToolStripMenuItem
            // 
            this.génerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoGéneroToolStripMenuItem,
            this.listadoGeneralDeGénerosToolStripMenuItem,
            this.consultaDeDatosDeUnGéneroToolStripMenuItem});
            this.génerosToolStripMenuItem.Name = "génerosToolStripMenuItem";
            this.génerosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.génerosToolStripMenuItem.Text = "Géneros ";
            // 
            // agregarNuevoGéneroToolStripMenuItem
            // 
            this.agregarNuevoGéneroToolStripMenuItem.Name = "agregarNuevoGéneroToolStripMenuItem";
            this.agregarNuevoGéneroToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.agregarNuevoGéneroToolStripMenuItem.Text = "Agregar nuevo género…";
            this.agregarNuevoGéneroToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoGéneroToolStripMenuItem_Click);
            // 
            // listadoGeneralDeGénerosToolStripMenuItem
            // 
            this.listadoGeneralDeGénerosToolStripMenuItem.Name = "listadoGeneralDeGénerosToolStripMenuItem";
            this.listadoGeneralDeGénerosToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.listadoGeneralDeGénerosToolStripMenuItem.Text = "Listado general de géneros…";
            this.listadoGeneralDeGénerosToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralDeGénerosToolStripMenuItem_Click);
            // 
            // consultaDeDatosDeUnGéneroToolStripMenuItem
            // 
            this.consultaDeDatosDeUnGéneroToolStripMenuItem.Name = "consultaDeDatosDeUnGéneroToolStripMenuItem";
            this.consultaDeDatosDeUnGéneroToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.consultaDeDatosDeUnGéneroToolStripMenuItem.Text = "Consulta de datos de un género….";
            this.consultaDeDatosDeUnGéneroToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosDeUnGéneroToolStripMenuItem_Click);
            // 
            // visualizacionesToolStripMenuItem
            // 
            this.visualizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVisualizaciónToolStripMenuItem,
            this.consultaDeVisualizacionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.visualizacionesDeUnMesToolStripMenuItem,
            this.visualizacionesDeUnGéneroToolStripMenuItem,
            this.toolStripMenuItem3,
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem,
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem});
            this.visualizacionesToolStripMenuItem.Name = "visualizacionesToolStripMenuItem";
            this.visualizacionesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.visualizacionesToolStripMenuItem.Text = "Visualizaciones";
            // 
            // registrarVisualizaciónToolStripMenuItem
            // 
            this.registrarVisualizaciónToolStripMenuItem.Name = "registrarVisualizaciónToolStripMenuItem";
            this.registrarVisualizaciónToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.registrarVisualizaciónToolStripMenuItem.Text = "Registrar visualización….";
            this.registrarVisualizaciónToolStripMenuItem.Click += new System.EventHandler(this.registrarVisualizaciónToolStripMenuItem_Click);
            // 
            // consultaDeVisualizacionesToolStripMenuItem
            // 
            this.consultaDeVisualizacionesToolStripMenuItem.Name = "consultaDeVisualizacionesToolStripMenuItem";
            this.consultaDeVisualizacionesToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.consultaDeVisualizacionesToolStripMenuItem.Text = "Consulta de visualizaciones…";
            this.consultaDeVisualizacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVisualizacionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(296, 6);
            // 
            // visualizacionesDeUnMesToolStripMenuItem
            // 
            this.visualizacionesDeUnMesToolStripMenuItem.Name = "visualizacionesDeUnMesToolStripMenuItem";
            this.visualizacionesDeUnMesToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.visualizacionesDeUnMesToolStripMenuItem.Text = "Visualizaciones de un mes…";
            this.visualizacionesDeUnMesToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnMesToolStripMenuItem_Click);
            // 
            // visualizacionesDeUnGéneroToolStripMenuItem
            // 
            this.visualizacionesDeUnGéneroToolStripMenuItem.Name = "visualizacionesDeUnGéneroToolStripMenuItem";
            this.visualizacionesDeUnGéneroToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.visualizacionesDeUnGéneroToolStripMenuItem.Text = "Visualizaciones de un género….";
            this.visualizacionesDeUnGéneroToolStripMenuItem.Click += new System.EventHandler(this.visualizacionesDeUnGéneroToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(296, 6);
            // 
            // estadísticaDeVisualizacionesPorMesToolStripMenuItem
            // 
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Name = "estadísticaDeVisualizacionesPorMesToolStripMenuItem";
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Text = "Estadística de visualizaciones por mes…";
            this.estadísticaDeVisualizacionesPorMesToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDeVisualizacionesPorMesToolStripMenuItem_Click);
            // 
            // estadísticaDeVisualizacionesPorGéneroToolStripMenuItem
            // 
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Name = "estadísticaDeVisualizacionesPorGéneroToolStripMenuItem";
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Text = "Estadística de visualizaciones por género….";
            this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem.Click += new System.EventHandler(this.estadísticaDeVisualizacionesPorGéneroToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAutomaticaDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem génerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoGéneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralDeGénerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosDeUnGéneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVisualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVisualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionesDeUnGéneroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeVisualizacionesPorMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaDeVisualizacionesPorGéneroToolStripMenuItem;
    }
}

