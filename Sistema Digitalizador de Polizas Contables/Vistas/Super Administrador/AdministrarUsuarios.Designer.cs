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
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbPass = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.tabPagePersonales = new System.Windows.Forms.TabPage();
            this.txtbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellidoP = new System.Windows.Forms.TextBox();
            this.tabPagePrivilegios = new System.Windows.Forms.TabPage();
            this.checkBoxDios = new System.Windows.Forms.CheckBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new Entidades.ButtonStyle();
            this.btnGuardar = new Entidades.ButtonStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.BtnCerrar = new Entidades.ButtonStyle();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            this.tabControlUsuarios.SuspendLayout();
            this.tabPageAcceso.SuspendLayout();
            this.tabPagePersonales.SuspendLayout();
            this.tabPagePrivilegios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
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
            this.lblNobreU.Text = "Nombre de Usuario";
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
            this.lblApellidoP.Size = new System.Drawing.Size(117, 16);
            this.lblApellidoP.TabIndex = 1;
            this.lblApellidoP.Text = "Apellido Paterno";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellidoM.Location = new System.Drawing.Point(8, 69);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(122, 16);
            this.lblApellidoM.TabIndex = 1;
            this.lblApellidoM.Text = "Apellido Materno";
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabPageAcceso);
            this.tabControlUsuarios.Controls.Add(this.tabPagePersonales);
            this.tabControlUsuarios.Controls.Add(this.tabPagePrivilegios);
            this.tabControlUsuarios.Location = new System.Drawing.Point(12, 75);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(411, 122);
            this.tabControlUsuarios.TabIndex = 2;
            // 
            // tabPageAcceso
            // 
            this.tabPageAcceso.Controls.Add(this.cmbArea);
            this.tabPageAcceso.Controls.Add(this.cmbPass);
            this.tabPageAcceso.Controls.Add(this.cmbUsuario);
            this.tabPageAcceso.Controls.Add(this.lblNobreU);
            this.tabPageAcceso.Controls.Add(this.lblpass);
            this.tabPageAcceso.Controls.Add(this.lblArea);
            this.tabPageAcceso.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcceso.Name = "tabPageAcceso";
            this.tabPageAcceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcceso.Size = new System.Drawing.Size(403, 96);
            this.tabPageAcceso.TabIndex = 0;
            this.tabPageAcceso.Text = "Datos de Acceso";
            this.tabPageAcceso.UseVisualStyleBackColor = true;
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(145, 64);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(252, 21);
            this.cmbArea.TabIndex = 2;
            // 
            // cmbPass
            // 
            this.cmbPass.FormattingEnabled = true;
            this.cmbPass.Location = new System.Drawing.Point(145, 37);
            this.cmbPass.Name = "cmbPass";
            this.cmbPass.Size = new System.Drawing.Size(252, 21);
            this.cmbPass.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(145, 11);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(252, 21);
            this.cmbUsuario.TabIndex = 2;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            this.cmbUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbUsuario_KeyUp);
            // 
            // tabPagePersonales
            // 
            this.tabPagePersonales.Controls.Add(this.txtbApellidoMaterno);
            this.tabPagePersonales.Controls.Add(this.txtbNombre);
            this.tabPagePersonales.Controls.Add(this.txtbApellidoP);
            this.tabPagePersonales.Controls.Add(this.lblNombre);
            this.tabPagePersonales.Controls.Add(this.lblApellidoM);
            this.tabPagePersonales.Controls.Add(this.lblApellidoP);
            this.tabPagePersonales.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonales.Name = "tabPagePersonales";
            this.tabPagePersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonales.Size = new System.Drawing.Size(403, 96);
            this.tabPagePersonales.TabIndex = 1;
            this.tabPagePersonales.Text = "Datos Personales";
            this.tabPagePersonales.UseVisualStyleBackColor = true;
            // 
            // txtbApellidoMaterno
            // 
            this.txtbApellidoMaterno.Location = new System.Drawing.Point(144, 64);
            this.txtbApellidoMaterno.Name = "txtbApellidoMaterno";
            this.txtbApellidoMaterno.Size = new System.Drawing.Size(252, 20);
            this.txtbApellidoMaterno.TabIndex = 4;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(144, 12);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(252, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // txtbApellidoP
            // 
            this.txtbApellidoP.Location = new System.Drawing.Point(144, 38);
            this.txtbApellidoP.Name = "txtbApellidoP";
            this.txtbApellidoP.Size = new System.Drawing.Size(252, 20);
            this.txtbApellidoP.TabIndex = 4;
            // 
            // tabPagePrivilegios
            // 
            this.tabPagePrivilegios.Controls.Add(this.checkBoxDios);
            this.tabPagePrivilegios.Controls.Add(this.checkBoxAdmin);
            this.tabPagePrivilegios.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrivilegios.Name = "tabPagePrivilegios";
            this.tabPagePrivilegios.Size = new System.Drawing.Size(403, 96);
            this.tabPagePrivilegios.TabIndex = 2;
            this.tabPagePrivilegios.Text = "Privilegios";
            this.tabPagePrivilegios.UseVisualStyleBackColor = true;
            // 
            // checkBoxDios
            // 
            this.checkBoxDios.AutoSize = true;
            this.checkBoxDios.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxDios.Location = new System.Drawing.Point(17, 41);
            this.checkBoxDios.Name = "checkBoxDios";
            this.checkBoxDios.Size = new System.Drawing.Size(161, 20);
            this.checkBoxDios.TabIndex = 2;
            this.checkBoxDios.Text = "Super Administrador";
            this.checkBoxDios.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxAdmin.Location = new System.Drawing.Point(17, 15);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(166, 20);
            this.checkBoxAdmin.TabIndex = 2;
            this.checkBoxAdmin.Text = "Administrador (Area)";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnCancelar.Location = new System.Drawing.Point(16, 205);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 24);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnGuardar.Location = new System.Drawing.Point(356, 205);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 24);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(388, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(44, 49);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(334, 13);
            this.lblUsuarioSeleccionado.TabIndex = 12;
            this.lblUsuarioSeleccionado.Text = "                                                                                 " +
    "                            ";
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
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(1, 7);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(205, 16);
            this.lblTituloVentana.TabIndex = 36;
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
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 241);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.pctBoxCabecera1);
            this.Controls.Add(this.lblUsuarioSeleccionado);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbApellidoMaterno;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellidoP;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.ComboBox cmbPass;
        private Entidades.ButtonStyle BtnCerrar;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
    }
}