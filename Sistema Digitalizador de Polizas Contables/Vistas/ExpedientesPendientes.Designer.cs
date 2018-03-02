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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPendientes = new System.Windows.Forms.Label();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarExpedientesCompletadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCajaLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnMin = new Entidades.ButtonStyle();
            this.BtnCerrar = new Entidades.ButtonStyle();
            this.btnActualizar = new Entidades.ButtonStyle();
            this.dgvExpedientes = new Entidades.DataGridStyle();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digitalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPendientes
            // 
            this.labelPendientes.AutoSize = true;
            this.labelPendientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.labelPendientes.Location = new System.Drawing.Point(10, 76);
            this.labelPendientes.Name = "labelPendientes";
            this.labelPendientes.Size = new System.Drawing.Size(65, 16);
            this.labelPendientes.TabIndex = 1;
            this.labelPendientes.Text = "Filtrar por:";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.insertarRegistroToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.herramientasToolStripMenuItem.Text = "Administrar";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.administrarToolStripMenuItem.Text = "Getionar Documentos";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.AdministrarToolStripMenuItem_Click);
            // 
            // insertarRegistroToolStripMenuItem
            // 
            this.insertarRegistroToolStripMenuItem.Name = "insertarRegistroToolStripMenuItem";
            this.insertarRegistroToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.insertarRegistroToolStripMenuItem.Text = "Insertar Registro";
            this.insertarRegistroToolStripMenuItem.Click += new System.EventHandler(this.InsertarRegistroToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(63, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(121, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarExpedientesCompletadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // mostrarExpedientesCompletadosToolStripMenuItem
            // 
            this.mostrarExpedientesCompletadosToolStripMenuItem.Name = "mostrarExpedientesCompletadosToolStripMenuItem";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.mostrarExpedientesCompletadosToolStripMenuItem.Text = "Mostrar expedientes completados";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Click += new System.EventHandler(this.MostrarExpedientesCompletadosToolStripMenuItem_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.White;
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Nombre de Expediente",
            "Nombre de Categoria",
            "Nombre de Usuario"});
            this.cmbFiltro.Location = new System.Drawing.Point(75, 74);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(170, 24);
            this.cmbFiltro.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(248, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palabra Clave:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txbBusqueda.Location = new System.Drawing.Point(539, 75);
            this.txbBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(177, 22);
            this.txbBusqueda.TabIndex = 7;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.TxbBusqueda_TextChanged);
            // 
            // pctBoxCabecera1
            // 
            this.pctBoxCabecera1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxCabecera1.BackColor = System.Drawing.Color.Black;
            this.pctBoxCabecera1.Location = new System.Drawing.Point(-2, -1);
            this.pctBoxCabecera1.Name = "pctBoxCabecera1";
            this.pctBoxCabecera1.Size = new System.Drawing.Size(766, 63);
            this.pctBoxCabecera1.TabIndex = 10;
            this.pctBoxCabecera1.TabStop = false;
            // 
            // pictureBoxCajaLogo
            // 
            this.pictureBoxCajaLogo.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCajaLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCajaLogo.Image")));
            this.pictureBoxCajaLogo.Location = new System.Drawing.Point(-4, 5);
            this.pictureBoxCajaLogo.Name = "pictureBoxCajaLogo";
            this.pictureBoxCajaLogo.Size = new System.Drawing.Size(65, 50);
            this.pictureBoxCajaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCajaLogo.TabIndex = 11;
            this.pictureBoxCajaLogo.TabStop = false;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(55, 9);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(187, 16);
            this.lblTituloVentana.TabIndex = 12;
            this.lblTituloVentana.Text = "|    Expedientes Pendientes     |";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.BackColor = System.Drawing.Color.Black;
            this.lblFechaHora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(235, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(178, 16);
            this.lblFechaHora.TabIndex = 13;
            this.lblFechaHora.Text = "|                                                    |";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(478, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.BackColor = System.Drawing.Color.Black;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActual.Location = new System.Drawing.Point(505, 11);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(202, 16);
            this.lblUsuarioActual.TabIndex = 15;
            this.lblUsuarioActual.Text = "|                                                            |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(489, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Buscar:";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txbFiltro.Location = new System.Drawing.Point(340, 74);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(145, 22);
            this.txbFiltro.TabIndex = 24;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnMin.Location = new System.Drawing.Point(701, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 23);
            this.btnMin.TabIndex = 22;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.Black;
            this.BtnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.BackgroundImage")));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BtnCerrar.Location = new System.Drawing.Point(730, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.TabIndex = 21;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.Black;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnActualizar.Location = new System.Drawing.Point(721, 69);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(32, 32);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.fechaCreacion,
            this.nombreUsuario,
            this.nombreExpediente,
            this.nombreCategoria,
            this.digitalizado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpedientes.EnableHeadersVisualStyles = false;
            this.dgvExpedientes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgvExpedientes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvExpedientes.Location = new System.Drawing.Point(10, 110);
            this.dgvExpedientes.MultiSelect = false;
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.ReadOnly = true;
            this.dgvExpedientes.RowHeadersVisible = false;
            this.dgvExpedientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvExpedientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(743, 328);
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
            // ExpedientesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 446);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.pictureBoxCajaLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.labelPendientes);
            this.Controls.Add(this.dgvExpedientes);
            this.Controls.Add(this.pctBoxCabecera1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExpedientesP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes Pendientes de Digitalizar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExpedientesP_FormClosed);
            this.Load += new System.EventHandler(this.ExpedientesP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem insertarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarExpedientesCompletadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
        private System.Windows.Forms.PictureBox pictureBoxCajaLogo;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioActual;
        private Entidades.ButtonStyle BtnCerrar;
        private Entidades.ButtonStyle btnMin;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}