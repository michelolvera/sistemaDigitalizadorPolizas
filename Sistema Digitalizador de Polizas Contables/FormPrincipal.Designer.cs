namespace Sistema_Digitalizador_de_Polizas_Contables
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.contenedorDividido1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarExplorador = new System.Windows.Forms.TextBox();
            this.labelExplorador = new System.Windows.Forms.Label();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.contenedorDividido2 = new System.Windows.Forms.SplitContainer();
            this.botonConfigAdmin = new System.Windows.Forms.Button();
            this.labelPAnelAdmin = new System.Windows.Forms.Label();
            this.boton_Autodo = new System.Windows.Forms.Button();
            this.brrMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido1)).BeginInit();
            this.contenedorDividido1.Panel1.SuspendLayout();
            this.contenedorDividido1.Panel2.SuspendLayout();
            this.contenedorDividido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido2)).BeginInit();
            this.contenedorDividido2.Panel2.SuspendLayout();
            this.contenedorDividido2.SuspendLayout();
            this.brrMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorDividido1
            // 
            this.contenedorDividido1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDividido1.Location = new System.Drawing.Point(0, 24);
            this.contenedorDividido1.Name = "contenedorDividido1";
            // 
            // contenedorDividido1.Panel1
            // 
            this.contenedorDividido1.Panel1.Controls.Add(this.splitContainer1);
            this.contenedorDividido1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.contenedorDividido1.Panel1MinSize = 200;
            // 
            // contenedorDividido1.Panel2
            // 
            this.contenedorDividido1.Panel2.Controls.Add(this.contenedorDividido2);
            this.contenedorDividido1.Size = new System.Drawing.Size(768, 476);
            this.contenedorDividido1.SplitterDistance = 200;
            this.contenedorDividido1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.botonBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBuscarExplorador);
            this.splitContainer1.Panel1.Controls.Add(this.labelExplorador);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelPendientes);
            this.splitContainer1.Size = new System.Drawing.Size(200, 476);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Location = new System.Drawing.Point(156, 0);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(24, 26);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarExplorador
            // 
            this.textBoxBuscarExplorador.Location = new System.Drawing.Point(3, 3);
            this.textBoxBuscarExplorador.Name = "textBoxBuscarExplorador";
            this.textBoxBuscarExplorador.Size = new System.Drawing.Size(149, 20);
            this.textBoxBuscarExplorador.TabIndex = 1;
            this.textBoxBuscarExplorador.Text = "Buscar";
            // 
            // labelExplorador
            // 
            this.labelExplorador.AutoSize = true;
            this.labelExplorador.Location = new System.Drawing.Point(3, 25);
            this.labelExplorador.Name = "labelExplorador";
            this.labelExplorador.Size = new System.Drawing.Size(57, 13);
            this.labelExplorador.TabIndex = 0;
            this.labelExplorador.Text = "Explorador";
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Location = new System.Drawing.Point(3, 10);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(60, 13);
            this.labelPendientes.TabIndex = 0;
            this.labelPendientes.Text = "Pendientes";
            // 
            // contenedorDividido2
            // 
            this.contenedorDividido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDividido2.Location = new System.Drawing.Point(0, 0);
            this.contenedorDividido2.Name = "contenedorDividido2";
            // 
            // contenedorDividido2.Panel2
            // 
            this.contenedorDividido2.Panel2.Controls.Add(this.botonConfigAdmin);
            this.contenedorDividido2.Panel2.Controls.Add(this.labelPAnelAdmin);
            this.contenedorDividido2.Panel2.Controls.Add(this.boton_Autodo);
            this.contenedorDividido2.Panel2MinSize = 200;
            this.contenedorDividido2.Size = new System.Drawing.Size(564, 476);
            this.contenedorDividido2.SplitterDistance = 359;
            this.contenedorDividido2.TabIndex = 0;
            this.contenedorDividido2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.contenedorDividido2_SplitterMoved);
            // 
            // botonConfigAdmin
            // 
            this.botonConfigAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonConfigAdmin.BackgroundImage")));
            this.botonConfigAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonConfigAdmin.Location = new System.Drawing.Point(159, 10);
            this.botonConfigAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.botonConfigAdmin.Name = "botonConfigAdmin";
            this.botonConfigAdmin.Size = new System.Drawing.Size(27, 26);
            this.botonConfigAdmin.TabIndex = 2;
            this.botonConfigAdmin.UseVisualStyleBackColor = true;
            // 
            // labelPAnelAdmin
            // 
            this.labelPAnelAdmin.AutoSize = true;
            this.labelPAnelAdmin.Location = new System.Drawing.Point(6, 16);
            this.labelPAnelAdmin.Name = "labelPAnelAdmin";
            this.labelPAnelAdmin.Size = new System.Drawing.Size(127, 13);
            this.labelPAnelAdmin.TabIndex = 1;
            this.labelPAnelAdmin.Text = "Sección de Administrador";
            // 
            // boton_Autodo
            // 
            this.boton_Autodo.Location = new System.Drawing.Point(32, 441);
            this.boton_Autodo.Name = "boton_Autodo";
            this.boton_Autodo.Size = new System.Drawing.Size(131, 23);
            this.boton_Autodo.TabIndex = 0;
            this.boton_Autodo.Text = "Autorizar Todo";
            this.boton_Autodo.UseVisualStyleBackColor = true;
            this.boton_Autodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // brrMenu
            // 
            this.brrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.popoToolStripMenuItem});
            this.brrMenu.Location = new System.Drawing.Point(0, 0);
            this.brrMenu.Name = "brrMenu";
            this.brrMenu.Size = new System.Drawing.Size(768, 24);
            this.brrMenu.TabIndex = 1;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivoToolStripMenuItem.Text = "Archivo?";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.editarToolStripMenuItem.Text = "Editar?";
            // 
            // popoToolStripMenuItem
            // 
            this.popoToolStripMenuItem.Name = "popoToolStripMenuItem";
            this.popoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.popoToolStripMenuItem.Text = "Ver?";
            this.popoToolStripMenuItem.Click += new System.EventHandler(this.popoToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 500);
            this.Controls.Add(this.contenedorDividido1);
            this.Controls.Add(this.brrMenu);
            this.MainMenuStrip = this.brrMenu;
            this.Name = "formPrincipal";
            this.Text = "Sistema Digitalizador";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.contenedorDividido1.Panel1.ResumeLayout(false);
            this.contenedorDividido1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido1)).EndInit();
            this.contenedorDividido1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contenedorDividido2.Panel2.ResumeLayout(false);
            this.contenedorDividido2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido2)).EndInit();
            this.contenedorDividido2.ResumeLayout(false);
            this.brrMenu.ResumeLayout(false);
            this.brrMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer contenedorDividido1;
        private System.Windows.Forms.SplitContainer contenedorDividido2;
        private System.Windows.Forms.MenuStrip brrMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button boton_Autodo;
        private System.Windows.Forms.Label labelExplorador;
        private System.Windows.Forms.Label labelPendientes;
        private System.Windows.Forms.Button botonConfigAdmin;
        private System.Windows.Forms.Label labelPAnelAdmin;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarExplorador;
    }
}

