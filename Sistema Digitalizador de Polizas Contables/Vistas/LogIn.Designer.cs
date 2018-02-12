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
            this.btnCancelar = new Entidades.ButtonStyle();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnAcceso = new Entidades.ButtonStyle();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnCancelar.Location = new System.Drawing.Point(212, 109);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BotonCancelarLogAdmin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(318, 65);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '·';
            this.txbPassword.Size = new System.Drawing.Size(115, 20);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassword_KeyDown);
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceso.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.btnAcceso.Location = new System.Drawing.Point(342, 109);
            this.btnAcceso.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(84, 32);
            this.btnAcceso.TabIndex = 3;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.BotonAccesoAdmin_Click);
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(318, 41);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(115, 20);
            this.txbNombreUsuario.TabIndex = 1;
            this.txbNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNombreUsuario_KeyDown);
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(212, 17);
            this.lblIDUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblIDUsuario.TabIndex = 5;
            this.lblIDUsuario.Text = "ID de Usuario:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(211, 43);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre de Usuario:";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(212, 68);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña";
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.Location = new System.Drawing.Point(318, 17);
            this.txbIDUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.Size = new System.Drawing.Size(115, 20);
            this.txbIDUsuario.TabIndex = 0;
            this.txbIDUsuario.TextChanged += new System.EventHandler(this.TxbIDUsuario_TextChanged);
            this.txbIDUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbIDUsuario_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 153);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbIDUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.txbNombreUsuario);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalizador - Iniciar Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogIn_FormClosed);
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Entidades.ButtonStyle btnCancelar;
        private System.Windows.Forms.TextBox txbPassword;
        private Entidades.ButtonStyle btnAcceso;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbIDUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}