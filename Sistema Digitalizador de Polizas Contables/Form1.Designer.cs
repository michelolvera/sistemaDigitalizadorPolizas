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
            this.contenedorDividido1 = new System.Windows.Forms.SplitContainer();
            this.contenedorDividido2 = new System.Windows.Forms.SplitContainer();
            this.brrMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido1)).BeginInit();
            this.contenedorDividido1.Panel2.SuspendLayout();
            this.contenedorDividido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido2)).BeginInit();
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
            // contenedorDividido2
            // 
            this.contenedorDividido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDividido2.Location = new System.Drawing.Point(0, 0);
            this.contenedorDividido2.Name = "contenedorDividido2";
            this.contenedorDividido2.Panel2MinSize = 200;
            this.contenedorDividido2.Size = new System.Drawing.Size(564, 476);
            this.contenedorDividido2.SplitterDistance = 359;
            this.contenedorDividido2.TabIndex = 0;
            this.contenedorDividido2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.contenedorDividido2_SplitterMoved);
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
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivoToolStripMenuItem.Text = "Archivo?";
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
            this.contenedorDividido1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contenedorDividido1)).EndInit();
            this.contenedorDividido1.ResumeLayout(false);
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
    }
}

