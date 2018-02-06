namespace Sistema_Digitalizador_de_Polizas_Contables.Vistas
{
    partial class VisorDeDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorDeDocumentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnActualizarDocs = new System.Windows.Forms.Button();
            this.btnEliminarDoc = new System.Windows.Forms.Button();
            this.btnReemplazarDoc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.checkBoxDigitalizadosDoc = new System.Windows.Forms.CheckBox();
            this.labelCatActual = new System.Windows.Forms.Label();
            this.dgvDocumentos = new Entidades.DataGridStyle();
            this.btnDigitalizar = new System.Windows.Forms.Button();
            this.labelNoDigitalizado = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDigitalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digitalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnActualizarDocs);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminarDoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnReemplazarDoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxDigitalizadosDoc);
            this.splitContainer1.Panel1.Controls.Add(this.labelCatActual);
            this.splitContainer1.Panel1.Controls.Add(this.dgvDocumentos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDigitalizar);
            this.splitContainer1.Panel2.Controls.Add(this.labelNoDigitalizado);
            this.splitContainer1.Panel2.Controls.Add(this.axAcroPDF1);
            this.splitContainer1.Size = new System.Drawing.Size(1113, 577);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnActualizarDocs
            // 
            this.btnActualizarDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarDocs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarDocs.BackgroundImage")));
            this.btnActualizarDocs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarDocs.Location = new System.Drawing.Point(303, 11);
            this.btnActualizarDocs.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarDocs.Name = "btnActualizarDocs";
            this.btnActualizarDocs.Size = new System.Drawing.Size(40, 39);
            this.btnActualizarDocs.TabIndex = 7;
            this.btnActualizarDocs.UseVisualStyleBackColor = true;
            this.btnActualizarDocs.Click += new System.EventHandler(this.btnActualizarDocs_Click);
            // 
            // btnEliminarDoc
            // 
            this.btnEliminarDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarDoc.BackgroundImage")));
            this.btnEliminarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarDoc.Location = new System.Drawing.Point(292, 534);
            this.btnEliminarDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDoc.Name = "btnEliminarDoc";
            this.btnEliminarDoc.Size = new System.Drawing.Size(52, 38);
            this.btnEliminarDoc.TabIndex = 6;
            this.btnEliminarDoc.UseVisualStyleBackColor = true;
            this.btnEliminarDoc.Click += new System.EventHandler(this.btnEliminarDoc_Click);
            // 
            // btnReemplazarDoc
            // 
            this.btnReemplazarDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReemplazarDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReemplazarDoc.BackgroundImage")));
            this.btnReemplazarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReemplazarDoc.Location = new System.Drawing.Point(232, 534);
            this.btnReemplazarDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnReemplazarDoc.Name = "btnReemplazarDoc";
            this.btnReemplazarDoc.Size = new System.Drawing.Size(52, 38);
            this.btnReemplazarDoc.TabIndex = 5;
            this.btnReemplazarDoc.UseVisualStyleBackColor = true;
            this.btnReemplazarDoc.Click += new System.EventHandler(this.btnReemplazarDoc_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Location = new System.Drawing.Point(16, 539);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Regresar a Pendientes";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // checkBoxDigitalizadosDoc
            // 
            this.checkBoxDigitalizadosDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDigitalizadosDoc.AutoSize = true;
            this.checkBoxDigitalizadosDoc.Location = new System.Drawing.Point(16, 36);
            this.checkBoxDigitalizadosDoc.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDigitalizadosDoc.Name = "checkBoxDigitalizadosDoc";
            this.checkBoxDigitalizadosDoc.Size = new System.Drawing.Size(160, 21);
            this.checkBoxDigitalizadosDoc.TabIndex = 4;
            this.checkBoxDigitalizadosDoc.Text = "Mostrar digitalizados";
            this.checkBoxDigitalizadosDoc.UseVisualStyleBackColor = true;
            this.checkBoxDigitalizadosDoc.Visible = false;
            // 
            // labelCatActual
            // 
            this.labelCatActual.AutoSize = true;
            this.labelCatActual.Location = new System.Drawing.Point(16, 11);
            this.labelCatActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCatActual.Name = "labelCatActual";
            this.labelCatActual.Size = new System.Drawing.Size(240, 17);
            this.labelCatActual.TabIndex = 3;
            this.labelCatActual.Text = "Categoria actual: Pólizas de Egresos";
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
            this.dgvDocumentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.nombreDoc,
            this.fechaDigitalizacion,
            this.Digitalizado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(238)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentos.EnableHeadersVisualStyles = false;
            this.dgvDocumentos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dgvDocumentos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDocumentos.Location = new System.Drawing.Point(13, 64);
            this.dgvDocumentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocumentos.MultiSelect = false;
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowHeadersVisible = false;
            this.dgvDocumentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvDocumentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentos.Size = new System.Drawing.Size(353, 463);
            this.dgvDocumentos.TabIndex = 2;
            this.dgvDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellDoubleClick);
            // 
            // btnDigitalizar
            // 
            this.btnDigitalizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDigitalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalizar.Location = new System.Drawing.Point(293, 308);
            this.btnDigitalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDigitalizar.Name = "btnDigitalizar";
            this.btnDigitalizar.Size = new System.Drawing.Size(176, 57);
            this.btnDigitalizar.TabIndex = 2;
            this.btnDigitalizar.Text = "Digitalizar";
            this.btnDigitalizar.UseVisualStyleBackColor = true;
            this.btnDigitalizar.Visible = false;
            this.btnDigitalizar.Click += new System.EventHandler(this.btnDigitalizar_Click);
            // 
            // labelNoDigitalizado
            // 
            this.labelNoDigitalizado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoDigitalizado.AutoSize = true;
            this.labelNoDigitalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDigitalizado.Location = new System.Drawing.Point(143, 249);
            this.labelNoDigitalizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoDigitalizado.Name = "labelNoDigitalizado";
            this.labelNoDigitalizado.Size = new System.Drawing.Size(478, 42);
            this.labelNoDigitalizado.TabIndex = 1;
            this.labelNoDigitalizado.Text = "¡Documento no digitalizado!";
            this.labelNoDigitalizado.Visible = false;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(738, 577);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // idDoc
            // 
            this.idDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDoc.HeaderText = "Id de Documento";
            this.idDoc.Name = "idDoc";
            this.idDoc.ReadOnly = true;
            // 
            // nombreDoc
            // 
            this.nombreDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDoc.HeaderText = "Nombre Documento";
            this.nombreDoc.Name = "nombreDoc";
            this.nombreDoc.ReadOnly = true;
            // 
            // fechaDigitalizacion
            // 
            this.fechaDigitalizacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaDigitalizacion.HeaderText = "Fecha de Digitalizacion";
            this.fechaDigitalizacion.Name = "fechaDigitalizacion";
            this.fechaDigitalizacion.ReadOnly = true;
            // 
            // Digitalizado
            // 
            this.Digitalizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Digitalizado.HeaderText = "Digitalizado";
            this.Digitalizado.Name = "Digitalizado";
            this.Digitalizado.ReadOnly = true;
            // 
            // VisorDeDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 577);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisorDeDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorDeDocumentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Entidades.DataGridStyle dgvDocumentos;
        private System.Windows.Forms.Label labelCatActual;
        private System.Windows.Forms.CheckBox checkBoxDigitalizadosDoc;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEliminarDoc;
        private System.Windows.Forms.Button btnReemplazarDoc;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnDigitalizar;
        private System.Windows.Forms.Label labelNoDigitalizado;
        private System.Windows.Forms.Button btnActualizarDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDigitalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digitalizado;
    }
}