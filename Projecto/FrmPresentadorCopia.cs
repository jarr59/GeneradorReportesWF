using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaReportesEnWF
{
    public partial class FrmPresentadorCopia : Form
    {
        private List<string> nuevosTipo;

        List<string> listaTiposAgregados;

        private string _tipo;

        List<Button> CollectionsButtons;
        List<Panel> CollectionsPanel;

        public FrmPresentadorCopia()
        {
            nuevosTipo = new List<string>();
            _tipo = string.Empty;
            InitializeComponent();
            IniciarToolTip();
            CollectionsButtons = new List<Button>();
            CollectionsPanel = new List<Panel>();
            listaTiposAgregados = new List<string>();
            listaTiposAgregados.AddRange(llenarTipoPrincipales());
        }

        private string[] llenarTipoPrincipales()
        {
            return (new string[] { "Cliente", "Proveedor", "Empleado" } );
        }

        private void BtnConfigurarar_Click(object sender, EventArgs e)
        {
            if (nuevosTipo.ToArray().Length >= 20 )
            {
                MessageBox.Show("Ya no puede agregar más");
            }
            else
            {
                FrmAgregarTipo frmAgregar = new FrmAgregarTipo(listaTiposAgregados.ToArray());
                AddOwnedForm(frmAgregar);
                frmAgregar.ShowDialog();
                listaTiposAgregados.Add(frmAgregar.tipoAgregado);
                nuevosTipo.Add(frmAgregar.tipoAgregado);
                GenerarBotones(nuevosTipo.ToArray());
            }
            
        }

        private void GenerarBotones(string [] listaTipos)
        {
           
            if (listaTipos.Count() > -1)
            {
                if (listaTipos.Count() > 3)
                {
                    BtnMaximizar_Click_1(this, new EventArgs());
                }
                for (int i = 0; i < listaTipos.Length; i++)
                {
                    CollectionsButtons.Add(new Button());
                    CollectionsPanel.Add(new Panel());

                    if (i == 0)
                    {
                        CollectionsPanel[i].Location = new System.Drawing.Point(1, PanelEmpleados.Location.Y + 34);
                        CollectionsButtons[i].Location = new System.Drawing.Point(13, BtnListaEmpleados.Location.Y + 34);
                    }
                    else
                    {
                        CollectionsPanel[i].Location = new System.Drawing.Point(1, CollectionsPanel[i-1].Location.Y + 34);
                        CollectionsButtons[i].Location = new System.Drawing.Point(13, CollectionsButtons[i-1].Location.Y + 34);
                    }
                    // 
                    // PanelGenerico
                    // 
                    CollectionsPanel[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    CollectionsPanel[i].Name = "Panel" + listaTipos[i];
                    CollectionsPanel[i].Size = new System.Drawing.Size(10, 27);
                    CollectionsPanel[i].TabIndex = 3;
                    // 
                    // BtnGenerico
                    // 
                    CollectionsButtons[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
                    CollectionsButtons[i].FlatAppearance.BorderSize = 0;
                    CollectionsButtons[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    CollectionsButtons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    CollectionsButtons[i].Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    CollectionsButtons[i].ForeColor = System.Drawing.Color.White;
                    CollectionsButtons[i].Image = global::TareaReportesEnWF.Properties.Resources.ClienteC;
                    CollectionsButtons[i].ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    CollectionsButtons[i].Name = "BtnLista"+ listaTipos[i];
                    CollectionsButtons[i].Size = new System.Drawing.Size(184, 28);
                    CollectionsButtons[i].TabIndex = 2;
                    CollectionsButtons[i].Text = listaTipos[i];
                    CollectionsButtons[i].UseVisualStyleBackColor = false;

                    CollectionsButtons[i].Click += new EventHandler(this.BtnGeneric_Click);
                }
                BtnQuitarLista.Visible = true;
                FrmPresentadorCopia_Load(this,new EventArgs());
            }
        }

        private void IniciarToolTip()
        {
            //TpBarraBusqueda.SetToolTip(TxtBoxBuscar, MensajesToolTip.MbarraBusqueda);
            //TpLimpiar.SetToolTip(BtnLimpiar, MensajesToolTip.MbtnBorrar);
            //TpBuscar.SetToolTip(BtnBuscar, MensajesToolTip.MbtnBusqueda);
            //TpImprimir.SetToolTip(BtnImprimir, MensajesToolTip.MbtnImprimir);
        }

        #region Barra Superior
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Mouse_MouseClick(object args, MouseEventArgs e)
        {
            LblMensajeSeleccioneLista.Visible = false;
            ObtenerRegistro();
        }
        #endregion

        #region FuncionalidadDeArrastrarFormulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Panel Izquierdo

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            LblMensajeSeleccioneLista.Visible = false;
            Button btnGeneric = (Button)sender;
            _tipo = btnGeneric.Text;
            ObtenerRegistro();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            BtnCerrar_Click(sender, e);
        }
        #endregion

        #region Barra de busqueda
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBoxBuscar.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerRegistro();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string filtro = string.IsNullOrEmpty(TxtBoxBuscar.Text) ? "%" : TxtBoxBuscar.Text;

            FrmVistaPrevia frmVistaPrevia = new FrmVistaPrevia(_tipo, filtro);

            frmVistaPrevia.Show();
        }
        #endregion

        #region Obtener Listado 
        private void ObtenerRegistro()
        {
            string comandoSql = "SELECT P.ID, PT.[Tipo], P.Saludo, P.Apellido, P.Telefono, P.Direccion1, P.Direccion2,"
                             + " P.Ciudad,P.Estado,P.[CodigoPostal]  FROM Persona P"
                             + $" INNER JOIN PersonaTipo PT ON PT.[PersonaID] = P.[ID] WHERE PT.Tipo = '{_tipo}'";

            if (!string.IsNullOrEmpty(TxtBoxBuscar.Text))
            {
                string filtro = TxtBoxBuscar.Text;

                comandoSql += $"AND (P.Nombre LIKE '{filtro}%' OR P.Apellido LIKE '{filtro}%'"
                            + $" OR P.Email LIKE '{filtro}%' OR P.Email LIKE '{filtro}%' OR P.Ciudad LIKE '{filtro}%'"
                            + $" OR P.Telefono LIKE '{filtro}%' OR P.CodigoPostal LIKE '{filtro}%'"
                            + $" OR P.Direccion1 LIKE '{filtro}%' OR P.Direccion1 LIKE '{filtro}%')";
            }
            AdminBD adminBD = new AdminBD();

            adminBD.AbrirConexion();

            SqlDataReader lector = (SqlDataReader)adminBD.EjecutarComando(comandoSql);

            if (lector != null)
            {
                DataTable tabla = new DataTable();

                tabla.Load(lector);

                GrdPrincipal.DataSource = tabla;

                GrdPrincipal.Columns[0].Visible = false;

                lector.Close();
            }

            adminBD.CerrarConexion();
        }
        #endregion


        private void FrmPresentadorCopia_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tipo))
                LblMensajeSeleccioneLista.Visible = true;
            else
                LblMensajeSeleccioneLista.Visible = false;
            if (CollectionsButtons.Count > -1 && CollectionsPanel.Count > -1)
            {
                PanelMenu.Controls.AddRange(CollectionsButtons.ToArray());
                PanelMenu.Controls.AddRange(CollectionsPanel.ToArray());
            }
        }

        private void BtnMinizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnQuitarLista_Click(object sender, EventArgs e)
        {
            string[] tiposPrinicipales = llenarTipoPrincipales();

            if (_tipo != tiposPrinicipales[0] && _tipo != tiposPrinicipales[1] 
                && _tipo != tiposPrinicipales[2])
            {
                for (int i = 0; i < CollectionsButtons.Count(); i++)
                {
                    if (_tipo == CollectionsButtons[i].Text)
                    {
                        PanelMenu.Controls.Remove(CollectionsPanel[i]);
                        PanelMenu.Controls.Remove(CollectionsButtons[i]);
                        listaTiposAgregados.Remove(CollectionsButtons[i].Text);
                        CollectionsButtons.Remove(CollectionsButtons[i]);
                        CollectionsPanel.Remove(CollectionsPanel[i]);
                        GrdPrincipal.Columns.Clear();
                        _tipo = string.Empty;
                        LblMensajeSeleccioneLista.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una lista agregada para eliminar");
            }
            if (listaTiposAgregados.ToArray() == llenarTipoPrincipales())
            {
                this.BtnQuitarLista.Visible = false;
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_tipo))
            {
                ObtenerRegistro();
            }
            else
            {
                MessageBox.Show("Seleccione alguna lista donde buscar");
            }          
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            TxtBoxBuscar.Text = string.Empty;
        }

        private void BtnImprimir_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_tipo))
            {
                string filtro = string.IsNullOrEmpty(TxtBoxBuscar.Text) ? "%" : TxtBoxBuscar.Text;

                FrmVistaPrevia frmVistaPrevia = new FrmVistaPrevia(_tipo, filtro);

                frmVistaPrevia.Show();
            }
            else
            {
                MessageBox.Show("Seleccione alguna lista");
            }
           
        }
    }
}
