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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarExpedientesCompletadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxExpediente = new System.Windows.Forms.ToolStripTextBox();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxCategoria = new System.Windows.Forms.ToolStripTextBox();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.eliminarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCajaLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.picBoxLog = new System.Windows.Forms.PictureBox();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
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
            this.pctBoxBarra = new System.Windows.Forms.PictureBox();
            this.margenDer = new System.Windows.Forms.PictureBox();
            this.margenIzq = new System.Windows.Forms.PictureBox();
            this.margenAbajo = new System.Windows.Forms.PictureBox();
            this.lblVerActual = new System.Windows.Forms.Label();
            this.picBoxBuscar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscar)).BeginInit();
            this.SuspendLayout();
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
            this.herramientasToolStripMenuItem.DropDownClosed += new System.EventHandler(this.herramientasToolStripMenuItem_DropDownClosed);
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
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
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.filtrarToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(6, 44);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(168, 24);
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
            this.verToolStripMenuItem.DropDownClosed += new System.EventHandler(this.verToolStripMenuItem_DropDownClosed);
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // mostrarExpedientesCompletadosToolStripMenuItem
            // 
            this.mostrarExpedientesCompletadosToolStripMenuItem.Name = "mostrarExpedientesCompletadosToolStripMenuItem";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.mostrarExpedientesCompletadosToolStripMenuItem.Text = "Mostrar expedientes completados";
            this.mostrarExpedientesCompletadosToolStripMenuItem.Click += new System.EventHandler(this.MostrarExpedientesCompletadosToolStripMenuItem_Click);
            // 
            // filtrarToolStripMenuItem
            // 
            this.filtrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expToolStripMenuItem,
            this.catToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.eliminarFiltrosToolStripMenuItem});
            this.filtrarToolStripMenuItem.Name = "filtrarToolStripMenuItem";
            this.filtrarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.filtrarToolStripMenuItem.Text = "Filtrar";
            this.filtrarToolStripMenuItem.DropDownClosed += new System.EventHandler(this.filtrarToolStripMenuItem_DropDownClosed);
            this.filtrarToolStripMenuItem.Click += new System.EventHandler(this.filtrarToolStripMenuItem_Click);
            // 
            // expToolStripMenuItem
            // 
            this.expToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxExpediente});
            this.expToolStripMenuItem.Name = "expToolStripMenuItem";
            this.expToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.expToolStripMenuItem.Text = "Expedientes";
            this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
            // 
            // toolStripTextBoxExpediente
            // 
            this.toolStripTextBoxExpediente.Name = "toolStripTextBoxExpediente";
            this.toolStripTextBoxExpediente.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxExpediente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxExpediente_KeyUp);
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxCategoria});
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.catToolStripMenuItem.Text = "Categoria";
            this.catToolStripMenuItem.Click += new System.EventHandler(this.catToolStripMenuItem_Click);
            // 
            // toolStripTextBoxCategoria
            // 
            this.toolStripTextBoxCategoria.Name = "toolStripTextBoxCategoria";
            this.toolStripTextBoxCategoria.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxCategoria_KeyUp);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxUsuario});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click_1);
            // 
            // toolStripTextBoxUsuario
            // 
            this.toolStripTextBoxUsuario.Name = "toolStripTextBoxUsuario";
            this.toolStripTextBoxUsuario.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxUsuario_KeyUp);
            // 
            // eliminarFiltrosToolStripMenuItem
            // 
            this.eliminarFiltrosToolStripMenuItem.Name = "eliminarFiltrosToolStripMenuItem";
            this.eliminarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eliminarFiltrosToolStripMenuItem.Text = "Eliminar filtros";
            this.eliminarFiltrosToolStripMenuItem.Click += new System.EventHandler(this.eliminarFiltrosToolStripMenuItem_Click);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBusqueda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txbBusqueda.Location = new System.Drawing.Point(375, 45);
            this.txbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(342, 22);
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
            this.pictureBoxCajaLogo.Location = new System.Drawing.Point(-2, 2);
            this.pictureBoxCajaLogo.Name = "pictureBoxCajaLogo";
            this.pictureBoxCajaLogo.Size = new System.Drawing.Size(60, 32);
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
            this.lblTituloVentana.Size = new System.Drawing.Size(188, 16);
            this.lblTituloVentana.TabIndex = 12;
            this.lblTituloVentana.Text = "|    Expedientes pendientes     |";
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
            // picBoxLog
            // 
            this.picBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLog.BackColor = System.Drawing.Color.Black;
            this.picBoxLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLog.BackgroundImage")));
            this.picBoxLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLog.Location = new System.Drawing.Point(473, 6);
            this.picBoxLog.Name = "picBoxLog";
            this.picBoxLog.Size = new System.Drawing.Size(26, 26);
            this.picBoxLog.TabIndex = 14;
            this.picBoxLog.TabStop = false;
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.BackColor = System.Drawing.Color.Black;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActual.Location = new System.Drawing.Point(500, 11);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(202, 16);
            this.lblUsuarioActual.TabIndex = 15;
            this.lblUsuarioActual.Text = "|                                                            |";
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
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnActualizar.Location = new System.Drawing.Point(727, 43);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(25, 25);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.dgvExpedientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpedientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpedientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExpedientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpedientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpedientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpedientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.fechaCreacion,
            this.nombreUsuario,
            this.nombreExpediente,
            this.nombreCategoria,
            this.digitalizado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpedientes.EnableHeadersVisualStyles = false;
            this.dgvExpedientes.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgvExpedientes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvExpedientes.Location = new System.Drawing.Point(10, 106);
            this.dgvExpedientes.MultiSelect = false;
            this.dgvExpedientes.Name = "dgvExpedientes";
            this.dgvExpedientes.ReadOnly = true;
            this.dgvExpedientes.RowHeadersVisible = false;
            this.dgvExpedientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvExpedientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpedientes.Size = new System.Drawing.Size(743, 332);
            this.dgvExpedientes.TabIndex = 0;
            this.dgvExpedientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvExpedientes_CellMouseDoubleClick);
            this.dgvExpedientes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExpedientes_ColumnHeaderMouseClick);
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
            this.fechaCreacion.HeaderText = "Fecha de creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreUsuario.FillWeight = 113.9843F;
            this.nombreUsuario.HeaderText = "Nombre de usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // nombreExpediente
            // 
            this.nombreExpediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreExpediente.FillWeight = 76.14214F;
            this.nombreExpediente.HeaderText = "Nombre expediente";
            this.nombreExpediente.Name = "nombreExpediente";
            this.nombreExpediente.ReadOnly = true;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCategoria.HeaderText = "Nombre de categoria";
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
            // pctBoxBarra
            // 
            this.pctBoxBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pctBoxBarra.Location = new System.Drawing.Point(-2, 38);
            this.pctBoxBarra.Name = "pctBoxBarra";
            this.pctBoxBarra.Size = new System.Drawing.Size(766, 35);
            this.pctBoxBarra.TabIndex = 25;
            this.pctBoxBarra.TabStop = false;
            // 
            // margenDer
            // 
            this.margenDer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenDer.BackColor = System.Drawing.Color.Black;
            this.margenDer.Location = new System.Drawing.Point(762, 36);
            this.margenDer.Name = "margenDer";
            this.margenDer.Size = new System.Drawing.Size(1, 410);
            this.margenDer.TabIndex = 40;
            this.margenDer.TabStop = false;
            // 
            // margenIzq
            // 
            this.margenIzq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.margenIzq.BackColor = System.Drawing.Color.Black;
            this.margenIzq.Location = new System.Drawing.Point(0, 35);
            this.margenIzq.Name = "margenIzq";
            this.margenIzq.Size = new System.Drawing.Size(1, 410);
            this.margenIzq.TabIndex = 39;
            this.margenIzq.TabStop = false;
            // 
            // margenAbajo
            // 
            this.margenAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenAbajo.BackColor = System.Drawing.Color.Black;
            this.margenAbajo.Location = new System.Drawing.Point(0, 445);
            this.margenAbajo.Name = "margenAbajo";
            this.margenAbajo.Size = new System.Drawing.Size(762, 1);
            this.margenAbajo.TabIndex = 38;
            this.margenAbajo.TabStop = false;
            // 
            // lblVerActual
            // 
            this.lblVerActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVerActual.AutoSize = true;
            this.lblVerActual.BackColor = System.Drawing.Color.White;
            this.lblVerActual.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblVerActual.ForeColor = System.Drawing.Color.Black;
            this.lblVerActual.Location = new System.Drawing.Point(9, 82);
            this.lblVerActual.Name = "lblVerActual";
            this.lblVerActual.Size = new System.Drawing.Size(180, 16);
            this.lblVerActual.TabIndex = 41;
            this.lblVerActual.Text = "| Expedientes incompletos   |";
            // 
            // picBoxBuscar
            // 
            this.picBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.picBoxBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxBuscar.BackgroundImage")));
            this.picBoxBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxBuscar.Location = new System.Drawing.Point(338, 42);
            this.picBoxBuscar.Name = "picBoxBuscar";
            this.picBoxBuscar.Size = new System.Drawing.Size(26, 26);
            this.picBoxBuscar.TabIndex = 42;
            this.picBoxBuscar.TabStop = false;
            // 
            // ExpedientesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 446);
            this.Controls.Add(this.picBoxBuscar);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblVerActual);
            this.Controls.Add(this.margenDer);
            this.Controls.Add(this.margenIzq);
            this.Controls.Add(this.margenAbajo);
            this.Controls.Add(this.pctBoxBarra);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblUsuarioActual);
            this.Controls.Add(this.picBoxLog);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.pictureBoxCajaLogo);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entidades.DataGridStyle dgvExpedientes;
        private Entidades.ButtonStyle btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem insertarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarExpedientesCompletadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
        private System.Windows.Forms.PictureBox pictureBoxCajaLogo;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.PictureBox picBoxLog;
        private System.Windows.Forms.Label lblUsuarioActual;
        private Entidades.ButtonStyle BtnCerrar;
        private Entidades.ButtonStyle btnMin;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctBoxBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn digitalizado;
        private System.Windows.Forms.PictureBox margenDer;
        private System.Windows.Forms.PictureBox margenIzq;
        private System.Windows.Forms.PictureBox margenAbajo;
        private System.Windows.Forms.Label lblVerActual;
        private System.Windows.Forms.PictureBox picBoxBuscar;
        private System.Windows.Forms.ToolStripMenuItem filtrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxExpediente;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCategoria;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUsuario;
        private System.Windows.Forms.ToolStripMenuItem eliminarFiltrosToolStripMenuItem;
    }
}