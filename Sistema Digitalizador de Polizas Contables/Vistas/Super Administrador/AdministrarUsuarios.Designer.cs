namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Super_Administrador
{
    partial class AdministrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarUsuarios));
            this.lblNobreU = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoP = new System.Windows.Forms.Label();
            this.lblApellidoM = new System.Windows.Forms.Label();
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabPageAcceso = new System.Windows.Forms.TabPage();
            this.txtbIdUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.tabPagePersonales = new System.Windows.Forms.TabPage();
            this.txtbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.tabPagePrivilegios = new System.Windows.Forms.TabPage();
            this.checkBoxDios = new System.Windows.Forms.CheckBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.picBoxIconoPersona = new System.Windows.Forms.PictureBox();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new Entidades.ButtonStyle();
            this.btnCancelar = new Entidades.ButtonStyle();
            this.btnGuardar = new Entidades.ButtonStyle();
            this.margenDer = new System.Windows.Forms.PictureBox();
            this.margenIzq = new System.Windows.Forms.PictureBox();
            this.margenAbajo = new System.Windows.Forms.PictureBox();
            this.TxbSAPass = new System.Windows.Forms.TextBox();
            this.lblSAPass = new System.Windows.Forms.Label();
            this.tabControlUsuarios.SuspendLayout();
            this.tabPageAcceso.SuspendLayout();
            this.tabPagePersonales.SuspendLayout();
            this.tabPagePrivilegios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconoPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNobreU
            // 
            this.lblNobreU.AutoSize = true;
            this.lblNobreU.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNobreU.Location = new System.Drawing.Point(9, 12);
            this.lblNobreU.Name = "lblNobreU";
            this.lblNobreU.Size = new System.Drawing.Size(133, 16);
            this.lblNobreU.TabIndex = 0;
            this.lblNobreU.Text = "Nombre de usuario";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(9, 38);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(83, 16);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Contraseña";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(9, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 16);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(7, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoP.Location = new System.Drawing.Point(6, 38);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(119, 16);
            this.lblApellidoP.TabIndex = 1;
            this.lblApellidoP.Text = "Apellido paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoM.Location = new System.Drawing.Point(8, 69);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(122, 16);
            this.lblApellidoM.TabIndex = 1;
            this.lblApellidoM.Text = "Apellido materno";
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabPageAcceso);
            this.tabControlUsuarios.Controls.Add(this.tabPagePersonales);
            this.tabControlUsuarios.Controls.Add(this.tabPagePrivilegios);
            this.tabControlUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlUsuarios.Location = new System.Drawing.Point(12, 75);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(411, 122);
            this.tabControlUsuarios.TabIndex = 0;
            // 
            // tabPageAcceso
            // 
            this.tabPageAcceso.Controls.Add(this.txtbIdUsuario);
            this.tabPageAcceso.Controls.Add(this.txtContrasena);
            this.tabPageAcceso.Controls.Add(this.cmbArea);
            this.tabPageAcceso.Controls.Add(this.cmbUsuario);
            this.tabPageAcceso.Controls.Add(this.lblNobreU);
            this.tabPageAcceso.Controls.Add(this.lblpass);
            this.tabPageAcceso.Controls.Add(this.lblArea);
            this.tabPageAcceso.Location = new System.Drawing.Point(4, 25);
            this.tabPageAcceso.Name = "tabPageAcceso";
            this.tabPageAcceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcceso.Size = new System.Drawing.Size(403, 93);
            this.tabPageAcceso.TabIndex = 0;
            this.tabPageAcceso.Text = "Datos de acceso";
            this.tabPageAcceso.UseVisualStyleBackColor = true;
            // 
            // txtbIdUsuario
            // 
            this.txtbIdUsuario.Enabled = false;
            this.txtbIdUsuario.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtbIdUsuario.Location = new System.Drawing.Point(145, 12);
            this.txtbIdUsuario.Name = "txtbIdUsuario";
            this.txtbIdUsuario.Size = new System.Drawing.Size(37, 21);
            this.txtbIdUsuario.TabIndex = 38;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtContrasena.Location = new System.Drawing.Point(145, 38);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(252, 21);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(145, 64);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(252, 24);
            this.cmbArea.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(188, 11);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(209, 24);
            this.cmbUsuario.TabIndex = 0;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.CmbUsuario_SelectedIndexChanged);
            this.cmbUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbUsuario_KeyUp);
            // 
            // tabPagePersonales
            // 
            this.tabPagePersonales.Controls.Add(this.txtbApellidoMaterno);
            this.tabPagePersonales.Controls.Add(this.txtbNombre);
            this.tabPagePersonales.Controls.Add(this.txtbApellidoPaterno);
            this.tabPagePersonales.Controls.Add(this.lblNombre);
            this.tabPagePersonales.Controls.Add(this.lblApellidoM);
            this.tabPagePersonales.Controls.Add(this.lblApellidoP);
            this.tabPagePersonales.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonales.Name = "tabPagePersonales";
            this.tabPagePersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonales.Size = new System.Drawing.Size(403, 93);
            this.tabPagePersonales.TabIndex = 1;
            this.tabPagePersonales.Text = "Datos personales";
            this.tabPagePersonales.UseVisualStyleBackColor = true;
            // 
            // txtbApellidoMaterno
            // 
            this.txtbApellidoMaterno.Location = new System.Drawing.Point(144, 64);
            this.txtbApellidoMaterno.Name = "txtbApellidoMaterno";
            this.txtbApellidoMaterno.Size = new System.Drawing.Size(252, 22);
            this.txtbApellidoMaterno.TabIndex = 2;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(144, 12);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(252, 22);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtbApellidoPaterno
            // 
            this.txtbApellidoPaterno.Location = new System.Drawing.Point(144, 38);
            this.txtbApellidoPaterno.Name = "txtbApellidoPaterno";
            this.txtbApellidoPaterno.Size = new System.Drawing.Size(252, 22);
            this.txtbApellidoPaterno.TabIndex = 1;
            // 
            // tabPagePrivilegios
            // 
            this.tabPagePrivilegios.Controls.Add(this.checkBoxDios);
            this.tabPagePrivilegios.Controls.Add(this.checkBoxAdmin);
            this.tabPagePrivilegios.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrivilegios.Name = "tabPagePrivilegios";
            this.tabPagePrivilegios.Size = new System.Drawing.Size(403, 93);
            this.tabPagePrivilegios.TabIndex = 2;
            this.tabPagePrivilegios.Text = "Privilegios";
            this.tabPagePrivilegios.UseVisualStyleBackColor = true;
            // 
            // checkBoxDios
            // 
            this.checkBoxDios.AutoSize = true;
            this.checkBoxDios.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxDios.Location = new System.Drawing.Point(17, 48);
            this.checkBoxDios.Name = "checkBoxDios";
            this.checkBoxDios.Size = new System.Drawing.Size(160, 20);
            this.checkBoxDios.TabIndex = 1;
            this.checkBoxDios.Text = "Super administrador";
            this.checkBoxDios.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxAdmin.Location = new System.Drawing.Point(17, 16);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(165, 20);
            this.checkBoxAdmin.TabIndex = 0;
            this.checkBoxAdmin.Text = "Administrador (area)";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // picBoxIconoPersona
            // 
            this.picBoxIconoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxIconoPersona.BackColor = System.Drawing.Color.White;
            this.picBoxIconoPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxIconoPersona.BackgroundImage")));
            this.picBoxIconoPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxIconoPersona.Location = new System.Drawing.Point(12, 37);
            this.picBoxIconoPersona.Name = "picBoxIconoPersona";
            this.picBoxIconoPersona.Size = new System.Drawing.Size(35, 32);
            this.picBoxIconoPersona.TabIndex = 11;
            this.picBoxIconoPersona.TabStop = false;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(57, 49);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(352, 18);
            this.lblUsuarioSeleccionado.TabIndex = 12;
            this.lblUsuarioSeleccionado.Text = "Seleccione un nombre usuario para comenzar";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(1, 7);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(205, 16);
            this.lblTituloVentana.TabIndex = 1;
            this.lblTituloVentana.Text = "|    Administración de usuarios     |";
            // 
            // pctBoxCabecera1
            // 
            this.pctBoxCabecera1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxCabecera1.BackColor = System.Drawing.Color.Black;
            this.pctBoxCabecera1.Location = new System.Drawing.Point(0, 0);
            this.pctBoxCabecera1.Name = "pctBoxCabecera1";
            this.pctBoxCabecera1.Size = new System.Drawing.Size(435, 31);
            this.pctBoxCabecera1.TabIndex = 35;
            this.pctBoxCabecera1.TabStop = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(404, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.TabIndex = 37;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnCancelar.Location = new System.Drawing.Point(16, 204);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 24);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnGuardar.Location = new System.Drawing.Point(333, 205);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 24);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // margenDer
            // 
            this.margenDer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenDer.BackColor = System.Drawing.Color.Black;
            this.margenDer.Location = new System.Drawing.Point(434, 27);
            this.margenDer.Name = "margenDer";
            this.margenDer.Size = new System.Drawing.Size(1, 215);
            this.margenDer.TabIndex = 40;
            this.margenDer.TabStop = false;
            // 
            // margenIzq
            // 
            this.margenIzq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenIzq.BackColor = System.Drawing.Color.Black;
            this.margenIzq.Location = new System.Drawing.Point(0, 25);
            this.margenIzq.Name = "margenIzq";
            this.margenIzq.Size = new System.Drawing.Size(1, 218);
            this.margenIzq.TabIndex = 39;
            this.margenIzq.TabStop = false;
            // 
            // margenAbajo
            // 
            this.margenAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenAbajo.BackColor = System.Drawing.Color.Black;
            this.margenAbajo.Location = new System.Drawing.Point(0, 240);
            this.margenAbajo.Name = "margenAbajo";
            this.margenAbajo.Size = new System.Drawing.Size(435, 1);
            this.margenAbajo.TabIndex = 38;
            this.margenAbajo.TabStop = false;
            // 
            // TxbSAPass
            // 
            this.TxbSAPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.TxbSAPass.Location = new System.Drawing.Point(219, 206);
            this.TxbSAPass.Margin = new System.Windows.Forms.Padding(2);
            this.TxbSAPass.Name = "TxbSAPass";
            this.TxbSAPass.Size = new System.Drawing.Size(109, 22);
            this.TxbSAPass.TabIndex = 41;
            this.TxbSAPass.UseSystemPasswordChar = true;
            this.TxbSAPass.Visible = false;
            this.TxbSAPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxbSAPass_KeyUp);
            // 
            // lblSAPass
            // 
            this.lblSAPass.AutoSize = true;
            this.lblSAPass.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblSAPass.Location = new System.Drawing.Point(108, 209);
            this.lblSAPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSAPass.Name = "lblSAPass";
            this.lblSAPass.Size = new System.Drawing.Size(109, 16);
            this.lblSAPass.TabIndex = 42;
            this.lblSAPass.Text = "Contraseña de SA:";
            this.lblSAPass.Visible = false;
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 241);
            this.Controls.Add(this.lblSAPass);
            this.Controls.Add(this.TxbSAPass);
            this.Controls.Add(this.margenDer);
            this.Controls.Add(this.margenIzq);
            this.Controls.Add(this.margenAbajo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.pctBoxCabecera1);
            this.Controls.Add(this.lblUsuarioSeleccionado);
            this.Controls.Add(this.picBoxIconoPersona);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControlUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabPageAcceso.ResumeLayout(false);
            this.tabPageAcceso.PerformLayout();
            this.tabPagePersonales.ResumeLayout(false);
            this.tabPagePersonales.PerformLayout();
            this.tabPagePrivilegios.ResumeLayout(false);
            this.tabPagePrivilegios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconoPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNobreU;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoP;
        private System.Windows.Forms.Label lblApellidoM;
        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabPageAcceso;
        private System.Windows.Forms.TabPage tabPagePersonales;
        private System.Windows.Forms.TabPage tabPagePrivilegios;
        private System.Windows.Forms.CheckBox checkBoxDios;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private Entidades.ButtonStyle btnCancelar;
        private Entidades.ButtonStyle btnGuardar;
        private System.Windows.Forms.PictureBox picBoxIconoPersona;
        private System.Windows.Forms.TextBox txtbApellidoMaterno;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellidoPaterno;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private Entidades.ButtonStyle BtnCerrar;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtbIdUsuario;
        private System.Windows.Forms.PictureBox margenDer;
        private System.Windows.Forms.PictureBox margenIzq;
        private System.Windows.Forms.PictureBox margenAbajo;
        private System.Windows.Forms.TextBox TxbSAPass;
        private System.Windows.Forms.Label lblSAPass;
    }
}