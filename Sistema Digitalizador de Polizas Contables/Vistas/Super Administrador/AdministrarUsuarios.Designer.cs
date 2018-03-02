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
            this.txtbApellidoP = new System.Windows.Forms.TextBox();
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
            this.tabControlUsuarios.SuspendLayout();
            this.tabPageAcceso.SuspendLayout();
            this.tabPagePersonales.SuspendLayout();
            this.tabPagePrivilegios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIconoPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNobreU
            // 
            this.lblNobreU.AutoSize = true;
            this.lblNobreU.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNobreU.Location = new System.Drawing.Point(12, 15);
            this.lblNobreU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNobreU.Name = "lblNobreU";
            this.lblNobreU.Size = new System.Drawing.Size(158, 19);
            this.lblNobreU.TabIndex = 0;
            this.lblNobreU.Text = "Nombre de Usuario";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(12, 47);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(98, 19);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Contraseña";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblArea.Location = new System.Drawing.Point(12, 81);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 19);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(9, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoP.Location = new System.Drawing.Point(8, 47);
            this.lblApellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(138, 19);
            this.lblApellidoP.TabIndex = 1;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoM.Location = new System.Drawing.Point(11, 85);
            this.lblApellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(143, 19);
            this.lblApellidoM.TabIndex = 1;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabPageAcceso);
            this.tabControlUsuarios.Controls.Add(this.tabPagePersonales);
            this.tabControlUsuarios.Controls.Add(this.tabPagePrivilegios);
            this.tabControlUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlUsuarios.Location = new System.Drawing.Point(16, 92);
            this.tabControlUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(548, 150);
            this.tabControlUsuarios.TabIndex = 2;
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
            this.tabPageAcceso.Location = new System.Drawing.Point(4, 27);
            this.tabPageAcceso.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAcceso.Name = "tabPageAcceso";
            this.tabPageAcceso.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAcceso.Size = new System.Drawing.Size(540, 119);
            this.tabPageAcceso.TabIndex = 0;
            this.tabPageAcceso.Text = "Datos de Acceso";
            this.tabPageAcceso.UseVisualStyleBackColor = true;
            // 
            // txtbIdUsuario
            // 
            this.txtbIdUsuario.Enabled = false;
            this.txtbIdUsuario.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtbIdUsuario.Location = new System.Drawing.Point(193, 15);
            this.txtbIdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtbIdUsuario.Name = "txtbIdUsuario";
            this.txtbIdUsuario.Size = new System.Drawing.Size(48, 25);
            this.txtbIdUsuario.TabIndex = 38;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtContrasena.Location = new System.Drawing.Point(193, 47);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(335, 25);
            this.txtContrasena.TabIndex = 3;
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(193, 79);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(335, 27);
            this.cmbArea.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(251, 14);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(277, 27);
            this.cmbUsuario.TabIndex = 2;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.CmbUsuario_SelectedIndexChanged);
            this.cmbUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbUsuario_KeyUp);
            // 
            // tabPagePersonales
            // 
            this.tabPagePersonales.Controls.Add(this.txtbApellidoMaterno);
            this.tabPagePersonales.Controls.Add(this.txtbNombre);
            this.tabPagePersonales.Controls.Add(this.txtbApellidoP);
            this.tabPagePersonales.Controls.Add(this.lblNombre);
            this.tabPagePersonales.Controls.Add(this.lblApellidoM);
            this.tabPagePersonales.Controls.Add(this.lblApellidoP);
            this.tabPagePersonales.Location = new System.Drawing.Point(4, 27);
            this.tabPagePersonales.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePersonales.Name = "tabPagePersonales";
            this.tabPagePersonales.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePersonales.Size = new System.Drawing.Size(540, 119);
            this.tabPagePersonales.TabIndex = 1;
            this.tabPagePersonales.Text = "Datos Personales";
            this.tabPagePersonales.UseVisualStyleBackColor = true;
            // 
            // txtbApellidoMaterno
            // 
            this.txtbApellidoMaterno.Location = new System.Drawing.Point(192, 79);
            this.txtbApellidoMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtbApellidoMaterno.Name = "txtbApellidoMaterno";
            this.txtbApellidoMaterno.Size = new System.Drawing.Size(335, 26);
            this.txtbApellidoMaterno.TabIndex = 4;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(192, 15);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(335, 26);
            this.txtbNombre.TabIndex = 4;
            // 
            // txtbApellidoP
            // 
            this.txtbApellidoP.Location = new System.Drawing.Point(192, 47);
            this.txtbApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.txtbApellidoP.Name = "txtbApellidoP";
            this.txtbApellidoP.Size = new System.Drawing.Size(335, 26);
            this.txtbApellidoP.TabIndex = 4;
            // 
            // tabPagePrivilegios
            // 
            this.tabPagePrivilegios.Controls.Add(this.checkBoxDios);
            this.tabPagePrivilegios.Controls.Add(this.checkBoxAdmin);
            this.tabPagePrivilegios.Location = new System.Drawing.Point(4, 27);
            this.tabPagePrivilegios.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePrivilegios.Name = "tabPagePrivilegios";
            this.tabPagePrivilegios.Size = new System.Drawing.Size(540, 119);
            this.tabPagePrivilegios.TabIndex = 2;
            this.tabPagePrivilegios.Text = "Privilegios";
            this.tabPagePrivilegios.UseVisualStyleBackColor = true;
            // 
            // checkBoxDios
            // 
            this.checkBoxDios.AutoSize = true;
            this.checkBoxDios.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxDios.Location = new System.Drawing.Point(23, 50);
            this.checkBoxDios.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDios.Name = "checkBoxDios";
            this.checkBoxDios.Size = new System.Drawing.Size(188, 23);
            this.checkBoxDios.TabIndex = 2;
            this.checkBoxDios.Text = "Super Administrador";
            this.checkBoxDios.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxAdmin.Location = new System.Drawing.Point(23, 18);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(194, 23);
            this.checkBoxAdmin.TabIndex = 2;
            this.checkBoxAdmin.Text = "Administrador (Area)";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // picBoxIconoPersona
            // 
            this.picBoxIconoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxIconoPersona.BackColor = System.Drawing.Color.White;
            this.picBoxIconoPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxIconoPersona.BackgroundImage")));
            this.picBoxIconoPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxIconoPersona.Location = new System.Drawing.Point(16, 46);
            this.picBoxIconoPersona.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxIconoPersona.Name = "picBoxIconoPersona";
            this.picBoxIconoPersona.Size = new System.Drawing.Size(47, 39);
            this.picBoxIconoPersona.TabIndex = 11;
            this.picBoxIconoPersona.TabStop = false;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(76, 60);
            this.lblUsuarioSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(430, 23);
            this.lblUsuarioSeleccionado.TabIndex = 12;
            this.lblUsuarioSeleccionado.Text = "                                                                                 " +
    "   ";
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(1, 9);
            this.lblTituloVentana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(259, 18);
            this.lblTituloVentana.TabIndex = 36;
            this.lblTituloVentana.Text = "|    Administración de usuarios     |";
            // 
            // pctBoxCabecera1
            // 
            this.pctBoxCabecera1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxCabecera1.BackColor = System.Drawing.Color.Black;
            this.pctBoxCabecera1.Location = new System.Drawing.Point(0, 0);
            this.pctBoxCabecera1.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxCabecera1.Name = "pctBoxCabecera1";
            this.pctBoxCabecera1.Size = new System.Drawing.Size(580, 38);
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
            this.BtnCerrar.Location = new System.Drawing.Point(539, 5);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(31, 28);
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
            this.btnCancelar.Location = new System.Drawing.Point(21, 252);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
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
            this.btnGuardar.Location = new System.Drawing.Point(475, 252);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 297);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtbApellidoP;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private Entidades.ButtonStyle BtnCerrar;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtbIdUsuario;
    }
}