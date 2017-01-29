namespace WindowsFormsApplication1
{
    partial class Sicap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sicap));
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bloquearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArchivoReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.habitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faenasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVentanasCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVentanasHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVentanasVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasYSalidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.bloquearToolStripMenuItem,
            this.mnArchivoReiniciar,
            this.toolStripSeparator2,
            this.mnArchivoSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // bloquearToolStripMenuItem
            // 
            this.bloquearToolStripMenuItem.Name = "bloquearToolStripMenuItem";
            this.bloquearToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bloquearToolStripMenuItem.Text = "Bloquear...";
            this.bloquearToolStripMenuItem.Click += new System.EventHandler(this.bloquearToolStripMenuItem_Click);
            // 
            // mnArchivoReiniciar
            // 
            this.mnArchivoReiniciar.Name = "mnArchivoReiniciar";
            this.mnArchivoReiniciar.Size = new System.Drawing.Size(130, 22);
            this.mnArchivoReiniciar.Text = "Reiniciar";
            this.mnArchivoReiniciar.Click += new System.EventHandler(this.mnArchivoReiniciar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // mnArchivoSalir
            // 
            this.mnArchivoSalir.Image = ((System.Drawing.Image)(resources.GetObject("mnArchivoSalir.Image")));
            this.mnArchivoSalir.Name = "mnArchivoSalir";
            this.mnArchivoSalir.Size = new System.Drawing.Size(130, 22);
            this.mnArchivoSalir.Text = "Salir";
            this.mnArchivoSalir.Click += new System.EventHandler(this.mnArchivoSalir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitantesToolStripMenuItem,
            this.faenasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Catalogos";
            // 
            // habitantesToolStripMenuItem
            // 
            this.habitantesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("habitantesToolStripMenuItem.Image")));
            this.habitantesToolStripMenuItem.Name = "habitantesToolStripMenuItem";
            this.habitantesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.habitantesToolStripMenuItem.Text = "Habitantes...";
            this.habitantesToolStripMenuItem.Click += new System.EventHandler(this.habitantesToolStripMenuItem_Click);
            // 
            // faenasToolStripMenuItem
            // 
            this.faenasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("faenasToolStripMenuItem.Image")));
            this.faenasToolStripMenuItem.Name = "faenasToolStripMenuItem";
            this.faenasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.faenasToolStripMenuItem.Text = "Cooperaciones...";
            this.faenasToolStripMenuItem.Click += new System.EventHandler(this.faenasToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnVentanasCascada,
            this.mnVentanasHorizontal,
            this.mnVentanasVertical});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ventanaToolStripMenuItem.Text = "Ventanas";
            // 
            // mnVentanasCascada
            // 
            this.mnVentanasCascada.Name = "mnVentanasCascada";
            this.mnVentanasCascada.Size = new System.Drawing.Size(129, 22);
            this.mnVentanasCascada.Text = "Cascada";
            this.mnVentanasCascada.Click += new System.EventHandler(this.mnVentanasCascada_Click);
            // 
            // mnVentanasHorizontal
            // 
            this.mnVentanasHorizontal.Name = "mnVentanasHorizontal";
            this.mnVentanasHorizontal.Size = new System.Drawing.Size(129, 22);
            this.mnVentanasHorizontal.Text = "Horizontal";
            this.mnVentanasHorizontal.Click += new System.EventHandler(this.mnVentanasHorizontal_Click);
            // 
            // mnVentanasVertical
            // 
            this.mnVentanasVertical.Name = "mnVentanasVertical";
            this.mnVentanasVertical.Size = new System.Drawing.Size(129, 22);
            this.mnVentanasVertical.Text = "Vertical";
            this.mnVentanasVertical.Click += new System.EventHandler(this.mnVentanasVertical_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otroToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // otroToolStripMenuItem1
            // 
            this.otroToolStripMenuItem1.Name = "otroToolStripMenuItem1";
            this.otroToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.otroToolStripMenuItem1.Text = "Otro...";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasYSalidasToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // entradasYSalidasToolStripMenuItem
            // 
            this.entradasYSalidasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradasYSalidasToolStripMenuItem.Image")));
            this.entradasYSalidasToolStripMenuItem.Name = "entradasYSalidasToolStripMenuItem";
            this.entradasYSalidasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.entradasYSalidasToolStripMenuItem.Text = "Ingresos y Egresos...";
            this.entradasYSalidasToolStripMenuItem.Click += new System.EventHandler(this.entradasYSalidasToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagosToolStripMenuItem.Image")));
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pagosToolStripMenuItem.Text = "Pagos...";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ventanaToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones...";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // Sicap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 402);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sicap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SICAP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaxShop_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoReiniciar;
        private System.Windows.Forms.ToolStripMenuItem mnArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnVentanasCascada;
        private System.Windows.Forms.ToolStripMenuItem mnVentanasHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnVentanasVertical;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem habitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasYSalidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faenasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}