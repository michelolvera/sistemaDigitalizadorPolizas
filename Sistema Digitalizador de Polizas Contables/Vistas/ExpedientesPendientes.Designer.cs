namespace Sistema_Digitalizador_de_Polizas_Contables
{
    partial class ExpedientesP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpedientesP));
            this.dgvExpedientes = new Entidades.DataGridStyle();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digitalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.checkBoxDigitalizadosPend = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.AllowUserToAddRows = false;
            this.dgvExpedientes.AllowUserToDeleteRows = false;
            this.dgvExpedientes.AllowUserToOrderColumns = true;
            this.dgvExpedientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpedientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colNombre,
            this.colCategoria,
            this.colCreacion,
            this.Digitalizado});
            this.dgvExpedientes.Location = new System.Drawing.Point(10, 61);
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.ReadOnly = true;
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(743, 344);
            this.dgvExpedientes.TabIndex = 0;
            this.dgvExpedientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvExpedientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvExpedientes_CellMouseDoubleClick);
            // 
            // colNum
            // 
            this.colNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNum.FillWeight = 81.90491F;
            this.colNum.HeaderText = "Número. Expediente";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.FillWeight = 113.9843F;
            this.colNombre.HeaderText = "Nombre Expediente";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoria.FillWeight = 113.9843F;
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colCreacion
            // 
            this.colCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCreacion.FillWeight = 113.9843F;
            this.colCreacion.HeaderText = "Fecha de Creación";
            this.colCreacion.Name = "colCreacion";
            this.colCreacion.ReadOnly = true;
            // 
            // Digitalizado
            // 
            this.Digitalizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Digitalizado.FillWeight = 76.14214F;
            this.Digitalizado.HeaderText = "Digitalizado";
            this.Digitalizado.Name = "Digitalizado";
            this.Digitalizado.ReadOnly = true;
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Location = new System.Drawing.Point(10, 32);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(60, 13);
            this.labelPendientes.TabIndex = 1;
            this.labelPendientes.Text = "Pendientes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(723, 23);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(30, 32);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // checkBoxDigitalizadosPend
            // 
            this.checkBoxDigitalizadosPend.AutoSize = true;
            this.checkBoxDigitalizadosPend.Location = new System.Drawing.Point(583, 31);
            this.checkBoxDigitalizadosPend.Name = "checkBoxDigitalizadosPend";
            this.checkBoxDigitalizadosPend.Size = new System.Drawing.Size(121, 17);
            this.checkBoxDigitalizadosPend.TabIndex = 5;
            this.checkBoxDigitalizadosPend.Text = "Mostrar digitalizados";
            this.checkBoxDigitalizadosPend.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.AdministrarToolStripMenuItem_Click);
            // 
            // ExpedientesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 416);
            this.Controls.Add(this.checkBoxDigitalizadosPend);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelPendientes);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExpedientesP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes Pendientes de Digitalizasr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpedientesP_FormClosed);
            this.Load += new System.EventHandler(this.ExpedientesP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entidades.DataGridStyle dgvExpedientes;
        private System.Windows.Forms.Label labelPendientes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox checkBoxDigitalizadosPend;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digitalizado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
    }
}