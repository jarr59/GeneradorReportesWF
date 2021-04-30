namespace TareaReportesEnWF
{
    partial class FrmVistaPreviaReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RpVwVistaPrevia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDataSet = new TareaReportesEnWF.DataSet.ReporteDataSet();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new TareaReportesEnWF.DataSet.ReporteDataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpVwVistaPrevia
            // 
            this.RpVwVistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PersonaDS";
            reportDataSource1.Value = this.personaBindingSource;
            this.RpVwVistaPrevia.LocalReport.DataSources.Add(reportDataSource1);
            this.RpVwVistaPrevia.LocalReport.ReportEmbeddedResource = "TareaReportesEnWF.Reportes.RepListaPersona.rdlc";
            this.RpVwVistaPrevia.Location = new System.Drawing.Point(0, 0);
            this.RpVwVistaPrevia.Name = "RpVwVistaPrevia";
            this.RpVwVistaPrevia.ServerReport.BearerToken = null;
            this.RpVwVistaPrevia.Size = new System.Drawing.Size(544, 450);
            this.RpVwVistaPrevia.TabIndex = 0;
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
            // FrmVistaPreviaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.RpVwVistaPrevia);
            this.Name = "FrmVistaPreviaReporte";
            this.Text = "FrmVistaPreviaReporte";
            this.Load += new System.EventHandler(this.FrmVistaPreviaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpVwVistaPrevia;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private DataSet.ReporteDataSet reporteDataSet;
        private DataSet.ReporteDataSetTableAdapters.PersonaTableAdapter personaTableAdapter;
    }
}