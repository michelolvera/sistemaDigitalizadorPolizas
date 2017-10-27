namespace Sistema_Digitalizador_de_Polizas_Contables
{
    partial class LogInAdmin
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
            this.botonCancelarLogAdmin = new System.Windows.Forms.Button();
            this.comboBoxLogAdmin = new System.Windows.Forms.ComboBox();
            this.textBoxContrasenaAdmin = new System.Windows.Forms.TextBox();
            this.botonAccesoAdmin = new System.Windows.Forms.Button();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonCancelarLogAdmin
            // 
            this.botonCancelarLogAdmin.Location = new System.Drawing.Point(27, 127);
            this.botonCancelarLogAdmin.Name = "botonCancelarLogAdmin";
            this.botonCancelarLogAdmin.Size = new System.Drawing.Size(84, 32);
            this.botonCancelarLogAdmin.TabIndex = 0;
            this.botonCancelarLogAdmin.Text = "Cancelar";
            this.botonCancelarLogAdmin.UseVisualStyleBackColor = true;
            // 
            // comboBoxLogAdmin
            // 
            this.comboBoxLogAdmin.FormattingEnabled = true;
            this.comboBoxLogAdmin.Location = new System.Drawing.Point(12, 49);
            this.comboBoxLogAdmin.Name = "comboBoxLogAdmin";
            this.comboBoxLogAdmin.Size = new System.Drawing.Size(202, 21);
            this.comboBoxLogAdmin.TabIndex = 1;
            // 
            // textBoxContrasenaAdmin
            // 
            this.textBoxContrasenaAdmin.Location = new System.Drawing.Point(12, 101);
            this.textBoxContrasenaAdmin.Name = "textBoxContrasenaAdmin";
            this.textBoxContrasenaAdmin.PasswordChar = '·';
            this.textBoxContrasenaAdmin.Size = new System.Drawing.Size(202, 20);
            this.textBoxContrasenaAdmin.TabIndex = 2;
            // 
            // botonAccesoAdmin
            // 
            this.botonAccesoAdmin.Location = new System.Drawing.Point(117, 127);
            this.botonAccesoAdmin.Name = "botonAccesoAdmin";
            this.botonAccesoAdmin.Size = new System.Drawing.Size(84, 32);
            this.botonAccesoAdmin.TabIndex = 3;
            this.botonAccesoAdmin.Text = "Acceso";
            this.botonAccesoAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(12, 76);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(202, 20);
            this.textBoxNombreUsuario.TabIndex = 4;
            // 
            // LogInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 171);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.botonAccesoAdmin);
            this.Controls.Add(this.textBoxContrasenaAdmin);
            this.Controls.Add(this.comboBoxLogAdmin);
            this.Controls.Add(this.botonCancelarLogAdmin);
            this.Name = "LogInAdmin";
            this.Text = "LogInAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelarLogAdmin;
        private System.Windows.Forms.ComboBox comboBoxLogAdmin;
        private System.Windows.Forms.TextBox textBoxContrasenaAdmin;
        private System.Windows.Forms.Button botonAccesoAdmin;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
    }
}