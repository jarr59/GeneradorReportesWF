namespace TareaReportesEnWF
{
    partial class FrmAgregarTipo
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
            this.PanelBarraDeTitulo = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcBoxIcono = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblListasDisponibles = new System.Windows.Forms.Label();
            this.CmbTipos = new System.Windows.Forms.ComboBox();
            this.LblTituloFormulario = new System.Windows.Forms.Label();
            this.PanelBarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraDeTitulo
            // 
            this.PanelBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.PanelBarraDeTitulo.Controls.Add(this.LblTitulo);
            this.PanelBarraDeTitulo.Controls.Add(this.PcBoxIcono);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnCerrar);
            this.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo";
            this.PanelBarraDeTitulo.Size = new System.Drawing.Size(333, 26);
            this.PanelBarraDeTitulo.TabIndex = 11;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(22, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(129, 21);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Agregar a Lista";
            // 
            // PcBoxIcono
            // 
            this.PcBoxIcono.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.ReporteIconox24;
            this.PcBoxIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcBoxIcono.InitialImage = null;
            this.PcBoxIcono.Location = new System.Drawing.Point(0, 0);
            this.PcBoxIcono.Name = "PcBoxIcono";
            this.PcBoxIcono.Size = new System.Drawing.Size(25, 26);
            this.PcBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcBoxIcono.TabIndex = 4;
            this.PcBoxIcono.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnCerrar.Location = new System.Drawing.Point(315, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(15, 17);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(12, 164);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(86, 26);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Agregar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(235, 164);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 26);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblListasDisponibles
            // 
            this.LblListasDisponibles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblListasDisponibles.AutoSize = true;
            this.LblListasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListasDisponibles.ForeColor = System.Drawing.Color.Black;
            this.LblListasDisponibles.Location = new System.Drawing.Point(8, 90);
            this.LblListasDisponibles.Name = "LblListasDisponibles";
            this.LblListasDisponibles.Size = new System.Drawing.Size(120, 18);
            this.LblListasDisponibles.TabIndex = 14;
            this.LblListasDisponibles.Text = "Seleccione Lista:";
            // 
            // CmbTipos
            // 
            this.CmbTipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbTipos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipos.FormattingEnabled = true;
            this.CmbTipos.Location = new System.Drawing.Point(138, 89);
            this.CmbTipos.Name = "CmbTipos";
            this.CmbTipos.Size = new System.Drawing.Size(183, 25);
            this.CmbTipos.TabIndex = 15;
            // 
            // LblTituloFormulario
            // 
            this.LblTituloFormulario.AutoSize = true;
            this.LblTituloFormulario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloFormulario.ForeColor = System.Drawing.Color.Black;
            this.LblTituloFormulario.Location = new System.Drawing.Point(95, 41);
            this.LblTituloFormulario.Name = "LblTituloFormulario";
            this.LblTituloFormulario.Size = new System.Drawing.Size(133, 21);
            this.LblTituloFormulario.TabIndex = 16;
            this.LblTituloFormulario.Text = "Lista Disponibles";
            // 
            // FrmAgregarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 202);
            this.Controls.Add(this.LblTituloFormulario);
            this.Controls.Add(this.CmbTipos);
            this.Controls.Add(this.LblListasDisponibles);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.PanelBarraDeTitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarTipo";
            this.Load += new System.EventHandler(this.FrmAgregarTipo_Load);
            this.PanelBarraDeTitulo.ResumeLayout(false);
            this.PanelBarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraDeTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcBoxIcono;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblListasDisponibles;
        private System.Windows.Forms.ComboBox CmbTipos;
        private System.Windows.Forms.Label LblTituloFormulario;
    }
}