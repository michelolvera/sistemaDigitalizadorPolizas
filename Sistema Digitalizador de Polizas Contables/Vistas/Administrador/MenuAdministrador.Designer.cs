namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas.Administrador
{
    partial class MenuAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministrador));
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.cmbExpediente = new System.Windows.Forms.ComboBox();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dgvDocumentos = new Entidades.DataGridStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckbArea = new System.Windows.Forms.CheckBox();
            this.ckbExpediente = new System.Windows.Forms.CheckBox();
            this.ckbCategoria = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 14);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area:";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Enabled = false;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(155, 11);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(541, 24);
            this.cmbArea.TabIndex = 1;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.CmbArea_SelectedIndexChanged);
            // 
            // cmbExpediente
            // 
            this.cmbExpediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpediente.Enabled = false;
            this.cmbExpediente.FormattingEnabled = true;
            this.cmbExpediente.Location = new System.Drawing.Point(155, 42);
            this.cmbExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbExpediente.Name = "cmbExpediente";
            this.cmbExpediente.Size = new System.Drawing.Size(541, 24);
            this.cmbExpediente.TabIndex = 2;
            this.cmbExpediente.SelectedIndexChanged += new System.EventHandler(this.CmbExpediente_SelectedIndexChanged);
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(12, 46);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(82, 17);
            this.lblExpediente.TabIndex = 3;
            this.lblExpediente.Text = "Expediente:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(155, 73);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(541, 24);
            this.cmbCategoria.TabIndex = 4;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.CmbCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria:";
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.AllowUserToResizeColumns = false;
            this.dgvDocumentos.AllowUserToResizeRows = false;
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDocumentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentos.Enabled = false;
            this.dgvDocumentos.EnableHeadersVisualStyles = false;
            this.dgvDocumentos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgvDocumentos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDocumentos.Location = new System.Drawing.Point(15, 103);
            this.dgvDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDocumentos.MultiSelect = false;
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowHeadersVisible = false;
            this.dgvDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvDocumentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumentos.RowTemplate.Height = 24;
            this.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentos.Size = new System.Drawing.Size(755, 306);
            this.dgvDocumentos.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(684, 416);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 29);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 416);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckbArea
            // 
            this.ckbArea.AutoSize = true;
            this.ckbArea.Enabled = false;
            this.ckbArea.Location = new System.Drawing.Point(701, 14);
            this.ckbArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbArea.Name = "ckbArea";
            this.ckbArea.Size = new System.Drawing.Size(68, 21);
            this.ckbArea.TabIndex = 11;
            this.ckbArea.Text = "Activo";
            this.ckbArea.UseVisualStyleBackColor = true;
            // 
            // ckbExpediente
            // 
            this.ckbExpediente.AutoSize = true;
            this.ckbExpediente.Enabled = false;
            this.ckbExpediente.Location = new System.Drawing.Point(701, 44);
            this.ckbExpediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbExpediente.Name = "ckbExpediente";
            this.ckbExpediente.Size = new System.Drawing.Size(68, 21);
            this.ckbExpediente.TabIndex = 12;
            this.ckbExpediente.Text = "Activo";
            this.ckbExpediente.UseVisualStyleBackColor = true;
            // 
            // ckbCategoria
            // 
            this.ckbCategoria.AutoSize = true;
            this.ckbCategoria.Enabled = false;
            this.ckbCategoria.Location = new System.Drawing.Point(701, 75);
            this.ckbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbCategoria.Name = "ckbCategoria";
            this.ckbCategoria.Size = new System.Drawing.Size(68, 21);
            this.ckbCategoria.TabIndex = 13;
            this.ckbCategoria.Text = "Activo";
            this.ckbCategoria.UseVisualStyleBackColor = true;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.ckbCategoria);
            this.Controls.Add(this.ckbExpediente);
            this.Controls.Add(this.ckbArea);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblExpediente);
            this.Controls.Add(this.cmbExpediente);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.lblArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.Load += new System.EventHandler(this.MenuAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.ComboBox cmbExpediente;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private Entidades.DataGridStyle dgvDocumentos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbArea;
        private System.Windows.Forms.CheckBox ckbExpediente;
        private System.Windows.Forms.CheckBox ckbCategoria;
    }
}