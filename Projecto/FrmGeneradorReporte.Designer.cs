namespace TareaReportesEnWF
{
    partial class FrmGeneradorReporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.GrpListReportes = new System.Windows.Forms.GroupBox();
            this.LblEmpleados = new System.Windows.Forms.Label();
            this.LblProveedores = new System.Windows.Forms.Label();
            this.LblClientes = new System.Windows.Forms.Label();
            this.TsTpPrincipal = new System.Windows.Forms.ToolStrip();
            this.TsTpPrincipalLblBuscar = new System.Windows.Forms.ToolStripLabel();
            this.TsTpPrincipalTxtBxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.GrdPrincipal = new System.Windows.Forms.DataGridView();
            this.TsTpPrincipalBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.TsTpBtnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.TsTpPrincipalImprimir = new System.Windows.Forms.ToolStripButton();
            this.GrpBoxPrincipal.SuspendLayout();
            this.GrpListReportes.SuspendLayout();
            this.TsTpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpBoxPrincipal
            // 
            this.GrpBoxPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBoxPrincipal.Controls.Add(this.GrpListReportes);
            this.GrpBoxPrincipal.Location = new System.Drawing.Point(12, 31);
            this.GrpBoxPrincipal.Name = "GrpBoxPrincipal";
            this.GrpBoxPrincipal.Size = new System.Drawing.Size(163, 524);
            this.GrpBoxPrincipal.TabIndex = 1;
            this.GrpBoxPrincipal.TabStop = false;
            this.GrpBoxPrincipal.Text = "Lista de Opciones de Reporte";
            // 
            // GrpListReportes
            // 
            this.GrpListReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpListReportes.Controls.Add(this.LblEmpleados);
            this.GrpListReportes.Controls.Add(this.LblProveedores);
            this.GrpListReportes.Controls.Add(this.LblClientes);
            this.GrpListReportes.Location = new System.Drawing.Point(6, 19);
            this.GrpListReportes.Name = "GrpListReportes";
            this.GrpListReportes.Size = new System.Drawing.Size(151, 499);
            this.GrpListReportes.TabIndex = 0;
            this.GrpListReportes.TabStop = false;
            // 
            // LblEmpleados
            // 
            this.LblEmpleados.AutoSize = true;
            this.LblEmpleados.Location = new System.Drawing.Point(6, 115);
            this.LblEmpleados.Name = "LblEmpleados";
            this.LblEmpleados.Size = new System.Drawing.Size(99, 13);
            this.LblEmpleados.TabIndex = 2;
            this.LblEmpleados.Text = "Lista de Empleados";
            this.LblEmpleados.Click += new System.EventHandler(this.LblEmpleados_Click);
            // 
            // LblProveedores
            // 
            this.LblProveedores.AutoSize = true;
            this.LblProveedores.Location = new System.Drawing.Point(6, 70);
            this.LblProveedores.Name = "LblProveedores";
            this.LblProveedores.Size = new System.Drawing.Size(107, 13);
            this.LblProveedores.TabIndex = 1;
            this.LblProveedores.Text = "Lista de Proveedores";
            this.LblProveedores.Click += new System.EventHandler(this.LblProveedores_Click);
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Location = new System.Drawing.Point(6, 26);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(84, 13);
            this.LblClientes.TabIndex = 0;
            this.LblClientes.Text = "Lista de Clientes";
            this.LblClientes.Click += new System.EventHandler(this.LblClientes_Click);
            // 
            // TsTpPrincipal
            // 
            this.TsTpPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TsTpPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.TsTpPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsTpPrincipalLblBuscar,
            this.TsTpPrincipalTxtBxBuscar,
            this.TsTpBtnLimpiar,
            this.TsTpPrincipalBtnBuscar,
            this.TsTpPrincipalImprimir});
            this.TsTpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TsTpPrincipal.Name = "TsTpPrincipal";
            this.TsTpPrincipal.Size = new System.Drawing.Size(656, 25);
            this.TsTpPrincipal.TabIndex = 2;
            // 
            // TsTpPrincipalLblBuscar
            // 
            this.TsTpPrincipalLblBuscar.Name = "TsTpPrincipalLblBuscar";
            this.TsTpPrincipalLblBuscar.Size = new System.Drawing.Size(42, 22);
            this.TsTpPrincipalLblBuscar.Text = "Buscar";
            // 
            // TsTpPrincipalTxtBxBuscar
            // 
            this.TsTpPrincipalTxtBxBuscar.Name = "TsTpPrincipalTxtBxBuscar";
            this.TsTpPrincipalTxtBxBuscar.Size = new System.Drawing.Size(500, 25);
            this.TsTpPrincipalTxtBxBuscar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TsTpPrincipalTxtBxBuscar.ToolTipText = "Escribe para filtrar registros";
            // 
            // GrdPrincipal
            // 
            this.GrdPrincipal.AllowUserToAddRows = false;
            this.GrdPrincipal.AllowUserToDeleteRows = false;
            this.GrdPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrdPrincipal.Location = new System.Drawing.Point(176, 31);
            this.GrdPrincipal.MultiSelect = false;
            this.GrdPrincipal.Name = "GrdPrincipal";
            this.GrdPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPrincipal.Size = new System.Drawing.Size(493, 518);
            this.GrdPrincipal.TabIndex = 3;
            // 
            // TsTpPrincipalBtnBuscar
            // 
            this.TsTpPrincipalBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsTpPrincipalBtnBuscar.Image = global::TareaReportesEnWF.Properties.Resources.Search_noHalo_16x;
            this.TsTpPrincipalBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsTpPrincipalBtnBuscar.Name = "TsTpPrincipalBtnBuscar";
            this.TsTpPrincipalBtnBuscar.Size = new System.Drawing.Size(23, 22);
            this.TsTpPrincipalBtnBuscar.ToolTipText = "Presione para buscar...";
            this.TsTpPrincipalBtnBuscar.Click += new System.EventHandler(this.TsTpPrincipalBtnBuscar_Click);
            // 
            // TsTpBtnLimpiar
            // 
            this.TsTpBtnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsTpBtnLimpiar.Image = global::TareaReportesEnWF.Properties.Resources.Close_16x;
            this.TsTpBtnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsTpBtnLimpiar.Name = "TsTpBtnLimpiar";
            this.TsTpBtnLimpiar.Size = new System.Drawing.Size(23, 22);
            // 
            // TsTpPrincipalImprimir
            // 
            this.TsTpPrincipalImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsTpPrincipalImprimir.Image = global::TareaReportesEnWF.Properties.Resources.PrintStatusBar5_16x;
            this.TsTpPrincipalImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsTpPrincipalImprimir.Name = "TsTpPrincipalImprimir";
            this.TsTpPrincipalImprimir.Size = new System.Drawing.Size(23, 22);
            this.TsTpPrincipalImprimir.Text = "toolStripButton1";
            this.TsTpPrincipalImprimir.Click += new System.EventHandler(this.TsTpPrincipalImprimir_Click);
            // 
            // FrmGeneradorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.GrdPrincipal);
            this.Controls.Add(this.TsTpPrincipal);
            this.Controls.Add(this.GrpBoxPrincipal);
            this.Name = "FrmGeneradorReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador De Reportes";
            this.GrpBoxPrincipal.ResumeLayout(false);
            this.GrpListReportes.ResumeLayout(false);
            this.GrpListReportes.PerformLayout();
            this.TsTpPrincipal.ResumeLayout(false);
            this.TsTpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpBoxPrincipal;
        private System.Windows.Forms.ToolStrip TsTpPrincipal;
        private System.Windows.Forms.ToolStripLabel TsTpPrincipalLblBuscar;
        private System.Windows.Forms.ToolStripTextBox TsTpPrincipalTxtBxBuscar;
        private System.Windows.Forms.ToolStripButton TsTpPrincipalBtnBuscar;
        private System.Windows.Forms.ToolStripButton TsTpPrincipalImprimir;
        private System.Windows.Forms.GroupBox GrpListReportes;
        private System.Windows.Forms.Label LblEmpleados;
        private System.Windows.Forms.Label LblProveedores;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.DataGridView GrdPrincipal;
        private System.Windows.Forms.ToolStripButton TsTpBtnLimpiar;
    }
}

