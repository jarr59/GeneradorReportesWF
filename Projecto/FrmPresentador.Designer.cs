namespace TareaReportesEnWF
{
    partial class FrmPresentador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBarraDeTitulo = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.PcBoxIcono = new System.Windows.Forms.PictureBox();
            this.BtnMinizar = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelSalir = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblListaDisponible = new System.Windows.Forms.Label();
            this.PanelEmpleados = new System.Windows.Forms.Panel();
            this.BtnListaEmpleados = new System.Windows.Forms.Button();
            this.PanelProveedores = new System.Windows.Forms.Panel();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.PanelCLientes = new System.Windows.Forms.Panel();
            this.BtnListaClientes = new System.Windows.Forms.Button();
            this.PcBoxMeguminReporte = new System.Windows.Forms.PictureBox();
            this.GrdPrincipal = new System.Windows.Forms.DataGridView();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBoxBuscar = new System.Windows.Forms.TextBox();
            this.BtnImprimir = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.PictureBox();
            this.LblMensajeSeleccioneLista = new System.Windows.Forms.Label();
            this.TpBarraBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.TpLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.TpBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.TpImprimir = new System.Windows.Forms.ToolTip(this.components);
            this.PanelBarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxMeguminReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraDeTitulo
            // 
            this.PanelBarraDeTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.PanelBarraDeTitulo.Controls.Add(this.LblTitulo);
            this.PanelBarraDeTitulo.Controls.Add(this.PcBoxIcono);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnMinizar);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnRestaurar);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelBarraDeTitulo.Controls.Add(this.BtnCerrar);
            this.PanelBarraDeTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraDeTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraDeTitulo.Name = "PanelBarraDeTitulo";
            this.PanelBarraDeTitulo.Size = new System.Drawing.Size(800, 26);
            this.PanelBarraDeTitulo.TabIndex = 0;
            this.PanelBarraDeTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraDeTitulo_MouseDown);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(22, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(173, 21);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Presentador de Listas";
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
            // BtnMinizar
            // 
            this.BtnMinizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinizar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Minimize_16x;
            this.BtnMinizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinizar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnMinizar.Location = new System.Drawing.Point(740, 4);
            this.BtnMinizar.Name = "BtnMinizar";
            this.BtnMinizar.Size = new System.Drawing.Size(15, 17);
            this.BtnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinizar.TabIndex = 3;
            this.BtnMinizar.TabStop = false;
            this.BtnMinizar.Click += new System.EventHandler(this.BtnMinizar_Click);
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
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnMinimizar_Click);
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
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.PanelSalir);
            this.PanelMenu.Controls.Add(this.BtnSalir);
            this.PanelMenu.Controls.Add(this.LblListaDisponible);
            this.PanelMenu.Controls.Add(this.PanelEmpleados);
            this.PanelMenu.Controls.Add(this.BtnListaEmpleados);
            this.PanelMenu.Controls.Add(this.PanelProveedores);
            this.PanelMenu.Controls.Add(this.BtnProveedores);
            this.PanelMenu.Controls.Add(this.PanelCLientes);
            this.PanelMenu.Controls.Add(this.BtnListaClientes);
            this.PanelMenu.Controls.Add(this.PcBoxMeguminReporte);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 26);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(198, 424);
            this.PanelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(197, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 27);
            this.panel1.TabIndex = 11;
            // 
            // PanelSalir
            // 
            this.PanelSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelSalir.Location = new System.Drawing.Point(0, 393);
            this.PanelSalir.Name = "PanelSalir";
            this.PanelSalir.Size = new System.Drawing.Size(10, 27);
            this.PanelSalir.TabIndex = 10;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Image = global::TareaReportesEnWF.Properties.Resources.boton_de_encendido_apagado_x16;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(12, 393);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(186, 28);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblListaDisponible
            // 
            this.LblListaDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.LblListaDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblListaDisponible.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaDisponible.ForeColor = System.Drawing.Color.White;
            this.LblListaDisponible.Location = new System.Drawing.Point(0, 118);
            this.LblListaDisponible.Name = "LblListaDisponible";
            this.LblListaDisponible.Size = new System.Drawing.Size(198, 23);
            this.LblListaDisponible.TabIndex = 8;
            this.LblListaDisponible.Text = "Lista Disponibles";
            this.LblListaDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelEmpleados
            // 
            this.PanelEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelEmpleados.Location = new System.Drawing.Point(1, 227);
            this.PanelEmpleados.Name = "PanelEmpleados";
            this.PanelEmpleados.Size = new System.Drawing.Size(10, 27);
            this.PanelEmpleados.TabIndex = 7;
            // 
            // BtnListaEmpleados
            // 
            this.BtnListaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.BtnListaEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnListaEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnListaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListaEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnListaEmpleados.Image = global::TareaReportesEnWF.Properties.Resources.EmpleadoC;
            this.BtnListaEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListaEmpleados.Location = new System.Drawing.Point(13, 227);
            this.BtnListaEmpleados.Name = "BtnListaEmpleados";
            this.BtnListaEmpleados.Size = new System.Drawing.Size(183, 28);
            this.BtnListaEmpleados.TabIndex = 6;
            this.BtnListaEmpleados.Text = "Empleados";
            this.BtnListaEmpleados.UseVisualStyleBackColor = false;
            this.BtnListaEmpleados.Click += new System.EventHandler(this.BtnListaEmpleados_Click);
            this.BtnListaEmpleados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_MouseClick);
            // 
            // PanelProveedores
            // 
            this.PanelProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelProveedores.Location = new System.Drawing.Point(1, 193);
            this.PanelProveedores.Name = "PanelProveedores";
            this.PanelProveedores.Size = new System.Drawing.Size(10, 27);
            this.PanelProveedores.TabIndex = 5;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.Color.White;
            this.BtnProveedores.Image = global::TareaReportesEnWF.Properties.Resources.ProveedorC1;
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.Location = new System.Drawing.Point(13, 193);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(183, 28);
            this.BtnProveedores.TabIndex = 4;
            this.BtnProveedores.Text = " Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            this.BtnProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_MouseClick);
            // 
            // PanelCLientes
            // 
            this.PanelCLientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelCLientes.Location = new System.Drawing.Point(2, 159);
            this.PanelCLientes.Name = "PanelCLientes";
            this.PanelCLientes.Size = new System.Drawing.Size(10, 27);
            this.PanelCLientes.TabIndex = 3;
            // 
            // BtnListaClientes
            // 
            this.BtnListaClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.BtnListaClientes.FlatAppearance.BorderSize = 0;
            this.BtnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListaClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListaClientes.ForeColor = System.Drawing.Color.White;
            this.BtnListaClientes.Image = global::TareaReportesEnWF.Properties.Resources.ClienteC;
            this.BtnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListaClientes.Location = new System.Drawing.Point(14, 159);
            this.BtnListaClientes.Name = "BtnListaClientes";
            this.BtnListaClientes.Size = new System.Drawing.Size(183, 28);
            this.BtnListaClientes.TabIndex = 2;
            this.BtnListaClientes.Text = "Clientes";
            this.BtnListaClientes.UseVisualStyleBackColor = false;
            this.BtnListaClientes.Click += new System.EventHandler(this.BtnListaClientes_Click);
            this.BtnListaClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_MouseClick);
            // 
            // PcBoxMeguminReporte
            // 
            this.PcBoxMeguminReporte.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.PcBoxMeguminReporte.Image = global::TareaReportesEnWF.Properties.Resources.ImagenPrincipalV21;
            this.PcBoxMeguminReporte.Location = new System.Drawing.Point(0, 3);
            this.PcBoxMeguminReporte.Name = "PcBoxMeguminReporte";
            this.PcBoxMeguminReporte.Size = new System.Drawing.Size(197, 101);
            this.PcBoxMeguminReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PcBoxMeguminReporte.TabIndex = 1;
            this.PcBoxMeguminReporte.TabStop = false;
            // 
            // GrdPrincipal
            // 
            this.GrdPrincipal.AllowUserToAddRows = false;
            this.GrdPrincipal.AllowUserToDeleteRows = false;
            this.GrdPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.GrdPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(2)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdPrincipal.EnableHeadersVisualStyles = false;
            this.GrdPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.GrdPrincipal.Location = new System.Drawing.Point(202, 54);
            this.GrdPrincipal.MultiSelect = false;
            this.GrdPrincipal.Name = "GrdPrincipal";
            this.GrdPrincipal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdPrincipal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdPrincipal.RowHeadersVisible = false;
            this.GrdPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPrincipal.Size = new System.Drawing.Size(574, 395);
            this.GrdPrincipal.TabIndex = 2;
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.ForeColor = System.Drawing.Color.Black;
            this.LblBuscar.Location = new System.Drawing.Point(204, 27);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(61, 21);
            this.LblBuscar.TabIndex = 3;
            this.LblBuscar.Text = "Buscar";
            // 
            // TxtBoxBuscar
            // 
            this.TxtBoxBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtBoxBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxBuscar.Location = new System.Drawing.Point(272, 28);
            this.TxtBoxBuscar.MaxLength = 100;
            this.TxtBoxBuscar.Name = "TxtBoxBuscar";
            this.TxtBoxBuscar.Size = new System.Drawing.Size(373, 21);
            this.TxtBoxBuscar.TabIndex = 4;
            this.TxtBoxBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnImprimir.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.PrintStatusBar5_16x;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnImprimir.Location = new System.Drawing.Point(695, 31);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(16, 17);
            this.BtnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.TabStop = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Search_noHalo_16x;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnBuscar.Location = new System.Drawing.Point(673, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(16, 17);
            this.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLimpiar.BackgroundImage = global::TareaReportesEnWF.Properties.Resources.Close_16x;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.InitialImage = global::TareaReportesEnWF.Properties.Resources.Close_red_16x;
            this.BtnLimpiar.Location = new System.Drawing.Point(651, 31);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(16, 17);
            this.BtnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.TabStop = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LblMensajeSeleccioneLista
            // 
            this.LblMensajeSeleccioneLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblMensajeSeleccioneLista.Cursor = System.Windows.Forms.Cursors.No;
            this.LblMensajeSeleccioneLista.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensajeSeleccioneLista.Location = new System.Drawing.Point(343, 74);
            this.LblMensajeSeleccioneLista.Name = "LblMensajeSeleccioneLista";
            this.LblMensajeSeleccioneLista.Size = new System.Drawing.Size(302, 46);
            this.LblMensajeSeleccioneLista.TabIndex = 8;
            this.LblMensajeSeleccioneLista.Text = "Seleccione una lista...";
            this.LblMensajeSeleccioneLista.Visible = false;
            // 
            // FrmPresentador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMensajeSeleccioneLista);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtBoxBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.GrdPrincipal);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelBarraDeTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPresentador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPresentador";
            this.Load += new System.EventHandler(this.FrmPresentador_Load);
            this.PanelBarraDeTitulo.ResumeLayout(false);
            this.PanelBarraDeTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcBoxMeguminReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraDeTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMinizar;
        private System.Windows.Forms.PictureBox PcBoxMeguminReporte;
        private System.Windows.Forms.Button BtnListaClientes;
        private System.Windows.Forms.Panel PanelCLientes;
        private System.Windows.Forms.Label LblListaDisponible;
        private System.Windows.Forms.Panel PanelEmpleados;
        private System.Windows.Forms.Button BtnListaEmpleados;
        private System.Windows.Forms.Panel PanelProveedores;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Panel PanelSalir;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox PcBoxIcono;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView GrdPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBoxBuscar;
        private System.Windows.Forms.PictureBox BtnLimpiar;
        private System.Windows.Forms.PictureBox BtnBuscar;
        private System.Windows.Forms.PictureBox BtnImprimir;
        private System.Windows.Forms.Label LblMensajeSeleccioneLista;
        private System.Windows.Forms.ToolTip TpBarraBusqueda;
        private System.Windows.Forms.ToolTip TpLimpiar;
        private System.Windows.Forms.ToolTip TpBuscar;
        private System.Windows.Forms.ToolTip TpImprimir;
    }
}