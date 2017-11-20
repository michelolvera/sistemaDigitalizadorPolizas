namespace Sistema_Digitalizador_de_Polizas_Contables
{
    partial class LogIn
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbLogIn = new System.Windows.Forms.ComboBox();
            this.txtbPasswor = new System.Windows.Forms.TextBox();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(27, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 32);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botonCancelarLogAdmin_Click);
            // 
            // cmbLogIn
            // 
            this.cmbLogIn.FormattingEnabled = true;
            this.cmbLogIn.Location = new System.Drawing.Point(12, 49);
            this.cmbLogIn.Name = "cmbLogIn";
            this.cmbLogIn.Size = new System.Drawing.Size(202, 21);
            this.cmbLogIn.TabIndex = 1;
            // 
            // txtbPasswor
            // 
            this.txtbPasswor.Location = new System.Drawing.Point(12, 101);
            this.txtbPasswor.Name = "txtbPasswor";
            this.txtbPasswor.PasswordChar = '·';
            this.txtbPasswor.Size = new System.Drawing.Size(202, 20);
            this.txtbPasswor.TabIndex = 2;
            // 
            // btnAcceso
            // 
            this.btnAcceso.Location = new System.Drawing.Point(117, 127);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(84, 32);
            this.btnAcceso.TabIndex = 3;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.UseVisualStyleBackColor = true;
            this.btnAcceso.Click += new System.EventHandler(this.botonAccesoAdmin_Click);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(12, 76);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(202, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 171);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.txtbPasswor);
            this.Controls.Add(this.cmbLogIn);
            this.Controls.Add(this.btnCancelar);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbLogIn;
        private System.Windows.Forms.TextBox txtbPasswor;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.TextBox txtbNombre;
    }
}