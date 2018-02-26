namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    partial class ManualInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualInsert));
            this.CmbArea = new System.Windows.Forms.ComboBox();
            this.CmbExpediente = new System.Windows.Forms.ComboBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuardar = new Entidades.ButtonStyle();
            this.btnMin = new Entidades.ButtonStyle();
            this.BtnCerrar = new Entidades.ButtonStyle();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.pictureBoxCajaLogo = new System.Windows.Forms.PictureBox();
            this.pctBoxCabecera1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbArea
            // 
            this.CmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArea.FormattingEnabled = true;
            this.CmbArea.Location = new System.Drawing.Point(97, 45);
            this.CmbArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbArea.Name = "CmbArea";
            this.CmbArea.Size = new System.Drawing.Size(281, 21);
            this.CmbArea.TabIndex = 0;
            this.CmbArea.SelectedIndexChanged += new System.EventHandler(this.CmbArea_SelectedIndexChanged);
            // 
            // CmbExpediente
            // 
            this.CmbExpediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbExpediente.Enabled = false;
            this.CmbExpediente.FormattingEnabled = true;
            this.CmbExpediente.Location = new System.Drawing.Point(97, 70);
            this.CmbExpediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbExpediente.Name = "CmbExpediente";
            this.CmbExpediente.Size = new System.Drawing.Size(281, 21);
            this.CmbExpediente.TabIndex = 1;
            this.CmbExpediente.SelectedIndexChanged += new System.EventHandler(this.CmbExpediente_SelectedIndexChanged);
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.Enabled = false;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(97, 94);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(281, 21);
            this.CmbCategoria.TabIndex = 2;
            this.CmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expediente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(97, 119);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(281, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Identificador:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.BtnGuardar.Location = new System.Drawing.Point(312, 149);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(65, 27);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.btnMin.Location = new System.Drawing.Point(323, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 23);
            this.btnMin.TabIndex = 35;
            this.btnMin.UseVisualStyleBackColor = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(353, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(23, 23);
            this.BtnCerrar.TabIndex = 34;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.BackColor = System.Drawing.Color.Black;
            this.lblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(52, 7);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(240, 16);
            this.lblTituloVentana.TabIndex = 33;
            this.lblTituloVentana.Text = "|   Inserción Manual de Expedientes     |";
            // 
            // pictureBoxCajaLogo
            // 
            this.pictureBoxCajaLogo.BackColor = System.Drawing.Color.Black;
            this.pictureBoxCajaLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCajaLogo.Image")));
            this.pictureBoxCajaLogo.Location = new System.Drawing.Point(8, 0);
            this.pictureBoxCajaLogo.Name = "pictureBoxCajaLogo";
            this.pictureBoxCajaLogo.Size = new System.Drawing.Size(40, 30);
            this.pictureBoxCajaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCajaLogo.TabIndex = 32;
            this.pictureBoxCajaLogo.TabStop = false;
            // 
            // pctBoxCabecera1
            // 
            this.pctBoxCabecera1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctBoxCabecera1.BackColor = System.Drawing.Color.Black;
            this.pctBoxCabecera1.Location = new System.Drawing.Point(1, 0);
            this.pctBoxCabecera1.Name = "pctBoxCabecera1";
            this.pctBoxCabecera1.Size = new System.Drawing.Size(392, 30);
            this.pctBoxCabecera1.TabIndex = 31;
            this.pctBoxCabecera1.TabStop = false;
            // 
            // ManualInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 186);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.lblTituloVentana);
            this.Controls.Add(this.pictureBoxCajaLogo);
            this.Controls.Add(this.pctBoxCabecera1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.CmbExpediente);
            this.Controls.Add(this.CmbArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManualInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManualInsert";
            this.Load += new System.EventHandler(this.ManualInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCajaLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCabecera1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbArea;
        private System.Windows.Forms.ComboBox CmbExpediente;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private Entidades.ButtonStyle BtnGuardar;
        private Entidades.ButtonStyle btnMin;
        private Entidades.ButtonStyle BtnCerrar;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.PictureBox pictureBoxCajaLogo;
        private System.Windows.Forms.PictureBox pctBoxCabecera1;
    }
}