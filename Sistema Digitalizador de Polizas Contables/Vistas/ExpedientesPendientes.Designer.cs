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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpedientesP));
            this.dgvExpedientes = new Entidades.DataGridStyle();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.btnActualizar = new Entidades.ButtonStyle();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarExpedientesCompletadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.AllowUserToAddRows = false;
            this.dgvExpedientes.AllowUserToDeleteRows = false;
            this.dgvExpedientes.AllowUserToResizeColumns = false;
            this.dgvExpedientes.AllowUserToResizeRows = false;
            this.dgvExpedientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpedientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpedientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpedientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpedientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.fechaCreacion,
            this.nombreUsuario,
            this.nombreExpediente,
            this.nombreCategoria,
            this.digitalizado});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvExpedientes.EnableHeadersVisualStyles = false;
            this.dgvExpedientes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgvExpedientes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvExpedientes.Location = new System.Drawing.Point(13, 75);
            this.dgvExpedientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExpedientes.MultiSelect = false;
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.ReadOnly = true;
            this.dgvExpedientes.RowHeadersVisible = false;
            this.dgvExpedientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvExpedientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(991, 423);
            this.dgvExpedientes.TabIndex = 0;
            this.dgvExpedientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvExpedientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvExpedientes_CellMouseDoubleClick);
            // 
            // identificador
            // 
            this.identificador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identificador.FillWeight = 113.9843F;
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaCreacion.FillWeight = 113.9843F;
            this.fechaCreacion.HeaderText = "Fecha de Creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreUsuario.FillWeight = 113.9843F;
            this.nombreUsuario.HeaderText = "Nombre de Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // nombreExpediente
            // 
            this.nombreExpediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreExpediente.FillWeight = 76.14214F;
            this.nombreExpediente.HeaderText = "Nombre Expediente";
            this.nombreExpediente.Name = "nombreExpediente";
            this.nombreExpediente.ReadOnly = true;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCategoria.HeaderText = "Nombre de Categoria";
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.ReadOnly = true;
            // 
            // digitalizado
            // 
            this.digitalizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.digitalizado.HeaderText = "Completo";
            this.digitalizado.Name = "digitalizado";
            this.digitalizado.ReadOnly = true;
            this.digitalizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.digitalizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Location = new System.Drawing.Point(13, 39);
            this.labelPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(56, 17);
            this.labelPendientes.TabIndex = 1;
            this.labelPendientes.Text = "Buscar:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnActualizar.Location = new System.Drawing.Point(964, 28);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(40, 39);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.insertarRegistroToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.herramientasToolStripMenuItem.Text = "Administrar";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.administrarToolStripMenuItem.Text = "Getionar Documentos";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.AdministrarToolStripMenuItem_Click);
            // 
            // insertarRegistroToolStripMenuItem
            // 
            this.insertarRegistroToolStripMenuItem.Name = "insertarRegistroToolStripMenuItem";
            this.insertarRegistroToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.insertarRegistroToolStripMenuItem.Text = "Insertar Registro";
            this.insertarRegistroToolStripMenuItem.Click += new System.EventHandler(this.InsertarRegistroToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1017, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Identificador",
            "Fecha de Creacion",
            "Nombre de Usuario",
            "Nombre de Expediente",
            "Nombre de Categoria"});
            this.cmbBusqueda.Location = new System.Drawing.Point(371, 34);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(263, 24);
            this.cmbBusqueda.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Por:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(76, 34);
            this.txbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(249, 22);
            this.txbBusqueda.TabIndex = 7;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.TxbBusqueda_TextChanged);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarExpedientesCompletadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // mostrarExpedientesCompletadosToolStripMenuItem
            // 
            this.mostrarExpedientesCompletadosToolStripMenuItem.Name = "mostrarExpedientesCompletadosToolStripMenuItem";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.mostrarExpedientesCompletadosToolStripMenuItem.Text = "Mostrar expedientes completados";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Click += new System.EventHandler(this.MostrarExpedientesCompletadosToolStripMenuItem_Click);
            // 
            // ExpedientesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelPendientes);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpedientesP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes Pendientes de Digitalizar";
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
        private Entidades.ButtonStyle btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn digitalizado;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem insertarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarExpedientesCompletadosToolStripMenuItem;
    }
}