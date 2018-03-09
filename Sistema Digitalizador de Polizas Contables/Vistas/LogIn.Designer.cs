namespace Sistema_Digitalizador_de_Polizas_Contables
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnAcceso = new Entidades.ButtonStyle();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxCajaLogo = new System.Windows.Forms.PictureBox();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            this.BtnCerrarLogIn = new Entidades.ButtonStyle();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.margenAbajo = new System.Windows.Forms.PictureBox();
            this.margenDer = new System.Windows.Forms.PictureBox();
            this.margenIzq = new System.Windows.Forms.PictureBox();
            this.picBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(317, 98);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(115, 22);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceso.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnAcceso.Location = new System.Drawing.Point(240, 137);
            this.btnAcceso.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(154, 32);
            this.btnAcceso.TabIndex = 3;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.BotonAccesoAdmin_Click);
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreUsuario.Location = new System.Drawing.Point(317, 70);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(115, 22);
            this.txbNombreUsuario.TabIndex = 1;
            this.txbNombreUsuario.TextChanged += new System.EventHandler(this.txbNombreUsuario_TextChanged);
            this.txbNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNombreUsuario_KeyDown);
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUsuario.Location = new System.Drawing.Point(193, 40);
            this.lblIDUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(87, 16);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "ID de usuario:";
            this.lblIDUsuario.Click += new System.EventHandler(this.lblIDUsuario_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(193, 73);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(123, 16);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(193, 102);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDUsuario.Location = new System.Drawing.Point(317, 40);
            this.txbIDUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.Size = new System.Drawing.Size(115, 22);
            this.txbIDUsuario.TabIndex = 0;
            this.txbIDUsuario.TextChanged += new System.EventHandler(this.TxbIDUsuario_TextChanged);
            this.txbIDUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbIDUsuario_KeyDown);
            // 
            // pictureBoxCajaLogo
            // 
            this.pictureBoxCajaLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCajaLogo.Image")));
            this.pictureBoxCajaLogo.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxCajaLogo.Name = "pictureBoxCajaLogo";
            this.pictureBoxCajaLogo.Size = new System.Drawing.Size(197, 122);
            this.pictureBoxCajaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCajaLogo.TabIndex = 8;
            this.pictureBoxCajaLogo.TabStop = false;
            this.pictureBoxCajaLogo.Click += new System.EventHandler(this.pictureBoxCajaLogo_Click);
            // 
            // pctBoxCabecera1
            // 
            this.pctBoxCabecera1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxCabecera1.BackColor = System.Drawing.Color.Black;
            this.pctBoxCabecera1.Location = new System.Drawing.Point(0, 0);
            this.pctBoxCabecera1.Name = "pctBoxCabecera1";
            this.pctBoxCabecera1.Size = new System.Drawing.Size(448, 24);
            this.pctBoxCabecera1.TabIndex = 19;
            this.pctBoxCabecera1.TabStop = false;
            this.pctBoxCabecera1.Click += new System.EventHandler(this.pctBoxCabecera1_Click);
            // 
            // BtnCerrarLogIn
            // 
            this.BtnCerrarLogIn.BackColor = System.Drawing.Color.Black;
            this.BtnCerrarLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrarLogIn.BackgroundImage")));
            this.BtnCerrarLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrarLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrarLogIn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnCerrarLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BtnCerrarLogIn.Location = new System.Drawing.Point(417, 1);
            this.BtnCerrarLogIn.Name = "BtnCerrarLogIn";
            this.BtnCerrarLogIn.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrarLogIn.TabIndex = 20;
            this.BtnCerrarLogIn.UseVisualStyleBackColor = false;
            this.BtnCerrarLogIn.Click += new System.EventHandler(this.BtnCerrarLogIn_Click);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(37, 4);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(134, 16);
            this.lblTituloVentana.TabIndex = 21;
            this.lblTituloVentana.Text = "|   Inicio de sesión    |";
            // 
            // margenAbajo
            // 
            this.margenAbajo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenAbajo.BackColor = System.Drawing.Color.Black;
            this.margenAbajo.Location = new System.Drawing.Point(0, 186);
            this.margenAbajo.Name = "margenAbajo";
            this.margenAbajo.Size = new System.Drawing.Size(448, 2);
            this.margenAbajo.TabIndex = 22;
            this.margenAbajo.TabStop = false;
            // 
            // margenDer
            // 
            this.margenDer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenDer.BackColor = System.Drawing.Color.Black;
            this.margenDer.Location = new System.Drawing.Point(445, 21);
            this.margenDer.Name = "margenDer";
            this.margenDer.Size = new System.Drawing.Size(2, 167);
            this.margenDer.TabIndex = 23;
            this.margenDer.TabStop = false;
            // 
            // margenIzq
            // 
            this.margenIzq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.margenIzq.BackColor = System.Drawing.Color.Black;
            this.margenIzq.Location = new System.Drawing.Point(0, 21);
            this.margenIzq.Name = "margenIzq";
            this.margenIzq.Size = new System.Drawing.Size(2, 167);
            this.margenIzq.TabIndex = 24;
            this.margenIzq.TabStop = false;
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.BackColor = System.Drawing.Color.Black;
            this.picBoxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxLogin.BackgroundImage")));
            this.picBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxLogin.Location = new System.Drawing.Point(12, 2);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(21, 20);
            this.picBoxLogin.TabIndex = 25;
            this.picBoxLogin.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 188);
            this.Controls.Add(this.picBoxLogin);
            this.Controls.Add(this.margenIzq);
            this.Controls.Add(this.margenDer);
            this.Controls.Add(this.margenAbajo);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.BtnCerrarLogIn);
            this.Controls.Add(this.pctBoxCabecera1);
            this.Controls.Add(this.pictureBoxCajaLogo);
            this.Controls.Add(this.txbIDUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.txbNombreUsuario);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.txbPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizador - Iniciar Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenDer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.margenIzq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPassword;
        private Entidades.ButtonStyle btnAcceso;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbIDUsuario;
        private System.Windows.Forms.PictureBox pictureBoxCajaLogo;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
        private Entidades.ButtonStyle BtnCerrarLogIn;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.PictureBox margenAbajo;
        private System.Windows.Forms.PictureBox margenDer;
        private System.Windows.Forms.PictureBox margenIzq;
        private System.Windows.Forms.PictureBox picBoxLogin;
    }
}