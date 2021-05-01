namespace TareaReportesEnWF
{
    partial class FrmVistaPrevia
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PanelBarraDeTitulo = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcBoxIcono = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.RpVwPrincipal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDataSet = new TareaReportesEnWF.DataSet.ReporteDataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new TareaReportesEnWF.DataSet.ReporteDataSetTableAdapters.PersonaTableAdapter();
            this.PanelBarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraDeTitulo
            // 
            this.PanelBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.PanelBarraDeTitulo.Controls.Add(this.LblTitulo);
            this.PanelBarraDeTitulo.Controls.Add(this.PcBoxIcono);
            this.PanelBarraDeTitulo.Controls.Add(this.pictureBox2);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnRestaurar);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnCerrar);
            this.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo";
            this.PanelBarraDeTitulo.Size = new System.Drawing.Size(800, 26);
            this.PanelBarraDeTitulo.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(22, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(192, 21);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Vista Previa de Reporte";
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Minimize_16x;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.pictureBox2.Location = new System.Drawing.Point(740, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.minimizar;
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnRestaurar.Location = new System.Drawing.Point(761, 4);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(15, 17);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 2;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.maximizar;
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnMaximizar.Location = new System.Drawing.Point(761, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(15, 17);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnCerrar.Location = new System.Drawing.Point(782, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(15, 17);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // RpVwPrincipal
            // 
            this.RpVwPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "PersonaDS";
            reportDataSource3.Value = this.personaBindingSource;
            this.RpVwPrincipal.LocalReport.DataSources.Add(reportDataSource3);
            this.RpVwPrincipal.LocalReport.ReportEmbeddedResource = "TareaReportesEnWF.Reportes.RepListaPersona.rdlc";
            this.RpVwPrincipal.Location = new System.Drawing.Point(0, 25);
            this.RpVwPrincipal.Name = "RpVwPrincipal";
            this.RpVwPrincipal.ServerReport.BearerToken = null;
            this.RpVwPrincipal.Size = new System.Drawing.Size(800, 425);
            this.RpVwPrincipal.TabIndex = 2;
            // 
            // reporteDataSet
            // 
            this.reporteDataSet.DataSetName = "ReporteDataSet";
            this.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.reporteDataSet;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVistaPrevia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RpVwPrincipal);
            this.Controls.Add(this.PanelBarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaPrevia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVistaPrevia_Load);
            this.PanelBarraDeTitulo.ResumeLayout(false);
            this.PanelBarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraDeTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox PcBoxIcono;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer RpVwPrincipal;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DataSet.ReporteDataSet reporteDataSet;
        private DataSet.ReporteDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
    }
}